namespace MedicineManagement.Views
{
    partial class UcBanThuoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalIventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MostUsedMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁN THUỐC";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(20, 252);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1272, 34);
            this.textBox1.TabIndex = 55;
            this.textBox1.Text = "TÊN BẢNG";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Medicine,
            this.Name,
            this.MedicineGroup,
            this.Uses,
            this.Unit,
            this.Price,
            this.TotalIventory,
            this.MostUsedMonth,
            this.Note,
            this.Edit,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(20, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1272, 284);
            this.dataGridView1.TabIndex = 54;
            // 
            // ID_Medicine
            // 
            this.ID_Medicine.HeaderText = "Mã thuốc";
            this.ID_Medicine.Name = "ID_Medicine";
            // 
            // Name
            // 
            this.Name.HeaderText = "Tên thuốc";
            this.Name.Name = "Name";
            // 
            // MedicineGroup
            // 
            this.MedicineGroup.HeaderText = "Tên thuốc";
            this.MedicineGroup.Name = "MedicineGroup";
            // 
            // Uses
            // 
            this.Uses.HeaderText = "Công dụng";
            this.Uses.Name = "Uses";
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Đơn vị tính";
            this.Unit.Name = "Unit";
            // 
            // Price
            // 
            this.Price.HeaderText = "Giá tiền";
            this.Price.Name = "Price";
            // 
            // TotalIventory
            // 
            this.TotalIventory.HeaderText = "Tổng tồn kho";
            this.TotalIventory.Name = "TotalIventory";
            // 
            // MostUsedMonth
            // 
            this.MostUsedMonth.HeaderText = "Tháng dùng nhiều nhất";
            this.MostUsedMonth.Name = "MostUsedMonth";
            // 
            // Note
            // 
            this.Note.HeaderText = "Ghi chú";
            this.Note.Name = "Note";
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "Sửa";
            this.Edit.Image = global::MedicineManagement.Properties.Resources.edit;
            this.Edit.Name = "Edit";
            this.Edit.Width = 32;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "Xoá";
            this.Delete.Image = global::MedicineManagement.Properties.Resources.delete;
            this.Delete.Name = "Delete";
            this.Delete.Width = 32;
            // 
            // UcBanThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "UcBanThuoc";
            this.Size = new System.Drawing.Size(1312, 822);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalIventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn MostUsedMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
