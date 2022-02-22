using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    interface IAccount
    {
        string PasswordChecker(string pass);

        string ShowInfo();
    }
}
