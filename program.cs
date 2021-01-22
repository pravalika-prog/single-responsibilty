using singleresponsibility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Single
{
 public   class program
    {
        static void Main()
        {
      standradmessages.welcome();
      person user= Datacapture.capture();
      bool isvalidname = personvalidation.validaton(user);
            if (isvalidname == true)
            {
                standradmessages.end();
                return;
            }
            account.useraccount(user);
            standradmessages.end();
         }
    }
}
