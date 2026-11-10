using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CarRental
{
    // Раздел «Мой профиль»: просмотр и изменение собственных данных.
    // Пользователь может редактировать только свою учётную запись:
    // роль и чужие профили недоступны.
    public partial class ProfileForm : Form
    {
        private const int MaxPhotoBytes = 2 * 1024 * 1024;

        private AppUser user;
        private string newPhotoFile;

        public ProfileForm()
        {
            InitializeComponent();
            Load += ProfileForm_Load;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            if (Session.Current == null)
            {
                MessageBox.Show("Вход не выполнен.");
                this.Close();
                return;
            }

            try
            {
                user = UserRepository.GetById(Session.Current.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось прочитать профиль: " +
                    ex.Message);
                this.Close();
                return;
            }

            ShowUser();
        }

        private void ShowUser()
        {
            lblLoginVal.Text = user.Login;
            lblRoleVal.Text = user.Role == "Admin"
                ? "Администратор" : "Пользователь";
            lblCreatedVal.Text = user.CreatedAt.ToString("dd.MM.yyyy HH:mm");
            txtFirst.Text = user.FirstName;
            txtLast.Text = user.LastName;
            txtPhone.Text = user.Phone;
            txtEmail.Text = user.Email;
            ShowPhoto(PhotoFullPath(user.PhotoPath));
        }

        private string PhotoFullPath(string stored)
        {
            if (string.IsNullOrEmpty(stored))
            {
                return null;
            }
            return Path.IsPathRooted(stored)
                ? stored : Path.Combine(Db.AppFolder, stored);
        }

        private void ShowPhoto(string path)
        {
            if (picPhoto.Image != null)
            {
                picPhoto.Image.Dispose();
                picPhoto.Image = null;
            }
            if (string.IsNullOrEmpty(path) || !File.Exists(path))
            {
                return;
            }
            // файл читается в память, чтобы не оставаться заблокированным
            byte[] bytes = File.ReadAllBytes(path);
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                picPhoto.Image = Image.FromStream(ms);
            }
        }

        // Загрузка фотографии: проверяются формат и размер файла,
        // изображение показывается до сохранения
        private void btnPhoto_Click(object sender, EventArgs e)
        {
            if (ofdPhoto.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string file = ofdPhoto.FileName;
            string ext = Path.GetExtension(file).ToLower();
            if (ext != ".jpg" && ext != ".jpeg" && ext != ".png" &&
                ext != ".bmp")
            {
                Status("Поддерживаются только файлы jpg, png и bmp.", false);
                MessageBox.Show("Поддерживаются только файлы jpg, png и bmp.");
                return;
            }

            FileInfo info = new FileInfo(file);
            if (info.Length > MaxPhotoBytes)
            {
                string message = "Файл слишком большой: " +
                    (info.Length / 1024) + " КБ. Допустимо до 2048 КБ.";
                Status(message, false);
                MessageBox.Show(message);
                return;
            }

            try
            {
                ShowPhoto(file);
            }
            catch
            {
                Status("Файл не является изображением.", false);
                MessageBox.Show("Файл не является изображением.");
                return;
            }

            newPhotoFile = file;
            Status("Фотография выбрана. Нажмите «СОХРАНИТЬ».", true);
        }

        private void btnRemovePhoto_Click(object sender, EventArgs e)
        {
            newPhotoFile = null;
            user.PhotoPath = "";
            ShowPhoto(null);
            Status("Фотография удалена. Нажмите «СОХРАНИТЬ».", true);
        }

        // Сохранение профиля в PostgreSQL
        private void btnSave_Click(object sender, EventArgs e)
        {
            user.FirstName = txtFirst.Text.Trim();
            user.LastName = txtLast.Text.Trim();
            user.Phone = txtPhone.Text.Trim();
            user.Email = txtEmail.Text.Trim();

            if (newPhotoFile != null)
            {
                try
                {
                    user.PhotoPath = CopyPhoto(newPhotoFile);
                    newPhotoFile = null;
                }
                catch (Exception ex)
                {
                    Status("Не удалось сохранить фотографию: " +
                        ex.Message, false);
                    return;
                }
            }

            try
            {
                UserRepository.UpdateProfile(user);
            }
            catch (AccessDeniedException ex)
            {
                Status(ex.Message, false);
                MessageBox.Show(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                Status("Ошибка сохранения: " + ex.Message, false);
                return;
            }

            Session.Current.FirstName = user.FirstName;
            Session.Current.LastName = user.LastName;
            Session.Current.PhotoPath = user.PhotoPath;
            Status("Профиль сохранён в базе данных.", true);
        }

        // Файл фотографии кладётся в папку UserPhotos рядом с программой,
        // в базе хранится только путь
        private string CopyPhoto(string source)
        {
            string folder = Path.Combine(Db.AppFolder, "UserPhotos");
            Directory.CreateDirectory(folder);
            string name = user.Id + "_" +
                Guid.NewGuid().ToString("N").Substring(0, 8) +
                Path.GetExtension(source).ToLower();
            string target = Path.Combine(folder, name);
            File.Copy(source, target, true);
            return Path.Combine("UserPhotos", name);
        }

        // Смена пароля: старый пароль обязателен
        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            string oldPwd = txtOld.Text;
            string newPwd = txtNew.Text;

            if (oldPwd.Length == 0 || newPwd.Length == 0)
            {
                Status("Заполните оба поля пароля.", false);
                return;
            }
            if (newPwd.Length < 6)
            {
                Status("Новый пароль должен быть не короче 6 символов.",
                    false);
                return;
            }

            bool changed;
            try
            {
                changed = UserRepository.ChangePassword(user.Id, oldPwd,
                    newPwd);
            }
            catch (AccessDeniedException ex)
            {
                Status(ex.Message, false);
                return;
            }
            catch (Exception ex)
            {
                Status("Ошибка смены пароля: " + ex.Message, false);
                return;
            }

            if (!changed)
            {
                Status("Старый пароль указан неверно, пароль не изменён.",
                    false);
                return;
            }

            txtOld.Clear();
            txtNew.Clear();
            Status("Пароль изменён. Новый хеш сохранён в базе.", true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Status(string text, bool ok)
        {
            lblStatus.Text = text;
            lblStatus.ForeColor = ok
                ? Color.FromArgb(26, 110, 60) : Color.FromArgb(168, 42, 42);
        }
    }
}
