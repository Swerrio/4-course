namespace MultithreadingWinFormApplication
{
    partial class Form1
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

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RandomNumberTextBox = new System.Windows.Forms.TextBox();
            this.FirstMethodButton = new System.Windows.Forms.Button();
            this.SecondMethodButton = new System.Windows.Forms.Button();
            this.ThirdMethodButton = new System.Windows.Forms.Button();
            this.StartThreadingButton = new System.Windows.Forms.Button();
            this.StopThreadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 340);
            this.panel1.TabIndex = 0;

            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(330, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 340);
            this.panel2.TabIndex = 1;

            this.RandomNumberTextBox.Location = new System.Drawing.Point(648, 12);
            this.RandomNumberTextBox.Multiline = true;
            this.RandomNumberTextBox.Name = "RandomNumberTextBox";
            this.RandomNumberTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RandomNumberTextBox.Size = new System.Drawing.Size(300, 340);
            this.RandomNumberTextBox.TabIndex = 2;

            this.FirstMethodButton.Location = new System.Drawing.Point(12, 362);
            this.FirstMethodButton.Name = "FirstMethodButton";
            this.FirstMethodButton.Size = new System.Drawing.Size(300, 30);
            this.FirstMethodButton.TabIndex = 3;
            this.FirstMethodButton.Text = "Отрисовка прямоугольников";
            this.FirstMethodButton.UseVisualStyleBackColor = true;
            this.FirstMethodButton.Click += new System.EventHandler(this.FirstMethodButton_Click);

            this.SecondMethodButton.Location = new System.Drawing.Point(330, 362);
            this.SecondMethodButton.Name = "SecondMethodButton";
            this.SecondMethodButton.Size = new System.Drawing.Size(300, 30);
            this.SecondMethodButton.TabIndex = 4;
            this.SecondMethodButton.Text = "Отрисовка эллипсов";
            this.SecondMethodButton.UseVisualStyleBackColor = true;
            this.SecondMethodButton.Click += new System.EventHandler(this.SecondMethodButton_Click);

            this.ThirdMethodButton.Location = new System.Drawing.Point(648, 362);
            this.ThirdMethodButton.Name = "ThirdMethodButton";
            this.ThirdMethodButton.Size = new System.Drawing.Size(300, 30);
            this.ThirdMethodButton.TabIndex = 5;
            this.ThirdMethodButton.Text = "Сгенерировать число";
            this.ThirdMethodButton.UseVisualStyleBackColor = true;
            this.ThirdMethodButton.Click += new System.EventHandler(this.ThirdMethodButton_Click);

            this.StartThreadingButton.Location = new System.Drawing.Point(330, 402);
            this.StartThreadingButton.Name = "StartThreadingButton";
            this.StartThreadingButton.Size = new System.Drawing.Size(145, 45);
            this.StartThreadingButton.TabIndex = 6;
            this.StartThreadingButton.Text = "Запустить все методы";
            this.StartThreadingButton.UseVisualStyleBackColor = true;
            this.StartThreadingButton.Click += new System.EventHandler(this.StartThreadingButton_Click);

            this.StopThreadButton.Location = new System.Drawing.Point(485, 402);
            this.StopThreadButton.Name = "StopThreadButton";
            this.StopThreadButton.Size = new System.Drawing.Size(145, 45);
            this.StopThreadButton.TabIndex = 7;
            this.StopThreadButton.Text = "Остановить выполнение потоков";
            this.StopThreadButton.UseVisualStyleBackColor = true;
            this.StopThreadButton.Click += new System.EventHandler(this.StopThreadButton_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 461);
            this.Controls.Add(this.StopThreadButton);
            this.Controls.Add(this.StartThreadingButton);
            this.Controls.Add(this.ThirdMethodButton);
            this.Controls.Add(this.SecondMethodButton);
            this.Controls.Add(this.FirstMethodButton);
            this.Controls.Add(this.RandomNumberTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox RandomNumberTextBox;
        private System.Windows.Forms.Button FirstMethodButton;
        private System.Windows.Forms.Button SecondMethodButton;
        private System.Windows.Forms.Button ThirdMethodButton;
        private System.Windows.Forms.Button StartThreadingButton;
        private System.Windows.Forms.Button StopThreadButton;
    }
}
