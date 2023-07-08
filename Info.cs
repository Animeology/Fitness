namespace Fitness
{
    public class Info
    {
        public static float m_weight;
        public static int m_height;
        public static int m_age;
        public static char m_gender;

        bool isTesting = true;

        public static void InfoMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Your Info ");
            Console.WriteLine("1. Create");
            Console.WriteLine("2. Check");
            Console.WriteLine("3. Go Back to Menu");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Info info = new Info();
                    info.Create();
                    break;
                case 2:
                    Check();
                    break;
                case 3:
                    FitnessApp.Menu();
                    break;
                default:
                    Console.WriteLine("Not a valid choice!");
                    break;
            }
        }

        static void Check()
        {
            Console.Write("Current Weight: ");
            Console.Write(m_weight);
            Console.WriteLine(" lbs");

            Console.Write("Current Height: ");
            Console.Write(m_height);
            Console.WriteLine(" inches");

            Console.Write("Current Age: ");
            Console.Write(m_age);
            Console.WriteLine(" year old");

            Console.Write("Current Gender: ");
            if (m_gender == 'M')
            {
                Console.WriteLine("Male");
            }
            else
            {
                Console.WriteLine("Female");
            }

            InfoMenu();
        }

        void Create()
        {
            CreateWeightInfo();
            CreateHeightInfo();
            CreateAge();
            CreateGender();
            InfoMenu();
        }

        public float CreateWeightInfo()
        {
            if(isTesting == false)
            {
                Console.Write("Weight (in pounds): ");
                m_weight = Convert.ToInt32(Console.ReadLine());
            }
            return m_weight;
        }

        public int CreateHeightInfo()
        {
            if (isTesting == false)
            {
                Console.Write("Height (in inches): ");
                m_height = Convert.ToInt32(Console.ReadLine());
            }
            return m_height;
        }

        public int CreateAge()
        {
            if (isTesting == false)
            {
                Console.Write("Age (in years): ");
                m_age = Convert.ToInt32(Console.ReadLine());
            }
            return m_age;
        }

        public char CreateGender()
        {
            if (isTesting == false)
            {
                Console.Write("Gender ((M)ale or (F)emale): ");
                m_gender = Convert.ToChar(Console.ReadLine()!);
            }

            if (m_gender != 'M' && m_gender != 'F')
            {
                Console.WriteLine("There are only 2 genders, (M)ale and (F)emale");
                CreateGender();
            }
            return m_gender;
        }
    }
}
