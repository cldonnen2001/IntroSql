using System;

namespace cSharp_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameType = "Dragon Whisperer";
            int yearsStudy = 3;
            char classLevel = 'A';
            bool willFinish = true;
            double stageLevel = 1.15;
            decimal averageYears = 17.750003215875m;
            Console.WriteLine($"Welcome to {nameType} this is year {yearsStudy} of your learning.  You are currently at class {classLevel}." +
                $"At this rate it will take {stageLevel} months to move to the next level.  Will you finish the class?  {willFinish}  with an average of {averageYears} " +
                $"to complete the course");
        }
    }
}
