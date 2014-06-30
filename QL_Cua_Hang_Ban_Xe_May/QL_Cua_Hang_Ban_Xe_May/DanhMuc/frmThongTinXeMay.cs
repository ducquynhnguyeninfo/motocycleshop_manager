using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QL_Cua_Hang_Ban_Xe_May.BusinessLogic;
using QL_Cua_Hang_Ban_Xe_May.BusinessObject;

namespace QL_Cua_Hang_Ban_Xe_May
{
    public partial class frmThongTinXeMay : Form
    {
        private HangHoaBUS hhBUS = new HangHoaBUS();
        private int pos = 0;
        bool bienTTXM = true;
        bool dulieunhap;
        public frmThongTinXeMay()
        {
            InitializeComponent();
        }

        //Thiet lap thuoc tinh
        private void ThietLapThuocTinh(bool flag)
        {
            txtMaXeTTXM.Enabled = flag;
            txtTenXeTTXM.Enabled = flag;
            txtGiaDeNghiTTXM.Enabled = flag;
            txtNhaSXTTXM.Enabled = flag;
            dateTimePickerTTXM.Enabled = flag;
            txtKieuDangTTXM.Enabled = flag;
            txtMauXeTTXM.Enabled = flag;
            txtSoKhungTTXM.Enabled = flag;
            txtSoSuonTTXM.Enabled = flag;
        }
        //Thiet lap nut
        private void ThietLapNut(bool flag)
        {
            btn_LuuTTXM.Enabled = !flag;
            btn_NhapTTXM.Enabled = flag;
            btn_SuaTTXM.Enabled = flag;
            btn_XoaTTXM.Enabled = flag;
            btn_ThoatTTXM.Enabled = flag;
        }

        private void frmThongTinXeMay_Load(object sender, EventArgs e)
        {
            //if (btn_NhapTTXM.Text != "Nhập")
            //{
                dataGridViewTacVuTTXM.Visible = false;
                dataGridViewThongTinXeMay.DataSource = hhBUS.LayDanhSachHangHoa();
                //groupBoxTTXM.Visible = false;
            //}
            //else
            //{
            //    dataGridViewThongTinXeMay.DataSource = hhBUS.LayDanhSachHangHoaNhap();
            //}
                
            ThietLapNut(true);
            ThietLapThuocTinh(false);
            btn_LuuTTXM.Enabled = false;
        }

        private void btn_NhapTTXM_Click(object sender, EventArgs e)
        {
            if (btn_NhapTTXM.Text == "Nhập")
            {
                btn_NhapTTXM.Text = "Ngừng";
                ThietLapNut(false);
                btn_SuaTTXM.Enabled = false;
                btn_XoaTTXM.Enabled = false;
                btn_NhapTTXM.Enabled = true;
                dataGridViewTacVuTTXM.DataSource = hhBUS.LayDanhSachNhapTTXM();
                dataGridViewTacVuTTXM.Visible = true;
                dataGridViewTacVuTTXM.ReadOnly = false;
                //if (dulieunhap == false)
                //{
                //    dataGridViewTacVuTTXM.Rows[pos].Cells["TTXM_MAXE"].ReadOnly = true;
                //    dataGridViewTacVuTTXM.Rows[pos].Cells["TTXM_NGAYSX"].ReadOnly = true;
                //}
            }
            else
            {
                btn_NhapTTXM.Text = "Nhập";
                btn_XoaTTXM.Text = "Tìm Xóa";
                ThietLapNut(true);
                frmThongTinXeMay_Load(sender, e);
            }
        }

