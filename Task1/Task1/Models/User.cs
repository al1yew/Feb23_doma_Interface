using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class User : IAccount
    {
        public User(string username, string password)
        {
            Password = password;
        }
        public string Fullname { get; set; }
        public string Email { get; set; }

        public string Password;

        public string PasswordChecker(string pass)
        {
            bool checkwhile = true;
            while (checkwhile)
            {
                if (pass.Length > 8)
                {
                    bool checkDigit = false;
                    bool checkUpper = false;
                    bool checkLower = false;

                    foreach (char item in pass)
                    {
                        if (char.IsUpper(item))
                        {
                            checkUpper = true;
                        }
                        else if (char.IsDigit(item))
                        {
                            checkDigit = true;
                        }
                        else if (char.IsLower(item))
                        {
                            checkLower = true;
                        }
                        if (checkDigit && checkUpper && checkLower == true)
                        {
                            checkwhile = false;
                            break; //mutleq sonra yeniden cehd
                        }
                    }
                    if ( !checkDigit || !checkUpper || !checkLower )
                    {
                        Console.WriteLine("Shifreni duz yazin");
                        pass = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Shifre 8 simvol olmalidi");
                    pass = Console.ReadLine();
                }
            }
        }

        public string ShowInfo()
        {
            return $"{Fullname} {Email}";
        }
    }

}
    
