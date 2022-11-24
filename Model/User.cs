using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Model
{
    class User
    {
        string _username;
        string _password;
        bool _issigned;
        int _products;
        public string Username 
        {
            get { return _username; }
            set
            {
                if (value.Trim().Length >= 6 && value.Trim().Length <= 25)
                {
                    _username = value;
                }
                else
                {
                    _username = "Istifadeci adinizi duzgun daxil edin:";
                }
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                int SayLow = 0;
                int SayUp = 0;
                int SayNum = 0;
                for (int i = 0; value.Length > i; i++)
                {
                    if (char.IsLower(value[i]))
                    {
                        SayLow++;
                    }
                    if (char.IsUpper(value[i]))
                    {
                        SayUp++;
                    }
                    if (char.IsDigit(value[i]))
                    {
                        SayNum++;
                    }
                }
                if (value.Trim().Length >= 8 && value.Trim().Length <=25&&SayLow>=0&&SayNum>=0&&SayUp>0)
                {
                    _password = value;
                }
                else
                {
                    _password ="Parolunuz sehvdir duzgun daaxil edin:";
                }
            }
        }
        public bool Issignedin 
        {
            get { return _issigned; }
            set
            {
                if (_username == "Istifadeci adinizi duzgun daxil edin:" && _password == "Parolunuz sehvdir duzgun daaxil edin:") 
                {
                    Console.WriteLine("Login olmaq isteyirsinizmi");
                    string login=Console.ReadLine();
                    switch (login)
                    {
                        case "Yes":
                            Login();
                            break;
                        case "No":
                            break;
                    }
                    
                }
            }
        }

        public int Product 
        {
            get { return _products; }
            set 
            {
                if (value>0)
                {
                    _products = value;
                }
            }
        }
        public string Login()
        {
            
        }

    }
}
