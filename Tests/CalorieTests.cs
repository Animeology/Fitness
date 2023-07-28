namespace Fitness.Tests
{
    using MetabolicData;
    using Info;
    using Calorie;

    public class CalorieTests
    {
        public void AllCalorieTests()
        {
            CalculateMenDeficitCalorie_Works();
            CalculateMenSurplusCalorie_Works();
            CalculateWomenDeficitCalorie_Works();
            CalculateWomenSurplusCalorie_Works();
        }

        void CalculateMenDeficitCalorie_Works()
        {
            float expectedWeight = 150;
            int expectedHeight = 180;
            int expectedAge = 25;

            Calorie calorie = new Calorie();
            InfoAccount info = new InfoAccount();

            info.m_weight = expectedWeight;
            info.m_height = expectedHeight;
            info.m_age = expectedAge;

            float expected = Metabolic.MEN_HARRIS_BENEFIT + 
                            (expectedWeight * Metabolic.MEN_WEIGHT) + 
                            (expectedWeight * Metabolic.MEN_WEIGHT) + 
                            (expectedAge *  Metabolic.MEN_AGE);

            float actual = calorie.MenCalorieDeficit();

            if (actual == expected)
            {
                Console.WriteLine("Calculate Men's Deficit Works: expected: {0} actual: {1}", expected, actual);
            }
            else
            {
                Console.WriteLine("Calculate Men's Deficit Doesn't Works: expected: {0} actual: {1}", expected, actual);
            }
        }

        void CalculateMenSurplusCalorie_Works()
        {
            float expectedWeight = 200;
            int expectedHeight = 230;
            int expectedAge = 34;

            Calorie calorie = new Calorie();
            InfoAccount info = new InfoAccount();

            info.m_weight = expectedWeight;
            info.m_height = expectedHeight;
            info.m_age = expectedAge;

            float expected = Metabolic.MEN_HARRIS_BENEFIT +
                            (expectedWeight * Metabolic.MEN_WEIGHT) +
                            (expectedWeight * Metabolic.MEN_WEIGHT) +
                            (expectedAge * Metabolic.MEN_AGE);
            float actual = calorie.MenCalorieSurplus();


            if (actual == expected)
            {
                Console.WriteLine("Calculate Men's Surplus Works: expected: {0} actual: {1}", expected, actual);
            }
            else
            {
                Console.WriteLine("Calculate Men's Surplus Doesn't Works: expected: {0} actual: {1}", expected, actual);
            }
        }

        void CalculateWomenDeficitCalorie_Works()
        {
            float expectedWeight = 100;
            int expectedHeight = 135;
            int expectedAge = 25;

            Calorie calorie = new Calorie();
            InfoAccount info = new InfoAccount();

            info.m_weight = expectedWeight;
            info.m_height = expectedHeight;
            info.m_age = expectedAge;

            float expected = Metabolic.WOMEN_HARRIS_BENEFIT +
                            (expectedWeight * Metabolic.WOMEN_WEIGHT) +
                            (expectedWeight * Metabolic.WOMEN_WEIGHT) +
                            (expectedAge * Metabolic.WOMEN_AGE);
            float actual = calorie.WomenCalorieDeficit();


            if (actual == expected)
            {
                Console.WriteLine("Calculate Women's Deficit Works: expected: {0} actual: {1}", expected, actual);
            }
            else
            {
                Console.WriteLine("Calculate Women's Deficit Doesn't Works: expected: {0} actual: {1}", expected, actual);
            }
        }

        void CalculateWomenSurplusCalorie_Works()
        {
            float expectedWeight = 100;
            int expectedHeight = 135;
            int expectedAge = 25;

            Calorie calorie = new Calorie();
            InfoAccount info = new InfoAccount();

            info.m_weight = expectedWeight;
            info.m_height = expectedHeight;
            info.m_age = expectedAge;

            float expected = Metabolic.WOMEN_HARRIS_BENEFIT +
                            (expectedWeight * Metabolic.WOMEN_WEIGHT) +
                            (expectedWeight * Metabolic.WOMEN_WEIGHT) +
                            (expectedAge * Metabolic.WOMEN_AGE);
            float actual = calorie.WomenCalorieSurplus();


            if (actual == expected)
            {
                Console.WriteLine("Calculate Women's Surplus Works: expected: {0} actual: {1}", expected, actual);
            }
            else
            {
                Console.WriteLine("Calculate Women's Surplus Doesn't Works: expected: {0} actual: {1}", expected, actual);
            }
        }
    }
}
