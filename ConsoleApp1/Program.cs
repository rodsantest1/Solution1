using ClassLibrary1;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{

    #region UI Layer
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.FirstName = "Rodney";

            //Console.WriteLine(person.FirstName);

            List<Person> people = BusinessLayer.GetPeople();

            foreach (var person in people)
            {
                Console.WriteLine($"Id: {person.Id} Name: {person.FirstName}");
            }
        }
    }
    #endregion UI Layer
}
