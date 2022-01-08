using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DependencyInjection
{
    class NameValidator : IStringValidator
    {
        Regex regex = new Regex(@"[A - Z]{1}[^\d&^\s]*");
        public bool IsValid(string s) 
        {
            if (regex.IsMatch(s))
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
