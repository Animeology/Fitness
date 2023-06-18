namespace Fitness
{
    static class Calorie
    {
        static void CalorieMenu()
        {
            Console.WriteLine("Want to lose weight or gain weight?");
            Console.WriteLine("1. Lose Weight");
            Console.WriteLine("2. Gain Weight");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Not a valid choice!");
                    CalorieMenu();
                    break;
            }
        }

        public static void CheckInfoBeforeCalculate()
        {
            Console.WriteLine("Your weight is {0}, your height is {1}, and you are {2} years old",
                Info.m_weight,
                Info.m_height,
                Info.m_age
            );

            Console.WriteLine("Is this correct?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CalorieMenu();
                    break;
                case 2:
                    Info.InfoMenu();
                    break;
                default:
                    Console.WriteLine("Not a valid choice, try again");
                    CheckInfoBeforeCalculate();
                    break;
            }
        }
    }
}
