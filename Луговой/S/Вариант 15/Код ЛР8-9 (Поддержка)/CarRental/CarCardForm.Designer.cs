namespace CarRental
{
    partial class CarCardForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.grpProps = new System.Windows.Forms.GroupBox();
            this.lblBrandCap = new System.Windows.Forms.Label();
            this.lblBrandVal = new System.Windows.Forms.Label();
            this.lblModelCap = new System.Windows.Forms.Label();
            this.lblModelVal = new System.Windows.Forms.Label();
            this.lblTypeCap = new System.Windows.Forms.Label();
            this.lblTypeVal = new System.Windows.Forms.Label();
            this.lblPriceCap = new System.Windows.Forms.Label();
            this.lblPriceVal = new System.Windows.Forms.Label();
            this.lblWeekCap = new System.Windows.Forms.Label();
            this.lblWeekVal = new System.Windows.Forms.Label();
            this.lblSaved = new System.Windows.Forms.Label();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.grpProps.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(640, 60);
            this.pnlHeader.TabIndex = 0;
            //
            // lblHeader
            //
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(24, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(290, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "КАРТОЧКА АВТОМОБИЛЯ";
            //
            // lblName
            //
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.lblName.Location = new System.Drawing.Point(24, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(592, 32);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Автомобиль";
            //
            // picPhoto
            //
            this.picPhoto.BackColor = System.Drawing.Color.White;
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Location = new System.Drawing.Point(24, 116);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(260, 170);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 2;
            this.picPhoto.TabStop = false;
            //
            // grpProps
            //
            this.grpProps.Controls.Add(this.lblBrandCap);
            this.grpProps.Controls.Add(this.lblBrandVal);
            this.grpProps.Controls.Add(this.lblModelCap);
            this.grpProps.Controls.Add(this.lblModelVal);
            this.grpProps.Controls.Add(this.lblTypeCap);
            this.grpProps.Controls.Add(this.lblTypeVal);
            this.grpProps.Controls.Add(this.lblPriceCap);
            this.grpProps.Controls.Add(this.lblPriceVal);
            this.grpProps.Controls.Add(this.lblWeekCap);
            this.grpProps.Controls.Add(this.lblWeekVal);
            this.grpProps.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.grpProps.Location = new System.Drawing.Point(300, 116);
            this.grpProps.Name = "grpProps";
            this.grpProps.Size = new System.Drawing.Size(316, 170);
            this.grpProps.TabIndex = 3;
            this.grpProps.TabStop = false;
            this.grpProps.Text = "Характеристики";
            //
            // lblBrandCap
            //
            this.lblBrandCap.AutoSize = true;
            this.lblBrandCap.Location = new System.Drawing.Point(16, 30);
            this.lblBrandCap.Name = "lblBrandCap";
            this.lblBrandCap.Size = new System.Drawing.Size(46, 15);
            this.lblBrandCap.TabIndex = 0;
            this.lblBrandCap.Text = "Марка:";
            //
            // lblBrandVal
            //
            this.lblBrandVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBrandVal.Location = new System.Drawing.Point(150, 30);
            this.lblBrandVal.Name = "lblBrandVal";
            this.lblBrandVal.Size = new System.Drawing.Size(150, 18);
            this.lblBrandVal.TabIndex = 1;
            this.lblBrandVal.Text = "—";
            //
            // lblModelCap
            //
            this.lblModelCap.AutoSize = true;
            this.lblModelCap.Location = new System.Drawing.Point(16, 58);
            this.lblModelCap.Name = "lblModelCap";
            this.lblModelCap.Size = new System.Drawing.Size(53, 15);
            this.lblModelCap.TabIndex = 2;
            this.lblModelCap.Text = "Модель:";
            //
            // lblModelVal
            //
            this.lblModelVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblModelVal.Location = new System.Drawing.Point(150, 58);
            this.lblModelVal.Name = "lblModelVal";
            this.lblModelVal.Size = new System.Drawing.Size(150, 18);
            this.lblModelVal.TabIndex = 3;
            this.lblModelVal.Text = "—";
            //
            // lblTypeCap
            //
            this.lblTypeCap.AutoSize = true;
            this.lblTypeCap.Location = new System.Drawing.Point(16, 86);
            this.lblTypeCap.Name = "lblTypeCap";
            this.lblTypeCap.Size = new System.Drawing.Size(40, 15);
            this.lblTypeCap.TabIndex = 4;
            this.lblTypeCap.Text = "Класс:";
            //
            // lblTypeVal
            //
            this.lblTypeVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTypeVal.Location = new System.Drawing.Point(150, 86);
            this.lblTypeVal.Name = "lblTypeVal";
            this.lblTypeVal.Size = new System.Drawing.Size(150, 18);
            this.lblTypeVal.TabIndex = 5;
            this.lblTypeVal.Text = "—";
            //
            // lblPriceCap
            //
            this.lblPriceCap.AutoSize = true;
            this.lblPriceCap.Location = new System.Drawing.Point(16, 114);
            this.lblPriceCap.Name = "lblPriceCap";
            this.lblPriceCap.Size = new System.Drawing.Size(85, 15);
            this.lblPriceCap.TabIndex = 6;
            this.lblPriceCap.Text = "Цена за сутки:";
            //
            // lblPriceVal
            //
            this.lblPriceVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPriceVal.Location = new System.Drawing.Point(150, 114);
            this.lblPriceVal.Name = "lblPriceVal";
            this.lblPriceVal.Size = new System.Drawing.Size(150, 18);
            this.lblPriceVal.TabIndex = 7;
            this.lblPriceVal.Text = "—";
            //
            // lblWeekCap
            //
            this.lblWeekCap.AutoSize = true;
            this.lblWeekCap.Location = new System.Drawing.Point(16, 142);
            this.lblWeekCap.Name = "lblWeekCap";
            this.lblWeekCap.Size = new System.Drawing.Size(116, 15);
            this.lblWeekCap.TabIndex = 8;
            this.lblWeekCap.Text = "Аренда на 7 суток:";
            //
            // lblWeekVal
            //
            this.lblWeekVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblWeekVal.Location = new System.Drawing.Point(150, 142);
            this.lblWeekVal.Name = "lblWeekVal";
            this.lblWeekVal.Size = new System.Drawing.Size(150, 18);
            this.lblWeekVal.TabIndex = 9;
            this.lblWeekVal.Text = "—";
            //
            // lblSaved
            //
            this.lblSaved.ForeColor = System.Drawing.Color.DimGray;
            this.lblSaved.Location = new System.Drawing.Point(24, 298);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.Size = new System.Drawing.Size(592, 40);
            this.lblSaved.TabIndex = 4;
            this.lblSaved.Text = "Документ не сформирован";
            //
            // btnWord
            //
            this.btnWord.BackColor = System.Drawing.Color.FromArgb(52, 90, 138);
            this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWord.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnWord.ForeColor = System.Drawing.Color.White;
            this.btnWord.Location = new System.Drawing.Point(24, 352);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(300, 40);
            this.btnWord.TabIndex = 5;
            this.btnWord.Text = "СФОРМИРОВАТЬ ДОКУМЕНТ";
            this.btnWord.UseVisualStyleBackColor = false;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            //
            // btnClose
            //
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(226, 229, 233);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.btnClose.Location = new System.Drawing.Point(340, 352);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(276, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "ЗАКРЫТЬ";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // CarCardForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.ClientSize = new System.Drawing.Size(640, 416);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.grpProps);
            this.Controls.Add(this.lblSaved);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CarCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АвтоПрокат — карточка автомобиля";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.grpProps.ResumeLayout(false);
            this.grpProps.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.GroupBox grpProps;
        private System.Windows.Forms.Label lblBrandCap;
        private System.Windows.Forms.Label lblBrandVal;
        private System.Windows.Forms.Label lblModelCap;
        private System.Windows.Forms.Label lblModelVal;
        private System.Windows.Forms.Label lblTypeCap;
        private System.Windows.Forms.Label lblTypeVal;
        private System.Windows.Forms.Label lblPriceCap;
        private System.Windows.Forms.Label lblPriceVal;
        private System.Windows.Forms.Label lblWeekCap;
        private System.Windows.Forms.Label lblWeekVal;
        private System.Windows.Forms.Label lblSaved;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnClose;
    }
}