        //Lay thong tin de them du lieu cho bang thong tin xe mayLay
        private HangHoa LayThongTinTTXM(int pos)
        {
            HangHoa myttxm = new HangHoa();
            myttxm.MaXe = dataGridViewTacVuTTXM.Rows[pos].Cells["TTXM_MAXE"].Value.ToString().Trim();
            myttxm.TenXe = dataGridViewTacVuTTXM.Rows[pos].Cells["TTXM_TENXE"].Value.ToString().Trim();
            myttxm.NhaSX = dataGridViewTacVuTTXM.Rows[pos].Cells["TTXM_NHASX"].Value.ToString().Trim();
            myttxm.NgaySX = Convert.ToDateTime(dataGridViewTacVuTTXM.Rows[pos].Cells["TTXM_NGAYSX"].Value.ToString().Trim());
            myttxm.MauXe = dataGridViewTacVuTTXM.Rows[pos].Cells["TTXM_MAUXE"].Value.ToString().Trim();
            myttxm.KieuDang = dataGridViewTacVuTTXM.Rows[pos].Cells["TTXM_KIEUDANG"].Value.ToString().Trim();
            myttxm.SoKhung = dataGridViewTacVuTTXM.Rows[pos].Cells["TTXM_SOKHUNG"].Value.ToString().Trim();
            myttxm.SoSuon = dataGridViewTacVuTTXM.Rows[pos].Cells["TTXM_SOSUON"].Value.ToString().Trim();
            myttxm.GiaDeNghi = dataGridViewTacVuTTXM.Rows[pos].Cells["TTXM_GIADENGHI"].Value.ToString().Trim();

            return myttxm;
        }

        //Lay thong tin de them du lieu cho bang thong tin xe may
        private HangHoa LayThongTinSuaTTXM(int pos)
        {
            HangHoa myttxm = new HangHoa();
            myttxm.MaXe = dataGridViewThongTinXeMay.Rows[pos].Cells["MaXe"].Value.ToString().Trim();
            myttxm.TenXe = dataGridViewThongTinXeMay.Rows[pos].Cells["TenXe"].Value.ToString().Trim();
            myttxm.NhaSX = dataGridViewThongTinXeMay.Rows[pos].Cells["NhaSX"].Value.ToString().Trim();
            myttxm.NgaySX = Convert.ToDateTime(dataGridViewThongTinXeMay.Rows[pos].Cells["NgaySX"].Value.ToString().Trim());
            myttxm.MauXe = dataGridViewThongTinXeMay.Rows[pos].Cells["MauXe"].Value.ToString().Trim();
            myttxm.KieuDang = dataGridViewThongTinXeMay.Rows[pos].Cells["KieuDang"].Value.ToString().Trim();
            myttxm.SoKhung = dataGridViewThongTinXeMay.Rows[pos].Cells["SoKhung"].Value.ToString().Trim();
            myttxm.SoSuon = dataGridViewThongTinXeMay.Rows[pos].Cells["SoSuon"].Value.ToString().Trim();
            myttxm.GiaDeNghi = dataGridViewThongTinXeMay.Rows[pos].Cells["GiaDeNghi"].Value.ToString().Trim();

            return myttxm;
        }

