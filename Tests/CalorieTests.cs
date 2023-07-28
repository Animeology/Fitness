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
            float expectedWeight = 150.0f;
            int expectedHeight = 180;
            int expectedAge = 25;

            Calorie calorie = new Calorie();

            calorie.info.m_weight = expectedWeight;
            calorie.info.m_height = expectedHeight;
            calorie.info.m_age = expectedAge;
            calorie.info.m_gender = 'M';

            float expected = Metabolic.MEN_HARRIS_BENEFIT + 
                            (expectedWeight * Metabolic.MEN_WEIGHT) + 
                            (expectedHeight * Metabolic.MEN_HEIGHT) + 
                            (expectedAge *  Metabolic.MEN_AGE) - Metabolic.CALORIE_DIFF;

            float actual = calorie.MenCalorieDeficit();

            if (actual != expected)
            {
                throw new Exception("Calculate Men's Deficit Failed");
            }
        }

        void CalculateMenSurplusCalorie_Works()
        {
            float expectedWeight = 200.0f;
            int expectedHeight = 230;
            int expectedAge = 34;

            Calorie calorie = new Calorie();

            calorie.info.m_weight = expectedWeight;
            calorie.info.m_height = expectedHeight;
            calorie.info.m_age = expectedAge;
            calorie.info.m_gender = 'M';

            float expected = Metabolic.MEN_HARRIS_BENEFIT +
                            (expectedWeight * Metabolic.MEN_WEIGHT) +
                            (expectedHeight * Metabolic.MEN_HEIGHT) +
                            (expectedAge * Metabolic.MEN_AGE) + Metabolic.CALORIE_DIFF;

            float actual = calorie.MenCalorieSurplus();

            if (actual != expected)
            {
                throw new Exception("Calculate Men's Surplus Failed");
            }
        }

        void CalculateWomenDeficitCalorie_Works()
        {
            float expectedWeight = 100.0f;
            int expectedHeight = 135;
            int expectedAge = 25;

            Calorie calorie = new Calorie();

            calorie.info.m_weight = expectedWeight;
            calorie.info.m_height = expectedHeight;
            calorie.info.m_age = expectedAge;
            calorie.info.m_gender = 'F';

            float expected = Metabolic.WOMEN_HARRIS_BENEFIT +
                            (expectedWeight * Metabolic.WOMEN_WEIGHT) +
                            (expectedHeight * Metabolic.WOMEN_HEIGHT) +
                            (expectedAge * Metabolic.WOMEN_AGE) - Metabolic.CALORIE_DIFF;

            float actual = calorie.WomenCalorieDeficit();

            if (actual != expected)
            {
                throw new Exception("Calculate Women's Deficit Failed");
            }
        }

        void CalculateWomenSurplusCalorie_Works()
        {
            float expectedWeight = 100.0f;
            int expectedHeight = 135;
            int expectedAge = 25;

            Calorie calorie = new Calorie();

            calorie.info.m_weight = expectedWeight;
            calorie.info.m_height = expectedHeight;
            calorie.info.m_age = expectedAge;
            calorie.info.m_gender = 'F';

            float expected = Metabolic.WOMEN_HARRIS_BENEFIT +
                            (expectedWeight * Metabolic.WOMEN_WEIGHT) +
                            (expectedHeight * Metabolic.WOMEN_HEIGHT) +
                            (expectedAge * Metabolic.WOMEN_AGE) + Metabolic.CALORIE_DIFF;

            float actual = calorie.WomenCalorieSurplus();

            if (actual != expected)
            {
                throw new Exception("Calculate Women's Surplus Failed");
            }
        }
    }
}
