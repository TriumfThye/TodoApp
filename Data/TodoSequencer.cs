using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TodoApp.Data
{
    public class TodoSequencer
    {
        static int todoId;

        public static int NextTodoId()
        {
            return ++todoId;
        }

        public static void Reset()
        {
            todoId = 0;
        }

    }//Class
}//Namespace
