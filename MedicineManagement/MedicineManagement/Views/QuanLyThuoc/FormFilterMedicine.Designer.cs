namespace MedicineManagement.Views.QuanLyThuoc
{
    partial class FormFilterMedicine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilterMedicine));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_MostUsed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Submit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.numericUpDown_PriceFrom = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_InventoryFrom = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_PriceTo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_InventoryTo = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_Unit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_MedicineGroup = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_MedicineName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_MedicineID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PriceFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_InventoryFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PriceTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_InventoryTo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 77;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MedicineManagement.Properties.Resources.filter;
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(37, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "Lọc thuốc";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox_MostUsed);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_Cancel);
            this.panel2.Controls.Add(this.btn_Submit);
            this.panel2.Controls.Add(this.numericUpDown_PriceFrom);
            this.panel2.Controls.Add(this.numericUpDown_InventoryFrom);
            this.panel2.Controls.Add(this.numericUpDown_PriceTo);
            this.panel2.Controls.Add(this.numericUpDown_InventoryTo);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.comboBox_Unit);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.comboBox_MedicineGroup);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox_MedicineName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox_MedicineID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 405);
            this.panel2.TabIndex = 78;
            // 
            // textBox_MostUsed
            // 
            this.textBox_MostUsed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MostUsed.Location = new System.Drawing.Point(161, 164);
            this.textBox_MostUsed.Name = "textBox_MostUsed";
            this.textBox_MostUsed.Size = new System.Drawing.Size(217, 27);
            this.textBox_MostUsed.TabIndex = 123;
            this.textBox_MostUsed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_MostUsed_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 124;
            this.label1.Text = "Tháng dùng nhiều";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.ActiveBorderThickness = 1;
            this.btn_Cancel.ActiveCornerRadius = 20;
            this.btn_Cancel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Cancel.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.btn_Cancel.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.BackgroundImage")));
            this.btn_Cancel.ButtonText = "Huỷ";
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Cancel.IdleBorderThickness = 1;
            this.btn_Cancel.IdleCornerRadius = 20;
            this.btn_Cancel.IdleFillColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Cancel.IdleForecolor = System.Drawing.Color.Navy;
            this.btn_Cancel.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Cancel.Location = new System.Drawing.Point(644, 340);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(124, 45);
            this.btn_Cancel.TabIndex = 122;
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.ActiveBorderThickness = 1;
            this.btn_Submit.ActiveCornerRadius = 20;
            this.btn_Submit.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Submit.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.btn_Submit.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btn_Submit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Submit.BackgroundImage")));
            this.btn_Submit.ButtonText = "Lọc";
            this.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Submit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Submit.IdleBorderThickness = 1;
            this.btn_Submit.IdleCornerRadius = 20;
            this.btn_Submit.IdleFillColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Submit.IdleForecolor = System.Drawing.Color.Navy;
            this.btn_Submit.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Submit.Location = new System.Drawing.Point(509, 340);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(124, 45);
            this.btn_Submit.TabIndex = 121;
            this.btn_Submit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // numericUpDown_PriceFrom
            // 
            this.numericUpDown_PriceFrom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_PriceFrom.Location = new System.Drawing.Point(509, 75);
            this.numericUpDown_PriceFrom.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown_PriceFrom.Name = "numericUpDown_PriceFrom";
            this.numericUpDown_PriceFrom.Size = new System.Drawing.Size(100, 27);
            this.numericUpDown_PriceFrom.TabIndex = 120;
            // 
            // numericUpDown_InventoryFrom
            // 
            this.numericUpDown_InventoryFrom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_InventoryFrom.Location = new System.Drawing.Point(509, 119);
            this.numericUpDown_InventoryFrom.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown_InventoryFrom.Name = "numericUpDown_InventoryFrom";
            this.numericUpDown_InventoryFrom.Size = new System.Drawing.Size(100, 27);
            this.numericUpDown_InventoryFrom.TabIndex = 119;
            // 
            // numericUpDown_PriceTo
            // 
            this.numericUpDown_PriceTo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_PriceTo.Location = new System.Drawing.Point(669, 75);
            this.numericUpDown_PriceTo.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown_PriceTo.Name = "numericUpDown_PriceTo";
            this.numericUpDown_PriceTo.Size = new System.Drawing.Size(100, 27);
            this.numericUpDown_PriceTo.TabIndex = 118;
            // 
            // numericUpDown_InventoryTo
            // 
            this.numericUpDown_InventoryTo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_InventoryTo.Location = new System.Drawing.Point(669, 119);
            this.numericUpDown_InventoryTo.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown_InventoryTo.Name = "numericUpDown_InventoryTo";
            this.numericUpDown_InventoryTo.Size = new System.Drawing.Size(100, 27);
            this.numericUpDown_InventoryTo.TabIndex = 117;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(621, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 19);
            this.label10.TabIndex = 116;
            this.label10.Text = "đến";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(621, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 19);
            this.label9.TabIndex = 115;
            this.label9.Text = "đến";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_Unit
            // 
            this.comboBox_Unit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Unit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Unit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Unit.FormattingEnabled = true;
            this.comboBox_Unit.Items.AddRange(new object[] {
            "vỉ",
            "mũi tiêm",
            "chai",
            "tuýp",
            "viên",
            "hộp",
            "lọ"});
            this.comboBox_Unit.Location = new System.Drawing.Point(509, 29);
            this.comboBox_Unit.Name = "comboBox_Unit";
            this.comboBox_Unit.Size = new System.Drawing.Size(260, 27);
            this.comboBox_Unit.TabIndex = 114;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(424, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 113;
            this.label6.Text = "Tồn kho từ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(424, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 112;
            this.label7.Text = "Giá tiền từ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(424, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 19);
            this.label8.TabIndex = 111;
            this.label8.Text = "Đơn vị tính";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_MedicineGroup
            // 
            this.comboBox_MedicineGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_MedicineGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_MedicineGroup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_MedicineGroup.FormattingEnabled = true;
            this.comboBox_MedicineGroup.Items.AddRange(new object[] {
            "bôi",
            "uống",
            "tiêm",
            "miếng dán",
            "dung dịch rửa",
            "nhỏ"});
            this.comboBox_MedicineGroup.Location = new System.Drawing.Point(118, 119);
            this.comboBox_MedicineGroup.Name = "comboBox_MedicineGroup";
            this.comboBox_MedicineGroup.Size = new System.Drawing.Size(260, 27);
            this.comboBox_MedicineGroup.TabIndex = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(30, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 107;
            this.label4.Text = "Nhóm thuốc";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_MedicineName
            // 
            this.textBox_MedicineName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MedicineName.Location = new System.Drawing.Point(119, 75);
            this.textBox_MedicineName.Name = "textBox_MedicineName";
            this.textBox_MedicineName.Size = new System.Drawing.Size(259, 27);
            this.textBox_MedicineName.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 105;
            this.label3.Text = "Tên thuốc";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_MedicineID
            // 
            this.textBox_MedicineID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MedicineID.Location = new System.Drawing.Point(119, 29);
            this.textBox_MedicineID.Name = "textBox_MedicineID";
            this.textBox_MedicineID.Size = new System.Drawing.Size(259, 27);
            this.textBox_MedicineID.TabIndex = 104;
            this.textBox_MedicineID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_MedicineID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 103;
            this.label2.Text = "Mã thuốc";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormFilterMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFilterMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFilterMedicine";
            this.Load += new System.EventHandler(this.FormFilterMedicine_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PriceFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_InventoryFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PriceTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_InventoryTo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Cancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Submit;
        private System.Windows.Forms.NumericUpDown numericUpDown_PriceFrom;
        private System.Windows.Forms.NumericUpDown numericUpDown_InventoryFrom;
        private System.Windows.Forms.NumericUpDown numericUpDown_PriceTo;
        private System.Windows.Forms.NumericUpDown numericUpDown_InventoryTo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_Unit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_MedicineGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_MedicineName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_MedicineID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_MostUsed;
        private System.Windows.Forms.Label label1;
    }
}