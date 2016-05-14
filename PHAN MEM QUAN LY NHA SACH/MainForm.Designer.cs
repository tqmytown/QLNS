namespace PHAN_MEM_QUAN_LY_NHA_SACH
{
    partial class MainForm
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rbMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnKetNoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLyTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnBackUp = new DevExpress.XtraBars.BarButtonItem();
            this.btnReStore = new DevExpress.XtraBars.BarButtonItem();
            this.rbPageConnect = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbPageGroupKetNoi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPageGroupTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPageDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbPageDB = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbPageGroupSaoLuu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPageKhoiPhuc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.rbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // rbMain
            // 
            this.rbMain.ExpandCollapseItem.Id = 0;
            this.rbMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbMain.ExpandCollapseItem,
            this.btnKetNoi,
            this.btnDangNhap,
            this.btnQuanLyTK,
            this.btnBackUp,
            this.btnReStore});
            this.rbMain.Location = new System.Drawing.Point(0, 0);
            this.rbMain.MaxItemId = 10;
            this.rbMain.Name = "rbMain";
            this.rbMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbPageConnect,
            this.rbPageDanhMuc,
            this.rbPageDB});
            this.rbMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.rbMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.rbMain.Size = new System.Drawing.Size(1039, 144);
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Caption = "Kết Nối CSDL";
            this.btnKetNoi.Glyph = global::PHAN_MEM_QUAN_LY_NHA_SACH.Properties.Resources.Misc_Web_Database_icon;
            this.btnKetNoi.Id = 4;
            this.btnKetNoi.LargeGlyph = global::PHAN_MEM_QUAN_LY_NHA_SACH.Properties.Resources.Misc_Web_Database_icon;
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng Nhập";
            this.btnDangNhap.Glyph = global::PHAN_MEM_QUAN_LY_NHA_SACH.Properties.Resources.Apps_Computer_Login_icon;
            this.btnDangNhap.Id = 6;
            this.btnDangNhap.LargeGlyph = global::PHAN_MEM_QUAN_LY_NHA_SACH.Properties.Resources.Apps_Computer_Login_icon;
            this.btnDangNhap.Name = "btnDangNhap";
            // 
            // btnQuanLyTK
            // 
            this.btnQuanLyTK.Caption = "Quản Lý Tài Khoản";
            this.btnQuanLyTK.Id = 7;
            this.btnQuanLyTK.LargeGlyph = global::PHAN_MEM_QUAN_LY_NHA_SACH.Properties.Resources.App_login_manager_icon;
            this.btnQuanLyTK.Name = "btnQuanLyTK";
            // 
            // btnBackUp
            // 
            this.btnBackUp.Caption = "btnBackUp";
            this.btnBackUp.Glyph = global::PHAN_MEM_QUAN_LY_NHA_SACH.Properties.Resources.Blue_Backup_W;
            this.btnBackUp.Id = 8;
            this.btnBackUp.LargeGlyph = global::PHAN_MEM_QUAN_LY_NHA_SACH.Properties.Resources.Blue_Backup_W;
            this.btnBackUp.Name = "btnBackUp";
            toolTipTitleItem1.Text = "Data Backup";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Sao lưu dữ liệu hiện thời";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.btnBackUp.SuperTip = superToolTip1;
            // 
            // btnReStore
            // 
            this.btnReStore.Caption = "btnReStore";
            this.btnReStore.Id = 9;
            this.btnReStore.LargeGlyph = global::PHAN_MEM_QUAN_LY_NHA_SACH.Properties.Resources.Time_Machine_icon;
            this.btnReStore.Name = "btnReStore";
            // 
            // rbPageConnect
            // 
            this.rbPageConnect.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbPageGroupKetNoi,
            this.rbPageGroupTaiKhoan});
            this.rbPageConnect.Name = "rbPageConnect";
            this.rbPageConnect.Text = "Kết nối & Đăng nhập";
            // 
            // rbPageGroupKetNoi
            // 
            this.rbPageGroupKetNoi.AllowMinimize = false;
            this.rbPageGroupKetNoi.AllowTextClipping = false;
            this.rbPageGroupKetNoi.ItemLinks.Add(this.btnKetNoi);
            this.rbPageGroupKetNoi.Name = "rbPageGroupKetNoi";
            this.rbPageGroupKetNoi.Text = "Kết Nối";
            // 
            // rbPageGroupTaiKhoan
            // 
            this.rbPageGroupTaiKhoan.ItemLinks.Add(this.btnDangNhap);
            this.rbPageGroupTaiKhoan.ItemLinks.Add(this.btnQuanLyTK);
            this.rbPageGroupTaiKhoan.Name = "rbPageGroupTaiKhoan";
            this.rbPageGroupTaiKhoan.Text = "Tài Khoản";
            // 
            // rbPageDanhMuc
            // 
            this.rbPageDanhMuc.Name = "rbPageDanhMuc";
            this.rbPageDanhMuc.Text = "Danh mục";
            // 
            // rbPageDB
            // 
            this.rbPageDB.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbPageGroupSaoLuu,
            this.rbPageKhoiPhuc});
            this.rbPageDB.Name = "rbPageDB";
            this.rbPageDB.Text = "DATABASE";
            // 
            // rbPageGroupSaoLuu
            // 
            this.rbPageGroupSaoLuu.AllowMinimize = false;
            this.rbPageGroupSaoLuu.ItemLinks.Add(this.btnBackUp);
            this.rbPageGroupSaoLuu.Name = "rbPageGroupSaoLuu";
            this.rbPageGroupSaoLuu.Text = "Sao Lưu Dữ Liệu";
            // 
            // rbPageKhoiPhuc
            // 
            this.rbPageKhoiPhuc.ItemLinks.Add(this.btnReStore);
            this.rbPageKhoiPhuc.Name = "rbPageKhoiPhuc";
            this.rbPageKhoiPhuc.Text = "Khôi Phục Dữ Liệu";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 533);
            this.Controls.Add(this.rbMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.rbMain;
            this.Text = "PHAN MEM QUAN LY NHA SACH - BOOK STORE MANAGEMENT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rbMain;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPageConnect;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPageDanhMuc;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPageGroupKetNoi;
        private DevExpress.XtraBars.BarButtonItem btnKetNoi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPageGroupTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnQuanLyTK;
        private DevExpress.XtraBars.BarButtonItem btnBackUp;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPageDB;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPageGroupSaoLuu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPageKhoiPhuc;
        private DevExpress.XtraBars.BarButtonItem btnReStore;
    }
}

