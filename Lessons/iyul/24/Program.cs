using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24iyul
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Customer customer1 = new Customer();
            customer1.Name = "Azer";
            customer1.Surname = "Hasanov";
            customer1.Password = "Azer7778";
            customer1.Username = "Duman";
            customer1.Email = "azer.hasanov@gmail.com";

            Customer.CheckCustomer(customer1);
            Customer.ShowDb();
            Console.ReadLine();         

        }

    }

}
