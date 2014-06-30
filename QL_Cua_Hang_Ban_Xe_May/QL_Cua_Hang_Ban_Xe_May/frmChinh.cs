using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QL_Cua_Hang_Ban_Xe_May.BusinessLogic;
using QL_Cua_Hang_Ban_Xe_May.NguoiDung;
using QL_Cua_Hang_Ban_Xe_May.BaoCao;

namespace QL_Cua_Hang_Ban_Xe_May
{
    public partial class frmChinh : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public static string tendangnhap;
        public frmChinh()
        {
            InitializeComponent();
        }

        Form frmNH;
        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            //frmNhapHang nh = new frmNhapHang();
            //nh.Show();
            //nh.MdiParent = this;
            if (!CheckExistForm("frmNhapHang"))
            {
                frmNH = new frmNhapHang();
                frmNH.MdiParent = this;
                frmNH.Show();
            }
            else
                ActiveChildForm("frmNhapHang");
        }
        Form frmDMK;
        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            //frmDoiMatKhau dmk = new frmDoiMatKhau();
            //dmk.Show();
            //dmk.MdiParent = this;
                if (!CheckExistForm("frmDoiMatKhau"))
                {
                    frmDMK = new frmDoiMatKhau();
                    frmDMK.MdiParent = this;
                    frmDMK.Show();
                }
                else
                    ActiveChildForm("frmDoiMatKhau");
            }

        private void btn_ThoatChuongTrinh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Form frmHH;
        private void btn_HangHoa_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmThongTinXeMay"))
            {
                frmHH = new frmThongTinXeMay();
                frmHH.MdiParent = this;
                frmHH.Show();
            }
            else
                ActiveChildForm("frmThongTinXeMay");
        }

        //Form frmNV;
        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            //frmNhanVien nv = new frmNhanVien();
            //nv.Show();
            //nv.MdiParent = this;
            if (!CheckExistForm("frmNhanVien"))
            {
                frmNV = new frmNhanVien();
                frmNV.MdiParent = this;
                frmNV.Show();
            }
            else
                ActiveChildForm("frmNhanVien");
        }

        Form frmKH;
        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            //frmKhachHang kh = new frmKhachHang();
            //kh.Show();
            //kh.MdiParent = this;
            if (!CheckExistForm("frmKhachHang"))
            {
                frmKH = new frmKhachHang();
                frmKH.MdiParent = this;
                frmKH.Show();
            }
            else
                ActiveChildForm("frmKhachHang");
        }

        Form frmNCC;
        private void btn_NhaCungCap_Click(object sender, EventArgs e)
        {
            //frmNhaCungCap ncc = new frmNhaCungCap();
            //ncc.Show();
            //ncc.MdiParent = this;
            if (!CheckExistForm("frmNhaCungCap"))
            {
                frmNCC = new frmNhaCungCap();
                frmNCC.MdiParent = this;
                frmNCC.Show();
            }
            else
                ActiveChildForm("frmNhaCungCap");
        }

        Form frmXH;
        private void btn_XuatHang_Click(object sender, EventArgs e)
        {
            //frmXuatHang xh = new frmXuatHang();
            //xh.Show();
            //xh.MdiParent = this;
            if (!CheckExistForm("frmXuatHang"))
            {
                frmXH = new frmXuatHang();
                frmXH.MdiParent = this;
                frmXH.Show();
            }
            else
                ActiveChildForm("frmXuatHang");
        }

        Form frmReHN;
        private void btn_HangNhap_Click(object sender, EventArgs e)
        {
            //frmReportPhieuNhap hn = new frmReportPhieuNhap();
            //hn.Show();
            //hn.MdiParent = this;
            if (!CheckExistForm("frmReportPhieuNhap"))
            {
                frmReHN = new frmReportPhieuNhap();
                frmReHN.MdiParent = this;
                frmReHN.Show();
            }
            else
                ActiveChildForm("frmReportPhieuNhap");
        }

        Form frmReHX;
        private void btn_HangXuat_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmReportPhieuXuat"))
            {
                frmReHX = new frmReportPhieuXuat();
                frmReHX.MdiParent = this;
                frmReHX.Show();
            }
            else
                ActiveChildForm("frmReportPhieuXuat");
        }

        Form frmReBH;
        private void btn_BaoHanh_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmReportBaoHanh"))
            {
                frmReBH = new frmReportBaoHanh();
                frmReBH.MdiParent = this;
                frmReBH.Show();
            }
            else
                ActiveChildForm("frmReportBaoHanh");
        }

        private void btn_TacGia_Click(object sender, EventArgs e)
        {
            //frmGioiThieu gt = new frmGioiThieu();
            //gt.Show();
            //gt.MdiParent = this;
            if (!CheckExistForm("frmGioiThieu"))
            {
                Form frmGT2 = new frmGioiThieu();
                frmGT2.MdiParent = this;
                frmGT2.Show();
            }
            else
                ActiveChildForm("frmGioiThieu");
        }

        private void btn_SoDoHeThong_Click(object sender, EventArgs e)
        {
            frmHeThong sdht = new frmHeThong();
            sdht.Show();
            sdht.MdiParent = this;
        }

        Form frmTCHH;
        private void btn_TraCuuHangHoa_Click(object sender, EventArgs e)
        {
            //frmTraCuuXe tc_hcc = new frmTraCuuXe();
            //tc_hcc.Show();
            //tc_hcc.MdiParent = this;
            if (!CheckExistForm("frmTraCuuXe"))
            {
                frmTCHH = new frmTraCuuXe();
                frmTCHH.MdiParent = this;
                frmTCHH.Show();
            }
            else
                ActiveChildForm("frmTraCuuXe");
        }

        frmDangNhap dn = new frmDangNhap();
        private void frmChinh_Load(object sender, EventArgs e)
        {
            dn.ShowDialog();
            PhanQuyen();
            tendangnhap = dn.txtTenDN.Text;
            //if (dn.kt == true)
            //{
            //    UserBUS user = new UserBUS();
            //    string nhom = user.LayNhomQuyen(dn.txtTenDN.Text);

            //    PhanQuyenSuDungHeThong(nhom);
            //}
            //else
            //{
            //    NhomChuaDangNhap();
            //}
        }
        void PhanQuyen()
        {
            if (dn.kt == true)
            {
                UserBUS user = new UserBUS();
                string nhom = user.LayNhomQuyen(dn.txtTenDN.Text);

                PhanQuyenSuDungHeThong(nhom);
            }
            else
            {
                MessageBox.Show("Bạn chưa đăng nhập vào hệ thống");
                NhomChuaDangNhap();
            }
        }

        public void PhanQuyenSuDungHeThong(string manhom)
        {
            //Neu dang nhap thanh cong => bat het menu con lai
            if (dn.kt != false)
            {
                switch (manhom)
                {
                    //Nhom Admin
                    case "MN001": HienThiAdmin();
                        MessageBox.Show("Bạn đã đăng nhập bằng quyền admin");
                        break;
                    //Nhom QuanLy
                    case "MN002": HienThiQuanLy();
                        MessageBox.Show("Bạn đã đăng nhập bằng quyền quản lý");
                        break;
                    //Nhom NhanVien
                    case "MN003": HienThiNhanVien();
                        MessageBox.Show("Bạn đã đăng nhập bằng quyền nhân viên");
                        break;
                }
            }
        }

        //Hien thi menu tuy theo nhom quyen
        public void NhomChuaDangNhap()
        {
            btn_NguoiDung.Enabled = false;
            btn_NhomNguoiDung.Enabled = false;
            btn_DangXuat.Enabled = false;
            btn_DoiMatKhau.Enabled = false;
            ribbonTabItem_DanhMuc.Enabled = false;
            ribbonTabItem_NghiepVu.Enabled = false;
            ribbonTabItem_BaoCao.Enabled = false;
            ribbonTabItem_TraCuu.Enabled = false;
            expandablePanel_DanhMuc.Enabled = false;
            expandablePanel_BaoCao.Enabled = false;
            expandablePanel_TraCuu.Enabled = false;
            expandablePanel_NghiepVu.Enabled = false;

            //Tac vu ben trong
            //Danh muc
            btn_HangHoa.Enabled = false;
            btn_NhanVien.Enabled = false;
            btn_KhachHang.Enabled = false;
            btn_NhaCungCap.Enabled = false;
            btn_Chucvu.Enabled = false;
            //Nghiep vu
            btn_NhapHang.Enabled = false;
            btn_XuatHang.Enabled = false;
            //Bao cao
            btn_HangNhap.Enabled = false;
            btn_HangXuat.Enabled = false;
            btn_Thongtinxemay.Enabled = false;
            btn_Nhanvienre.Enabled = false;
            btn_Khachang.Enabled = false;
            btn_BaoHanh.Enabled = false;
            //Tra cuu
            btn_TraCuuHangHoa.Enabled = false;
            bt_tracuu_nv.Enabled = false;
            bt_tracuu_kh.Enabled = false;
            bt_tracuu_nhap.Enabled = false;
            bt_tracuu_xuat.Enabled = false;
            bt_tracuu_ncc.Enabled = false;
        }

        public void HienThiAdmin()
        {
            btn_DangNhap.Enabled=false;

            //Hien thi cac nut voi quyen admin
            btn_DoiMatKhau.Enabled = true;
            btn_DangXuat.Enabled = true;
            btn_NguoiDung.Enabled = true;
            btn_NhomNguoiDung.Enabled = true;
            ribbonTabItem_NghiepVu.Enabled = true;
            ribbonTabItem_DanhMuc.Enabled = true;
            ribbonTabItem_BaoCao.Enabled = true;
            ribbonTabItem_TraCuu.Enabled = true;
            expandablePanel_DanhMuc.Enabled = true;
            expandablePanel_BaoCao.Enabled = true;
            expandablePanel_TraCuu.Enabled = true;
            expandablePanel_NghiepVu.Enabled = true;

            //Tac vu ben trong
            //Danh muc
            btn_HangHoa.Enabled = true;
            btn_NhanVien.Enabled = true;
            btn_KhachHang.Enabled = true;
            btn_NhaCungCap.Enabled = true;
            btn_Chucvu.Enabled = true;
            //Nghiep vu
            btn_NhapHang.Enabled = true;
            btn_XuatHang.Enabled = true;
            //Bao cao
            btn_HangNhap.Enabled = true;
            btn_HangXuat.Enabled = true;
            btn_Thongtinxemay.Enabled = true;
            btn_Nhanvienre.Enabled = true;
            btn_Khachang.Enabled = true;
            btn_BaoHanh.Enabled = true;
            //Tra cuu
            btn_TraCuuHangHoa.Enabled = true;
            bt_tracuu_nv.Enabled = true;
            bt_tracuu_kh.Enabled = true;
            bt_tracuu_nhap.Enabled = true;
            bt_tracuu_xuat.Enabled = true;
            bt_tracuu_ncc.Enabled = true;
        }

        public void HienThiQuanLy()
        {
            //An cac nut voi quyen quan ly
            btn_NguoiDung.Enabled = false;
            btn_NhomNguoiDung.Enabled = false;
            btn_DangNhap.Enabled = false;

            //Hien cac nut voi quyen quan ly
            btn_DangXuat.Enabled = true;
            btn_DoiMatKhau.Enabled = true;
            ribbonTabItem_DanhMuc.Enabled = true;
            ribbonTabItem_NghiepVu.Enabled = true;
            ribbonTabItem_BaoCao.Enabled = true;
            ribbonTabItem_TraCuu.Enabled = true;
            expandablePanel_DanhMuc.Enabled = true;
            expandablePanel_BaoCao.Enabled = true;
            expandablePanel_TraCuu.Enabled = true;
            expandablePanel_NghiepVu.Enabled = true;
            //Danh muc
            btn_HangHoa.Enabled = true;
            btn_NhanVien.Enabled = true;
            btn_KhachHang.Enabled = true;
            btn_NhaCungCap.Enabled = true;
            btn_Chucvu.Enabled = true;
            //Nghiep vu
            btn_NhapHang.Enabled = true;
            btn_XuatHang.Enabled = true;
            //Bao cao
            btn_HangNhap.Enabled = true;
            btn_HangXuat.Enabled = true;
            btn_Thongtinxemay.Enabled = true;
            btn_Nhanvienre.Enabled = true;
            btn_Khachang.Enabled = true;
            btn_BaoHanh.Enabled = true;
            //Tra cuu
            btn_TraCuuHangHoa.Enabled = true;
            bt_tracuu_nv.Enabled = true;
            bt_tracuu_kh.Enabled = true;
            bt_tracuu_nhap.Enabled = true;
            bt_tracuu_xuat.Enabled = true;
            //bt_tc_pnhap.Enabled = true;
            //bt_tc_pxuat.Enabled = true;
            bt_tracuu_ncc.Enabled = true;

        }

        public void HienThiNhanVien()
        {
            //An cac nut voi quyen nhan vien
            btn_NguoiDung.Enabled = false;
            btn_NhomNguoiDung.Enabled = false;
            ribbonTabItem_DanhMuc.Enabled = false;
            btn_DangNhap.Enabled = false;
            btn_HangHoa.Enabled = false;
            btn_NhanVien.Enabled = false;
            btn_KhachHang.Enabled = false;
            btn_NhaCungCap.Enabled = false;
            btn_Chucvu.Enabled = false;
            expandablePanel_DanhMuc.Enabled = false;
            expandablePanel_NghiepVu.Enabled = true;

            //Hien cac nut voi quyen nhan vien
            btn_DangXuat.Enabled = true;
            btn_DoiMatKhau.Enabled = true;
            ribbonTabItem_NghiepVu.Enabled = true;
            ribbonTabItem_BaoCao.Enabled = true;
            ribbonTabItem_TraCuu.Enabled = true;
            expandablePanel_BaoCao.Enabled = true;
            expandablePanel_TraCuu.Enabled = true;
            //Nghiep vu
            btn_NhapHang.Enabled = true;
            btn_XuatHang.Enabled = true;
            //Bao cao
            btn_HangNhap.Enabled = true;
            btn_HangXuat.Enabled = true;
            btn_Thongtinxemay.Enabled = true;
            btn_Nhanvienre.Enabled = true;
            btn_Khachang.Enabled = true;
            btn_BaoHanh.Enabled = true;
            //Tra cuu
            btn_TraCuuHangHoa.Enabled = true;
            bt_tracuu_nv.Enabled = true;
            bt_tracuu_kh.Enabled = true;
            bt_tracuu_nhap.Enabled = true;
            bt_tracuu_xuat.Enabled = true;
            //bt_tc_pnhap.Enabled = true;
            //bt_tc_pxuat.Enabled = true;
            bt_tracuu_ncc.Enabled = true;

        }


        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            //frmDangNhap dn = new frmDangNhap();
            frmChinh_Load(sender, e);
        }

        public void CloseForm()
        {
            if (CheckExistForm("frmDoiMatKhau"))
            {
                frmDMK.Close();
            }
            if (CheckExistForm("frmNguoiDung"))
            {
                frmND.Close();
            }
            if (CheckExistForm("N"))
            {
                frmNhomND.Close();
            }
            //DANH MUC
            if (CheckExistForm("frmHangHoa"))
            {
                frmHH.Close();
            }
            if (CheckExistForm("frmNhanVien"))
            {
                frmNV.Close();
            }
            if (CheckExistForm("frmKhachHang"))
            {
                frmKH.Close();
            }
            if (CheckExistForm("frmNhaCungCap"))
            {
                frmNCC.Close();
            }
            if (CheckExistForm("frmChucVu"))
            {
                frmCV.Close();
            }
            //NGHIEP VU
            if (CheckExistForm("frmNhapHang"))
            {
                frmNH.Close();
            }
            if (CheckExistForm("frmXuatHang"))
            {
                frmXH.Close();
            }

            //TRA CUU
            if (CheckExistForm("frmTraCuuXe"))
            {
                frmTCHH.Close();
            }
            if (CheckExistForm("frmTraCuuNhanVien"))
            {
                frmTCNV.Close();
            }
            if (CheckExistForm("frmTraCuuKhachHang"))
            {
                frmTCKH.Close();
            }
            if (CheckExistForm("frmTraCuuPhieuNhap"))
            {
                frmTCPN.Close();
            }
            if (CheckExistForm("frmTraCuuPhieuXuat"))
            {
                frmTCPX.Close();
            }
            if (CheckExistForm("frmTraCuuHangCungCap"))
            {
                frmTCNCC.Close();
            }
            if (CheckExistForm("frmThongTinXeMay"))
            {
                frmHH.Close();
            }
            //BAO CAO
            if (CheckExistForm("frmReportPhieuNhap"))
            {
                frmReHN.Close();
            }
            if (CheckExistForm("frmReportPhieuXuat"))
            {
                frmReHX.Close();
            }
            if (CheckExistForm("frmReportThongTinXeMay"))
            {
                frmReTTXM.Close();
            }
            if (CheckExistForm("frmReportNhanVien"))
            {
                frmReNV.Close();
            }
            if (CheckExistForm("frmReportKhachHang"))
            {
                frmReKH.Close();
            }
            if (CheckExistForm("frmReportBaoHanh"))
            {
                frmReBH.Close();
            }
            if (CheckExistForm("frmReportNhaCungCap"))
            {
                frmReNCC.Close();
            }
            if (CheckExistForm("frmReportDoanhThu"))
            {
                frmReDT.Close();
            }
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            LopDungChung.user = null;
            NhomChuaDangNhap();
            btn_DangNhap.Enabled = true;
            CloseForm();
        }

        private void btn_ThoatChuongTrinh_Click_2(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi bảng này không?", "Hỏi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bt_hanghoa_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmThongTinXeMay"))
            {
                frmHH = new frmThongTinXeMay();
                frmHH.MdiParent = this;
                frmHH.Show();
            }
            else
                ActiveChildForm("frmThongTinXeMay");
        }

        Form frmNV;
        private void bt_nhanvien_Click(object sender, EventArgs e)
        {
            //frmNhanVien nv = new frmNhanVien();
            //nv.Show();
            //nv.MdiParent = this;
            if (!CheckExistForm("frmNhanVien"))
            {
                frmNV = new frmNhanVien();
                frmNV.MdiParent = this;
                frmNV.Show();
            }
            else
                ActiveChildForm("frmNhanVien");
        }

        private void bt_khachhang_Click(object sender, EventArgs e)
        {
            //frmKhachHang kh = new frmKhachHang();
            //kh.Show();
            //kh.MdiParent = this;
            if (!CheckExistForm("frmKhachHang"))
            {
                frmKH = new frmKhachHang();
                frmKH.MdiParent = this;
                frmKH.Show();
            }
            else
                ActiveChildForm("frmKhachHang");
        }

        private void btnhacc_Click(object sender, EventArgs e)
        {
            //frmNhaCungCap ncc = new frmNhaCungCap();
            //ncc.Show();
            //ncc.MdiParent = this;
            if (!CheckExistForm("frmNhaCungCap"))
            {
                frmNCC = new frmNhaCungCap();
                frmNCC.MdiParent = this;
                frmNCC.Show();
            }
            else
                ActiveChildForm("frmNhaCungCap");
        }

        private void bt_hangnhap_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmReportPhieuNhap"))
            {
                frmReHN = new frmReportPhieuNhap();
                frmReHN.MdiParent = this;
                frmReHN.Show();
            }
            else
                ActiveChildForm("frmReportPhieuNhap");
        }

        private void bt_doanhthu_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmReportThongTinXeMay"))
            {
                frmReTTXM = new frmReportThongTinXeMay();
                frmReTTXM.MdiParent = this;
                frmReTTXM.Show();
            }
            else
                ActiveChildForm("frmReportThongTinXeMay");
        }

        Form frmReNV;
        private void btn_Nhanvienre_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmReportNhanVien"))
            {
                frmReNV = new frmReportNhanVien();
                frmReNV.MdiParent = this;
                frmReNV.Show();
            }
            else
                ActiveChildForm("frmReportNhanVien");
        }
        private void bt_hangton_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmReportNhanVien"))
            {
                frmReNV = new frmReportNhanVien();
                frmReNV.MdiParent = this;
                frmReNV.Show();
            }
            else
                ActiveChildForm("frmReportNhanVien");
        }

        private void bt_hangbanchay_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmReportKhachHang"))
            {
                frmReKH = new frmReportKhachHang();
                frmReKH.MdiParent = this;
                frmReKH.Show();
            }
            else
                ActiveChildForm("frmReportKhachHang");
        }

        private void bt_baohanh_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmReportBaoHanh"))
            {
                frmReBH = new frmReportBaoHanh();
                frmReBH.MdiParent = this;
                frmReBH.Show();
            }
            else
                ActiveChildForm("frmReportBaoHanh");
        }

        Form frmTCNV;
        private void bt_tracuu_nv_Click(object sender, EventArgs e)
        {
            //frmTraCuuNhanVien tcnv = new frmTraCuuNhanVien();
            //tcnv.Show();
            //tcnv.MdiParent = this;
            if (!CheckExistForm("frmTraCuuNhanVien"))
            {
                frmTCNV = new frmTraCuuNhanVien();
                frmTCNV.MdiParent = this;
                frmTCNV.Show();
            }
            else
                ActiveChildForm("frmTraCuuNhanVien");
        }

        Form frmTCKH;
        private void bt_tracuu_kh_Click(object sender, EventArgs e)
        {
            //frmTraCuuKhachHang tckh = new frmTraCuuKhachHang();
            //tckh.Show();
            //tckh.MdiParent = this;
            if (!CheckExistForm("frmTraCuuKhachHang"))
            {
                frmTCKH = new frmTraCuuKhachHang();
                frmTCKH.MdiParent = this;
                frmTCKH.Show();
            }
            else
                ActiveChildForm("frmTraCuuKhachHang");
        }

        Form frmTCPN;
        private void bt_tracuu_nhap_Click(object sender, EventArgs e)
        {
            //frmTraCuuPhieuNhap pn = new frmTraCuuPhieuNhap();
            //pn.Show();
            //pn.MdiParent = this;
            if (!CheckExistForm("frmTraCuuPhieuNhap"))
            {
                frmTCPN = new frmTraCuuPhieuNhap();
                frmTCPN.MdiParent = this;
                frmTCPN.Show();
            }
            else
                ActiveChildForm("frmTraCuuPhieuNhap");
        }

        Form frmTCPX;
        private void bt_tracuu_xuat_Click(object sender, EventArgs e)
        {
            //frmTraCuuPhieuXuat px = new frmTraCuuPhieuXuat();
            //px.Show();
            //px.MdiParent = this;
            if (!CheckExistForm("frmTraCuuPhieuXuat"))
            {
                frmTCPX = new frmTraCuuPhieuXuat();
                frmTCPX.MdiParent = this;
                frmTCPX.Show();
            }
            else
                ActiveChildForm("frmTraCuuPhieuXuat");
        }

        Form frmTCNCC;
        private void bt_tracuu_ncc_Click(object sender, EventArgs e)
        {
            //frmTraCuuHangCungCap hcc = new frmTraCuuHangCungCap();
            //hcc.Show();
            //hcc.MdiParent = this;
            if (!CheckExistForm("frmTraCuuHangCungCap"))
            {
                frmTCNCC = new frmTraCuuHangCungCap();
                frmTCNCC.MdiParent = this;
                frmTCNCC.Show();
            }
            else
                ActiveChildForm("frmTraCuuHangCungCap");
        }

        private void bt_tc_hhoa_Click(object sender, EventArgs e)
        {
            //frmTraCuuXe xe = new frmTraCuuXe();
            //xe.Show();
            //xe.MdiParent = this;
            if (!CheckExistForm("frmTraCuuXe"))
            {
                frmTCHH = new frmTraCuuXe();
                frmTCHH.MdiParent = this;
                frmTCHH.Show();
            }
            else
                ActiveChildForm("frmTraCuuXe");
        }

        private void bt_tc_nvien_Click(object sender, EventArgs e)
        {
            //frmTraCuuNhanVien nv = new frmTraCuuNhanVien();
            //nv.Show();
            //nv.MdiParent = this;
            if (!CheckExistForm("frmTraCuuNhanVien"))
            {
                frmTCNV = new frmTraCuuNhanVien();
                frmTCNV.MdiParent = this;
                frmTCNV.Show();
            }
            else
                ActiveChildForm("frmTraCuuNhanVien");
        }

        private void bt_tc_kh_Click(object sender, EventArgs e)
        {
            //frmTraCuuKhachHang kh = new frmTraCuuKhachHang();
            //kh.Show();
            //kh.MdiParent = this;
            if (!CheckExistForm("frmTraCuuKhachHang"))
            {
                frmTCKH = new frmTraCuuKhachHang();
                frmTCKH.MdiParent = this;
                frmTCKH.Show();
            }
            else
                ActiveChildForm("frmTraCuuKhachHang");
        }

        private void bt_tc_pnhap_Click(object sender, EventArgs e)
        {
            //frmTraCuuPhieuNhap ph = new frmTraCuuPhieuNhap();
            //ph.Show();
            //ph.MdiParent = this;
            if (!CheckExistForm("frmTraCuuPhieuNhap"))
            {
                frmTCPN = new frmTraCuuPhieuNhap();
                frmTCPN.MdiParent = this;
                frmTCPN.Show();
            }
            else
                ActiveChildForm("frmTraCuuPhieuNhap");
        }

        private void bt_tc_pxuat_Click(object sender, EventArgs e)
        {
            //frmTraCuuPhieuXuat px = new frmTraCuuPhieuXuat();
            //px.Show();
            //px.MdiParent = this;
            if (!CheckExistForm("frmTraCuuPhieuXuat"))
            {
                frmTCPX = new frmTraCuuPhieuXuat();
                frmTCPX.MdiParent = this;
                frmTCPX.Show();
            }
            else
                ActiveChildForm("frmTraCuuPhieuXuat");
        }

        private void bt_tc_ncc_Click(object sender, EventArgs e)
        {
            //frmTraCuuHangCungCap hcc = new frmTraCuuHangCungCap();
            //hcc.Show();
            //hcc.MdiParent = this;
            if (!CheckExistForm("frmTraCuuHangCungCap"))
            {
                frmTCNCC = new frmTraCuuHangCungCap();
                frmTCNCC.MdiParent = this;
                frmTCNCC.Show();
            }
            else
                ActiveChildForm("frmTraCuuHangCungCap");
        }

        Form frmND;
        private void btn_NguoiDung_Click(object sender, EventArgs e)
        {
            //frmNguoiDung nd = new frmNguoiDung();
            //nd.Show();
            //nd.MdiParent = this;
            if (!CheckExistForm("frmNguoiDung"))
            {
                frmND = new frmNguoiDung();
                frmND.MdiParent = this;
                frmND.Show();
            }
            else
                ActiveChildForm("frmNguoiDung");
        }

        Form frmNhomND;
        private void btn_NhomNguoiDung_Click(object sender, EventArgs e)
        {
            //N nnd = new N();
            //nnd.Show();
            //nnd.MdiParent = this;
            if (!CheckExistForm("N"))
            {
                frmNhomND = new N();
                frmNhomND.MdiParent = this;
                frmNhomND.Show();
            }
            else
                ActiveChildForm("N");
        }

        private void bt_nhaphang_Click(object sender, EventArgs e)
        {
            //frmNhapHang nh = new frmNhapHang();
            //nh.Show();
            //nh.MdiParent = this;
            if (!CheckExistForm("frmNhapHang"))
            {
                frmNH = new frmNhapHang();
                frmNH.MdiParent = this;
                frmNH.Show();
            }
            else
                ActiveChildForm("frmNhapHang");
        }

        private void bt_xuathang_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmXuatHang"))
            {
                frmXH = new frmXuatHang();
                frmXH.MdiParent = this;
                frmXH.Show();
            }
            else
                ActiveChildForm("frmXuatHang");
        }

        private void bt_hethong_Click(object sender, EventArgs e)
        {
            //frmHeThong ht = new frmHeThong();
            //ht.Show();
            //ht.MdiParent = this;
            if (!CheckExistForm("frmHeThong"))
            {
                Form frmHT = new frmHeThong();
                frmHT.MdiParent = this;
                frmHT.Show();
            }
            else
                ActiveChildForm("frmHeThong");
        }

        private void bt_tacgia_Click(object sender, EventArgs e)
        {
            //frmGioiThieu gt=new frmGioiThieu();
            //gt.Show();
            //gt.MdiParent=this;
            if (!CheckExistForm("frmGioiThieu"))
            {
                Form frmGT = new frmGioiThieu();
                frmGT.MdiParent = this;
                frmGT.Show();
            }
            else
                ActiveChildForm("frmGioiThieu");

        }

        Form frmCV;
        private void btn_Chucvu_Click(object sender, EventArgs e)
        {
            //frmChucVu cv = new frmChucVu();
            //cv.Show();
            //cv.MdiParent = this;
            if (!CheckExistForm("frmChucVu"))
            {
                frmCV = new frmChucVu();
                frmCV.MdiParent = this;
                frmCV.Show();
            }
            else
                ActiveChildForm("frmChucVu");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void bt_chucvu_Click(object sender, EventArgs e)
        {
            //frmChucVu cvm = new frmChucVu();
            //cvm.Show();
            //cvm.MdiParent = this;
            if (!CheckExistForm("frmChucVu"))
            {
                frmCV = new frmChucVu();
                frmCV.MdiParent = this;
                frmCV.Show();
            }
            else
                ActiveChildForm("frmChucVu");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string ch = label2.Text;
            label2.Text = label2.Text.Substring(1, label2.Text.Length - 1);
            label2.Text += ch.Substring(0, 1);
        }

        //Kiem tra form da ton tai hay chua
        private  bool  CheckExistForm(string  name)
        {
            bool  check = false;
            foreach  (Form  frm in  this.MdiChildren)
            {
                if  (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return  check;
        }

        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        Form frmReKH;
        private void btn_Khachang_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmReportKhachHang"))
            {
                frmReKH = new frmReportKhachHang();
                frmReKH.MdiParent = this;
                frmReKH.Show();
            }
            else
                ActiveChildForm("frmReportKhachHang");
        }

        Form frmReNCC;
        private void buttonItem2_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmReportNhaCungCap"))
            {
                frmReNCC = new frmReportNhaCungCap();
                frmReNCC.MdiParent = this;
                frmReNCC.Show();
            }
            else
                ActiveChildForm("frmReportNhaCungCap");
        }

        Form frmReTTXM;
        private void btn_Thongtinxemay_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmReportThongTinXeMay"))
            {
                frmReTTXM = new frmReportThongTinXeMay();
                frmReTTXM.MdiParent = this;
                frmReTTXM.Show();
            }
            else
                ActiveChildForm("frmReportThongTinXeMay");
        }

        private void bt_hangxuat_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmReportPhieuXuat"))
            {
                frmReHX = new frmReportPhieuNhap();
                frmReHX.MdiParent = this;
                frmReHX.Show();
            }
            else
                ActiveChildForm("frmReportPhieuXuat");
        }

        private void btn_cungcap_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmReportNhaCungCap"))
            {
                frmReNCC = new frmReportNhaCungCap();
                frmReNCC.MdiParent = this;
                frmReNCC.Show();
            }
            else
                ActiveChildForm("frmReportNhaCungCap");
        }

        Form frmReDT;
        private void btn_BCDoanhThu_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmReportDoanhThu"))
            {
                frmReDT = new frmReportDoanhThu();
                frmReDT.MdiParent = this;
                frmReDT.Show();
            }
            else
                ActiveChildForm("frmReportDoanhThu");
        }

        private void btn_doanhthu_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmReportDoanhThu"))
            {
                frmReDT = new frmReportDoanhThu();
                frmReDT.MdiParent = this;
                frmReDT.Show();
            }
            else
                ActiveChildForm("frmReportDoanhThu");
        }
    }
}