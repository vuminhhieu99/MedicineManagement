namespace MedicineManagement.Views.NhaCungCap
{
    partial class UcNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcNhaCungCap));
            this.label_CountRecord = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_Export = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Reload = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Search = new Bunifu.Framework.UI.BunifuImageButton();
            this.quanLyThuocDataSet = new MedicineManagement.QuanLyThuocDataSet();
            this.sUPPLIERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUPPLIERTableAdapter = new MedicineManagement.QuanLyThuocDataSetTableAdapters.SUPPLIERTableAdapter();
            this.iDSupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewImageColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_CountRecord
            // 
            this.label_CountRecord.AutoSize = true;
            this.label_CountRecord.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CountRecord.ForeColor = System.Drawing.Color.Maroon;
            this.label_CountRecord.Location = new System.Drawing.Point(16, 788);
            this.label_CountRecord.Name = "label_CountRecord";
            this.label_CountRecord.Size = new System.Drawing.Size(86, 17);
            this.label_CountRecord.TabIndex = 71;
            this.label_CountRecord.Text = "30/30 bản ghi";
            // 
            // textBox_Search
            // 
            this.textBox_Search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Search.ForeColor = System.Drawing.Color.Black;
            this.textBox_Search.Location = new System.Drawing.Point(19, 18);
            this.textBox_Search.Multiline = true;
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(364, 30);
            this.textBox_Search.TabIndex = 66;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(19, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1272, 34);
            this.textBox1.TabIndex = 64;
            this.textBox1.Text = "DANH SÁCH NHÀ CUNG CẤP";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSupplierDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.detail,
            this.edit,
            this.delete});
            this.dataGridView1.DataSource = this.sUPPLIERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1272, 668);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Xem";
            this.dataGridViewImageColumn1.Image = global::MedicineManagement.Properties.Resources.icon_detail;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "Sửa";
            this.dataGridViewImageColumn2.Image = global::MedicineManagement.Properties.Resources.icon_edit;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.HeaderText = "Xoá";
            this.dataGridViewImageColumn3.Image = global::MedicineManagement.Properties.Resources.icon_delete;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            // 
            // btn_Export
            // 
            this.btn_Export.ActiveBorderThickness = 1;
            this.btn_Export.ActiveCornerRadius = 20;
            this.btn_Export.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Export.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.btn_Export.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btn_Export.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Export.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Export.BackgroundImage")));
            this.btn_Export.ButtonText = "Xuất file";
            this.btn_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Export.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Export.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Export.IdleBorderThickness = 1;
            this.btn_Export.IdleCornerRadius = 20;
            this.btn_Export.IdleFillColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Export.IdleForecolor = System.Drawing.Color.Navy;
            this.btn_Export.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Export.Location = new System.Drawing.Point(1037, 10);
            this.btn_Export.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(124, 45);
            this.btn_Export.TabIndex = 70;
            this.btn_Export.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.ActiveBorderThickness = 1;
            this.btn_Reload.ActiveCornerRadius = 20;
            this.btn_Reload.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Reload.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.btn_Reload.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btn_Reload.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Reload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Reload.BackgroundImage")));
            this.btn_Reload.ButtonText = "Nạp lại";
            this.btn_Reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reload.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Reload.IdleBorderThickness = 1;
            this.btn_Reload.IdleCornerRadius = 20;
            this.btn_Reload.IdleFillColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Reload.IdleForecolor = System.Drawing.Color.Navy;
            this.btn_Reload.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Reload.Location = new System.Drawing.Point(906, 10);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(124, 45);
            this.btn_Reload.TabIndex = 68;
            this.btn_Reload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.ActiveBorderThickness = 1;
            this.btn_Add.ActiveCornerRadius = 20;
            this.btn_Add.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Add.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.btn_Add.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btn_Add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Add.BackgroundImage")));
            this.btn_Add.ButtonText = "Thêm mới";
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Add.IdleBorderThickness = 1;
            this.btn_Add.IdleCornerRadius = 20;
            this.btn_Add.IdleFillColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Add.IdleForecolor = System.Drawing.Color.Navy;
            this.btn_Add.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Add.Location = new System.Drawing.Point(1167, 10);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(124, 45);
            this.btn_Add.TabIndex = 65;
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_Search.Image = global::MedicineManagement.Properties.Resources.icon_search;
            this.btn_Search.ImageActive = null;
            this.btn_Search.Location = new System.Drawing.Point(382, 18);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(44, 30);
            this.btn_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Search.TabIndex = 67;
            this.btn_Search.TabStop = false;
            this.btn_Search.Zoom = 10;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // quanLyThuocDataSet
            // 
            this.quanLyThuocDataSet.DataSetName = "QuanLyThuocDataSet";
            this.quanLyThuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sUPPLIERBindingSource
            // 
            this.sUPPLIERBindingSource.DataMember = "SUPPLIER";
            this.sUPPLIERBindingSource.DataSource = this.quanLyThuocDataSet;
            // 
            // sUPPLIERTableAdapter
            // 
            this.sUPPLIERTableAdapter.ClearBeforeFill = true;
            // 
            // iDSupplierDataGridViewTextBoxColumn
            // 
            this.iDSupplierDataGridViewTextBoxColumn.DataPropertyName = "ID_Supplier";
            this.iDSupplierDataGridViewTextBoxColumn.HeaderText = "Mã nhà cung cấp";
            this.iDSupplierDataGridViewTextBoxColumn.Name = "iDSupplierDataGridViewTextBoxColumn";
            this.iDSupplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nhà Cung Cấp";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Số Điện Thoại";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detail
            // 
            this.detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.detail.HeaderText = "Xem";
            this.detail.Image = global::MedicineManagement.Properties.Resources.icon_detail;
            this.detail.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            this.detail.Width = 34;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.HeaderText = "Sửa";
            this.edit.Image = global::MedicineManagement.Properties.Resources.icon_edit;
            this.edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Width = 32;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.HeaderText = "Xoá";
            this.delete.Image = global::MedicineManagement.Properties.Resources.icon_delete;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 32;
            // 
            // UcNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label_CountRecord);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UcNhaCungCap";
            this.Size = new System.Drawing.Size(1312, 822);
            this.Load += new System.EventHandler(this.UcNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btn_Export;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Reload;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Add;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label_CountRecord;
        private System.Windows.Forms.TextBox textBox_Search;
        private Bunifu.Framework.UI.BunifuImageButton btn_Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn detail;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.BindingSource sUPPLIERBindingSource;
        private QuanLyThuocDataSet quanLyThuocDataSet;
        private QuanLyThuocDataSetTableAdapters.SUPPLIERTableAdapter sUPPLIERTableAdapter;
    }
}
