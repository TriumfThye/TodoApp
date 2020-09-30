using System;
using TodoApp.Model;

namespace TodoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            //Constructor
            Person aPerson = new Person(555, "Bengt", "Svensson");
            aPerson.LastName = "Ohlsson";
            aPerson.FirstName = "Emil";
        }
    }
}
