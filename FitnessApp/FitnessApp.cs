﻿namespace Fitness.FitnessApp
{
    using Calorie;
    using Info;
    using PersonalRecord;

    public class FitnessApp
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Fitness App!");

            Console.WriteLine("1. Info");
            Console.WriteLine("2. Calorie Intake");
            Console.WriteLine("3. PR Stats");
            Console.WriteLine("4. Quit");

            int choice = Convert.ToInt32(Console.ReadLine());

            Info info = new Info();
            Calorie calorie = new Calorie();
            PersonalRecord pr = new PersonalRecord();

            switch (choice)
            {
                case 1:
                    info.InfoMenu();
                    break;
                case 2:
                    calorie.CheckInfoBeforeCalculate();
                    break;
                case 3:
                    pr.PRMenu();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Not a valid choice!");
                    Menu();
                    break;
            }
        }
    }
}