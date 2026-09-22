namespace CarRental
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblFilterInfo = new System.Windows.Forms.Label();
            this.grpRent = new System.Windows.Forms.GroupBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.lstCars = new System.Windows.Forms.ListBox();
            this.grpImage = new System.Windows.Forms.GroupBox();
            this.picCar = new System.Windows.Forms.PictureBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnClearImage = new System.Windows.Forms.Button();
            this.lblImageName = new System.Windows.Forms.Label();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.grpData.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.grpRent.SuspendLayout();
            this.grpImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(178, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "АВТОПРОКАТ v0.3";
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
            this.grpData.Location = new System.Drawing.Point(20, 50);
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
            this.grpActions.Controls.Add(this.lblSearch);
            this.grpActions.Controls.Add(this.txtSearch);
            this.grpActions.Controls.Add(this.btnSearch);
            this.grpActions.Location = new System.Drawing.Point(20, 235);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(400, 115);
            this.grpActions.TabIndex = 2;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Работа с автомобилями";
            //
            // btnAdd
            //
            this.btnAdd.Location = new System.Drawing.Point(15, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnDelete
            //
            this.btnDelete.Location = new System.Drawing.Point(205, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // lblSearch
            //
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(15, 76);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(99, 15);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Поиск по марке:";
            //
            // txtSearch
            //
            this.txtSearch.Location = new System.Drawing.Point(130, 73);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 23);
            this.txtSearch.TabIndex = 3;
            //
            // btnSearch
            //
            this.btnSearch.Location = new System.Drawing.Point(290, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            //
            // grpFilter
            //
            this.grpFilter.Controls.Add(this.cmbFilter);
            this.grpFilter.Controls.Add(this.btnFilter);
            this.grpFilter.Controls.Add(this.lblFilterInfo);
            this.grpFilter.Location = new System.Drawing.Point(20, 360);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(400, 90);
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
            this.btnFilter.Location = new System.Drawing.Point(225, 27);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(155, 26);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Показать";
            this.btnFilter.UseVisualStyleBackColor = true;
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
            // grpRent
            //
            this.grpRent.Controls.Add(this.lblDays);
            this.grpRent.Controls.Add(this.txtDays);
            this.grpRent.Controls.Add(this.btnCalc);
            this.grpRent.Controls.Add(this.lblResult);
            this.grpRent.Location = new System.Drawing.Point(20, 460);
            this.grpRent.Name = "grpRent";
            this.grpRent.Size = new System.Drawing.Size(400, 90);
            this.grpRent.TabIndex = 4;
            this.grpRent.TabStop = false;
            this.grpRent.Text = "Расчёт стоимости аренды";
            //
            // lblDays
            //
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(15, 31);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(84, 15);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "Дней аренды:";
            //
            // txtDays
            //
            this.txtDays.Location = new System.Drawing.Point(130, 28);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(85, 23);
            this.txtDays.TabIndex = 1;
            //
            // btnCalc
            //
            this.btnCalc.Location = new System.Drawing.Point(225, 27);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(155, 26);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Рассчитать";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            //
            // lblResult
            //
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(15, 60);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(365, 22);
            this.lblResult.TabIndex = 3;
            //
            // lblList
            //
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblList.Location = new System.Drawing.Point(440, 52);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(125, 15);
            this.lblList.TabIndex = 5;
            this.lblList.Text = "Список автомобилей:";
            //
            // lstCars
            //
            this.lstCars.FormattingEnabled = true;
            this.lstCars.ItemHeight = 15;
            this.lstCars.Location = new System.Drawing.Point(440, 72);
            this.lstCars.Name = "lstCars";
            this.lstCars.Size = new System.Drawing.Size(400, 184);
            this.lstCars.TabIndex = 6;
            //
            // grpImage
            //
            this.grpImage.Controls.Add(this.picCar);
            this.grpImage.Controls.Add(this.btnImage);
            this.grpImage.Controls.Add(this.btnClearImage);
            this.grpImage.Controls.Add(this.lblImageName);
            this.grpImage.Location = new System.Drawing.Point(440, 270);
            this.grpImage.Name = "grpImage";
            this.grpImage.Size = new System.Drawing.Size(400, 280);
            this.grpImage.TabIndex = 7;
            this.grpImage.TabStop = false;
            this.grpImage.Text = "Изображение автомобиля";
            //
            // picCar
            //
            this.picCar.BackColor = System.Drawing.Color.White;
            this.picCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCar.Location = new System.Drawing.Point(15, 28);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(365, 175);
            this.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCar.TabIndex = 0;
            this.picCar.TabStop = false;
            //
            // btnImage
            //
            this.btnImage.Location = new System.Drawing.Point(15, 240);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(180, 30);
            this.btnImage.TabIndex = 1;
            this.btnImage.Text = "Добавить изображение";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            //
            // btnClearImage
            //
            this.btnClearImage.Location = new System.Drawing.Point(205, 240);
            this.btnClearImage.Name = "btnClearImage";
            this.btnClearImage.Size = new System.Drawing.Size(175, 30);
            this.btnClearImage.TabIndex = 2;
            this.btnClearImage.Text = "Очистить изображение";
            this.btnClearImage.UseVisualStyleBackColor = true;
            this.btnClearImage.Click += new System.EventHandler(this.btnClearImage_Click);
            //
            // lblImageName
            //
            this.lblImageName.ForeColor = System.Drawing.Color.DimGray;
            this.lblImageName.Location = new System.Drawing.Point(15, 210);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(365, 20);
            this.lblImageName.TabIndex = 3;
            this.lblImageName.Text = "изображение не выбрано";
            //
            // ofdImage
            //
            this.ofdImage.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp";
            this.ofdImage.Title = "Выберите изображение автомобиля";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 570);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.grpRent);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lstCars);
            this.Controls.Add(this.grpImage);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АвтоПрокат";
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpActions.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpRent.ResumeLayout(false);
            this.grpRent.PerformLayout();
            this.grpImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
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
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblFilterInfo;
        private System.Windows.Forms.GroupBox grpRent;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.ListBox lstCars;
        private System.Windows.Forms.GroupBox grpImage;
        private System.Windows.Forms.PictureBox picCar;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnClearImage;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.OpenFileDialog ofdImage;
    }
}
