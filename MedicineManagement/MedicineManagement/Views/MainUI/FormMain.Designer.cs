namespace MedicineManagement
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTitle = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_ThongTin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_CaiDat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_NhaCungCap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_DonThuoc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_PhieuNhap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_NhapHang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_QuanLyThuoc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_BanThuoc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_TrangChu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelLogo = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.labelUserAddress = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.ucTrangChu1 = new MedicineManagement.Views.TrangChu.UcTrangChu();
            this.ucBanThuoc1 = new MedicineManagement.Views.UcBanThuoc();
            this.ucQuanLyThuoc1 = new MedicineManagement.Views.UcQuanLyThuoc();
            this.ucNhapHang1 = new MedicineManagement.Views.NhapHang.UcNhapHang();
            this.ucPhieuNhap1 = new MedicineManagement.Views.PhieuNhap.UcPhieuNhap();
            this.ucDonThuoc1 = new MedicineManagement.Views.DonThuoc.UcDonThuoc();
            this.ucNhaCungCap1 = new MedicineManagement.Views.NhaCungCap.UcNhaCungCap();
            this.ucCaiDat1 = new MedicineManagement.Views.CaiDat.UcCaiDat();
            this.ucThongTin1 = new MedicineManagement.Views.ThongTin.UcThongTin();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelStatus = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.labeDateTime = new System.Windows.Forms.Label();
            this.labelTask = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTitle;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelTitle
            // 
            this.panelTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTitle.BackgroundImage")));
            this.panelTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Controls.Add(this.btnExit);
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Controls.Add(this.pictureBox1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.GradientBottomLeft = System.Drawing.Color.DimGray;
            this.panelTitle.GradientBottomRight = System.Drawing.Color.White;
            this.panelTitle.GradientTopLeft = System.Drawing.Color.White;
            this.panelTitle.GradientTopRight = System.Drawing.Color.White;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Quality = 10;
            this.panelTitle.Size = new System.Drawing.Size(1600, 40);
            this.panelTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hệ Thống Quản Lý Thuốc";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::MedicineManagement.Properties.Resources.btn_exit;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(1566, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = global::MedicineManagement.Properties.Resources.btn_minimize;
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(1540, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MedicineManagement.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelMenu);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 860);
            this.panel1.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btn_ThongTin);
            this.panelMenu.Controls.Add(this.btn_CaiDat);
            this.panelMenu.Controls.Add(this.btn_NhaCungCap);
            this.panelMenu.Controls.Add(this.btn_DonThuoc);
            this.panelMenu.Controls.Add(this.btn_PhieuNhap);
            this.panelMenu.Controls.Add(this.btn_NhapHang);
            this.panelMenu.Controls.Add(this.btn_QuanLyThuoc);
            this.panelMenu.Controls.Add(this.btn_BanThuoc);
            this.panelMenu.Controls.Add(this.btn_TrangChu);
            this.panelMenu.GradientBottomLeft = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelMenu.GradientBottomRight = System.Drawing.Color.White;
            this.panelMenu.GradientTopLeft = System.Drawing.Color.White;
            this.panelMenu.GradientTopRight = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(3, 221);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Quality = 10;
            this.panelMenu.Size = new System.Drawing.Size(272, 634);
            this.panelMenu.TabIndex = 1;
            // 
            // btn_ThongTin
            // 
            this.btn_ThongTin.Activecolor = System.Drawing.Color.Thistle;
            this.btn_ThongTin.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThongTin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ThongTin.BorderRadius = 0;
            this.btn_ThongTin.ButtonText = "      Thông tin";
            this.btn_ThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThongTin.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ThongTin.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongTin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ThongTin.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ThongTin.Iconimage = global::MedicineManagement.Properties.Resources.icon_info;
            this.btn_ThongTin.Iconimage_right = null;
            this.btn_ThongTin.Iconimage_right_Selected = null;
            this.btn_ThongTin.Iconimage_Selected = null;
            this.btn_ThongTin.IconMarginLeft = 0;
            this.btn_ThongTin.IconMarginRight = 0;
            this.btn_ThongTin.IconRightVisible = true;
            this.btn_ThongTin.IconRightZoom = 0D;
            this.btn_ThongTin.IconVisible = true;
            this.btn_ThongTin.IconZoom = 90D;
            this.btn_ThongTin.IsTab = false;
            this.btn_ThongTin.Location = new System.Drawing.Point(8, 467);
            this.btn_ThongTin.Name = "btn_ThongTin";
            this.btn_ThongTin.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_ThongTin.OnHovercolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ThongTin.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ThongTin.selected = false;
            this.btn_ThongTin.Size = new System.Drawing.Size(255, 48);
            this.btn_ThongTin.TabIndex = 17;
            this.btn_ThongTin.Text = "      Thông tin";
            this.btn_ThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThongTin.Textcolor = System.Drawing.Color.DarkRed;
            this.btn_ThongTin.TextFont = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongTin.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // btn_CaiDat
            // 
            this.btn_CaiDat.Activecolor = System.Drawing.Color.Thistle;
            this.btn_CaiDat.BackColor = System.Drawing.Color.Transparent;
            this.btn_CaiDat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CaiDat.BorderRadius = 0;
            this.btn_CaiDat.ButtonText = "      Cài đặt";
            this.btn_CaiDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CaiDat.DisabledColor = System.Drawing.Color.Gray;
            this.btn_CaiDat.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CaiDat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_CaiDat.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_CaiDat.Iconimage = global::MedicineManagement.Properties.Resources.icon_setup;
            this.btn_CaiDat.Iconimage_right = null;
            this.btn_CaiDat.Iconimage_right_Selected = null;
            this.btn_CaiDat.Iconimage_Selected = null;
            this.btn_CaiDat.IconMarginLeft = 0;
            this.btn_CaiDat.IconMarginRight = 0;
            this.btn_CaiDat.IconRightVisible = true;
            this.btn_CaiDat.IconRightZoom = 0D;
            this.btn_CaiDat.IconVisible = true;
            this.btn_CaiDat.IconZoom = 90D;
            this.btn_CaiDat.IsTab = false;
            this.btn_CaiDat.Location = new System.Drawing.Point(8, 415);
            this.btn_CaiDat.Name = "btn_CaiDat";
            this.btn_CaiDat.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_CaiDat.OnHovercolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_CaiDat.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_CaiDat.selected = false;
            this.btn_CaiDat.Size = new System.Drawing.Size(255, 48);
            this.btn_CaiDat.TabIndex = 16;
            this.btn_CaiDat.Text = "      Cài đặt";
            this.btn_CaiDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CaiDat.Textcolor = System.Drawing.Color.DarkRed;
            this.btn_CaiDat.TextFont = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CaiDat.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // btn_NhaCungCap
            // 
            this.btn_NhaCungCap.Activecolor = System.Drawing.Color.Thistle;
            this.btn_NhaCungCap.BackColor = System.Drawing.Color.Transparent;
            this.btn_NhaCungCap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_NhaCungCap.BorderRadius = 0;
            this.btn_NhaCungCap.ButtonText = "      Nhà cung cấp";
            this.btn_NhaCungCap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NhaCungCap.DisabledColor = System.Drawing.Color.Gray;
            this.btn_NhaCungCap.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhaCungCap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_NhaCungCap.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_NhaCungCap.Iconimage = global::MedicineManagement.Properties.Resources.icon_provided;
            this.btn_NhaCungCap.Iconimage_right = null;
            this.btn_NhaCungCap.Iconimage_right_Selected = null;
            this.btn_NhaCungCap.Iconimage_Selected = null;
            this.btn_NhaCungCap.IconMarginLeft = 0;
            this.btn_NhaCungCap.IconMarginRight = 0;
            this.btn_NhaCungCap.IconRightVisible = true;
            this.btn_NhaCungCap.IconRightZoom = 0D;
            this.btn_NhaCungCap.IconVisible = true;
            this.btn_NhaCungCap.IconZoom = 90D;
            this.btn_NhaCungCap.IsTab = false;
            this.btn_NhaCungCap.Location = new System.Drawing.Point(8, 363);
            this.btn_NhaCungCap.Name = "btn_NhaCungCap";
            this.btn_NhaCungCap.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_NhaCungCap.OnHovercolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_NhaCungCap.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_NhaCungCap.selected = false;
            this.btn_NhaCungCap.Size = new System.Drawing.Size(255, 48);
            this.btn_NhaCungCap.TabIndex = 15;
            this.btn_NhaCungCap.Text = "      Nhà cung cấp";
            this.btn_NhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhaCungCap.Textcolor = System.Drawing.Color.DarkRed;
            this.btn_NhaCungCap.TextFont = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhaCungCap.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // btn_DonThuoc
            // 
            this.btn_DonThuoc.Activecolor = System.Drawing.Color.Thistle;
            this.btn_DonThuoc.BackColor = System.Drawing.Color.Transparent;
            this.btn_DonThuoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DonThuoc.BorderRadius = 0;
            this.btn_DonThuoc.ButtonText = "      Đơn thuốc";
            this.btn_DonThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DonThuoc.DisabledColor = System.Drawing.Color.Gray;
            this.btn_DonThuoc.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DonThuoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_DonThuoc.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_DonThuoc.Iconimage = global::MedicineManagement.Properties.Resources.icon_medicine;
            this.btn_DonThuoc.Iconimage_right = null;
            this.btn_DonThuoc.Iconimage_right_Selected = null;
            this.btn_DonThuoc.Iconimage_Selected = null;
            this.btn_DonThuoc.IconMarginLeft = 0;
            this.btn_DonThuoc.IconMarginRight = 0;
            this.btn_DonThuoc.IconRightVisible = true;
            this.btn_DonThuoc.IconRightZoom = 0D;
            this.btn_DonThuoc.IconVisible = true;
            this.btn_DonThuoc.IconZoom = 90D;
            this.btn_DonThuoc.IsTab = false;
            this.btn_DonThuoc.Location = new System.Drawing.Point(8, 311);
            this.btn_DonThuoc.Name = "btn_DonThuoc";
            this.btn_DonThuoc.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_DonThuoc.OnHovercolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_DonThuoc.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_DonThuoc.selected = false;
            this.btn_DonThuoc.Size = new System.Drawing.Size(255, 48);
            this.btn_DonThuoc.TabIndex = 14;
            this.btn_DonThuoc.Text = "      Đơn thuốc";
            this.btn_DonThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DonThuoc.Textcolor = System.Drawing.Color.DarkRed;
            this.btn_DonThuoc.TextFont = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DonThuoc.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // btn_PhieuNhap
            // 
            this.btn_PhieuNhap.Activecolor = System.Drawing.Color.Thistle;
            this.btn_PhieuNhap.BackColor = System.Drawing.Color.Transparent;
            this.btn_PhieuNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PhieuNhap.BorderRadius = 0;
            this.btn_PhieuNhap.ButtonText = "      Phiếu nhập";
            this.btn_PhieuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PhieuNhap.DisabledColor = System.Drawing.Color.Gray;
            this.btn_PhieuNhap.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PhieuNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_PhieuNhap.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_PhieuNhap.Iconimage = global::MedicineManagement.Properties.Resources.icon_paper;
            this.btn_PhieuNhap.Iconimage_right = null;
            this.btn_PhieuNhap.Iconimage_right_Selected = null;
            this.btn_PhieuNhap.Iconimage_Selected = null;
            this.btn_PhieuNhap.IconMarginLeft = 0;
            this.btn_PhieuNhap.IconMarginRight = 0;
            this.btn_PhieuNhap.IconRightVisible = true;
            this.btn_PhieuNhap.IconRightZoom = 0D;
            this.btn_PhieuNhap.IconVisible = true;
            this.btn_PhieuNhap.IconZoom = 90D;
            this.btn_PhieuNhap.IsTab = false;
            this.btn_PhieuNhap.Location = new System.Drawing.Point(8, 259);
            this.btn_PhieuNhap.Name = "btn_PhieuNhap";
            this.btn_PhieuNhap.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_PhieuNhap.OnHovercolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_PhieuNhap.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_PhieuNhap.selected = false;
            this.btn_PhieuNhap.Size = new System.Drawing.Size(255, 48);
            this.btn_PhieuNhap.TabIndex = 13;
            this.btn_PhieuNhap.Text = "      Phiếu nhập";
            this.btn_PhieuNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PhieuNhap.Textcolor = System.Drawing.Color.DarkRed;
            this.btn_PhieuNhap.TextFont = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PhieuNhap.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // btn_NhapHang
            // 
            this.btn_NhapHang.Activecolor = System.Drawing.Color.Thistle;
            this.btn_NhapHang.BackColor = System.Drawing.Color.Transparent;
            this.btn_NhapHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_NhapHang.BorderRadius = 0;
            this.btn_NhapHang.ButtonText = "      Nhập hàng";
            this.btn_NhapHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NhapHang.DisabledColor = System.Drawing.Color.Gray;
            this.btn_NhapHang.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapHang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_NhapHang.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_NhapHang.Iconimage = global::MedicineManagement.Properties.Resources.icon_input;
            this.btn_NhapHang.Iconimage_right = null;
            this.btn_NhapHang.Iconimage_right_Selected = null;
            this.btn_NhapHang.Iconimage_Selected = null;
            this.btn_NhapHang.IconMarginLeft = 0;
            this.btn_NhapHang.IconMarginRight = 0;
            this.btn_NhapHang.IconRightVisible = true;
            this.btn_NhapHang.IconRightZoom = 0D;
            this.btn_NhapHang.IconVisible = true;
            this.btn_NhapHang.IconZoom = 90D;
            this.btn_NhapHang.IsTab = false;
            this.btn_NhapHang.Location = new System.Drawing.Point(8, 207);
            this.btn_NhapHang.Name = "btn_NhapHang";
            this.btn_NhapHang.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_NhapHang.OnHovercolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_NhapHang.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_NhapHang.selected = false;
            this.btn_NhapHang.Size = new System.Drawing.Size(255, 48);
            this.btn_NhapHang.TabIndex = 12;
            this.btn_NhapHang.Text = "      Nhập hàng";
            this.btn_NhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhapHang.Textcolor = System.Drawing.Color.DarkRed;
            this.btn_NhapHang.TextFont = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapHang.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // btn_QuanLyThuoc
            // 
            this.btn_QuanLyThuoc.Activecolor = System.Drawing.Color.Thistle;
            this.btn_QuanLyThuoc.BackColor = System.Drawing.Color.Transparent;
            this.btn_QuanLyThuoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_QuanLyThuoc.BorderRadius = 0;
            this.btn_QuanLyThuoc.ButtonText = "      Quản lý thuốc";
            this.btn_QuanLyThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QuanLyThuoc.DisabledColor = System.Drawing.Color.Gray;
            this.btn_QuanLyThuoc.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyThuoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_QuanLyThuoc.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_QuanLyThuoc.Iconimage = global::MedicineManagement.Properties.Resources.icon_manage;
            this.btn_QuanLyThuoc.Iconimage_right = null;
            this.btn_QuanLyThuoc.Iconimage_right_Selected = null;
            this.btn_QuanLyThuoc.Iconimage_Selected = null;
            this.btn_QuanLyThuoc.IconMarginLeft = 0;
            this.btn_QuanLyThuoc.IconMarginRight = 0;
            this.btn_QuanLyThuoc.IconRightVisible = true;
            this.btn_QuanLyThuoc.IconRightZoom = 0D;
            this.btn_QuanLyThuoc.IconVisible = true;
            this.btn_QuanLyThuoc.IconZoom = 90D;
            this.btn_QuanLyThuoc.IsTab = false;
            this.btn_QuanLyThuoc.Location = new System.Drawing.Point(8, 155);
            this.btn_QuanLyThuoc.Name = "btn_QuanLyThuoc";
            this.btn_QuanLyThuoc.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_QuanLyThuoc.OnHovercolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_QuanLyThuoc.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_QuanLyThuoc.selected = false;
            this.btn_QuanLyThuoc.Size = new System.Drawing.Size(255, 48);
            this.btn_QuanLyThuoc.TabIndex = 11;
            this.btn_QuanLyThuoc.Text = "      Quản lý thuốc";
            this.btn_QuanLyThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLyThuoc.Textcolor = System.Drawing.Color.DarkRed;
            this.btn_QuanLyThuoc.TextFont = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyThuoc.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // btn_BanThuoc
            // 
            this.btn_BanThuoc.Activecolor = System.Drawing.Color.Thistle;
            this.btn_BanThuoc.BackColor = System.Drawing.Color.Transparent;
            this.btn_BanThuoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BanThuoc.BorderRadius = 0;
            this.btn_BanThuoc.ButtonText = "      Bán thuốc";
            this.btn_BanThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BanThuoc.DisabledColor = System.Drawing.Color.Gray;
            this.btn_BanThuoc.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BanThuoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_BanThuoc.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_BanThuoc.Iconimage = global::MedicineManagement.Properties.Resources.icon_sell;
            this.btn_BanThuoc.Iconimage_right = null;
            this.btn_BanThuoc.Iconimage_right_Selected = null;
            this.btn_BanThuoc.Iconimage_Selected = null;
            this.btn_BanThuoc.IconMarginLeft = 0;
            this.btn_BanThuoc.IconMarginRight = 0;
            this.btn_BanThuoc.IconRightVisible = true;
            this.btn_BanThuoc.IconRightZoom = 0D;
            this.btn_BanThuoc.IconVisible = true;
            this.btn_BanThuoc.IconZoom = 90D;
            this.btn_BanThuoc.IsTab = false;
            this.btn_BanThuoc.Location = new System.Drawing.Point(8, 103);
            this.btn_BanThuoc.Name = "btn_BanThuoc";
            this.btn_BanThuoc.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_BanThuoc.OnHovercolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_BanThuoc.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_BanThuoc.selected = false;
            this.btn_BanThuoc.Size = new System.Drawing.Size(255, 48);
            this.btn_BanThuoc.TabIndex = 10;
            this.btn_BanThuoc.Text = "      Bán thuốc";
            this.btn_BanThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BanThuoc.Textcolor = System.Drawing.Color.DarkRed;
            this.btn_BanThuoc.TextFont = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BanThuoc.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // btn_TrangChu
            // 
            this.btn_TrangChu.Activecolor = System.Drawing.Color.Thistle;
            this.btn_TrangChu.BackColor = System.Drawing.Color.Transparent;
            this.btn_TrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TrangChu.BorderRadius = 0;
            this.btn_TrangChu.ButtonText = "      Trang chủ";
            this.btn_TrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TrangChu.DisabledColor = System.Drawing.Color.Gray;
            this.btn_TrangChu.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangChu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_TrangChu.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_TrangChu.Iconimage = global::MedicineManagement.Properties.Resources.icon_home;
            this.btn_TrangChu.Iconimage_right = null;
            this.btn_TrangChu.Iconimage_right_Selected = null;
            this.btn_TrangChu.Iconimage_Selected = null;
            this.btn_TrangChu.IconMarginLeft = 0;
            this.btn_TrangChu.IconMarginRight = 0;
            this.btn_TrangChu.IconRightVisible = true;
            this.btn_TrangChu.IconRightZoom = 0D;
            this.btn_TrangChu.IconVisible = true;
            this.btn_TrangChu.IconZoom = 90D;
            this.btn_TrangChu.IsTab = false;
            this.btn_TrangChu.Location = new System.Drawing.Point(8, 51);
            this.btn_TrangChu.Name = "btn_TrangChu";
            this.btn_TrangChu.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_TrangChu.OnHovercolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_TrangChu.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_TrangChu.selected = false;
            this.btn_TrangChu.Size = new System.Drawing.Size(255, 48);
            this.btn_TrangChu.TabIndex = 9;
            this.btn_TrangChu.Text = "      Trang chủ";
            this.btn_TrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TrangChu.Textcolor = System.Drawing.Color.DarkRed;
            this.btn_TrangChu.TextFont = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangChu.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogo.Controls.Add(this.labelUserAddress);
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Controls.Add(this.labelUserName);
            this.panelLogo.GradientBottomLeft = System.Drawing.SystemColors.MenuHighlight;
            this.panelLogo.GradientBottomRight = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelLogo.GradientTopLeft = System.Drawing.Color.White;
            this.panelLogo.GradientTopRight = System.Drawing.Color.White;
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Quality = 10;
            this.panelLogo.Size = new System.Drawing.Size(272, 215);
            this.panelLogo.TabIndex = 0;
            // 
            // labelUserAddress
            // 
            this.labelUserAddress.AutoSize = true;
            this.labelUserAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelUserAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserAddress.Location = new System.Drawing.Point(12, 185);
            this.labelUserAddress.Name = "labelUserAddress";
            this.labelUserAddress.Size = new System.Drawing.Size(246, 19);
            this.labelUserAddress.TabIndex = 1;
            this.labelUserAddress.Text = "236 Hoàng Quốc Việt - Bắc Từ Liêm";
            this.labelUserAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::MedicineManagement.Properties.Resources.kissclipart_medical_symbol_clipart_caduceus_as_a_symbol_of_med_4ad9414f9ee75178;
            this.pictureBox2.Location = new System.Drawing.Point(28, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(211, 148);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(39, 164);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(191, 19);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Học viện Kỹ thuật Quân sự";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(280, 70);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1320, 830);
            this.panelMain.TabIndex = 3;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.ucTrangChu1);
            this.panelContent.Controls.Add(this.ucBanThuoc1);
            this.panelContent.Controls.Add(this.ucQuanLyThuoc1);
            this.panelContent.Controls.Add(this.ucNhapHang1);
            this.panelContent.Controls.Add(this.ucPhieuNhap1);
            this.panelContent.Controls.Add(this.ucDonThuoc1);
            this.panelContent.Controls.Add(this.ucNhaCungCap1);
            this.panelContent.Controls.Add(this.ucCaiDat1);
            this.panelContent.Controls.Add(this.ucThongTin1);
            this.panelContent.Location = new System.Drawing.Point(3, 3);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1312, 822);
            this.panelContent.TabIndex = 0;
            // 
            // ucTrangChu1
            // 
            this.ucTrangChu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTrangChu1.Location = new System.Drawing.Point(0, 0);
            this.ucTrangChu1.Name = "ucTrangChu1";
            this.ucTrangChu1.Size = new System.Drawing.Size(1310, 820);
            this.ucTrangChu1.TabIndex = 8;
            // 
            // ucBanThuoc1
            // 
            this.ucBanThuoc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBanThuoc1.Location = new System.Drawing.Point(0, 0);
            this.ucBanThuoc1.Name = "ucBanThuoc1";
            this.ucBanThuoc1.Size = new System.Drawing.Size(1310, 820);
            this.ucBanThuoc1.TabIndex = 7;
            // 
            // ucQuanLyThuoc1
            // 
            this.ucQuanLyThuoc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucQuanLyThuoc1.Location = new System.Drawing.Point(0, 0);
            this.ucQuanLyThuoc1.Name = "ucQuanLyThuoc1";
            this.ucQuanLyThuoc1.Size = new System.Drawing.Size(1310, 820);
            this.ucQuanLyThuoc1.TabIndex = 6;
            // 
            // ucNhapHang1
            // 
            this.ucNhapHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNhapHang1.Location = new System.Drawing.Point(0, 0);
            this.ucNhapHang1.Name = "ucNhapHang1";
            this.ucNhapHang1.Size = new System.Drawing.Size(1310, 820);
            this.ucNhapHang1.TabIndex = 5;
            // 
            // ucPhieuNhap1
            // 
            this.ucPhieuNhap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPhieuNhap1.Location = new System.Drawing.Point(0, 0);
            this.ucPhieuNhap1.Name = "ucPhieuNhap1";
            this.ucPhieuNhap1.Size = new System.Drawing.Size(1310, 820);
            this.ucPhieuNhap1.TabIndex = 4;
            // 
            // ucDonThuoc1
            // 
            this.ucDonThuoc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDonThuoc1.Location = new System.Drawing.Point(0, 0);
            this.ucDonThuoc1.Name = "ucDonThuoc1";
            this.ucDonThuoc1.Size = new System.Drawing.Size(1310, 820);
            this.ucDonThuoc1.TabIndex = 3;
            // 
            // ucNhaCungCap1
            // 
            this.ucNhaCungCap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNhaCungCap1.Location = new System.Drawing.Point(0, 0);
            this.ucNhaCungCap1.Name = "ucNhaCungCap1";
            this.ucNhaCungCap1.Size = new System.Drawing.Size(1310, 820);
            this.ucNhaCungCap1.TabIndex = 2;
            // 
            // ucCaiDat1
            // 
            this.ucCaiDat1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCaiDat1.Location = new System.Drawing.Point(0, 0);
            this.ucCaiDat1.Name = "ucCaiDat1";
            this.ucCaiDat1.Size = new System.Drawing.Size(1310, 820);
            this.ucCaiDat1.TabIndex = 1;
            // 
            // ucThongTin1
            // 
            this.ucThongTin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucThongTin1.Location = new System.Drawing.Point(0, 0);
            this.ucThongTin1.Name = "ucThongTin1";
            this.ucThongTin1.Size = new System.Drawing.Size(1310, 820);
            this.ucThongTin1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelStatus
            // 
            this.panelStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelStatus.BackgroundImage")));
            this.panelStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatus.Controls.Add(this.labeDateTime);
            this.panelStatus.Controls.Add(this.labelTask);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.GradientBottomLeft = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelStatus.GradientBottomRight = System.Drawing.Color.White;
            this.panelStatus.GradientTopLeft = System.Drawing.Color.White;
            this.panelStatus.GradientTopRight = System.Drawing.Color.White;
            this.panelStatus.Location = new System.Drawing.Point(280, 40);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Quality = 10;
            this.panelStatus.Size = new System.Drawing.Size(1320, 30);
            this.panelStatus.TabIndex = 2;
            // 
            // labeDateTime
            // 
            this.labeDateTime.AutoSize = true;
            this.labeDateTime.BackColor = System.Drawing.Color.Transparent;
            this.labeDateTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeDateTime.ForeColor = System.Drawing.Color.Navy;
            this.labeDateTime.Location = new System.Drawing.Point(1113, 6);
            this.labeDateTime.Name = "labeDateTime";
            this.labeDateTime.Size = new System.Drawing.Size(201, 19);
            this.labeDateTime.TabIndex = 1;
            this.labeDateTime.Text = "00:00:00 AM   ●   0000-00-00";
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.BackColor = System.Drawing.Color.Transparent;
            this.labelTask.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTask.ForeColor = System.Drawing.Color.Crimson;
            this.labelTask.Location = new System.Drawing.Point(5, 3);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(87, 23);
            this.labelTask.TabIndex = 0;
            this.labelTask.Text = "Trang chủ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel panelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuGradientPanel panelStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
        private Bunifu.Framework.UI.BunifuGradientPanel panelLogo;
        private Bunifu.Framework.UI.BunifuGradientPanel panelMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelUserAddress;
        private System.Windows.Forms.Label labeDateTime;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ThongTin;
        private Bunifu.Framework.UI.BunifuFlatButton btn_CaiDat;
        private Bunifu.Framework.UI.BunifuFlatButton btn_NhaCungCap;
        private Bunifu.Framework.UI.BunifuFlatButton btn_DonThuoc;
        private Bunifu.Framework.UI.BunifuFlatButton btn_PhieuNhap;
        private Bunifu.Framework.UI.BunifuFlatButton btn_NhapHang;
        private Bunifu.Framework.UI.BunifuFlatButton btn_QuanLyThuoc;
        private Bunifu.Framework.UI.BunifuFlatButton btn_BanThuoc;
        private Bunifu.Framework.UI.BunifuFlatButton btn_TrangChu;
        private Views.TrangChu.UcTrangChu ucTrangChu1;
        private Views.UcBanThuoc ucBanThuoc1;
        private Views.UcQuanLyThuoc ucQuanLyThuoc1;
        private Views.NhapHang.UcNhapHang ucNhapHang1;
        private Views.PhieuNhap.UcPhieuNhap ucPhieuNhap1;
        private Views.DonThuoc.UcDonThuoc ucDonThuoc1;
        private Views.NhaCungCap.UcNhaCungCap ucNhaCungCap1;
        private Views.CaiDat.UcCaiDat ucCaiDat1;
        private Views.ThongTin.UcThongTin ucThongTin1;
    }
}

