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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblDirection = new System.Windows.Forms.Label();
            this.txtDirection = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
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
            this.lblTitle.Text = "ПАЛИТРА v0.1";
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
            // lblName
            //
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 72);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "ФИО ученика";
            //
            // txtName
            //
            this.txtName.Location = new System.Drawing.Point(20, 92);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 23);
            this.txtName.TabIndex = 3;
            //
            // lblAge
            //
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(20, 132);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(50, 15);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Возраст";
            //
            // txtAge
            //
            this.txtAge.Location = new System.Drawing.Point(20, 152);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(260, 23);
            this.txtAge.TabIndex = 5;
            //
            // lblDirection
            //
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(20, 192);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(76, 15);
            this.lblDirection.TabIndex = 6;
            this.lblDirection.Text = "Направление";
            //
            // txtDirection
            //
            this.txtDirection.Location = new System.Drawing.Point(20, 212);
            this.txtDirection.Name = "txtDirection";
            this.txtDirection.Size = new System.Drawing.Size(260, 23);
            this.txtDirection.TabIndex = 7;
            //
            // btnAdd
            //
            this.btnAdd.BackColor = System.Drawing.Color.Thistle;
            this.btnAdd.Location = new System.Drawing.Point(20, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(260, 36);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить ученика";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // lblSearch
            //
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(310, 72);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(80, 15);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Поиск по ФИО";
            //
            // txtSearch
            //
            this.txtSearch.Location = new System.Drawing.Point(310, 92);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(215, 23);
            this.txtSearch.TabIndex = 10;
            //
            // btnSearch
            //
            this.btnSearch.BackColor = System.Drawing.Color.Thistle;
            this.btnSearch.Location = new System.Drawing.Point(535, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 25);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            //
            // lblList
            //
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(310, 132);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(94, 15);
            this.lblList.TabIndex = 12;
            this.lblList.Text = "Список учеников";
            //
            // lstStudents
            //
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 15;
            this.lstStudents.Location = new System.Drawing.Point(310, 152);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(310, 94);
            this.lstStudents.TabIndex = 13;
            //
            // btnDelete
            //
            this.btnDelete.BackColor = System.Drawing.Color.MistyRose;
            this.btnDelete.Location = new System.Drawing.Point(310, 262);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(310, 36);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Удалить выбранного";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(640, 320);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.txtDirection);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.btnDelete);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Художественная школа «Палитра»";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TextBox txtDirection;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Button btnDelete;
    }
}
