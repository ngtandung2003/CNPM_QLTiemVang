using QLTiemVang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTiemVang.GUI
{
    public partial class fHome : Form
    {
        public fHome()
        {
            InitializeComponent();
            LoadSP();
        }

        void LoadSP()
        {
            string query = @"select PHIEUBANHANG.MaPhieuBanHang, KHACHHANG.TenKhachHang, PHIEUBANHANG.NgayLap, 
                                SANPHAM.TenSanPham, SANPHAM.LoaiSanPham, SANPHAM_BAN.SoLuong, DONVITINH.DonViTinh, 
                                SANPHAM.DonGiaBan, SANPHAM_BAN.SoLuong*SANPHAM.DonGiaBan as [thanh tien] 
                            from KHACHHANG, PHIEUBANHANG, SANPHAM, SANPHAM_BAN, DONVITINH
                            where KHACHHANG.MaKhachHang = PHIEUBANHANG.MaKhachHang
                                and PHIEUBANHANG.MaPhieuBanHang = SANPHAM_BAN.MaPhieuBanHang
                                and SANPHAM_BAN.MaSanPham = SANPHAM.MaSanPham           
                                and SANPHAM.MaDonViTinh = DONVITINH.MaDonViTinh";

            dgvSP.DataSource = DataProvider.Instance.ExecuteQuery(query);
            
        }


    }
}
