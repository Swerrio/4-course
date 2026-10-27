namespace CarRental
{
    partial class CarsForm
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
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblFilterInfo = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.lstCars = new System.Windows.Forms.ListBox();
            this.grpImage = new System.Windows.Forms.GroupBox();
            this.picCar = new System.Windows.Forms.PictureBox();
            this.lblImageName = new System.Windows.Forms.Label();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnClearImage = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.pnlHeader.SuspendLayout();
            this.grpData.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.grpImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 60);
            this.pnlHeader.TabIndex = 0;
            //
            // lblHeader
            //
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(24, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(170, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "АВТОМОБИЛИ";
            //
            // grpData
            //
            this.grpData.Controls.Add(this.lblBrand);
            this.grpData.Controls.Add(this.txtBrand);
            this.grpData.Controls.Add(this.lblModel);
            this.grpData.Controls.Add(this.txtModel);
            this.grpData.Controls.Add(this.lblPrice);
            this.grpData.Controls.Add(this.txtPrice);
            this.grpData.Controls.Add(this.lblType);
            this.grpData.Controls.Add(this.cmbType);
            this.grpData.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.grpData.Location = new System.Drawing.Point(24, 78);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(400, 175);
            this.grpData.TabIndex = 1;
            this.grpData.TabStop = false;
            this.grpData.Text = "Данные автомобиля";
            //
            // lblBrand
            //
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(15, 33);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(46, 15);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Марка:";
            //
            // txtBrand
            //
            this.txtBrand.Location = new System.Drawing.Point(130, 30);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(250, 23);
            this.txtBrand.TabIndex = 1;
            //
            // lblModel
            //
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(15, 68);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(53, 15);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Модель:";
            //
            // txtModel
            //
            this.txtModel.Location = new System.Drawing.Point(130, 65);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(250, 23);
            this.txtModel.TabIndex = 3;
            //
            // lblPrice
            //
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(15, 103);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(85, 15);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Цена за сутки:";
            //
            // txtPrice
            //
            this.txtPrice.Location = new System.Drawing.Point(130, 100);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(250, 23);
            this.txtPrice.TabIndex = 5;
            //
            // lblType
            //
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(15, 138);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 15);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Тип:";
            //
            // cmbType
            //
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Эконом",
            "Комфорт",
            "Бизнес",
            "Внедорожник"});
            this.cmbType.Location = new System.Drawing.Point(130, 135);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(250, 23);
            this.cmbType.TabIndex = 7;
            //
            // grpActions
            //
            this.grpActions.Controls.Add(this.btnAdd);
            this.grpActions.Controls.Add(this.btnDelete);
            this.grpActions.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.grpActions.Location = new System.Drawing.Point(24, 263);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(400, 74);
            this.grpActions.TabIndex = 2;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Работа с каталогом";
            //
            // btnAdd
            //
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(52, 90, 138);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(15, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnDelete
            //
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(226, 229, 233);
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.btnDelete.Location = new System.Drawing.Point(205, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // grpFilter
            //
            this.grpFilter.Controls.Add(this.cmbFilter);
            this.grpFilter.Controls.Add(this.btnFilter);
            this.grpFilter.Controls.Add(this.lblFilterInfo);
            this.grpFilter.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.grpFilter.Location = new System.Drawing.Point(24, 347);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(400, 92);
            this.grpFilter.TabIndex = 3;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Фильтрация автомобилей по типу";
            //
            // cmbFilter
            //
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Все типы",
            "Эконом",
            "Комфорт",
            "Бизнес",
            "Внедорожник"});
            this.cmbFilter.Location = new System.Drawing.Point(15, 28);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(200, 23);
            this.cmbFilter.TabIndex = 0;
            //
            // btnFilter
            //
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(226, 229, 233);
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.btnFilter.Location = new System.Drawing.Point(225, 27);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(155, 26);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Показать";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            //
            // lblFilterInfo
            //
            this.lblFilterInfo.Location = new System.Drawing.Point(15, 60);
            this.lblFilterInfo.Name = "lblFilterInfo";
            this.lblFilterInfo.Size = new System.Drawing.Size(365, 20);
            this.lblFilterInfo.TabIndex = 2;
            this.lblFilterInfo.Text = "Показаны все автомобили: 0";
            //
            // lblList
            //
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblList.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.lblList.Location = new System.Drawing.Point(448, 82);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(136, 15);
            this.lblList.TabIndex = 4;
            this.lblList.Text = "Каталог автомобилей:";
            //
            // lstCars
            //
            this.lstCars.FormattingEnabled = true;
            this.lstCars.ItemHeight = 15;
            this.lstCars.Location = new System.Drawing.Point(448, 102);
            this.lstCars.Name = "lstCars";
            this.lstCars.Size = new System.Drawing.Size(428, 184);
            this.lstCars.TabIndex = 5;
            //
            // grpImage
            //
            this.grpImage.Controls.Add(this.picCar);
            this.grpImage.Controls.Add(this.lblImageName);
            this.grpImage.Controls.Add(this.btnImage);
            this.grpImage.Controls.Add(this.btnClearImage);
            this.grpImage.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.grpImage.Location = new System.Drawing.Point(448, 300);
            this.grpImage.Name = "grpImage";
            this.grpImage.Size = new System.Drawing.Size(428, 220);
            this.grpImage.TabIndex = 6;
            this.grpImage.TabStop = false;
            this.grpImage.Text = "Фотография автомобиля";
            //
            // picCar
            //
            this.picCar.BackColor = System.Drawing.Color.White;
            this.picCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCar.Location = new System.Drawing.Point(16, 26);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(396, 120);
            this.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCar.TabIndex = 0;
            this.picCar.TabStop = false;
            //
            // lblImageName
            //
            this.lblImageName.ForeColor = System.Drawing.Color.DimGray;
            this.lblImageName.Location = new System.Drawing.Point(16, 152);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(396, 20);
            this.lblImageName.TabIndex = 1;
            this.lblImageName.Text = "изображение не выбрано";
            //
            // btnImage
            //
            this.btnImage.BackColor = System.Drawing.Color.FromArgb(226, 229, 233);
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.btnImage.Location = new System.Drawing.Point(16, 178);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(190, 30);
            this.btnImage.TabIndex = 2;
            this.btnImage.Text = "Добавить фото";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            //
            // btnClearImage
            //
            this.btnClearImage.BackColor = System.Drawing.Color.FromArgb(226, 229, 233);
            this.btnClearImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearImage.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.btnClearImage.Location = new System.Drawing.Point(222, 178);
            this.btnClearImage.Name = "btnClearImage";
            this.btnClearImage.Size = new System.Drawing.Size(190, 30);
            this.btnClearImage.TabIndex = 3;
            this.btnClearImage.Text = "Очистить фото";
            this.btnClearImage.UseVisualStyleBackColor = false;
            this.btnClearImage.Click += new System.EventHandler(this.btnClearImage_Click);
            //
            // btnBack
            //
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(226, 229, 233);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.btnBack.Location = new System.Drawing.Point(24, 455);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(180, 38);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "НАЗАД";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            //
            // ofdImage
            //
            this.ofdImage.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp";
            this.ofdImage.Title = "Выберите изображение автомобиля";
            //
            // CarsForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lstCars);
            this.Controls.Add(this.grpImage);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "CarsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АвтоПрокат — автомобили";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpFilter.ResumeLayout(false);
            this.grpImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblFilterInfo;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.ListBox lstCars;
        private System.Windows.Forms.GroupBox grpImage;
        private System.Windows.Forms.PictureBox picCar;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnClearImage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.OpenFileDialog ofdImage;
    }
}
