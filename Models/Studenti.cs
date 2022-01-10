using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class Student
    {
        readonly IIntValidator BirthNumberValidator;
        readonly IStringValidator surnameValidator;
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public int BirthNumber { get; set; }

        public Student(IIntValidator iv, IStringValidator sv, DateTime date)
        {
            BirthNumberValidator = iv; surnameValidator = sv;Birthdate = date; 
        }

        public Student() { BirthNumberValidator = null; surnameValidator = null; }

        public void CheckInput()
        {
            bool nameOK;
            bool bnOK;
            //bool dateOK;

            do
            {
                string s = Console.ReadLine();
                if (string.IsNullOrEmpty(s)) return;
                if (nameOK = surnameValidator.IsValid(s))
                {
                    this.Name = s;
                }
            }
            while (nameOK == false);

            do
            {
                string s = Console.ReadLine();
                if (string.IsNullOrEmpty(s)) return;
                if (bnOK = BirthNumberValidator.IsValid(Convert.ToInt32(s)))
                {
                    this.BirthNumber = Convert.ToInt32(s);
                }
            } while (bnOK == false);
            //do
            //{
            //    string s = Console.ReadLine();
            //    if (string.IsNullOrEmpty(s)) return;
            //    if (dateOK = s.TryParse())
            //    {
            //        this.BirthNumber = Convert.ToInt32(s);
            //    }
            //} while (dateOK == false);
        }
    }
    class Program
    {
        static void Main()
        {
        }
    }
}
