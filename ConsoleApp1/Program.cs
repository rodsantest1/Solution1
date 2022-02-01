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

    #region Business Layer
    public class BusinessLayer
    {
        public static List<Person> GetPeople()
        {
            List<Person> people = DataAccessLayer.GetPeople();

            return people;
        }
    }
    #endregion Business Layer

    #region Data Layer
    public class DataAccessLayer
    {
        //CRUD - Create, Read, Update and Delete records
        public static List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { Id = 1, FirstName = "Rodney" });
            people.Add(new Person { Id = 2, FirstName = "Charity" });
            
            return people;
        }
    }
    #endregion Data Layer

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
