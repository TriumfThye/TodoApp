using System;
using System.Text;
using TodoApp.Model;

namespace TodoApp.Data
{
    public class TodoItems
    {
        static Todo[] todoArray = new Todo[0];

        public int Size()
        {
            return todoArray.Length;
        }

        public Todo[] FindAll()
        {
            return todoArray;
        }

        public Todo FindById(int todoId)
        {
            foreach (Todo todo in todoArray)
            {
                if (todo.TodoId == todoId)
                {
                    return todo;
                }
            }
            return null;
        }

        public void NewTodo(string desc)
        {
            int index = todoArray.Length;
            int todoId = TodoSequencer.NextTodoId();
            Todo newTodo = new Todo(todoId, desc);
            Array.Resize<Todo>(ref todoArray, index + 1);
            todoArray[index] = newTodo;
        }

        public void Clear()
        {
            todoArray = new Todo[0];
        }

        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            Todo[] doneTodo = new Todo[0];
            foreach (Todo todo in todoArray)
            {
                if (todo.Done == doneStatus)
                {
                    int index = doneTodo.Length;
                    Array.Resize<Todo>(ref doneTodo, index + 1);
                    doneTodo[index] = todo;
                }
            }
            return doneTodo;
        }

        public Todo[] FindByAssignee(int personId)
        {
            Todo[] assigneeTodo = new Todo[0];
            foreach (Todo todo in todoArray)
            {
                if (todo.Assignee != null && todo.Assignee.PersonId == personId) 
                { 
                    int index = assigneeTodo.Length;
                    Array.Resize<Todo>(ref assigneeTodo, index + 1);
                    assigneeTodo[index] = todo;
                }
            }
            return assigneeTodo;

        }

        public Todo[] FindByAssignee(Person assignee)
        {
            int id = assignee.PersonId;
            Todo[] storedAssignee = FindByAssignee(id);
            return storedAssignee;
        }



        public Todo[] FindUnassignedTodoItems()
        {
            Todo[] storedNullAssignee = new Todo[0];
            foreach (Todo todo in todoArray)
            {
                if (todo.Assignee == null)
                {
                    int index = storedNullAssignee.Length;
                    Array.Resize<Todo>(ref storedNullAssignee, index + 1);
                    storedNullAssignee[index] = todo;
                }
            }
            return storedNullAssignee;

        }
        
        public void RemoveTodoItem(Todo todo)
        {
            int indexRemove = Array.IndexOf(todoArray, todo);
            if (indexRemove >= 0)
            {
                todoArray[indexRemove] = todoArray[todoArray.Length - 1];
                Array.Resize<Todo>(ref todoArray, todoArray.Length - 1);
            }

        }

        

    }
}
