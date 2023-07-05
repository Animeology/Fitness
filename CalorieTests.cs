namespace Fitness
{
    public class CalorieTests
    {
        static void Main(string[] args)
        {

        }

        static void CalculateMenDeficitCalorie_ReturnExpected()
        {
            Info.m_weight = 10;

            Calorie menDeficit = new Calorie();

            menDeficit.MenCalorieDeficit();

            float expected = menDeficit.BMR;
        }
    }
}
