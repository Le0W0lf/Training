using System;

namespace GradeBook
{

    class Program
    {
        
        static void Main(string[] args)
        {
            Account acount = new Account();

            acount.EvEnt += ShowMessage;
            acount._Delegat += ShowMessage;

            //acount._Event("qqq");
            //acount._Delegat("qqq");

            acount.Do("qqq");
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
