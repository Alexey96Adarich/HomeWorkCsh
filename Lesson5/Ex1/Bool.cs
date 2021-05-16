using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lesson5
{
    class Bool
    {
        public static bool LogInNoReg(string login)
        {
            if (login.Length >= 2 && login.Length <= 10 && char.GetNumericValue(login[0]) == -1)
            {
                for (int i = 0; i < login.Length; i++)
                {
                    char c = char.ToLower(login[i]);
                    if (c >= 'a' && c <= 'z' || char.IsDigit(c))
                        return true;
                }
            }
            return false;
        }

        public static bool LogInReg(string login)
        {
            Regex myReg = new Regex(@"^[A-Za-z][A-Za-z0-9]{1,9}$");
            return myReg.IsMatch(login);///
        }
    }
}