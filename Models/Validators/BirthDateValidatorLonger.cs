using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class BirthDateValidatorLonger : IDateTimeValidator
    {
        DateTime max = new DateTime(1954,1,1);
        public bool IsValid(DateTime d)
        {
            if (d < max)
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
