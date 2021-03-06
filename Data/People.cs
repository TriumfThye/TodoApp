﻿using System;
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
            Array.Resize<Person>(ref personArray, index + 1);
            personArray[index] = newPerson;
        }

        public void Clear()
        {
            personArray = new Person[0];
        }

        public void RemovePerson(Person person)
        {
            int indexRemove = Array.IndexOf(personArray, person);
            if (indexRemove >= 0)
            {
                personArray[indexRemove] = personArray[personArray.Length - 1];
                Array.Resize<Person>(ref personArray, personArray.Length - 1);
            }

        }


    }
}
