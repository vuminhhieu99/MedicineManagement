namespace MedicineManagement.Views.PhieuNhap
{
    partial class FormEditInputCoupon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditInputCoupon));
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Cancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Submit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel_title = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaPN = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxMaNCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxMaNCC);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.textBoxTongTien);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxMaPN);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_Cancel);
            this.panel2.Controls.Add(this.btn_Submit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 405);
            this.panel2.TabIndex = 86;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTongTien.Location = new System.Drawing.Point(159, 169);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.Size = new System.Drawing.Size(609, 27);
            this.textBoxTongTien.TabIndex = 103;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(30, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 102;
            this.label4.Text = "Tổng Tiền";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 100;
            this.label3.Text = "Ngày Lập";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btn_Cancel.TabIndex = 97;
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
            this.btn_Submit.ButtonText = "Lưu";
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
            this.btn_Submit.TabIndex = 96;
            this.btn_Submit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_title.Controls.Add(this.pictureBox1);
            this.panel_title.Controls.Add(this.label1);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(800, 35);
            this.panel_title.TabIndex = 85;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MedicineManagement.Properties.Resources.edit;
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(37, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chỉnh Sửa Phiếu Nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 100;
            this.label2.Text = "Mã Phiếu Nhập";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxMaPN
            // 
            this.textBoxMaPN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaPN.Location = new System.Drawing.Point(159, 27);
            this.textBoxMaPN.Name = "textBoxMaPN";
            this.textBoxMaPN.ReadOnly = true;
            this.textBoxMaPN.Size = new System.Drawing.Size(609, 27);
            this.textBoxMaPN.TabIndex = 101;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 123);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(609, 27);
            this.dateTimePicker1.TabIndex = 105;
            // 
            // textBoxMaNCC
            // 
            this.textBoxMaNCC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaNCC.Location = new System.Drawing.Point(159, 75);
            this.textBoxMaNCC.Name = "textBoxMaNCC";
            this.textBoxMaNCC.Size = new System.Drawing.Size(609, 27);
            this.textBoxMaNCC.TabIndex = 107;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(30, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 106;
            this.label5.Text = "Mã Nhà Cung Cấp";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormEditInputCoupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditInputCoupon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditInputCoupon";
            this.Load += new System.EventHandler(this.FormEditInputCoupon_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Cancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Submit;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaPN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxMaNCC;
        private System.Windows.Forms.Label label5;
    }
}