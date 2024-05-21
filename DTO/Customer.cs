using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DTO
{
    class Customer
    {
        public Customer(string iD, string name, string phoneNum)
        {
            this.iD=iD;
            this.name=name;
            this.phoneNum=phoneNum;
        }

        private string iD;
        public string ID { get { return iD; } set { iD = value; } }

        private string name;
        public string Name { get { return name; } set { name = value; } }

        private string phoneNum;
        public string PhoneNum { get {  return phoneNum; } set {  phoneNum = value; } }

    }
}
