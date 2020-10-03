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




    }
}
