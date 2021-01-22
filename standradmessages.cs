using System;
using System.Collections.Generic;
using System.Text;

namespace singleresponsibility
{
  public  class standradmessages
    {
        public static void welcome()
        {
            Console.WriteLine("welcome to the application");
        }
        public static void end()
        {
            Console.Write("please  enter to close the application");
            Console.ReadLine();
        }
     public static void displayerrormessages(string  name)
         {
            Console.WriteLine($"you are name is not  a valid one  {name} ");
        }
    }
}
