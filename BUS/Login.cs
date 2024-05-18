using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTiemVang.DAO;


namespace QLTiemVang.BUS
{
    internal class Login
    {
        private DAO.Login loginDao;

        public Login()
        {
            loginDao = new DAO.Login();
        }

        public DataTable getUser(string USERNAME, string PASSWORD)
        {
            return loginDao.getUser(USERNAME, PASSWORD);
        }

    }
}
