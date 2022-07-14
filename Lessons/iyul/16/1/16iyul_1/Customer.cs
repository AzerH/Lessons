using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16iyul_1
{
    class Customer
    {
        public string name;
        public string surname;
        public int PassportNo;
        public string PassportSeril;
        public string address;
        public int Gender;

        public Customer()
        {
            PassportSeril = "Az";
           
        }

        internal bool CheckCustomerFromDb()
        {
            return true;
        }
        public bool ChecjCustomer()
        {
            bool result = CheckCustomerFromDb();
            return result;
        }


    }

   
}
