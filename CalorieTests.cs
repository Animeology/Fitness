namespace Fitness
{
    public class CalorieTests
    {
        static void Main(string[] args)
        {
            CalculateMenDeficitCalorie_Works();
        }

        static void CalculateMenDeficitCalorie_Works()
        {
            Info.m_weight = 150;
            Info.m_height = 180;
            Info.m_age = 25;

            var expectedWeight = Info.m_weight;
            var expectedHeight = Info.m_height;
            var expectedAge = Info.m_age;

            float expected = CalculatorExpectedMenCalories(expectedWeight, expectedHeight, expectedAge, "deficit");
            float actual = Calorie.MenCalorieDeficit();


            if (actual == expected)
            {
                Console.WriteLine("Calculate Men's Deficit Works: expected: {0} actual: {1}", expected, actual);
            }
            else
            {
                Console.WriteLine("Calculate Men's Deficit Doesn't Works: expected: {0} actual: {1}", expected, actual);
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
    }
}
