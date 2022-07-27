using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _24iyul
{
    class Customer
    {
        private static ArrayList _dbArrayList;
        static Customer()
        {
            _dbArrayList = new ArrayList();    
        }
        private string _username;
        private string _password;
        public string Email { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get
            {
                return _username;
            }
            set 
            {
                if (checkUsername(value))               
                    Console.WriteLine("Əlavə etmək istədiyiniz username artıq sistemdə mövcuddur");         
                else
                {
                    _username = value;
                    _dbArrayList.Add(_username);                    
                }
                
            }
        }
        public string Password 
        {
            get 
            {
                return _password;
            }
            set
            {
                if (checkPassword(value))
                {
                    _password = value;
                    Console.WriteLine("Şifrə qaydalara uyğun gəlir");
                }                   

                else 
                {
                    Console.WriteLine("Şifrə ən az 8 simvoldan ibarət, içərisində ən az 1 böyük hərf və 1 rəqəm olmalıdır");
                    Console.WriteLine("Proqrama yenidən daxil olub yoxlayın");
                    Console.ReadLine();
                }
                    

            }
        }        
        bool  checkUsername (string username)
        {
            bool check = _dbArrayList.Contains(username);
           return check;
        }
       
        #region checkPassword
        bool checkPassword(string password)
        {
            bool a = false;
            if (password.Length > 7 && checkUpper(password) && checkDigit(password))
            {
                a = true;
            
            }
                
            
            return a;         
        }
        bool checkUpper(string password)
        {
            bool a = false;
            foreach (char c in password)
                if (c == char.ToUpper(c))               
                    a = true;                
            return a;                    
        }
        static bool checkDigit(string password)
        {
            bool a = false;
            foreach (char c in password)
                if (char.IsDigit(c))
                    a = true;
            return a;
        }
        #endregion
              
        static bool checkEmail(string email)
        {
            bool check = _dbArrayList.Contains(email);
            return check;
        }
        public static void CheckCustomer(Customer customer)
        {
            Console.Write("Digər məlumatlar yoxlanılır.");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(800);
                Console.Write(".");
            }
            Console.WriteLine();         
        
            if (customer != null && customer.Username != null && customer.Username != "" && customer.Email != null && customer.Email != "")
            {
                if (Customer.checkEmail(customer.Email))  
                    
                    Console.WriteLine( "Əlavə etmək istədiyiniz müştəri artıq sistemdə mövcuddur");               
                else
                {

                    Console.WriteLine("Yeni müştəri əlavə olundu");
                    _dbArrayList.Add(customer.Email);
                }
                    
            }
            else
                Console.WriteLine("Məlumatlar tam əlavə edilməyib");
        }
        public static void ShowDb ()
        {
            int a = 1;            
            Console.WriteLine();
            Console.WriteLine("Bazada olan məlumatlar:");
            foreach (var item in _dbArrayList)
                
                Console.WriteLine($"{a++}) {item}");
        }

    





    }
}
