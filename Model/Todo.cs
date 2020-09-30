using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp.Model
{
    public class Todo
    {
        readonly int todoId;
        string description;
        bool done;
        Person assignee;

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Description is null, empty or space");
                }
                else
                {
                    description = value;
                }
            }
        }

        public bool Done
        {
            get
            {
                return done;
            }
            set
            {
                done = value;
            }
        }

        public Person Assignee
        {
            get
            {
                return assignee;
            }
            set
            {
                assignee = value;
            }
        }

        public Todo(int id, string desc)
        {
            todoId = id;
            Description = desc;
        }

    }
}
