namespace MedicineManagement.Views.PhieuNhap
{
    partial class FormDetailInputCoupon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailInputCoupon));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_title = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxMaNCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMaPN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Return = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Edit = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_title.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MedicineManagement.Properties.Resources.detail;
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
            this.label1.Size = new System.Drawing.Size(181, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Phiếu Nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.panel_title.TabIndex = 84;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.textBoxMaNCC);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxMaPN);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxTongTien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_Return);
            this.panel2.Controls.Add(this.btn_Edit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 405);
            this.panel2.TabIndex = 85;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(609, 27);
            this.dateTimePicker1.TabIndex = 106;
            // 
            // textBoxMaNCC
            // 
            this.textBoxMaNCC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaNCC.Location = new System.Drawing.Point(159, 66);
            this.textBoxMaNCC.Name = "textBoxMaNCC";
            this.textBoxMaNCC.ReadOnly = true;
            this.textBoxMaNCC.Size = new System.Drawing.Size(609, 27);
            this.textBoxMaNCC.TabIndex = 105;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(30, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 104;
            this.label5.Text = "Mã Nhà Cung Cấp";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxMaPN
            // 
            this.textBoxMaPN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaPN.Location = new System.Drawing.Point(159, 17);
            this.textBoxMaPN.Name = "textBoxMaPN";
            this.textBoxMaPN.ReadOnly = true;
            this.textBoxMaPN.Size = new System.Drawing.Size(609, 27);
            this.textBoxMaPN.TabIndex = 103;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(30, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 102;
            this.label4.Text = "Mã Phiếu Nhập";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTongTien.Location = new System.Drawing.Point(159, 158);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.ReadOnly = true;
            this.textBoxTongTien.Size = new System.Drawing.Size(609, 27);
            this.textBoxTongTien.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 100;
            this.label3.Text = "Tổng Tiền ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 98;
            this.label2.Text = "Ngày Lập";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Return
            // 
            this.btn_Return.ActiveBorderThickness = 1;
            this.btn_Return.ActiveCornerRadius = 20;
            this.btn_Return.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Return.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.btn_Return.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btn_Return.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Return.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Return.BackgroundImage")));
            this.btn_Return.ButtonText = "Danh sách";
            this.btn_Return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Return.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Return.IdleBorderThickness = 1;
            this.btn_Return.IdleCornerRadius = 20;
            this.btn_Return.IdleFillColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Return.IdleForecolor = System.Drawing.Color.Navy;
            this.btn_Return.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Return.Location = new System.Drawing.Point(644, 340);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(124, 45);
            this.btn_Return.TabIndex = 97;
            this.btn_Return.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.ActiveBorderThickness = 1;
            this.btn_Edit.ActiveCornerRadius = 20;
            this.btn_Edit.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Edit.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.btn_Edit.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btn_Edit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Edit.BackgroundImage")));
            this.btn_Edit.ButtonText = "Chỉnh sửa";
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Edit.IdleBorderThickness = 1;
            this.btn_Edit.IdleCornerRadius = 20;
            this.btn_Edit.IdleFillColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Edit.IdleForecolor = System.Drawing.Color.Navy;
            this.btn_Edit.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Edit.Location = new System.Drawing.Point(509, 340);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(124, 45);
            this.btn_Edit.TabIndex = 96;
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // FormDetailInputCoupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDetailInputCoupon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetailInputCoupon";
            this.Load += new System.EventHandler(this.FormDetailInputCoupon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Return;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Edit;
        private System.Windows.Forms.TextBox textBoxTongTien;
        private System.Windows.Forms.TextBox textBoxMaPN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMaNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}