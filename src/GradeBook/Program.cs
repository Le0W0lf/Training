using System;

namespace GradeBook
{

    class Program
    {
        
        static void Main(string[] args)
        {
            ChildClass qqq = new ChildClass();
            qqq.Add(1);
            qqq.Add(2);
            qqq.Add(3);
            qqq.Add(4);
        }
        
        private static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        private static void ShowUpperMes(string message)
        {
            Console.WriteLine(message.ToUpper());
        }
    }

}
