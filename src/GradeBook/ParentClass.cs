using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public class ParentClass
    {
        private int privateInt=0;
        public int PublicInt;
        public ParentClass()
        {
            PublicInt = 20;
        }

        public void Add(int a)
        {
            privateInt += a;
            Console.WriteLine(privateInt);
        }
        public int GetPrivateInt()
        {
            return privateInt;
        }
    }
}
