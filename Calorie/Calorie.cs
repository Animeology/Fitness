namespace Fitness.Calorie
{
    using FitnessApp;
    using Info;
    using MetabolicData;

    public class Calorie
    {
        bool isTesting = true;
        InfoAccount info = new InfoAccount();

        void CalorieMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Want to lose weight or gain weight?");
            Console.WriteLine("1. Lose Weight");
            Console.WriteLine("2. Gain Weight");
            Console.WriteLine("3. Quit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (info.m_gender == 'M')
                    {
                        MenCalorieDeficit();
                    }
                    else
                    {
                        WomenCalorieDeficit();
                    }
                    CalorieMenu();
                    break;
                case 2:
                    if (info.m_gender == 'M')
                    {
                        MenCalorieSurplus();
                    }
                    else
                    {
                        WomenCalorieSurplus();
                    }
                    CalorieMenu();
                    break;
                case 3:
                    FitnessApp.Menu();
                    break;
                default:
                    Console.WriteLine("Not a valid choice!");
                    CalorieMenu();
                    break;
            }
        }

        public float MenCalorieDeficit()
        {
            float calorieDiff = 500.0f;

            float BMR = Metabolic.MEN_HARRIS_BENEFIT +
                        Metabolic.MEN_WEIGHT * info.m_weight +
                        Metabolic.MEN_HEIGHT * info.m_height +
                        Metabolic.MEN_AGE * info.m_age;

            float deficit = BMR - calorieDiff;

            if (!isTesting)
            {
                Console.WriteLine("Your calorie intake is {0}", deficit);
            }

            return deficit;
        }

        public float MenCalorieSurplus()
        {
            float calorieDiff = 500;

            float BMR = Metabolic.MEN_HARRIS_BENEFIT +
                        Metabolic.MEN_WEIGHT * info.m_weight +
                        Metabolic.MEN_HEIGHT * info.m_height +
                        Metabolic.MEN_AGE * info.m_age;

            float surplus = BMR + calorieDiff;

            if (!isTesting)
            {
                Console.WriteLine("Your calorie intake is {0} calories", surplus);
            }

            return surplus;
        }

        public float WomenCalorieDeficit()
        {
            float calorieDiff = 500;

            float BMR = Metabolic.WOMEN_HARRIS_BENEFIT +
                        Metabolic.WOMEN_WEIGHT * info.m_weight +
                        Metabolic.WOMEN_HEIGHT * info.m_height +
                        Metabolic.WOMEN_AGE * info.m_age;

            float deficit = BMR - calorieDiff;

            if (!isTesting)
            {
                Console.WriteLine("Your calorie intake is {0} calories", deficit);
            }

            return deficit;
        }

        public float WomenCalorieSurplus()
        {
            float calorieDiff = 500;

            float BMR = Metabolic.WOMEN_HARRIS_BENEFIT +
                        Metabolic.WOMEN_WEIGHT * info.m_weight +
                        Metabolic.WOMEN_HEIGHT * info.m_height +
                        Metabolic.WOMEN_AGE * info.m_age;

            float surplus = BMR + calorieDiff;

            if (!isTesting)
            {
                Console.WriteLine("Your calorie intake is {0} calories", surplus);
            }

            return surplus;
        }

        public void CheckInfoBeforeCalculate()
        {
            Console.WriteLine(
                "Your weight is {0}, your height is {1}, {2} years old, and a {3}",
                info.m_weight,
                info.m_height,
                info.m_age,
                info.m_gender == 'M' ? "Male" : "Female"
            );

            Console.WriteLine("Is this correct?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Calorie calorie = new Calorie();
                    calorie.CalorieMenu();
                    break;
                case 2:
                    Console.WriteLine("Please input the correct info.");
                    info.InfoMenu();
                    break;
                default:
                    Console.WriteLine("Not a valid choice, try again");
                    CheckInfoBeforeCalculate();
                    break;
            }
        }
    }
}
