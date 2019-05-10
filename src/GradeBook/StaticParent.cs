using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    static class StaticParent
    {
        static public int Count;
        static void Add(int a)
        {
            Count += a;
        }
        static void Set(int a)
        {
            Count = a;
        }
    }
}
