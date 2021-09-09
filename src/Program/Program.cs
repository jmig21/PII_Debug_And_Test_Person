using System;

namespace UnitTestAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John Doe", "1.234.567-8", "01/01/01");
            Person jane = new Person("Jane Doe", "8.765.432-1", "01/01/01");
            john.IntroduceYourself();
            jane.IntroduceYourself();
        }
    }
}
