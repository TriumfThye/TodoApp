using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using TodoApp.Model;

namespace TodoApp.Data
{
    public class People
    {
        static Person[] personArray = new Person[0];

        public int Size()
        {
            return personArray.Length;
        }

        public Person[] FindAll()
        {
            return personArray;
        }

        public Person FindById(int personId)
        {
            foreach (Person person in personArray)
            {
                if (person.PersonId == personId)
                {
                    return person;
                }
            }
            return null;
        }

        public void NewPerson(string firstName, string lastName)
        {
            int index = personArray.Length;
            int personId = PersonSequencer.NextPersonId();
            Person newPerson = new Person(personId, firstName, lastName);
            Array.Resize<Person>(ref personArray, index+1);
            personArray[index] = newPerson;
        }

        public void Clear()
        {
            personArray = new Person[0];
        }

    }
}
