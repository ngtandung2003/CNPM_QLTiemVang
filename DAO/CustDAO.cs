using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DAO
{
    public class CustDAO
    {
        private static CustDAO instance;

        public static CustDAO Instance
        {
            get { if (instance == null) instance = new CustDAO(); return instance; }
            private set { instance = value; }
        }

        private CustDAO() { }

        public DataTable Search(string text = " ")
        {
            string query = "USP_SearchCust N'%"+text+"%';";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }

}