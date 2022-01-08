using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    //class Student
    //{
    //    readonly IIntValidator vekValidator;
    //    readonly IStringValidator surnameValidator;
    //    public string Jmeno { get; set; }
    //   // public int Vek { get; set; }

    //    // Osoba je závislá na validátorech
    //    // závislost je injektovaná v konstruktoru
    //    public Student(IIntValidator iv, IStringValidator sv)
    //    {
    //        vekValidator = iv; surnameValidator = sv;
    //    }

    //    public Student() { vekValidator = null; surnameValidator = null; }

    //    public void ConsoleInput()
    //    {
    //        bool nameOK;
    //        bool vekOK;

    //        do
    //        {
    //            Console.Write("Příjmení: ");
    //            string s = Console.ReadLine();
    //            if (string.IsNullOrEmpty(s)) return;
    //            if (nameOK = surnameValidator.IsValid(s))
    //            {
    //                this.Jmeno = s;
    //            }
    //        }
    //        while (nameOK == false);

    //        do
    //        {
    //            Console.Write("Věk: ");
    //            string s = Console.ReadLine();
    //            if (string.IsNullOrEmpty(s)) return;
    //            if (vekOK = vekValidator.IsValid(s, out int vek))
    //            {
    //                this.Vek = vek;
    //            }
    //        } while (vekOK == false);
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Jmeno}:{Vek}";
    //    }
    //}
    //class Program
    //{
    //    static void Main()
    //    {
    //        // všechny osoby mimo Japonců
    //        // závislosti injektované v konstruktoru
    //        Student s = new Student(new AgeValidator(), new SurnameValidator());
    //        s.ConsoleInput();

    //        // Japonci to mají jinak
    //        // závislosti injektované v konstruktoru
    //        Student j = new Student(new JapanAgeValidator(), new JapanSurnameValidator());
    //        j.ConsoleInput();

    //        Console.WriteLine("========================================");

    //        Console.WriteLine(s);
    //        Console.WriteLine(j);

    //        Console.ReadLine();
    //    }
    //}
}
