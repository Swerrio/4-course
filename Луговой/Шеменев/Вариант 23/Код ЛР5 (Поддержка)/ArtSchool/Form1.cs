using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ArtSchool
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            cmbFilter.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Введите ФИО ученика");
                return;
            }

            int age;
            if (!int.TryParse(txtAge.Text, out age) || age < 5 || age > 18)
            {
                MessageBox.Show("Введите возраст от 5 до 18 лет");
                return;
            }

            Student student = new Student();
            student.Name = txtName.Text;
            student.Age = age;
            student.Direction = txtDirection.Text;
            students.Add(student);

            UpdateList();

            txtName.Clear();
            txtAge.Clear();
            txtDirection.Clear();
        }

        private void UpdateList()
        {
            lstStudents.Items.Clear();
            foreach (Student s in students)
            {
                string text = s.Name + " — " + s.Age + " лет";
                lstStudents.Items.Add(text + " — " + s.Direction);
            }
            lblFilterInfo.Text = "Показаны все ученики: " + students.Count;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (Student s in students)
            {
                if (s.Name.Contains(txtSearch.Text))
                {
                    MessageBox.Show("Найдено:\n\n" + s.Name + "\nВозраст: " + s.Age +
                        " лет\nНаправление: " + s.Direction);
                    return;
                }
            }
            MessageBox.Show("Ученик не найден");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите ученика в списке");
                return;
            }

            students.RemoveAt(lstStudents.SelectedIndex);
            UpdateList();
            lblResult.Text = "";
        }

        // кнопка «Показать» — фильтрация учеников по возрастной группе
        private void btnFilter_Click(object sender, EventArgs e)
        {
            int from = 5;
            int to = 18;
            if (cmbFilter.Text == "5–9 лет") { from = 5; to = 9; }
            if (cmbFilter.Text == "10–13 лет") { from = 10; to = 13; }
            if (cmbFilter.Text == "14–18 лет") { from = 14; to = 18; }

            lstStudents.Items.Clear();
            int count = 0;

            foreach (Student s in students)
            {
                if (s.Age >= from && s.Age <= to)
                {
                    string text = s.Name + " — " + s.Age + " лет";
                    lstStudents.Items.Add(text + " — " + s.Direction);
                    count++;
                }
            }

            lblFilterInfo.Text = "Показано учеников: " + count;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите ученика в списке");
                return;
            }

            int months;
            if (!int.TryParse(txtMonths.Text, out months))
            {
                MessageBox.Show("Введите количество месяцев числом");
                return;
            }
            if (months < 1 || months > 12)
            {
                MessageBox.Show("Количество месяцев должно быть от 1 до 12");
                return;
            }

            CalculateTuition(months);
        }

        // расчёт стоимости обучения выбранного ученика
        private void CalculateTuition(int months)
        {
            Student s = students[lstStudents.SelectedIndex];
            string direction = s.Direction.ToLower();
            int price = 3000;
            if (direction == "живопись" || direction == "скульптура")
            {
                price = 4000;
            }
            int total = price * months;
            lblResult.Text = "Стоимость обучения: " + total + " руб.";
        }

        // кнопка «Добавить изображение»
        private void btnImage_Click(object sender, EventArgs e)
        {
            ofdImage.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofdImage.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string ext = Path.GetExtension(ofdImage.FileName).ToLower();
            if (ext != ".jpg" && ext != ".jpeg" && ext != ".png" && ext != ".bmp")
            {
                MessageBox.Show("Выберите файл изображения: jpg, png или bmp");
                return;
            }

            picStudent.Image = Image.FromFile(ofdImage.FileName);
            lblImageName.Text = Path.GetFileName(ofdImage.FileName);
        }

        // кнопка «Очистить изображение»
        private void btnClearImage_Click(object sender, EventArgs e)
        {
            picStudent.Image = null;
            lblImageName.Text = "изображение не выбрано";
        }
    }
}
