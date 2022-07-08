using System;
using System.Collections.Generic;
using System.Text;

namespace CandU241A
{
    class Employee : Person241A
    {
        public int ID;

        public override void SayName()
        {
            Console.WriteLine(firstName + lastName);
        }
    }
}
