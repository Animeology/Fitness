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

        static void MenCalorieDeficit()
        {
            float menConst = 66;
            float weightConst = 6.23f;
            float heightConst = 12.7f;
            float ageConst = 6.8f;
            float calorieDiff = 500;

            double BMR = menConst + (weightConst * Info.m_weight) + (heightConst * Info.m_height) + (ageConst * Info.m_age);

            double deficit = BMR - calorieDiff;

            Console.WriteLine("Your calorie intake is {0}", deficit);
        }

        static void MenCalorieSurplus()
        {
            float menConst = 66;
            float weightConst = 6.23f;
            float heightConst = 12.7f;
            float ageConst = 6.8f;
            float calorieDiff = 500;

            double BMR = menConst + (weightConst * Info.m_weight) + (heightConst * Info.m_height) + (ageConst * Info.m_age);

            double deficit = BMR + calorieDiff;

            Console.WriteLine("Your calorie intake is {0}", deficit);
        }


        public static void CheckInfoBeforeCalculate()
        {
            Console.WriteLine("Your weight is {0}, your height is {1}, {2} years old, and a {3}",
                Info.m_weight,
                Info.m_height,
                Info.m_age,
                Info.m_gender == 'M' ? "Male" : "Female" 
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
