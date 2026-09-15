namespace CarRental;

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
        lblBrand = new Label();
        txtBrand = new TextBox();
        lblModel = new Label();
        txtModel = new TextBox();
        lblPrice = new Label();
        txtPrice = new TextBox();
        lblSearch = new Label();
        txtSearch = new TextBox();
        btnAdd = new Button();
        btnSearch = new Button();
        btnDelete = new Button();
        lstCars = new ListBox();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitle.Location = new Point(20, 15);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(178, 25);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "АВТОПРОКАТ v0.1";
        // 
        // lblBrand
        // 
        lblBrand.AutoSize = true;
        lblBrand.Location = new Point(20, 63);
        lblBrand.Name = "lblBrand";
        lblBrand.Size = new Size(46, 15);
        lblBrand.TabIndex = 1;
        lblBrand.Text = "Марка:";
        // 
        // txtBrand
        // 
        txtBrand.Location = new Point(130, 60);
        txtBrand.Name = "txtBrand";
        txtBrand.Size = new Size(300, 23);
        txtBrand.TabIndex = 2;
        // 
        // lblModel
        // 
        lblModel.AutoSize = true;
        lblModel.Location = new Point(20, 98);
        lblModel.Name = "lblModel";
        lblModel.Size = new Size(53, 15);
        lblModel.TabIndex = 3;
        lblModel.Text = "Модель:";
        // 
        // txtModel
        // 
        txtModel.Location = new Point(130, 95);
        txtModel.Name = "txtModel";
        txtModel.Size = new Size(300, 23);
        txtModel.TabIndex = 4;
        // 
        // lblPrice
        // 
        lblPrice.AutoSize = true;
        lblPrice.Location = new Point(20, 133);
        lblPrice.Name = "lblPrice";
        lblPrice.Size = new Size(85, 15);
        lblPrice.TabIndex = 5;
        lblPrice.Text = "Цена за сутки:";
        // 
        // txtPrice
        // 
        txtPrice.Location = new Point(130, 130);
        txtPrice.Name = "txtPrice";
        txtPrice.Size = new Size(300, 23);
        txtPrice.TabIndex = 6;
        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Location = new Point(20, 168);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new Size(99, 15);
        lblSearch.TabIndex = 7;
        lblSearch.Text = "Поиск по марке:";
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(130, 165);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(300, 23);
        txtSearch.TabIndex = 8;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(20, 205);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(130, 32);
        btnAdd.TabIndex = 9;
        btnAdd.Text = "Добавить";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(160, 205);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(130, 32);
        btnSearch.TabIndex = 10;
        btnSearch.Text = "Найти";
        btnSearch.UseVisualStyleBackColor = true;
        btnSearch.Click += btnSearch_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(300, 205);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(130, 32);
        btnDelete.TabIndex = 11;
        btnDelete.Text = "Удалить";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // lstCars
        // 
        lstCars.FormattingEnabled = true;
        lstCars.Location = new Point(20, 250);
        lstCars.Name = "lstCars";
        lstCars.Size = new Size(410, 169);
        lstCars.TabIndex = 12;
        lstCars.SelectedIndexChanged += lstCars_SelectedIndexChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(450, 435);
        Controls.Add(lblTitle);
        Controls.Add(lblBrand);
        Controls.Add(txtBrand);
        Controls.Add(lblModel);
        Controls.Add(txtModel);
        Controls.Add(lblPrice);
        Controls.Add(txtPrice);
        Controls.Add(lblSearch);
        Controls.Add(txtSearch);
        Controls.Add(btnAdd);
        Controls.Add(btnSearch);
        Controls.Add(btnDelete);
        Controls.Add(lstCars);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "АвтоПрокат";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitle;
    private Label lblBrand;
    private TextBox txtBrand;
    private Label lblModel;
    private TextBox txtModel;
    private Label lblPrice;
    private TextBox txtPrice;
    private Label lblSearch;
    private TextBox txtSearch;
    private Button btnAdd;
    private Button btnSearch;
    private Button btnDelete;
    private ListBox lstCars;
}
