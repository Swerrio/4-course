namespace BackgroundWorkerApplication
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.ContainerTextBox = new System.Windows.Forms.TextBox();
            this.CountNumber = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.CountLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.HintLabel = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);

            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);

            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabel,
            this.toolStripStatusLabelTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 339);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(684, 22);
            this.statusStrip.TabIndex = 0;

            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(200, 16);

            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(300, 17);
            this.toolStripStatusLabel.Text = "Готов к работе";
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabelTime.Text = "...00:00:000";

            this.ContainerTextBox.Location = new System.Drawing.Point(12, 12);
            this.ContainerTextBox.Multiline = true;
            this.ContainerTextBox.Name = "ContainerTextBox";
            this.ContainerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ContainerTextBox.Size = new System.Drawing.Size(400, 315);
            this.ContainerTextBox.TabIndex = 1;

            this.StartButton.Location = new System.Drawing.Point(430, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(115, 28);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Запустить";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);

            this.StopButton.Location = new System.Drawing.Point(555, 12);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(115, 28);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Остановить";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);

            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(430, 70);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(130, 13);
            this.CountLabel.TabIndex = 4;
            this.CountLabel.Text = "Количество символов";

            this.CountNumber.Location = new System.Drawing.Point(430, 90);
            this.CountNumber.Name = "CountNumber";
            this.CountNumber.Size = new System.Drawing.Size(140, 20);
            this.CountNumber.TabIndex = 5;
            this.CountNumber.Text = "100";

            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(430, 140);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(150, 13);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Генератор случайных чисел";

            this.HintLabel.AutoSize = true;
            this.HintLabel.Location = new System.Drawing.Point(430, 160);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(200, 13);
            this.HintLabel.TabIndex = 7;
            this.HintLabel.Text = "Диапазон значений: от 0 до 100";

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.HintLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CountNumber);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ContainerTextBox);
            this.Controls.Add(this.statusStrip);
            this.Name = "Form1";
            this.Text = "Генератор чисел";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.TextBox ContainerTextBox;
        private System.Windows.Forms.TextBox CountNumber;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label HintLabel;
    }
}
