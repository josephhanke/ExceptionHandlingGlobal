using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Domain
{
   
        public class ExampleMethods
        {

            public static void SomeMethod()
            {
                throw new Exception("I told you not to do it");
            }



        }
}
