using QLTiemVang.DTO;
using QLTiemVang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTiemVang.GUI
{
    public partial class fSaleSlip : Form
    {
        private Cust cust = new Cust();
        public fSaleSlip()
        {
            InitializeComponent();
            LoadProduct();
            ShowSlip();
            
        }

        private void LoadProduct()
        {
            List<Product> listProduct = ProductDAO.Instance.GetListProduct();
            cbProduct.DataSource = listProduct;
            cbProduct.DisplayMember = "Name";
        }

        private void ShowSlip()
        {
            int count = SaleSlipDAO.Instance.CountSaleSlip() + 1;
            string ID = GenerateFormattedId(count);
            tb_ID.Text = ID;

            //DateTime currentDate = DateTime.Now;
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("dd-MM-yyyy");
            tb_Date.Text = formattedDate;
            if (cust.ID != "")
            {
                tb_Customer.Text = cust.Name;
            }
        }

        static string GenerateFormattedId(int id)
        {
            // Format the ID to be exactly 4 digits, padded with leading zeros if necessary
            return $"PBH{id:0000}";
        }

        private void tb_Customer_MouseClick(object sender, MouseEventArgs e)
        {
            using (fCust_add cust_Add = new fCust_add() { custInfor = new Cust()})
            {
                if (cust_Add.ShowDialog() == DialogResult.OK)
                {
                    cust = cust_Add.custInfor;
                    sender = cust_Add.custInfor.Name;
                }
            }
        }
    }
    
}
