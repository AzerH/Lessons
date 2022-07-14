using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;



namespace _16iyul_1
{
    class Program 
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            customer.CheckCustomerFromDb();

        }
    }
}