        bool kttt;
        private void btn_LuuTTXM_Click(object sender, EventArgs e)
        {
            HangHoa ttxm;
            if (btn_NhapTTXM.Text == "Ngừng") //Lưu cho trường hợp nhập
            {
                for (int i = 0; i < dataGridViewTacVuTTXM.RowCount - 1; i++)
                {
                    if (dataGridViewTacVuTTXM.Rows[i].Cells["TTXM_TENXE"].Value != null && dataGridViewTacVuTTXM.Rows[i].Cells["TTXM_NHASX"].Value != null && dataGridViewTacVuTTXM.Rows[i].Cells["TTXM_NGAYSX"].Value != null && dataGridViewTacVuTTXM.Rows[i].Cells["TTXM_MAUXE"].Value != null && dataGridViewTacVuTTXM.Rows[i].Cells["TTXM_KIEUDANG"].Value != null
                        && dataGridViewTacVuTTXM.Rows[i].Cells["TTXM_SOKHUNG"].Value != null && dataGridViewTacVuTTXM.Rows[i].Cells["TTXM_SOSUON"].Value != null && dataGridViewTacVuTTXM.Rows[i].Cells["TTXM_GIADENGHI"].Value != null)
                    {
                        ttxm = LayThongTinTTXM(i);
                        hhBUS.ThemTTXM(ttxm);
                        kttt = true;
                    }
                    else
                    {
                        MessageBox.Show("Bạn phải nhập đầy đủ thông tin trước khi lưu!", "Thông báo");
                        kttt = false;
                        break;
                    }
                }
                if (kttt == true)
                {
                    MessageBox.Show("Lưu bảng thông tin xe máy thành công!", "Thông báo");
                    btn_NhapTTXM.Text = "Nhập";
                    frmThongTinXeMay_Load(sender, e);
                }
            }
            else // Lưu cho trường hợp sửa
            {
                for (int i = 0; i < dataGridViewThongTinXeMay.RowCount - 1; i++)
                {
                    if (dataGridViewThongTinXeMay.Rows[i].Cells["TenXe"].Value != null && dataGridViewThongTinXeMay.Rows[i].Cells["NhaSX"].Value != null && dataGridViewThongTinXeMay.Rows[i].Cells["NgaySX"].Value != null && dataGridViewThongTinXeMay.Rows[i].Cells["MauXe"].Value != null && dataGridViewThongTinXeMay.Rows[i].Cells["KieuDang"].Value != null
                        && dataGridViewThongTinXeMay.Rows[i].Cells["SoKhung"].Value != null && dataGridViewThongTinXeMay.Rows[i].Cells["SoSuon"].Value != null && dataGridViewThongTinXeMay.Rows[i].Cells["GiaDeNghi"].Value != null)
                    {
                        ttxm = LayThongTinSuaTTXM(i);
                        hhBUS.SuaTTXM(ttxm);
                        kttt = true;
                    }
                    else
                    {
                        MessageBox.Show("Bạn phải nhập đầy đủ thông tin trước khi lưu!", "Thông báo");
                        kttt = false;
                        break;
                    }
                }
                if (kttt == true)
                {
                    MessageBox.Show("Sửa bảng thông tin xe máy thành công!", "Thông báo");
                    btn_NhapTTXM.Text = "Nhập";
                    btn_SuaTTXM.Text = "Tìm Sửa";
                    dataGridViewThongTinXeMay.ReadOnly = true;
                    frmThongTinXeMay_Load(sender, e);
                }
            }
        }

