namespace Fitness.Tests
{
    using Info;

    public class InfoTests
    {
        public static void AllInfoTests(string[] args)
        {
            CreateWeightInfo_Works();
            CreateHeightInfo_Works();
            CreateAge_Works();
            CreateGender_Works();
        }

        static void CreateWeightInfo_Works()
        {
            Info.m_weight = 100;

            Info info = new Info();

            var expectedWeight = Info.m_weight;

            float actualWeight = info.CreateWeightInfo();

            if (actualWeight == expectedWeight)
            {
                Console.WriteLine("CreateWeightInfo test succeeded");
            }
            else
            {
                Console.WriteLine("CreateWeightInfo test failed");
            }
        }

        static void CreateHeightInfo_Works()
        {
            Info.m_height = 100;

            Info info = new Info();

            var expectedHeight = Info.m_weight;

            int actualHeight = info.CreateHeightInfo();

            if (actualHeight == expectedHeight)
            {
                Console.WriteLine("CreateHeightInfo test succeeded");
            }
            else
            {
                Console.WriteLine("CreateHeightInfo test failed");
            }
        }

        static void CreateAge_Works()
        {
            Info.m_age = 25;

            Info info = new Info();

            var expectedAge = Info.m_age;

            int actualHeight = info.CreateAge();

            if (actualHeight == expectedAge)
            {
                Console.WriteLine("CreateAge test succeeded");
            }
            else
            {
                Console.WriteLine("CreateAge test failed");
            }
        }

        static void CreateGender_Works()
        {
            Info.m_gender = 'M';

            Info info = new Info();

            var expectedGender = Info.m_gender;

            char actualGender = info.CreateGender();

            if (actualGender == expectedGender)
            {
                Console.WriteLine("CreateGender test succeeded");
            }
            else
            {
                Console.WriteLine("CreateGender test failed");
            }
        }
    }
}
