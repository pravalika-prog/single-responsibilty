using System;
using System.Collections.Generic;
using System.Text;

namespace singleresponsibility
{
  public  class Datacapture
    {
        public static person capture(){
            person output = new person();
            Console.WriteLine("enter the firstname");
            output.firstname = Console.ReadLine();
            Console.WriteLine ("enter the lastname");
            output.lastname = Console.ReadLine();
            return output;
        }
    }
}
