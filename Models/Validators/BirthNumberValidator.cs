using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace DependencyInjection
{
    class BirthNumberValidator : IIntValidator
    {
        Regex regex = new Regex(@"\d*\/\d*");
        public bool IsValid(int i)
        {
            if (regex.IsMatch(i.ToString()))
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
