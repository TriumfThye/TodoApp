﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp.Model
{
    public class Person
    {
        private readonly int personId;
        string firstName = "John";
        string lastName = "Doe";
        public string FirstName
        {//Properties
            get { return firstName; }
            set
            { 
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name is not filled out make sure there is no empty space");
                }
                else
                {
                    firstName = value;
                }
            }
        }
        public string LastName
        {//Properties
            get { return lastName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name is not filled out make sure there is no empty space");

                }
                else
                {
                    lastName = value;
                }
            }

        }
        //Constructor
        public Person(int personId, string firstName, string lastName)
        {
            this.personId = personId;
            this.FirstName = firstName;
            this.LastName = lastName;

        }
    


    }//class Person

}//namespace