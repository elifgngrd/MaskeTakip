using System;
using System.Collections.Generic;
using Business.Concrete;
using Entities.Concrete;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Person person1 = new Person();
            person1.FirstName = "Elif";
            person1.LastName = "GÜNGÖRDÜ";
            person1.DateOfBirthYear = 1995;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Murat";

            PttMenager pttMenager = new PttMenager(new PersonMenager());
            pttMenager.GiveMask(person1);

            Console.ReadLine();
        }
    }
}






