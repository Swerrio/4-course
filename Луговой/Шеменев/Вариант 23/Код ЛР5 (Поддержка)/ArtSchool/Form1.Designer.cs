namespace ArtSchool
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
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.grpStudent = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblDirection = new System.Windows.Forms.Label();
            this.txtDirection = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblFilterInfo = new System.Windows.Forms.Label();
            this.grpTuition = new System.Windows.Forms.GroupBox();
            this.lblMonths = new System.Windows.Forms.Label();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.grpImage = new System.Windows.Forms.GroupBox();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnClearImage = new System.Windows.Forms.Button();
            this.lblImageName = new System.Windows.Forms.Label();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.grpStudent.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpTuition.SuspendLayout();
            this.grpImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblTitle.Location = new System.Drawing.Point(18, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(164, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ПАЛИТРА v0.3";
            //
            // lblSubtitle
            //
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitle.Location = new System.Drawing.Point(21, 42);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(213, 15);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Художественная школа — учёт учеников";
            //
            // grpStudent
            //
            this.grpStudent.Controls.Add(this.lblName);
            this.grpStudent.Controls.Add(this.txtName);
            this.grpStudent.Controls.Add(this.lblAge);
            this.grpStudent.Controls.Add(this.txtAge);
            this.grpStudent.Controls.Add(this.lblDirection);
            this.grpStudent.Controls.Add(this.txtDirection);
            this.grpStudent.Controls.Add(this.btnAdd);
            this.grpStudent.Controls.Add(this.btnDelete);
            this.grpStudent.Location = new System.Drawing.Point(20, 70);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Size = new System.Drawing.Size(400, 175);
            this.grpStudent.TabIndex = 2;
            this.grpStudent.TabStop = false;
            this.grpStudent.Text = "Данные ученика";
            //
            // lblName
            //
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "ФИО ученика";
            //
            // txtName
            //
            this.txtName.Location = new System.Drawing.Point(130, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 23);
            this.txtName.TabIndex = 1;
            //
            // lblAge
            //
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(15, 66);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(50, 15);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Возраст";
            //
            // txtAge
            //
            this.txtAge.Location = new System.Drawing.Point(130, 63);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(250, 23);
            this.txtAge.TabIndex = 3;
            //
            // lblDirection
            //
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(15, 101);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(76, 15);
            this.lblDirection.TabIndex = 4;
            this.lblDirection.Text = "Направление";
            //
            // txtDirection
            //
            this.txtDirection.Location = new System.Drawing.Point(130, 98);
            this.txtDirection.Name = "txtDirection";
            this.txtDirection.Size = new System.Drawing.Size(250, 23);
            this.txtDirection.TabIndex = 5;
            //
            // btnAdd
            //
            this.btnAdd.BackColor = System.Drawing.Color.Thistle;
            this.btnAdd.Location = new System.Drawing.Point(15, 133);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 32);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить ученика";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnDelete
            //
            this.btnDelete.BackColor = System.Drawing.Color.MistyRose;
            this.btnDelete.Location = new System.Drawing.Point(205, 133);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 32);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Удалить выбранного";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // grpSearch
            //
            this.grpSearch.Controls.Add(this.lblSearch);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.lblFilter);
            this.grpSearch.Controls.Add(this.cmbFilter);
            this.grpSearch.Controls.Add(this.btnFilter);
            this.grpSearch.Controls.Add(this.lblFilterInfo);
            this.grpSearch.Location = new System.Drawing.Point(20, 255);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(400, 185);
            this.grpSearch.TabIndex = 3;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Поиск и фильтрация";
            //
            // lblSearch
            //
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(15, 28);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(80, 15);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Поиск по ФИО";
            //
            // txtSearch
            //
            this.txtSearch.Location = new System.Drawing.Point(15, 48);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 23);
            this.txtSearch.TabIndex = 1;
            //
            // btnSearch
            //
            this.btnSearch.BackColor = System.Drawing.Color.Thistle;
            this.btnSearch.Location = new System.Drawing.Point(275, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            //
            // lblFilter
            //
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(15, 88);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(109, 15);
            this.lblFilter.TabIndex = 3;
            this.lblFilter.Text = "Возрастная группа";
            //
            // cmbFilter
            //
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Все ученики",
            "5–9 лет",
            "10–13 лет",
            "14–18 лет"});
            this.cmbFilter.Location = new System.Drawing.Point(15, 108);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(250, 23);
            this.cmbFilter.TabIndex = 4;
            //
            // btnFilter
            //
            this.btnFilter.BackColor = System.Drawing.Color.Thistle;
            this.btnFilter.Location = new System.Drawing.Point(275, 107);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(105, 25);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Показать";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            //
            // lblFilterInfo
            //
            this.lblFilterInfo.Location = new System.Drawing.Point(15, 145);
            this.lblFilterInfo.Name = "lblFilterInfo";
            this.lblFilterInfo.Size = new System.Drawing.Size(365, 20);
            this.lblFilterInfo.TabIndex = 6;
            this.lblFilterInfo.Text = "Показаны все ученики: 0";
            //
            // grpTuition
            //
            this.grpTuition.Controls.Add(this.lblMonths);
            this.grpTuition.Controls.Add(this.txtMonths);
            this.grpTuition.Controls.Add(this.btnCalc);
            this.grpTuition.Controls.Add(this.lblResult);
            this.grpTuition.Location = new System.Drawing.Point(20, 450);
            this.grpTuition.Name = "grpTuition";
            this.grpTuition.Size = new System.Drawing.Size(400, 95);
            this.grpTuition.TabIndex = 4;
            this.grpTuition.TabStop = false;
            this.grpTuition.Text = "Расчёт стоимости обучения";
            //
            // lblMonths
            //
            this.lblMonths.AutoSize = true;
            this.lblMonths.Location = new System.Drawing.Point(15, 31);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(115, 15);
            this.lblMonths.TabIndex = 0;
            this.lblMonths.Text = "Месяцев обучения";
            //
            // txtMonths
            //
            this.txtMonths.Location = new System.Drawing.Point(140, 28);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(85, 23);
            this.txtMonths.TabIndex = 1;
            //
            // btnCalc
            //
            this.btnCalc.BackColor = System.Drawing.Color.Thistle;
            this.btnCalc.Location = new System.Drawing.Point(240, 27);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(140, 26);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Рассчитать стоимость";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            //
            // lblResult
            //
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblResult.Location = new System.Drawing.Point(15, 62);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(365, 22);
            this.lblResult.TabIndex = 3;
            //
            // lblList
            //
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblList.Location = new System.Drawing.Point(440, 72);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(104, 15);
            this.lblList.TabIndex = 5;
            this.lblList.Text = "Список учеников";
            //
            // lstStudents
            //
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 15;
            this.lstStudents.Location = new System.Drawing.Point(440, 92);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(400, 154);
            this.lstStudents.TabIndex = 6;
            //
            // grpImage
            //
            this.grpImage.Controls.Add(this.picStudent);
            this.grpImage.Controls.Add(this.btnImage);
            this.grpImage.Controls.Add(this.btnClearImage);
            this.grpImage.Controls.Add(this.lblImageName);
            this.grpImage.Location = new System.Drawing.Point(440, 255);
            this.grpImage.Name = "grpImage";
            this.grpImage.Size = new System.Drawing.Size(400, 290);
            this.grpImage.TabIndex = 7;
            this.grpImage.TabStop = false;
            this.grpImage.Text = "Работа ученика";
            //
            // picStudent
            //
            this.picStudent.BackColor = System.Drawing.Color.White;
            this.picStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStudent.Location = new System.Drawing.Point(15, 28);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(365, 185);
            this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStudent.TabIndex = 0;
            this.picStudent.TabStop = false;
            //
            // btnImage
            //
            this.btnImage.BackColor = System.Drawing.Color.Thistle;
            this.btnImage.Location = new System.Drawing.Point(15, 248);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(180, 32);
            this.btnImage.TabIndex = 1;
            this.btnImage.Text = "Добавить изображение";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            //
            // btnClearImage
            //
            this.btnClearImage.BackColor = System.Drawing.Color.MistyRose;
            this.btnClearImage.Location = new System.Drawing.Point(205, 248);
            this.btnClearImage.Name = "btnClearImage";
            this.btnClearImage.Size = new System.Drawing.Size(175, 32);
            this.btnClearImage.TabIndex = 2;
            this.btnClearImage.Text = "Очистить изображение";
            this.btnClearImage.UseVisualStyleBackColor = false;
            this.btnClearImage.Click += new System.EventHandler(this.btnClearImage_Click);
            //
            // lblImageName
            //
            this.lblImageName.ForeColor = System.Drawing.Color.DimGray;
            this.lblImageName.Location = new System.Drawing.Point(15, 220);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(365, 20);
            this.lblImageName.TabIndex = 3;
            this.lblImageName.Text = "изображение не выбрано";
            //
            // ofdImage
            //
            this.ofdImage.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp";
            this.ofdImage.Title = "Выберите работу ученика";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(860, 565);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.grpStudent);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpTuition);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.grpImage);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Художественная школа «Палитра»";
            this.grpStudent.ResumeLayout(false);
            this.grpStudent.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpTuition.ResumeLayout(false);
            this.grpTuition.PerformLayout();
            this.grpImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox grpStudent;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TextBox txtDirection;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblFilterInfo;
        private System.Windows.Forms.GroupBox grpTuition;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.TextBox txtMonths;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.GroupBox grpImage;
        private System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnClearImage;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.OpenFileDialog ofdImage;
    }
}
