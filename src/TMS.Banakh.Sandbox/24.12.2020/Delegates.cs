using System;
using System.Collections.Generic;
using System.Text;

namespace TMS.Banakh.Sandbox._24._12._2020
{
    public class Delegates
    {
        private object _someobject;
        public Delegates(string somestring)
        {
            _someobject = somestring;
        }

        //public delegate void Message();
        //public Message message1;
        //public Action message1;

        public Func<int, string, bool> message1;

        //public Predicate<int> message1;

        //public bool ShowMessage(int number)
        //{

        //    Console.WriteLine(_someobject);
        //    return true;
        //}

        public void ShowMessage()
        {
            Console.WriteLine(_someobject);
        }
    }
}
