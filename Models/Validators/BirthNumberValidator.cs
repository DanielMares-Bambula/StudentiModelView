using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace DependencyInjection
{
    class BirthNumberValidator : IStringValidator
    {
        //Regex bd = new Regex(@"\d{6}\/\d{3}");
        //Regex bdl = new Regex(@"\d{6}\/\d{4}");
        Regex bn = new Regex(@"\d*\/\d*");
        public bool IsValid(string s)
        {
            if (bn.IsMatch(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
