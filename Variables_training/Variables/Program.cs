using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string name = "Dragon Weaver";
            int length = 17;
            char grade = 'S';
            bool onlevel = true;
            double age = 4.15;
            decimal averageLevel = 5;
            Console.WriteLine($"Your {name} is {age}. If is a grade of M or more than he is doing well. He is a grade {grade}. " +
                $"Is he onlevel? {onlevel}.  His tail is age {length} feet long, with an {averageLevel} spikes.");
        }
    }
}
