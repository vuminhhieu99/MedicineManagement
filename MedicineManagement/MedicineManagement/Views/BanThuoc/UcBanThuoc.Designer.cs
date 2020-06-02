namespace MedicineManagement.Views.BanThuoc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcBanThuoc));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._uses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._mostUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewImageColumn();
            this.add = new System.Windows.Forms.DataGridViewImageColumn();
            this.mEDICINEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuocDataSet = new MedicineManagement.QuanLyThuocDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this._stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._mathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bhyt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker_CreateDate = new System.Windows.Forms.DateTimePicker();
            this.textBox_TotalMoney_ByText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_TotalMoney_ByNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_MedicalRecord = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Doctor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_UserAddress = new System.Windows.Forms.Label();
            this.label_UserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label_CountRecord = new System.Windows.Forms.Label();
            this.mEDICINETableAdapter = new MedicineManagement.QuanLyThuocDataSetTableAdapters.MEDICINETableAdapter();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_SelectAll = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_DeleteFromList = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Export = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Reload = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Search = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Cancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Create = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICINEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuocDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(23, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(549, 34);
            this.textBox1.TabIndex = 88;
            this.textBox1.Text = "DANH SÁCH THUỐC";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._id,
            this._name,
            this._group,
            this._uses,
            this._unit,
            this._price,
            this._inventory,
            this._note,
            this._mostUsed,
            this.detail,
            this.add});
            this.dataGridView1.DataSource = this.mEDICINEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(549, 655);
            this.dataGridView1.TabIndex = 87;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // _id
            // 
            this._id.DataPropertyName = "ID_Medicine";
            this._id.HeaderText = "Mã";
            this._id.Name = "_id";
            this._id.ReadOnly = true;
            // 
            // _name
            // 
            this._name.DataPropertyName = "Name";
            this._name.HeaderText = "Tên";
            this._name.Name = "_name";
            this._name.ReadOnly = true;
            // 
            // _group
            // 
            this._group.DataPropertyName = "MedicineGroup";
            this._group.HeaderText = "Nhóm";
            this._group.Name = "_group";
            this._group.ReadOnly = true;
            // 
            // _uses
            // 
            this._uses.DataPropertyName = "Uses";
            this._uses.HeaderText = "Công dụng";
            this._uses.Name = "_uses";
            this._uses.ReadOnly = true;
            this._uses.Visible = false;
            // 
            // _unit
            // 
            this._unit.DataPropertyName = "Unit";
            this._unit.HeaderText = "DVT";
            this._unit.Name = "_unit";
            this._unit.ReadOnly = true;
            // 
            // _price
            // 
            this._price.DataPropertyName = "Price";
            this._price.HeaderText = "Giá";
            this._price.Name = "_price";
            this._price.ReadOnly = true;
            // 
            // _inventory
            // 
            this._inventory.DataPropertyName = "TotalInventory";
            this._inventory.HeaderText = "SL còn";
            this._inventory.Name = "_inventory";
            this._inventory.ReadOnly = true;
            // 
            // _note
            // 
            this._note.DataPropertyName = "Note";
            this._note.HeaderText = "Note";
            this._note.Name = "_note";
            this._note.ReadOnly = true;
            this._note.Visible = false;
            // 
            // _mostUsed
            // 
            this._mostUsed.DataPropertyName = "MostUsedMonth";
            this._mostUsed.HeaderText = "MostUsedMonth";
            this._mostUsed.Name = "_mostUsed";
            this._mostUsed.ReadOnly = true;
            this._mostUsed.Visible = false;
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
            // add
            // 
            this.add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.add.HeaderText = "Thêm";
            this.add.Image = global::MedicineManagement.Properties.Resources.icon_left_arrow;
            this.add.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.add.Name = "add";
            this.add.ReadOnly = true;
            this.add.Width = 40;
            // 
            // mEDICINEBindingSource
            // 
            this.mEDICINEBindingSource.DataMember = "MEDICINE";
            this.mEDICINEBindingSource.DataSource = this.quanLyThuocDataSet;
            // 
            // quanLyThuocDataSet
            // 
            this.quanLyThuocDataSet.DataSetName = "QuanLyThuocDataSet";
            this.quanLyThuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dateTimePicker_CreateDate);
            this.panel1.Controls.Add(this.textBox_TotalMoney_ByText);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox_TotalMoney_ByNum);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox_MedicalRecord);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_Doctor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_ID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label_UserAddress);
            this.panel1.Controls.Add(this.label_UserName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(595, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 689);
            this.panel1.TabIndex = 91;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._stt,
            this._mathuoc,
            this._tenthuoc,
            this._dongia,
            this._soluong,
            this._bhyt,
            this._thanhtien});
            this.dataGridView2.Location = new System.Drawing.Point(38, 232);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(624, 346);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            // 
            // _stt
            // 
            this._stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this._stt.HeaderText = "STT";
            this._stt.Name = "_stt";
            this._stt.ReadOnly = true;
            this._stt.Width = 53;
            // 
            // _mathuoc
            // 
            this._mathuoc.HeaderText = "Mã thuốc";
            this._mathuoc.Name = "_mathuoc";
            this._mathuoc.ReadOnly = true;
            this._mathuoc.Visible = false;
            // 
            // _tenthuoc
            // 
            this._tenthuoc.HeaderText = "Tên thuốc";
            this._tenthuoc.Name = "_tenthuoc";
            this._tenthuoc.ReadOnly = true;
            // 
            // _dongia
            // 
            this._dongia.HeaderText = "Đơn giá";
            this._dongia.Name = "_dongia";
            this._dongia.ReadOnly = true;
            // 
            // _soluong
            // 
            this._soluong.HeaderText = "Số lượng";
            this._soluong.Name = "_soluong";
            // 
            // _bhyt
            // 
            this._bhyt.HeaderText = "BHYT";
            this._bhyt.Name = "_bhyt";
            this._bhyt.ReadOnly = true;
            // 
            // _thanhtien
            // 
            this._thanhtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._thanhtien.HeaderText = "Thành tiền";
            this._thanhtien.Name = "_thanhtien";
            this._thanhtien.ReadOnly = true;
            // 
            // dateTimePicker_CreateDate
            // 
            this.dateTimePicker_CreateDate.CustomFormat = "";
            this.dateTimePicker_CreateDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_CreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_CreateDate.Location = new System.Drawing.Point(473, 122);
            this.dateTimePicker_CreateDate.Name = "dateTimePicker_CreateDate";
            this.dateTimePicker_CreateDate.Size = new System.Drawing.Size(189, 27);
            this.dateTimePicker_CreateDate.TabIndex = 20;
            // 
            // textBox_TotalMoney_ByText
            // 
            this.textBox_TotalMoney_ByText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TotalMoney_ByText.Location = new System.Drawing.Point(187, 633);
            this.textBox_TotalMoney_ByText.Name = "textBox_TotalMoney_ByText";
            this.textBox_TotalMoney_ByText.ReadOnly = true;
            this.textBox_TotalMoney_ByText.Size = new System.Drawing.Size(475, 27);
            this.textBox_TotalMoney_ByText.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 636);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tổng tiền (bằng chữ)";
            // 
            // textBox_TotalMoney_ByNum
            // 
            this.textBox_TotalMoney_ByNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TotalMoney_ByNum.Location = new System.Drawing.Point(187, 594);
            this.textBox_TotalMoney_ByNum.Name = "textBox_TotalMoney_ByNum";
            this.textBox_TotalMoney_ByNum.ReadOnly = true;
            this.textBox_TotalMoney_ByNum.Size = new System.Drawing.Size(475, 27);
            this.textBox_TotalMoney_ByNum.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 597);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "Tổng tiền (bằng số)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Danh sách thuốc";
            // 
            // textBox_MedicalRecord
            // 
            this.textBox_MedicalRecord.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MedicalRecord.Location = new System.Drawing.Point(473, 161);
            this.textBox_MedicalRecord.Name = "textBox_MedicalRecord";
            this.textBox_MedicalRecord.Size = new System.Drawing.Size(189, 27);
            this.textBox_MedicalRecord.TabIndex = 11;
            this.textBox_MedicalRecord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_MedicelRecord_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(369, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Hồ sơ bệnh án";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(369, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày lập";
            // 
            // textBox_Doctor
            // 
            this.textBox_Doctor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Doctor.Location = new System.Drawing.Point(136, 161);
            this.textBox_Doctor.Name = "textBox_Doctor";
            this.textBox_Doctor.Size = new System.Drawing.Size(209, 27);
            this.textBox_Doctor.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bác sĩ";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID.Location = new System.Drawing.Point(136, 122);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(209, 27);
            this.textBox_ID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã đơn thuốc";
            // 
            // label_UserAddress
            // 
            this.label_UserAddress.AutoSize = true;
            this.label_UserAddress.BackColor = System.Drawing.Color.Transparent;
            this.label_UserAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserAddress.Location = new System.Drawing.Point(56, 30);
            this.label_UserAddress.Name = "label_UserAddress";
            this.label_UserAddress.Size = new System.Drawing.Size(250, 15);
            this.label_UserAddress.TabIndex = 3;
            this.label_UserAddress.Text = "236 Hoàng Quốc Việt - Bắc Từ Liêm - Hà Nội";
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.BackColor = System.Drawing.Color.Transparent;
            this.label_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.Location = new System.Drawing.Point(56, 14);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(180, 15);
            this.label_UserName.TabIndex = 2;
            this.label_UserName.Text = "HỌC VIỆN KỸ THUẬT QUÂN SỰ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐƠN THUỐC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MedicineManagement.Properties.Resources.kissclipart_medical_symbol_clipart_caduceus_as_a_symbol_of_med_4ad9414f9ee75178;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Search.ForeColor = System.Drawing.Color.Black;
            this.textBox_Search.Location = new System.Drawing.Point(23, 20);
            this.textBox_Search.Multiline = true;
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(364, 30);
            this.textBox_Search.TabIndex = 94;
            // 
            // label_CountRecord
            // 
            this.label_CountRecord.AutoSize = true;
            this.label_CountRecord.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CountRecord.ForeColor = System.Drawing.Color.Maroon;
            this.label_CountRecord.Location = new System.Drawing.Point(20, 772);
            this.label_CountRecord.Name = "label_CountRecord";
            this.label_CountRecord.Size = new System.Drawing.Size(86, 17);
            this.label_CountRecord.TabIndex = 89;
            this.label_CountRecord.Text = "30/30 bản ghi";
            // 
            // mEDICINETableAdapter
            // 
            this.mEDICINETableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Thêm";
            this.dataGridViewImageColumn1.Image = global::MedicineManagement.Properties.Resources.icon_left_arrow;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "Thêm";
            this.dataGridViewImageColumn2.Image = global::MedicineManagement.Properties.Resources.icon_left_arrow;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // btn_SelectAll
            // 
            this.btn_SelectAll.ActiveBorderThickness = 1;
            this.btn_SelectAll.ActiveCornerRadius = 20;
            this.btn_SelectAll.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_SelectAll.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.btn_SelectAll.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btn_SelectAll.BackColor = System.Drawing.SystemColors.Control;
            this.btn_SelectAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SelectAll.BackgroundImage")));
            this.btn_SelectAll.ButtonText = "Chọn tất cả";
            this.btn_SelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SelectAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectAll.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_SelectAll.IdleBorderThickness = 1;
            this.btn_SelectAll.IdleCornerRadius = 20;
            this.btn_SelectAll.IdleFillColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_SelectAll.IdleForecolor = System.Drawing.Color.Navy;
            this.btn_SelectAll.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_SelectAll.Location = new System.Drawing.Point(595, 765);
            this.btn_SelectAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_SelectAll.Name = "btn_SelectAll";
            this.btn_SelectAll.Size = new System.Drawing.Size(124, 45);
            this.btn_SelectAll.TabIndex = 99;
            this.btn_SelectAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SelectAll.Click += new System.EventHandler(this.btn_SelectAll_Click);
            // 
            // btn_DeleteFromList
            // 
            this.btn_DeleteFromList.ActiveBorderThickness = 1;
            this.btn_DeleteFromList.ActiveCornerRadius = 20;
            this.btn_DeleteFromList.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_DeleteFromList.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.btn_DeleteFromList.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btn_DeleteFromList.BackColor = System.Drawing.SystemColors.Control;
            this.btn_DeleteFromList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DeleteFromList.BackgroundImage")));
            this.btn_DeleteFromList.ButtonText = "Xoá khỏi DS";
            this.btn_DeleteFromList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteFromList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteFromList.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_DeleteFromList.IdleBorderThickness = 1;
            this.btn_DeleteFromList.IdleCornerRadius = 20;
            this.btn_DeleteFromList.IdleFillColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_DeleteFromList.IdleForecolor = System.Drawing.Color.Navy;
            this.btn_DeleteFromList.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_DeleteFromList.Location = new System.Drawing.Point(738, 764);
            this.btn_DeleteFromList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_DeleteFromList.Name = "btn_DeleteFromList";
            this.btn_DeleteFromList.Size = new System.Drawing.Size(124, 45);
            this.btn_DeleteFromList.TabIndex = 98;
            this.btn_DeleteFromList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_DeleteFromList.Click += new System.EventHandler(this.btn_DeleteFromList_Click);
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
            this.btn_Export.Location = new System.Drawing.Point(882, 764);
            this.btn_Export.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(124, 45);
            this.btn_Export.TabIndex = 97;
            this.btn_Export.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.ActiveBorderThickness = 1;
            this.btn_Save.ActiveCornerRadius = 20;
            this.btn_Save.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Save.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.btn_Save.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btn_Save.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Save.BackgroundImage")));
            this.btn_Save.ButtonText = "Lưu";
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Save.IdleBorderThickness = 1;
            this.btn_Save.IdleCornerRadius = 20;
            this.btn_Save.IdleFillColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Save.IdleForecolor = System.Drawing.Color.Navy;
            this.btn_Save.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Save.Location = new System.Drawing.Point(1026, 765);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(124, 45);
            this.btn_Save.TabIndex = 96;
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
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
            this.btn_Reload.Location = new System.Drawing.Point(448, 12);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(124, 45);
            this.btn_Reload.TabIndex = 90;
            this.btn_Reload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_Search.Image = global::MedicineManagement.Properties.Resources.icon_search;
            this.btn_Search.ImageActive = null;
            this.btn_Search.Location = new System.Drawing.Point(386, 20);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(44, 30);
            this.btn_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Search.TabIndex = 95;
            this.btn_Search.TabStop = false;
            this.btn_Search.Zoom = 10;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.ActiveBorderThickness = 1;
            this.btn_Cancel.ActiveCornerRadius = 20;
            this.btn_Cancel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Cancel.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.btn_Cancel.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.Control;
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
            this.btn_Cancel.Location = new System.Drawing.Point(1169, 765);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(124, 45);
            this.btn_Cancel.TabIndex = 93;
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.ActiveBorderThickness = 1;
            this.btn_Create.ActiveCornerRadius = 20;
            this.btn_Create.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Create.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.btn_Create.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btn_Create.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Create.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Create.BackgroundImage")));
            this.btn_Create.ButtonText = "Đơn thuốc mới";
            this.btn_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Create.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Create.IdleBorderThickness = 1;
            this.btn_Create.IdleCornerRadius = 20;
            this.btn_Create.IdleFillColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Create.IdleForecolor = System.Drawing.Color.Navy;
            this.btn_Create.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Create.Location = new System.Drawing.Point(1169, 12);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(124, 45);
            this.btn_Create.TabIndex = 92;
            this.btn_Create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(595, 10);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(54, 47);
            this.dataGridView3.TabIndex = 100;
            this.dataGridView3.Visible = false;
            // 
            // UcBanThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_SelectAll);
            this.Controls.Add(this.btn_DeleteFromList);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.label_CountRecord);
            this.Name = "UcBanThuoc";
            this.Size = new System.Drawing.Size(1312, 822);
            this.Load += new System.EventHandler(this.UcBanThuoc_Load);
            this.VisibleChanged += new System.EventHandler(this.UcBanThuoc_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICINEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuocDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btn_Save;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CreateDate;
        private System.Windows.Forms.TextBox textBox_TotalMoney_ByText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_TotalMoney_ByNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_MedicalRecord;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Doctor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_UserAddress;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Reload;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Bunifu.Framework.UI.BunifuImageButton btn_Search;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Cancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Create;
        private System.Windows.Forms.Label label_CountRecord;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_DeleteFromList;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Export;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_SelectAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewTextBoxColumn _name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _group;
        private System.Windows.Forms.DataGridViewTextBoxColumn _uses;
        private System.Windows.Forms.DataGridViewTextBoxColumn _unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn _price;
        private System.Windows.Forms.DataGridViewTextBoxColumn _inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn _note;
        private System.Windows.Forms.DataGridViewTextBoxColumn _mostUsed;
        private System.Windows.Forms.DataGridViewImageColumn detail;
        private System.Windows.Forms.DataGridViewImageColumn add;
        private System.Windows.Forms.BindingSource mEDICINEBindingSource;
        private QuanLyThuocDataSet quanLyThuocDataSet;
        private QuanLyThuocDataSetTableAdapters.MEDICINETableAdapter mEDICINETableAdapter;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn _stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn _mathuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn _tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn _soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn _bhyt;
        private System.Windows.Forms.DataGridViewTextBoxColumn _thanhtien;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}
