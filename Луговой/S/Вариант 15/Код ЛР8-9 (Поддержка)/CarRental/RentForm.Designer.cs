namespace CarRental
{
    partial class RentForm
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
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.lblCar = new System.Windows.Forms.Label();
            this.cmbCars = new System.Windows.Forms.ComboBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblDays = new System.Windows.Forms.Label();
            this.numDays = new System.Windows.Forms.NumericUpDown();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpRents = new System.Windows.Forms.GroupBox();
            this.lstRents = new System.Windows.Forms.ListBox();
            this.btnAddRent = new System.Windows.Forms.Button();
            this.btnClearRents = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).BeginInit();
            this.grpRents.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(620, 60);
            this.pnlHeader.TabIndex = 0;
            //
            // lblHeader
            //
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(24, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(100, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "АРЕНДА";
            //
            // grpOrder
            //
            this.grpOrder.Controls.Add(this.lblCar);
            this.grpOrder.Controls.Add(this.cmbCars);
            this.grpOrder.Controls.Add(this.lblStart);
            this.grpOrder.Controls.Add(this.dtpStart);
            this.grpOrder.Controls.Add(this.lblDays);
            this.grpOrder.Controls.Add(this.numDays);
            this.grpOrder.Controls.Add(this.chkInsurance);
            this.grpOrder.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.grpOrder.Location = new System.Drawing.Point(24, 78);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(572, 170);
            this.grpOrder.TabIndex = 1;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Параметры аренды";
            //
            // lblCar
            //
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(16, 34);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(76, 15);
            this.lblCar.TabIndex = 0;
            this.lblCar.Text = "Автомобиль:";
            //
            // cmbCars
            //
            this.cmbCars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCars.FormattingEnabled = true;
            this.cmbCars.Location = new System.Drawing.Point(150, 31);
            this.cmbCars.Name = "cmbCars";
            this.cmbCars.Size = new System.Drawing.Size(400, 23);
            this.cmbCars.TabIndex = 1;
            //
            // lblStart
            //
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(16, 69);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(80, 15);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Дата начала:";
            //
            // dtpStart
            //
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(150, 66);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 23);
            this.dtpStart.TabIndex = 3;
            //
            // lblDays
            //
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(16, 104);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(84, 15);
            this.lblDays.TabIndex = 4;
            this.lblDays.Text = "Дней аренды:";
            //
            // numDays
            //
            this.numDays.Location = new System.Drawing.Point(150, 102);
            this.numDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDays.Name = "numDays";
            this.numDays.Size = new System.Drawing.Size(90, 23);
            this.numDays.TabIndex = 5;
            this.numDays.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            //
            // chkInsurance
            //
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Location = new System.Drawing.Point(150, 136);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(142, 19);
            this.chkInsurance.TabIndex = 6;
            this.chkInsurance.Text = "Страховка (+15 %)";
            this.chkInsurance.UseVisualStyleBackColor = true;
            //
            // btnCalc
            //
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(52, 90, 138);
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.Location = new System.Drawing.Point(24, 262);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(220, 38);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "РАССЧИТАТЬ";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            //
            // lblResult
            //
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.lblResult.Location = new System.Drawing.Point(260, 270);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(336, 24);
            this.lblResult.TabIndex = 3;
            //
            // grpRents
            //
            this.grpRents.Controls.Add(this.lstRents);
            this.grpRents.Controls.Add(this.btnAddRent);
            this.grpRents.Controls.Add(this.btnClearRents);
            this.grpRents.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.grpRents.Location = new System.Drawing.Point(24, 316);
            this.grpRents.Name = "grpRents";
            this.grpRents.Size = new System.Drawing.Size(572, 120);
            this.grpRents.TabIndex = 4;
            this.grpRents.TabStop = false;
            this.grpRents.Text = "Оформленные аренды";
            //
            // lstRents
            //
            this.lstRents.FormattingEnabled = true;
            this.lstRents.ItemHeight = 15;
            this.lstRents.Location = new System.Drawing.Point(16, 26);
            this.lstRents.Name = "lstRents";
            this.lstRents.Size = new System.Drawing.Size(400, 79);
            this.lstRents.TabIndex = 0;
            //
            // btnAddRent
            //
            this.btnAddRent.BackColor = System.Drawing.Color.FromArgb(226, 229, 233);
            this.btnAddRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRent.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.btnAddRent.Location = new System.Drawing.Point(426, 26);
            this.btnAddRent.Name = "btnAddRent";
            this.btnAddRent.Size = new System.Drawing.Size(130, 30);
            this.btnAddRent.TabIndex = 1;
            this.btnAddRent.Text = "ОФОРМИТЬ";
            this.btnAddRent.UseVisualStyleBackColor = false;
            this.btnAddRent.Click += new System.EventHandler(this.btnAddRent_Click);
            //
            // btnClearRents
            //
            this.btnClearRents.BackColor = System.Drawing.Color.FromArgb(226, 229, 233);
            this.btnClearRents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearRents.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.btnClearRents.Location = new System.Drawing.Point(426, 62);
            this.btnClearRents.Name = "btnClearRents";
            this.btnClearRents.Size = new System.Drawing.Size(130, 30);
            this.btnClearRents.TabIndex = 2;
            this.btnClearRents.Text = "ОЧИСТИТЬ";
            this.btnClearRents.UseVisualStyleBackColor = false;
            this.btnClearRents.Click += new System.EventHandler(this.btnClearRents_Click);
            //
            // btnBack
            //
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(226, 229, 233);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(40, 53, 79);
            this.btnBack.Location = new System.Drawing.Point(24, 450);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(180, 36);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "НАЗАД";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            //
            // RentForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.ClientSize = new System.Drawing.Size(620, 500);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.grpRents);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "RentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АвтоПрокат — аренда";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).EndInit();
            this.grpRents.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.ComboBox cmbCars;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.NumericUpDown numDays;
        private System.Windows.Forms.CheckBox chkInsurance;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox grpRents;
        private System.Windows.Forms.ListBox lstRents;
        private System.Windows.Forms.Button btnAddRent;
        private System.Windows.Forms.Button btnClearRents;
        private System.Windows.Forms.Button btnBack;
    }
}