        private void dataGridViewThongTinXeMay_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong == dataGridViewThongTinXeMay.RowCount - 1)
            {
                MessageBox.Show("Không có dữ liệu tại dòng này!", "Thông báo");
                btn_LuuTTXM.Enabled = false;
                
                //    if (btn_SuaNH.Text == "Ngừng")
                //    {
                //        btn_LuuNH.Enabled = false;
                //    }
                //    else
                //    {
                //        btn_XoaNH.Enabled = false;
                //    }
                //    bienNH = false;
                //    dong--;
                //}
                //else if (bienNH == false)
                //{
                //    if (btn_SuaNH.Text == "Ngừng")
                //    {
                //        btn_LuuNH.Enabled = true;
                //    }
                //    else
                //    {
                //        btn_XoaNH.Enabled = true;
                //    }
                //}
                //DuaDuLieuLendataGridViewSuaCTPN(dong);
                //pos = dong;
            }
            else //if (btn_NhapTTXM.Text != "Nhập" && btn_SuaTTXM.Text == "Ngừng")
            {
                if (btn_NhapTTXM.Text != "Nhập")
                {
                    btn_LuuTTXM.Enabled = true;
                }
                else if (btn_SuaTTXM.Text == "Ngừng")
                {
                    btn_LuuTTXM.Enabled = true;
                }
            }
        }

        private void btn_XoaTTXM_Click(object sender, EventArgs e)
        {
            if (btn_XoaTTXM.Text == "Tìm Xóa")
            {
                dulieunhap = true;
                dataGridViewTacVuTTXM.DataSource = hhBUS.LayDanhSachXoaTTXM();
                dataGridViewTacVuTTXM.Visible = true;
                dataGridViewTacVuTTXM.ReadOnly = true;
                btn_XoaTTXM.Text = "Xóa";
                btn_NhapTTXM.Text = "Ngừng";
                btn_SuaTTXM.Enabled = false;
                btn_ThoatTTXM.Enabled = false;
                btn_LuuTTXM.Enabled = false;
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn thông tin xe máy này không?", "Hỏi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    //nhBUS.XoaCTPhieuNhap(txtMaNhap.Text);
                    if (hhBUS.XoaTTXeMay(txtMaXeTTXM.Text))
                    {
                        //btn_ThaoTacCTPN.Text = "Thao Tác Trên Bảng CT Phiếu Nhập";
                        btn_NhapTTXM.Text = "Nhập";
                        dataGridViewTacVuTTXM.Visible = true;
                        btn_XoaTTXM.Text = "Tìm Xóa";
                        frmThongTinXeMay_Load(sender, e);
                    }
                }
            }
        }

        //dataGridView cho cac thao tac nhap xoa sua
        private void DuaDuLieuLendataGridViewThongTinXeMay(int dong)
        {
            if (dong >= dataGridViewTacVuTTXM.RowCount)
                return;
            if (dulieunhap != false)
            {
                txtMaXeTTXM.Text = dataGridViewTacVuTTXM.Rows[dong].Cells["TTXM_MAXE"].Value.ToString();
                txtTenXeTTXM.Text = dataGridViewTacVuTTXM.Rows[dong].Cells["TTXM_TENXE"].Value.ToString();
                txtGiaDeNghiTTXM.Text = dataGridViewTacVuTTXM.Rows[dong].Cells["TTXM_GIADENGHI"].Value.ToString();
                txtNhaSXTTXM.Text = dataGridViewTacVuTTXM.Rows[dong].Cells["TTXM_NHASX"].Value.ToString();
                dateTimePickerTTXM.Text = dataGridViewTacVuTTXM.Rows[dong].Cells["TTXM_NGAYSX"].Value.ToString();
                txtKieuDangTTXM.Text = dataGridViewTacVuTTXM.Rows[dong].Cells["TTXM_KIEUDANG"].Value.ToString();
                txtMauXeTTXM.Text = dataGridViewTacVuTTXM.Rows[dong].Cells["TTXM_MAUXE"].Value.ToString();
                txtSoKhungTTXM.Text = dataGridViewTacVuTTXM.Rows[dong].Cells["TTXM_SOKHUNG"].Value.ToString();
                txtSoSuonTTXM.Text = dataGridViewTacVuTTXM.Rows[dong].Cells["TTXM_SOSUON"].Value.ToString();
            }
        }
        
        private void dataGridViewTacVuTTXM_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong == dataGridViewTacVuTTXM.RowCount - 1)
            {
                MessageBox.Show("Không có dữ liệu tại dòng này!", "Thông báo");
                btn_XoaTTXM.Enabled = false;
                btn_SuaTTXM.Enabled = false;
                btn_LuuTTXM.Enabled = false;
                bienTTXM = false;
                dong--;
                dulieunhap = false;
                dataGridViewTacVuTTXM.ReadOnly = true;
            }
            else if (bienTTXM == false)
            {
                if (btn_NhapTTXM.Text == "Ngừng" && btn_XoaTTXM.Text == "Xóa")
                {
                    if(btn_SuaTTXM.Text == "Tìm Sửa")
                        btn_XoaTTXM.Enabled = true;
                    else
                        btn_SuaTTXM.Enabled = true;
                }
                else
                {
                    btn_LuuTTXM.Enabled = true;
                }
                dulieunhap = true;
            }
            DuaDuLieuLendataGridViewThongTinXeMay(dong);
            pos = dong;
        }

        private void btn_SuaTTXM_Click(object sender, EventArgs e)
        {
            if (btn_SuaTTXM.Text == "Tìm Sửa")
            {
                btn_LuuTTXM.Enabled = true;
                btn_XoaTTXM.Enabled = false;
                btn_NhapTTXM.Enabled = false;
                btn_ThoatTTXM.Enabled = false;
                btn_SuaTTXM.Text = "Ngừng";
                dataGridViewThongTinXeMay.ReadOnly = false;
                //dataGridViewThongTinXeMay.Rows[pos].Cells["TenXe"].ReadOnly = false;
                //dataGridViewThongTinXeMay.Rows[pos].Cells["MaXe"].ReadOnly = true;
            }
            else
            {
                btn_SuaTTXM.Text = "Tìm Sửa";      
                frmThongTinXeMay_Load(sender, e);
            }
        }

        private void btn_ThoatTTXM_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi bảng này không?", "Hỏi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
