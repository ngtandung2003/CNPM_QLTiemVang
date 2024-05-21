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
        public fSaleSlip()
        {
            InitializeComponent();
            LoadProduct();
        }

        private void LoadProduct()
        {
            List<Product> listProduct = ProductDAO.Instance.GetListProduct();
            cbProduct.DataSource = listProduct;
            cbProduct.DisplayMember = "Name";
        }



        private void fSaleSlip_Load(object sender, EventArgs e)
        {

        }

        private void b_Add_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
