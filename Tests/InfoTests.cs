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
            InfoAccount.m_weight = 100;

            InfoAccount info = new InfoAccount();

            var expectedWeight = InfoAccount.m_weight;

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
            InfoAccount.m_height = 100;

            InfoAccount info = new InfoAccount();

            var expectedHeight = InfoAccount.m_weight;

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
            InfoAccount.m_age = 25;

            InfoAccount info = new InfoAccount();

            var expectedAge = InfoAccount.m_age;

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
            InfoAccount.m_gender = 'M';

            InfoAccount info = new InfoAccount();

            var expectedGender = InfoAccount.m_gender;

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
