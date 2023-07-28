namespace Fitness.Tests
{
    using Info;

    public class InfoTests
    {
        public void AllInfoTests()
        {
            CreateWeightInfo_Works();
            CreateHeightInfo_Works();
            CreateAge_Works();
            CreateGender_Works();
        }

        void CreateWeightInfo_Works()
        {
            float expectedWeight = 100;

            InfoAccount info = new InfoAccount();

            info.m_weight = expectedWeight;
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

        void CreateHeightInfo_Works()
        {
            int expectedHeight = 100;

            InfoAccount info = new InfoAccount();

            info.m_height = expectedHeight;

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

        void CreateAge_Works()
        {
            int expectedAge = 25;

            InfoAccount info = new InfoAccount();

            info.m_age = expectedAge;
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

        void CreateGender_Works()
        {
            char expectedGender = 'M';

            InfoAccount info = new InfoAccount();

            info.m_gender = expectedGender;
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
