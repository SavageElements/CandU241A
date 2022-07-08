using System;

namespace CandU241A
{
    class Program
    {

        static void Main(string[] args)
        {
            Person241A person241 = new Employee();
            person241.firstName = "Sample";
            person241.lastName = "Student";

            person241.SayName();

        }
    }
}
