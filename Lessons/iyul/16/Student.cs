using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Student
    {
        private string _name;
        private string _surname;
        private string _email;

        public string Name {
            get
            {
                return _name;
            } 
            set
            {
                _name = value;                
                if (_surname != null)
                {
                    _email = (_name +"." +_surname + "@gmail.com").ToLower();
                }               
            }
        }
        public string Surname {
            get
            {
                return _surname;
            }   
            set 
            { 
                _surname = value;
                if (_name != null)
                    _email = (_name + "." + _surname + "@gmail.com").ToLower();
            } 
        }
        public void  ShowEmail()
        {
            Console.WriteLine(_email);
            Console.ReadLine();
        }
    }
}
