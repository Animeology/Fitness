﻿namespace Fitness
{
    static class PersonalRecord
    {
        public static float m_bench;
        public static float m_squat;
        public static float m_deadlift;

        public static void PRMenu()
        {
            PRStats();

            Console.WriteLine("Would you like to insert your new PR?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreatePRStats();
                    PRMenu();
                    break;
                case 2:
                    FitnessApp.Menu();
                    break;
                default:
                    Console.WriteLine("Not a valid choice");
                    PRMenu();
                    break;
            }
        }

        static void CreatePRStats()
        {
            BenchPR();
            SquatPR();
            DeadliftPR();
        }

        static void BenchPR()
        {
            Console.Write("Enter your bench PR (in pounds): ");
            try
            {
                m_bench = Convert.ToSingle(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input, must be a number.");
            }
        }

        static void SquatPR()
        {
            Console.Write("Enter your squat PR (in pounds): ");
            try
            {
                m_squat = Convert.ToSingle(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input, must be a number.");
            }
        }

        static void DeadliftPR()
        {
            Console.Write("Enter your deadlift PR (in pounds): ");
            try
            {
                m_deadlift = Convert.ToSingle(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input, must be a number.");
            }
        }

        static void PRStats()
        {
            float total = m_bench + m_squat + m_deadlift;
            Console.WriteLine("Here is your PR: ");
            Console.WriteLine("Bench: {0}", m_bench);
            Console.WriteLine("Squat: {0}", m_squat);
            Console.WriteLine("Deadlift: {0}", m_deadlift);
            Console.WriteLine("Total pounds: {0}", total);
            Console.WriteLine();
        }
    }
}