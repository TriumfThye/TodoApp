using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TodoApp.Data
{
    public class PersonSequencer
    {
        static int personId;

        public static int NextPersonId()
        {
            return ++personId;
        }

        public static void Reset()
        {
            personId = 0;
        }

    }//Class
}//Namespace
