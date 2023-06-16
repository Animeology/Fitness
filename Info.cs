namespace Fitness
{
    public class Info
    {
        int m_weight;
        int m_feet;
        int m_inches;

        public void InfoMenu()
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

        void Create()
        {
            Console.Write("Weight: ");
            m_weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Height: ");
            
            Console.Write("Ft: ");
            m_feet = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("In: ");
            m_inches = Convert.ToInt32(Console.ReadLine());

            InfoMenu();
        }

        void Check()
        {
            Console.Write("Current Weight: ");
            Console.WriteLine(m_weight);

            Console.WriteLine("Current Height: ");
            
            Console.Write("Ft: ");
            Console.Write(m_feet);

            Console.Write(" In: ");
            Console.WriteLine(m_inches);

            InfoMenu();
        }
    }
}
