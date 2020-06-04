namespace MedicineManagement.Views.TrangChu
{
    partial class UcTonkho
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcTonkho));
            this.quanLyThuocDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuocDataSet = new MedicineManagement.QuanLyThuocDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_TotalInventory = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_TotalMoney = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMedicineGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_ExportExcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBox_LimitInventory = new System.Windows.Forms.TextBox();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuocDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuocDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // quanLyThuocDataSetBindingSource
            // 
            this.quanLyThuocDataSetBindingSource.DataSource = this.quanLyThuocDataSet;
            this.quanLyThuocDataSetBindingSource.Position = 0;
            // 
            // quanLyThuocDataSet
            // 
            this.quanLyThuocDataSet.DataSetName = "QuanLyThuocDataSet";
            this.quanLyThuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button_ExportExcel);
            this.panel1.Controls.Add(this.textBox_LimitInventory);
            this.panel1.Controls.Add(this.bunifuCheckbox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bunifuCircleProgressbar1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Goldenrod;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 468);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label_TotalInventory);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label_TotalMoney);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.bunifuCustomDataGrid1);
            this.panel2.Location = new System.Drawing.Point(28, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 445);
            this.panel2.TabIndex = 15;
            // 
            // label_TotalInventory
            // 
            this.label_TotalInventory.AutoSize = true;
            this.label_TotalInventory.BackColor = System.Drawing.Color.Transparent;
            this.label_TotalInventory.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalInventory.ForeColor = System.Drawing.Color.Crimson;
            this.label_TotalInventory.Location = new System.Drawing.Point(339, 418);
            this.label_TotalInventory.Name = "label_TotalInventory";
            this.label_TotalInventory.Size = new System.Drawing.Size(19, 22);
            this.label_TotalInventory.TabIndex = 19;
            this.label_TotalInventory.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(246, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tổng tồn kho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(808, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "VNĐ";
            // 
            // label_TotalMoney
            // 
            this.label_TotalMoney.AutoSize = true;
            this.label_TotalMoney.BackColor = System.Drawing.Color.Transparent;
            this.label_TotalMoney.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalMoney.ForeColor = System.Drawing.Color.Crimson;
            this.label_TotalMoney.Location = new System.Drawing.Point(684, 418);
            this.label_TotalMoney.Name = "label_TotalMoney";
            this.label_TotalMoney.Size = new System.Drawing.Size(19, 22);
            this.label_TotalMoney.TabIndex = 16;
            this.label_TotalMoney.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(615, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tổng tiền";
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            this.bunifuCustomDataGrid1.AllowUserToResizeColumns = false;
            this.bunifuCustomDataGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuCustomDataGrid1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtName,
            this.txtMedicineGroup,
            this.txtTotalInventory,
            this.txtUnit,
            this.txtPrice});
            this.bunifuCustomDataGrid1.DataSource = this.quanLyThuocDataSetBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(-1, 0);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.bunifuCustomDataGrid1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(850, 408);
            this.bunifuCustomDataGrid1.TabIndex = 14;
            this.bunifuCustomDataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellClick_1);
            // 
            // txtName
            // 
            this.txtName.DataPropertyName = "Name";
            this.txtName.HeaderText = "Tên thuốc";
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            // 
            // txtMedicineGroup
            // 
            this.txtMedicineGroup.DataPropertyName = "MedicineGroup";
            this.txtMedicineGroup.HeaderText = "Nhóm thuốc";
            this.txtMedicineGroup.Name = "txtMedicineGroup";
            this.txtMedicineGroup.ReadOnly = true;
            // 
            // txtTotalInventory
            // 
            this.txtTotalInventory.DataPropertyName = "TotalInventory";
            this.txtTotalInventory.HeaderText = "Tồn kho";
            this.txtTotalInventory.Name = "txtTotalInventory";
            this.txtTotalInventory.ReadOnly = true;
            // 
            // txtUnit
            // 
            this.txtUnit.DataPropertyName = "Unit";
            this.txtUnit.HeaderText = "Đơn vị";
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            // 
            // txtPrice
            // 
            this.txtPrice.DataPropertyName = "Price";
            this.txtPrice.HeaderText = "Giá";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            // 
            // button_ExportExcel
            // 
            this.button_ExportExcel.Activecolor = System.Drawing.Color.ForestGreen;
            this.button_ExportExcel.BackColor = System.Drawing.Color.ForestGreen;
            this.button_ExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ExportExcel.BorderRadius = 5;
            this.button_ExportExcel.ButtonText = "     Xuất file Excel";
            this.button_ExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ExportExcel.DisabledColor = System.Drawing.Color.Gray;
            this.button_ExportExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_ExportExcel.Iconcolor = System.Drawing.Color.Transparent;
            this.button_ExportExcel.Iconimage = global::MedicineManagement.Properties.Resources.icon_excel;
            this.button_ExportExcel.Iconimage_right = null;
            this.button_ExportExcel.Iconimage_right_Selected = null;
            this.button_ExportExcel.Iconimage_Selected = null;
            this.button_ExportExcel.IconMarginLeft = 0;
            this.button_ExportExcel.IconMarginRight = 0;
            this.button_ExportExcel.IconRightVisible = true;
            this.button_ExportExcel.IconRightZoom = 0D;
            this.button_ExportExcel.IconVisible = true;
            this.button_ExportExcel.IconZoom = 80D;
            this.button_ExportExcel.IsTab = false;
            this.button_ExportExcel.Location = new System.Drawing.Point(1068, 46);
            this.button_ExportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.button_ExportExcel.Name = "button_ExportExcel";
            this.button_ExportExcel.Normalcolor = System.Drawing.Color.ForestGreen;
            this.button_ExportExcel.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.button_ExportExcel.OnHoverTextColor = System.Drawing.Color.White;
            this.button_ExportExcel.selected = false;
            this.button_ExportExcel.Size = new System.Drawing.Size(212, 45);
            this.button_ExportExcel.TabIndex = 14;
            this.button_ExportExcel.Text = "     Xuất file Excel";
            this.button_ExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ExportExcel.Textcolor = System.Drawing.Color.White;
            this.button_ExportExcel.TextFont = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ExportExcel.Click += new System.EventHandler(this.button_ExportExcel_Click);
            // 
            // textBox_LimitInventory
            // 
            this.textBox_LimitInventory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_LimitInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_LimitInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LimitInventory.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_LimitInventory.Location = new System.Drawing.Point(1068, 15);
            this.textBox_LimitInventory.Name = "textBox_LimitInventory";
            this.textBox_LimitInventory.Size = new System.Drawing.Size(212, 24);
            this.textBox_LimitInventory.TabIndex = 1;
            this.textBox_LimitInventory.TextChanged += new System.EventHandler(this.textBox_LimitInventory_TextChanged);
            this.textBox_LimitInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.Silver;
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(889, 15);
            this.bunifuCheckbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 7;
            this.bunifuCheckbox1.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(912, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chọn giới hạn số lượng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(1010, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng đã bán";
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(991, 142);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.Red;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(207, 207);
            this.bunifuCircleProgressbar1.TabIndex = 2;
            this.bunifuCircleProgressbar1.Value = 0;
            // 
            // UcTonkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcTonkho";
            this.Size = new System.Drawing.Size(1308, 468);
            this.Load += new System.EventHandler(this.UcTonkho_Load);
            this.VisibleChanged += new System.EventHandler(this.UcTonkho_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuocDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuocDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private System.Windows.Forms.BindingSource quanLyThuocDataSetBindingSource;
        private QuanLyThuocDataSet quanLyThuocDataSet;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_LimitInventory;
        private Bunifu.Framework.UI.BunifuFlatButton button_ExportExcel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_TotalInventory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_TotalMoney;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMedicineGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTotalInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrice;
    }
}
