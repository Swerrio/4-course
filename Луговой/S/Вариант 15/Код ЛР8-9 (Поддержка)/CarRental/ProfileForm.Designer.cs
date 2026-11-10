namespace CarRental
{
    partial class ProfileForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.btnRemovePhoto = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblLoginCap = new System.Windows.Forms.Label();
            this.lblLoginVal = new System.Windows.Forms.Label();
            this.lblRoleCap = new System.Windows.Forms.Label();
            this.lblRoleVal = new System.Windows.Forms.Label();
            this.lblCreatedCap = new System.Windows.Forms.Label();
            this.lblCreatedVal = new System.Windows.Forms.Label();
            this.lblFirstCap = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.lblLastCap = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.lblPhoneCap = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmailCap = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpPwd = new System.Windows.Forms.GroupBox();
            this.lblOld = new System.Windows.Forms.Label();
            this.txtOld = new System.Windows.Forms.TextBox();
            this.lblNew = new System.Windows.Forms.Label();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.btnChangePwd = new System.Windows.Forms.Button();
            this.lblPwdHint = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ofdPhoto = new System.Windows.Forms.OpenFileDialog();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.grpInfo.SuspendLayout();
            this.grpPwd.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(720, 64);
            this.pnlHeader.TabIndex = 0;
            //
            // lblHeader
            //
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(24, 17);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(180, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "МОЙ ПРОФИЛЬ";
            //
            // picPhoto
            //
            this.picPhoto.BackColor = System.Drawing.Color.White;
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Location = new System.Drawing.Point(24, 88);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(180, 180);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 1;
            this.picPhoto.TabStop = false;
            //
            // btnPhoto
            //
            this.btnPhoto.BackColor = System.Drawing.Color.FromArgb(226, 229, 233);
            this.btnPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhoto.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.btnPhoto.Location = new System.Drawing.Point(24, 276);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(180, 30);
            this.btnPhoto.TabIndex = 2;
            this.btnPhoto.Text = "Загрузить фото";
            this.btnPhoto.UseVisualStyleBackColor = false;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            //
            // btnRemovePhoto
            //
            this.btnRemovePhoto.BackColor = System.Drawing.Color.FromArgb(226, 229, 233);
            this.btnRemovePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePhoto.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.btnRemovePhoto.Location = new System.Drawing.Point(24, 312);
            this.btnRemovePhoto.Name = "btnRemovePhoto";
            this.btnRemovePhoto.Size = new System.Drawing.Size(180, 30);
            this.btnRemovePhoto.TabIndex = 3;
            this.btnRemovePhoto.Text = "Удалить фото";
            this.btnRemovePhoto.UseVisualStyleBackColor = false;
            this.btnRemovePhoto.Click += new System.EventHandler(this.btnRemovePhoto_Click);
            //
            // grpInfo
            //
            this.grpInfo.Controls.Add(this.lblLoginCap);
            this.grpInfo.Controls.Add(this.lblLoginVal);
            this.grpInfo.Controls.Add(this.lblRoleCap);
            this.grpInfo.Controls.Add(this.lblRoleVal);
            this.grpInfo.Controls.Add(this.lblCreatedCap);
            this.grpInfo.Controls.Add(this.lblCreatedVal);
            this.grpInfo.Controls.Add(this.lblFirstCap);
            this.grpInfo.Controls.Add(this.txtFirst);
            this.grpInfo.Controls.Add(this.lblLastCap);
            this.grpInfo.Controls.Add(this.txtLast);
            this.grpInfo.Controls.Add(this.lblPhoneCap);
            this.grpInfo.Controls.Add(this.txtPhone);
            this.grpInfo.Controls.Add(this.lblEmailCap);
            this.grpInfo.Controls.Add(this.txtEmail);
            this.grpInfo.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.grpInfo.Location = new System.Drawing.Point(228, 88);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(468, 260);
            this.grpInfo.TabIndex = 4;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Личные данные";
            //
            // lblLoginCap
            //
            this.lblLoginCap.AutoSize = true;
            this.lblLoginCap.Location = new System.Drawing.Point(16, 30);
            this.lblLoginCap.Name = "lblLoginCap";
            this.lblLoginCap.Size = new System.Drawing.Size(45, 15);
            this.lblLoginCap.TabIndex = 0;
            this.lblLoginCap.Text = "Логин:";
            //
            // lblLoginVal
            //
            this.lblLoginVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoginVal.Location = new System.Drawing.Point(150, 30);
            this.lblLoginVal.Name = "lblLoginVal";
            this.lblLoginVal.Size = new System.Drawing.Size(300, 18);
            this.lblLoginVal.TabIndex = 1;
            this.lblLoginVal.Text = "—";
            //
            // lblRoleCap
            //
            this.lblRoleCap.AutoSize = true;
            this.lblRoleCap.Location = new System.Drawing.Point(16, 58);
            this.lblRoleCap.Name = "lblRoleCap";
            this.lblRoleCap.Size = new System.Drawing.Size(34, 15);
            this.lblRoleCap.TabIndex = 2;
            this.lblRoleCap.Text = "Роль:";
            //
            // lblRoleVal
            //
            this.lblRoleVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRoleVal.Location = new System.Drawing.Point(150, 58);
            this.lblRoleVal.Name = "lblRoleVal";
            this.lblRoleVal.Size = new System.Drawing.Size(300, 18);
            this.lblRoleVal.TabIndex = 3;
            this.lblRoleVal.Text = "—";
            //
            // lblCreatedCap
            //
            this.lblCreatedCap.AutoSize = true;
            this.lblCreatedCap.Location = new System.Drawing.Point(16, 86);
            this.lblCreatedCap.Name = "lblCreatedCap";
            this.lblCreatedCap.Size = new System.Drawing.Size(113, 15);
            this.lblCreatedCap.TabIndex = 4;
            this.lblCreatedCap.Text = "Дата регистрации:";
            //
            // lblCreatedVal
            //
            this.lblCreatedVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCreatedVal.Location = new System.Drawing.Point(150, 86);
            this.lblCreatedVal.Name = "lblCreatedVal";
            this.lblCreatedVal.Size = new System.Drawing.Size(300, 18);
            this.lblCreatedVal.TabIndex = 5;
            this.lblCreatedVal.Text = "—";
            //
            // lblFirstCap
            //
            this.lblFirstCap.AutoSize = true;
            this.lblFirstCap.Location = new System.Drawing.Point(16, 118);
            this.lblFirstCap.Name = "lblFirstCap";
            this.lblFirstCap.Size = new System.Drawing.Size(31, 15);
            this.lblFirstCap.TabIndex = 6;
            this.lblFirstCap.Text = "Имя:";
            //
            // txtFirst
            //
            this.txtFirst.Location = new System.Drawing.Point(150, 115);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(300, 23);
            this.txtFirst.TabIndex = 7;
            //
            // lblLastCap
            //
            this.lblLastCap.AutoSize = true;
            this.lblLastCap.Location = new System.Drawing.Point(16, 150);
            this.lblLastCap.Name = "lblLastCap";
            this.lblLastCap.Size = new System.Drawing.Size(60, 15);
            this.lblLastCap.TabIndex = 8;
            this.lblLastCap.Text = "Фамилия:";
            //
            // txtLast
            //
            this.txtLast.Location = new System.Drawing.Point(150, 147);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(300, 23);
            this.txtLast.TabIndex = 9;
            //
            // lblPhoneCap
            //
            this.lblPhoneCap.AutoSize = true;
            this.lblPhoneCap.Location = new System.Drawing.Point(16, 182);
            this.lblPhoneCap.Name = "lblPhoneCap";
            this.lblPhoneCap.Size = new System.Drawing.Size(55, 15);
            this.lblPhoneCap.TabIndex = 10;
            this.lblPhoneCap.Text = "Телефон:";
            //
            // txtPhone
            //
            this.txtPhone.Location = new System.Drawing.Point(150, 179);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(300, 23);
            this.txtPhone.TabIndex = 11;
            //
            // lblEmailCap
            //
            this.lblEmailCap.AutoSize = true;
            this.lblEmailCap.Location = new System.Drawing.Point(16, 214);
            this.lblEmailCap.Name = "lblEmailCap";
            this.lblEmailCap.Size = new System.Drawing.Size(39, 15);
            this.lblEmailCap.TabIndex = 12;
            this.lblEmailCap.Text = "Почта:";
            //
            // txtEmail
            //
            this.txtEmail.Location = new System.Drawing.Point(150, 211);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 23);
            this.txtEmail.TabIndex = 13;
            //
            // btnSave
            //
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(52, 90, 138);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(228, 358);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 38);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "СОХРАНИТЬ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            //
            // grpPwd
            //
            this.grpPwd.Controls.Add(this.lblOld);
            this.grpPwd.Controls.Add(this.txtOld);
            this.grpPwd.Controls.Add(this.lblNew);
            this.grpPwd.Controls.Add(this.txtNew);
            this.grpPwd.Controls.Add(this.btnChangePwd);
            this.grpPwd.Controls.Add(this.lblPwdHint);
            this.grpPwd.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.grpPwd.Location = new System.Drawing.Point(24, 406);
            this.grpPwd.Name = "grpPwd";
            this.grpPwd.Size = new System.Drawing.Size(672, 104);
            this.grpPwd.TabIndex = 6;
            this.grpPwd.TabStop = false;
            this.grpPwd.Text = "Смена пароля";
            //
            // lblOld
            //
            this.lblOld.AutoSize = true;
            this.lblOld.Location = new System.Drawing.Point(16, 28);
            this.lblOld.Name = "lblOld";
            this.lblOld.Size = new System.Drawing.Size(93, 15);
            this.lblOld.TabIndex = 0;
            this.lblOld.Text = "Старый пароль:";
            //
            // txtOld
            //
            this.txtOld.Location = new System.Drawing.Point(130, 25);
            this.txtOld.Name = "txtOld";
            this.txtOld.Size = new System.Drawing.Size(200, 23);
            this.txtOld.TabIndex = 1;
            this.txtOld.UseSystemPasswordChar = true;
            //
            // lblNew
            //
            this.lblNew.AutoSize = true;
            this.lblNew.Location = new System.Drawing.Point(350, 28);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(92, 15);
            this.lblNew.TabIndex = 2;
            this.lblNew.Text = "Новый пароль:";
            //
            // txtNew
            //
            this.txtNew.Location = new System.Drawing.Point(460, 25);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(190, 23);
            this.txtNew.TabIndex = 3;
            this.txtNew.UseSystemPasswordChar = true;
            //
            // btnChangePwd
            //
            this.btnChangePwd.BackColor = System.Drawing.Color.FromArgb(226, 229, 233);
            this.btnChangePwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePwd.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.btnChangePwd.Location = new System.Drawing.Point(16, 60);
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.Size = new System.Drawing.Size(220, 30);
            this.btnChangePwd.TabIndex = 4;
            this.btnChangePwd.Text = "Сменить пароль";
            this.btnChangePwd.UseVisualStyleBackColor = false;
            this.btnChangePwd.Click += new System.EventHandler(this.btnChangePwd_Click);
            //
            // lblPwdHint
            //
            this.lblPwdHint.ForeColor = System.Drawing.Color.DimGray;
            this.lblPwdHint.Location = new System.Drawing.Point(250, 64);
            this.lblPwdHint.Name = "lblPwdHint";
            this.lblPwdHint.Size = new System.Drawing.Size(400, 20);
            this.lblPwdHint.TabIndex = 5;
            this.lblPwdHint.Text = "Новый пароль: не короче 6 символов";
            //
            // lblStatus
            //
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.lblStatus.Location = new System.Drawing.Point(24, 524);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(500, 38);
            this.lblStatus.TabIndex = 7;
            //
            // btnClose
            //
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(226, 229, 233);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.btnClose.Location = new System.Drawing.Point(544, 524);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(152, 38);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "ЗАКРЫТЬ";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // ofdPhoto
            //
            this.ofdPhoto.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp";
            this.ofdPhoto.Title = "Выберите фотографию профиля";
            //
            // ProfileForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.ClientSize = new System.Drawing.Size(720, 576);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.btnRemovePhoto);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpPwd);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АвтоПрокат — мой профиль";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpPwd.ResumeLayout(false);
            this.grpPwd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.Button btnRemovePhoto;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblLoginCap;
        private System.Windows.Forms.Label lblLoginVal;
        private System.Windows.Forms.Label lblRoleCap;
        private System.Windows.Forms.Label lblRoleVal;
        private System.Windows.Forms.Label lblCreatedCap;
        private System.Windows.Forms.Label lblCreatedVal;
        private System.Windows.Forms.Label lblFirstCap;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label lblLastCap;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label lblPhoneCap;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmailCap;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpPwd;
        private System.Windows.Forms.Label lblOld;
        private System.Windows.Forms.TextBox txtOld;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Button btnChangePwd;
        private System.Windows.Forms.Label lblPwdHint;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog ofdPhoto;
    }
}
