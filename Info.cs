namespace Fitness
{
    public class Info
    {
        static int m_weight;        
        static int m_inches;

        public static void InfoMenu()
        {
            Console.WriteLine("1. Create");
            Console.WriteLine("2. Check");
            Console.WriteLine("3. Go Back to Menu");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Create();
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
            Console.Write(m_inches);
            Console.WriteLine(" inches");

            InfoMenu();
        }

        static void Create()
        {
            CreateWeightInfo();
            CreateHeightInfo();
            InfoMenu();
        }

        static int CreateWeightInfo()
        {
            Console.Write("Weight (in pounds): ");
            m_weight = Convert.ToInt32(Console.ReadLine());
            return m_weight;
        }

        static int CreateHeightInfo()
        {
            Console.Write("Height (in inches): ");            
            m_inches = Convert.ToInt32(Console.ReadLine());
            return m_inches;            
        }
    }
}
