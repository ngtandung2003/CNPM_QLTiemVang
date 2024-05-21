using QLTiemVang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QLTiemVang.DAO
{
    public class SaleSlipDAO
    {
        private static SaleSlipDAO instance;

        public static SaleSlipDAO Instance
        {
            get { if (instance == null) instance = new SaleSlipDAO(); return instance; }
            private set { instance = value; }
        }

        private SaleSlipDAO() { }

       //public void InsertSlip()
       // {
       //     string query = "EXEC ThemPhieuBanHang @SoPhieu , @NgayLap , @MaKhachHang , @MaSanPham , @LoaiSanPham , @SoLuong , @DonViTinh , @DonGia";
       //     DataProvider.Instance.ExecuteNoneQuery(query, new object[]{ });
       // }
    }
}
