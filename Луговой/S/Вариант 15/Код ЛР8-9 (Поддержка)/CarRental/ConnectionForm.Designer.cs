namespace CarRental
{
    partial class ConnectionForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.rbPostgres = new System.Windows.Forms.RadioButton();
            this.grpPg = new System.Windows.Forms.GroupBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.rbSqlite = new System.Windows.Forms.RadioButton();
            this.grpLite = new System.Windows.Forms.GroupBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.sfdDatabase = new System.Windows.Forms.SaveFileDialog();
            this.pnlHeader.SuspendLayout();
            this.grpPg.SuspendLayout();
            this.grpLite.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSub);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(560, 64);
            this.pnlHeader.TabIndex = 0;
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ПОДКЛЮЧЕНИЕ К БАЗЕ ДАННЫХ";
            //
            // lblSub
            //
            this.lblSub.AutoSize = true;
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(170, 185, 205);
            this.lblSub.Location = new System.Drawing.Point(22, 38);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(330, 15);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Выберите хранилище данных приложения";
            //
            // rbPostgres
            //
            this.rbPostgres.AutoSize = true;
            this.rbPostgres.Checked = true;
            this.rbPostgres.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbPostgres.Location = new System.Drawing.Point(24, 80);
            this.rbPostgres.Name = "rbPostgres";
            this.rbPostgres.Size = new System.Drawing.Size(264, 21);
            this.rbPostgres.TabIndex = 1;
            this.rbPostgres.TabStop = true;
            this.rbPostgres.Text = "PostgreSQL (основное хранилище)";
            this.rbPostgres.UseVisualStyleBackColor = true;
            this.rbPostgres.CheckedChanged += new System.EventHandler(this.Provider_CheckedChanged);
            //
            // grpPg
            //
            this.grpPg.Controls.Add(this.lblHost);
            this.grpPg.Controls.Add(this.txtHost);
            this.grpPg.Controls.Add(this.lblPort);
            this.grpPg.Controls.Add(this.txtPort);
            this.grpPg.Controls.Add(this.lblDatabase);
            this.grpPg.Controls.Add(this.txtDatabase);
            this.grpPg.Controls.Add(this.lblUser);
            this.grpPg.Controls.Add(this.txtUser);
            this.grpPg.Controls.Add(this.lblPwd);
            this.grpPg.Controls.Add(this.txtPwd);
            this.grpPg.Location = new System.Drawing.Point(24, 106);
            this.grpPg.Name = "grpPg";
            this.grpPg.Size = new System.Drawing.Size(512, 150);
            this.grpPg.TabIndex = 2;
            this.grpPg.TabStop = false;
            this.grpPg.Text = "Параметры PostgreSQL";
            //
            // lblHost
            //
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(16, 30);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(50, 15);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Сервер:";
            //
            // txtHost
            //
            this.txtHost.Location = new System.Drawing.Point(150, 27);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(160, 23);
            this.txtHost.TabIndex = 1;
            //
            // lblPort
            //
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(330, 30);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(36, 15);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Порт:";
            //
            // txtPort
            //
            this.txtPort.Location = new System.Drawing.Point(390, 27);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 23);
            this.txtPort.TabIndex = 3;
            //
            // lblDatabase
            //
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(16, 64);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(82, 15);
            this.lblDatabase.TabIndex = 4;
            this.lblDatabase.Text = "База данных:";
            //
            // txtDatabase
            //
            this.txtDatabase.Location = new System.Drawing.Point(150, 61);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(340, 23);
            this.txtDatabase.TabIndex = 5;
            //
            // lblUser
            //
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(16, 98);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(88, 15);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Пользователь:";
            //
            // txtUser
            //
            this.txtUser.Location = new System.Drawing.Point(150, 95);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(160, 23);
            this.txtUser.TabIndex = 7;
            //
            // lblPwd
            //
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(330, 98);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(51, 15);
            this.lblPwd.TabIndex = 8;
            this.lblPwd.Text = "Пароль:";
            //
            // txtPwd
            //
            this.txtPwd.Location = new System.Drawing.Point(390, 95);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(100, 23);
            this.txtPwd.TabIndex = 9;
            this.txtPwd.UseSystemPasswordChar = true;
            //
            // rbSqlite
            //
            this.rbSqlite.AutoSize = true;
            this.rbSqlite.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbSqlite.Location = new System.Drawing.Point(24, 266);
            this.rbSqlite.Name = "rbSqlite";
            this.rbSqlite.Size = new System.Drawing.Size(338, 21);
            this.rbSqlite.TabIndex = 3;
            this.rbSqlite.Text = "SQLite (запасное хранилище, сервер не нужен)";
            this.rbSqlite.UseVisualStyleBackColor = true;
            this.rbSqlite.CheckedChanged += new System.EventHandler(this.Provider_CheckedChanged);
            //
            // grpLite
            //
            this.grpLite.Controls.Add(this.txtFile);
            this.grpLite.Controls.Add(this.btnBrowse);
            this.grpLite.Location = new System.Drawing.Point(24, 292);
            this.grpLite.Name = "grpLite";
            this.grpLite.Size = new System.Drawing.Size(512, 74);
            this.grpLite.TabIndex = 4;
            this.grpLite.TabStop = false;
            this.grpLite.Text = "Файл базы данных SQLite";
            //
            // txtFile
            //
            this.txtFile.Location = new System.Drawing.Point(16, 30);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(374, 23);
            this.txtFile.TabIndex = 0;
            //
            // btnBrowse
            //
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(226, 229, 233);
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.btnBrowse.Location = new System.Drawing.Point(400, 29);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(90, 26);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Обзор…";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            //
            // lblStatus
            //
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.lblStatus.Location = new System.Drawing.Point(24, 374);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(512, 40);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Подключение не проверялось";
            //
            // btnTest
            //
            this.btnTest.BackColor = System.Drawing.Color.FromArgb(226, 229, 233);
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTest.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.btnTest.Location = new System.Drawing.Point(24, 424);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(160, 38);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "ПРОВЕРИТЬ";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            //
            // btnInit
            //
            this.btnInit.BackColor = System.Drawing.Color.FromArgb(226, 229, 233);
            this.btnInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInit.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.btnInit.Location = new System.Drawing.Point(194, 424);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(180, 38);
            this.btnInit.TabIndex = 7;
            this.btnInit.Text = "СОЗДАТЬ ТАБЛИЦЫ";
            this.btnInit.UseVisualStyleBackColor = false;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            //
            // btnOk
            //
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(52, 90, 138);
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(384, 424);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(152, 38);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "ПРОДОЛЖИТЬ";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            //
            // sfdDatabase
            //
            this.sfdDatabase.Filter = "База SQLite|*.db";
            this.sfdDatabase.Title = "Файл базы данных SQLite";
            //
            // ConnectionForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.ClientSize = new System.Drawing.Size(560, 480);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.rbPostgres);
            this.Controls.Add(this.grpPg);
            this.Controls.Add(this.rbSqlite);
            this.Controls.Add(this.grpLite);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АвтоПрокат — подключение к базе данных";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpPg.ResumeLayout(false);
            this.grpPg.PerformLayout();
            this.grpLite.ResumeLayout(false);
            this.grpLite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.RadioButton rbPostgres;
        private System.Windows.Forms.GroupBox grpPg;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.RadioButton rbSqlite;
        private System.Windows.Forms.GroupBox grpLite;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.SaveFileDialog sfdDatabase;
    }
}
