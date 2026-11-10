namespace CarRental
{
    partial class UsersForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.grpNew = new System.Windows.Forms.GroupBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.grpNew.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(760, 64);
            this.pnlHeader.TabIndex = 0;
            //
            // lblHeader
            //
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(24, 17);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(220, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "УЧЁТНЫЕ ЗАПИСИ";
            //
            // dgvUsers
            //
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(24, 88);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(712, 280);
            this.dgvUsers.TabIndex = 1;
            //
            // grpNew
            //
            this.grpNew.Controls.Add(this.lblLogin);
            this.grpNew.Controls.Add(this.txtLogin);
            this.grpNew.Controls.Add(this.lblPwd);
            this.grpNew.Controls.Add(this.txtPwd);
            this.grpNew.Controls.Add(this.lblRole);
            this.grpNew.Controls.Add(this.cmbRole);
            this.grpNew.Controls.Add(this.btnAdd);
            this.grpNew.Controls.Add(this.btnDelete);
            this.grpNew.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.grpNew.Location = new System.Drawing.Point(24, 384);
            this.grpNew.Name = "grpNew";
            this.grpNew.Size = new System.Drawing.Size(712, 120);
            this.grpNew.TabIndex = 2;
            this.grpNew.TabStop = false;
            this.grpNew.Text = "Учётная запись";
            //
            // lblLogin
            //
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(16, 30);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(45, 15);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Логин:";
            //
            // txtLogin
            //
            this.txtLogin.Location = new System.Drawing.Point(90, 27);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(160, 23);
            this.txtLogin.TabIndex = 1;
            //
            // lblPwd
            //
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(270, 30);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(51, 15);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "Пароль:";
            //
            // txtPwd
            //
            this.txtPwd.Location = new System.Drawing.Point(340, 27);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(160, 23);
            this.txtPwd.TabIndex = 3;
            //
            // lblRole
            //
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(520, 30);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(34, 15);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "Роль:";
            //
            // cmbRole
            //
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.cmbRole.Location = new System.Drawing.Point(570, 27);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(120, 23);
            this.cmbRole.TabIndex = 5;
            //
            // btnAdd
            //
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(52, 90, 138);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(16, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Создать запись";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnDelete
            //
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(226, 229, 233);
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.btnDelete.Location = new System.Drawing.Point(210, 62);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Удалить выбранную";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // lblStatus
            //
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.lblStatus.Location = new System.Drawing.Point(24, 516);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(540, 38);
            this.lblStatus.TabIndex = 3;
            //
            // btnClose
            //
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(226, 229, 233);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.btnClose.Location = new System.Drawing.Point(584, 516);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(152, 38);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "ЗАКРЫТЬ";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // UsersForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.ClientSize = new System.Drawing.Size(760, 570);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.grpNew);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АвтоПрокат — управление учётными записями";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.grpNew.ResumeLayout(false);
            this.grpNew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox grpNew;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnClose;
    }
}
