using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    class Account
    {
        public delegate void NameOfDelegate(string message);
        public event NameOfDelegate EvEnt;
        public NameOfDelegate _Delegat;
        public NameOfDelegate _del2;

        public Account()
        {

        }

        public void Do(string message)
        {
            EvEnt(message);
            //_Delegat(message);
        }
    }
}
