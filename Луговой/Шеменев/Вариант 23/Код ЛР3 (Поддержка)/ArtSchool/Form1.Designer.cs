namespace ArtSchool;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblTitle = new Label();
        lblSubtitle = new Label();
        lblName = new Label();
        txtName = new TextBox();
        lblAge = new Label();
        txtAge = new TextBox();
        lblDirection = new Label();
        txtDirection = new TextBox();
        btnAdd = new Button();
        lblSearch = new Label();
        txtSearch = new TextBox();
        btnSearch = new Button();
        lblList = new Label();
        lstStudents = new ListBox();
        btnDelete = new Button();
        SuspendLayout();
        //
        // lblTitle
        //
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.ForeColor = Color.DarkMagenta;
        lblTitle.Location = new Point(18, 10);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(164, 30);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "ПАЛИТРА v0.1";
        //
        // lblSubtitle
        //
        lblSubtitle.AutoSize = true;
        lblSubtitle.ForeColor = Color.DimGray;
        lblSubtitle.Location = new Point(21, 42);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(213, 15);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Художественная школа — учёт учеников";
        //
        // lblName
        //
        lblName.AutoSize = true;
        lblName.Location = new Point(20, 72);
        lblName.Name = "lblName";
        lblName.Size = new Size(74, 15);
        lblName.TabIndex = 2;
        lblName.Text = "ФИО ученика";
        //
        // txtName
        //
        txtName.Location = new Point(20, 92);
        txtName.Name = "txtName";
        txtName.Size = new Size(260, 23);
        txtName.TabIndex = 3;
        //
        // lblAge
        //
        lblAge.AutoSize = true;
        lblAge.Location = new Point(20, 132);
        lblAge.Name = "lblAge";
        lblAge.Size = new Size(50, 15);
        lblAge.TabIndex = 4;
        lblAge.Text = "Возраст";
        //
        // txtAge
        //
        txtAge.Location = new Point(20, 152);
        txtAge.Name = "txtAge";
        txtAge.Size = new Size(260, 23);
        txtAge.TabIndex = 5;
        //
        // lblDirection
        //
        lblDirection.AutoSize = true;
        lblDirection.Location = new Point(20, 192);
        lblDirection.Name = "lblDirection";
        lblDirection.Size = new Size(76, 15);
        lblDirection.TabIndex = 6;
        lblDirection.Text = "Направление";
        //
        // txtDirection
        //
        txtDirection.Location = new Point(20, 212);
        txtDirection.Name = "txtDirection";
        txtDirection.Size = new Size(260, 23);
        txtDirection.TabIndex = 7;
        //
        // btnAdd
        //
        btnAdd.BackColor = Color.Thistle;
        btnAdd.Location = new Point(20, 262);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(260, 36);
        btnAdd.TabIndex = 8;
        btnAdd.Text = "Добавить ученика";
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += btnAdd_Click;
        //
        // lblSearch
        //
        lblSearch.AutoSize = true;
        lblSearch.Location = new Point(310, 72);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new Size(80, 15);
        lblSearch.TabIndex = 9;
        lblSearch.Text = "Поиск по ФИО";
        //
        // txtSearch
        //
        txtSearch.Location = new Point(310, 92);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(215, 23);
        txtSearch.TabIndex = 10;
        //
        // btnSearch
        //
        btnSearch.BackColor = Color.Thistle;
        btnSearch.Location = new Point(535, 91);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(85, 25);
        btnSearch.TabIndex = 11;
        btnSearch.Text = "Найти";
        btnSearch.UseVisualStyleBackColor = false;
        btnSearch.Click += btnSearch_Click;
        //
        // lblList
        //
        lblList.AutoSize = true;
        lblList.Location = new Point(310, 132);
        lblList.Name = "lblList";
        lblList.Size = new Size(94, 15);
        lblList.TabIndex = 12;
        lblList.Text = "Список учеников";
        //
        // lstStudents
        //
        lstStudents.FormattingEnabled = true;
        lstStudents.Location = new Point(310, 152);
        lstStudents.Name = "lstStudents";
        lstStudents.Size = new Size(310, 94);
        lstStudents.TabIndex = 13;
        //
        // btnDelete
        //
        btnDelete.BackColor = Color.MistyRose;
        btnDelete.Location = new Point(310, 262);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(310, 36);
        btnDelete.TabIndex = 14;
        btnDelete.Text = "Удалить выбранного";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        //
        // Form1
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Lavender;
        ClientSize = new Size(640, 320);
        Controls.Add(lblTitle);
        Controls.Add(lblSubtitle);
        Controls.Add(lblName);
        Controls.Add(txtName);
        Controls.Add(lblAge);
        Controls.Add(txtAge);
        Controls.Add(lblDirection);
        Controls.Add(txtDirection);
        Controls.Add(btnAdd);
        Controls.Add(lblSearch);
        Controls.Add(txtSearch);
        Controls.Add(btnSearch);
        Controls.Add(lblList);
        Controls.Add(lstStudents);
        Controls.Add(btnDelete);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Художественная школа «Палитра»";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitle;
    private Label lblSubtitle;
    private Label lblName;
    private TextBox txtName;
    private Label lblAge;
    private TextBox txtAge;
    private Label lblDirection;
    private TextBox txtDirection;
    private Button btnAdd;
    private Label lblSearch;
    private TextBox txtSearch;
    private Button btnSearch;
    private Label lblList;
    private ListBox lstStudents;
    private Button btnDelete;
}
