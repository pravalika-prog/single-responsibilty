using System;
using System.Collections.Generic;
using System.Text;

namespace singleresponsibility
{
  public  class account
    {
public static void useraccount(person user)
        {
            Console.WriteLine($"username is {user.firstname.Substring(0,1)}   {user.lastname}");
        }
    }
}
