using System;
using System.Collections.Generic;
using System.Text;

namespace singleresponsibility
{
  public  class personvalidation
    {
        public static bool validaton(person Person)
        {
            if (string.IsNullOrWhiteSpace(Person.firstname))
            {
                standradmessages.displayerrormessages("firstname");
                return true;
            }
            if (string.IsNullOrWhiteSpace(Person.lastname))
            {
                standradmessages.displayerrormessages("lastname");
                return true;
            }
            else
            {
                return false;
            } 
        }

    }
}
