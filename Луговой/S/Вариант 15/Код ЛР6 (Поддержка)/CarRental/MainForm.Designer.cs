namespace CarRental
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.grpNav = new System.Windows.Forms.GroupBox();
            this.btnCars = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.lblNavHint = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.grpNav.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSub);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(880, 74);
            this.pnlHeader.TabIndex = 0;
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(165, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "АВТОПРОКАТ";
            //
            // lblSub
            //
            this.lblSub.AutoSize = true;
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(170, 185, 205);
            this.lblSub.Location = new System.Drawing.Point(26, 47);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(235, 15);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Управление автопарком и договорами аренды";
            //
            // grpNav
            //
            this.grpNav.Controls.Add(this.btnCars);
            this.grpNav.Controls.Add(this.btnRent);
            this.grpNav.Controls.Add(this.lblNavHint);
            this.grpNav.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.grpNav.Location = new System.Drawing.Point(24, 96);
            this.grpNav.Name = "grpNav";
            this.grpNav.Size = new System.Drawing.Size(400, 140);
            this.grpNav.TabIndex = 1;
            this.grpNav.TabStop = false;
            this.grpNav.Text = "Разделы";
            //
            // btnCars
            //
            this.btnCars.BackColor = System.Drawing.Color.FromArgb(52, 90, 138);
            this.btnCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCars.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCars.ForeColor = System.Drawing.Color.White;
            this.btnCars.Location = new System.Drawing.Point(18, 34);
            this.btnCars.Name = "btnCars";
            this.btnCars.Size = new System.Drawing.Size(170, 44);
            this.btnCars.TabIndex = 0;
            this.btnCars.Text = "АВТОМОБИЛИ";
            this.btnCars.UseVisualStyleBackColor = false;
            this.btnCars.Click += new System.EventHandler(this.btnCars_Click);
            //
            // btnRent
            //
            this.btnRent.BackColor = System.Drawing.Color.FromArgb(52, 90, 138);
            this.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRent.ForeColor = System.Drawing.Color.White;
            this.btnRent.Location = new System.Drawing.Point(198, 34);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(170, 44);
            this.btnRent.TabIndex = 1;
            this.btnRent.Text = "АРЕНДА";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            //
            // lblNavHint
            //
            this.lblNavHint.ForeColor = System.Drawing.Color.DimGray;
            this.lblNavHint.Location = new System.Drawing.Point(18, 90);
            this.lblNavHint.Name = "lblNavHint";
            this.lblNavHint.Size = new System.Drawing.Size(360, 40);
            this.lblNavHint.TabIndex = 2;
            this.lblNavHint.Text = "«Автомобили» — каталог, фотографии и фильтрация. «Аренда» — расчёт стоимости и оформление заказа.";
            //
            // grpSearch
            //
            this.grpSearch.Controls.Add(this.lblSearch);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.grpSearch.Location = new System.Drawing.Point(24, 248);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(400, 110);
            this.grpSearch.TabIndex = 2;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Поиск";
            //
            // lblSearch
            //
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(18, 32);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(115, 15);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Марка автомобиля:";
            //
            // txtSearch
            //
            this.txtSearch.Location = new System.Drawing.Point(18, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 23);
            this.txtSearch.TabIndex = 1;
            //
            // btnSearch
            //
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(226, 229, 233);
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.btnSearch.Location = new System.Drawing.Point(268, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "НАЙТИ";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            //
            // grpInfo
            //
            this.grpInfo.Controls.Add(this.lstInfo);
            this.grpInfo.Controls.Add(this.lblStatus);
            this.grpInfo.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.grpInfo.Location = new System.Drawing.Point(448, 96);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(408, 330);
            this.grpInfo.TabIndex = 3;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Информационная область";
            //
            // lstInfo
            //
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.ItemHeight = 15;
            this.lstInfo.Location = new System.Drawing.Point(16, 30);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(376, 229);
            this.lstInfo.TabIndex = 0;
            //
            // lblStatus
            //
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(16, 272);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(376, 44);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Автомобилей в каталоге: 0";
            //
            // btnExit
            //
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(226, 229, 233);
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.btnExit.Location = new System.Drawing.Point(712, 450);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "ВЫХОД";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.ClientSize = new System.Drawing.Size(880, 510);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.grpNav);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АвтоПрокат — главное меню";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpNav.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.GroupBox grpNav;
        private System.Windows.Forms.Button btnCars;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label lblNavHint;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.ListBox lstInfo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnExit;
    }
}
