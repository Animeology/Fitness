namespace Fitness
{
    public class CalorieTests
    {
        static void Main(string[] args)
        {
            CalculateMenDeficitCalorie_Works();
            CalculateMenSurplusCalorie_Works();
            CalculateWomenDeficitCalorie_Works();
        }

        static void CalculateMenDeficitCalorie_Works()
        {
            float expectedWeight = 100;
            float expectedHeight = 135;
            float expectedAge = 25;

            Calorie calorie = new Calorie();

            float expected = CalculatorExpectedMenCalories(expectedWeight, expectedHeight, expectedAge, "deficit");
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

        static void CalculateMenSurplusCalorie_Works()
        {
            float expectedWeight = 100;
            float expectedHeight = 135;
            float expectedAge = 25;

            Calorie calorie = new Calorie();

            float expected = CalculatorExpectedMenCalories(expectedWeight, expectedHeight, expectedAge, "surplus");
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

        static void CalculateWomenDeficitCalorie_Works()
        {
            float expectedWeight = 100;
            float expectedHeight = 135;
            float expectedAge = 25;

            Calorie calorie = new Calorie();

            float expected = CalculatorExpectedWomenCalories(expectedWeight, expectedHeight, expectedAge, "deficit");
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


        static float CalculatorExpectedMenCalories(float weight, float height, float age, string difference)
        {
            float BMR;
            float menConst = 66;
            float weightConst = 6.23f;
            float heightConst = 12.7f;
            float ageConst = 6.8f;

            float calorieDiff = 500;

            if (difference == "surplus")
            {
                BMR = menConst + (weightConst * Info.m_weight) + (heightConst * Info.m_height) + (ageConst * Info.m_age) + calorieDiff;
            }
            else
            {
                BMR = menConst + (weightConst * Info.m_weight) + (heightConst * Info.m_height) + (ageConst * Info.m_age) - calorieDiff;
            }

            return BMR;
        }
        static float CalculatorExpectedWomenCalories(float weight, float height, float age, string difference)
        {
            float BMR;
            float womenConst = 655;
            float weightConst = 4.35f;
            float heightConst = 4.7f;
            float ageConst = 4.7f;

            float calorieDiff = 500;

            if (difference == "surplus")
            {
                BMR = womenConst + (weightConst * Info.m_weight) + (heightConst * Info.m_height) + (ageConst * Info.m_age) + calorieDiff;
            }
            else
            {
                BMR = womenConst + (weightConst * Info.m_weight) + (heightConst * Info.m_height) + (ageConst * Info.m_age) - calorieDiff;
            }

            return BMR;
        }
    }
}
