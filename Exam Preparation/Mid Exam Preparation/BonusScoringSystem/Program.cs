using System;

namespace BonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            double maxBonus = 0;
            double studentAttendances = 0;

            for (int i = 0; i < students; i++)
            {
                double attendance = double.Parse(Console.ReadLine());

                double totalBonus = (attendance / lectures) * (5 + additionalBonus);
                if (maxBonus < totalBonus)
                {
                    maxBonus = totalBonus;
                    studentAttendances = attendance;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {Math.Ceiling(studentAttendances)} lectures.");
        }
    }
}
