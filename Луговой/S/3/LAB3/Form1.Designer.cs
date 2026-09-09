
namespace LAB3
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
            this.label1 = new System.Windows.Forms.Label();
            this.markatext = new System.Windows.Forms.Label();
            this.modeltext = new System.Windows.Forms.Label();
            this.yeartext = new System.Windows.Forms.Label();
            this.pricedaytext = new System.Windows.Forms.Label();
            this.markaTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.leaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "АвтоПока";
            // 
            // markatext
            // 
            this.markatext.AutoSize = true;
            this.markatext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markatext.Location = new System.Drawing.Point(36, 70);
            this.markatext.Name = "markatext";
            this.markatext.Size = new System.Drawing.Size(61, 20);
            this.markatext.TabIndex = 1;
            this.markatext.Text = "Марка:";
            // 
            // modeltext
            // 
            this.modeltext.AutoSize = true;
            this.modeltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeltext.Location = new System.Drawing.Point(36, 103);
            this.modeltext.Name = "modeltext";
            this.modeltext.Size = new System.Drawing.Size(74, 20);
            this.modeltext.TabIndex = 2;
            this.modeltext.Text = "Модель:";
            this.modeltext.Click += new System.EventHandler(this.label2_Click);
            // 
            // yeartext
            // 
            this.yeartext.AutoSize = true;
            this.yeartext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yeartext.Location = new System.Drawing.Point(38, 131);
            this.yeartext.Name = "yeartext";
            this.yeartext.Size = new System.Drawing.Size(42, 20);
            this.yeartext.TabIndex = 3;
            this.yeartext.Text = "Год:";
            // 
            // pricedaytext
            // 
            this.pricedaytext.AutoSize = true;
            this.pricedaytext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pricedaytext.Location = new System.Drawing.Point(38, 157);
            this.pricedaytext.Name = "pricedaytext";
            this.pricedaytext.Size = new System.Drawing.Size(94, 20);
            this.pricedaytext.TabIndex = 4;
            this.pricedaytext.Text = "Цена/день:";
            // 
            // markaTextBox
            // 
            this.markaTextBox.Location = new System.Drawing.Point(98, 71);
            this.markaTextBox.Name = "markaTextBox";
            this.markaTextBox.Size = new System.Drawing.Size(260, 20);
            this.markaTextBox.TabIndex = 5;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(116, 105);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(242, 20);
            this.modelTextBox.TabIndex = 6;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(86, 131);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(226, 216);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "ДОБАВИТЬ";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(307, 216);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "НАЙТИ";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(388, 216);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "УДАЛИТЬ";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // leaveButton
            // 
            this.leaveButton.Location = new System.Drawing.Point(469, 216);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(75, 23);
            this.leaveButton.TabIndex = 12;
            this.leaveButton.Text = "ВЫХОД";
            this.leaveButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.markaTextBox);
            this.Controls.Add(this.pricedaytext);
            this.Controls.Add(this.yeartext);
            this.Controls.Add(this.modeltext);
            this.Controls.Add(this.markatext);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label markatext;
        private System.Windows.Forms.Label modeltext;
        private System.Windows.Forms.Label yeartext;
        private System.Windows.Forms.Label pricedaytext;
        private System.Windows.Forms.TextBox markaTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button leaveButton;
    }
}

