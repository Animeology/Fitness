namespace Fitness
{
    public class Info
    {
        int weight;
        int feet;
        int inches;

        public void MenuInfo()
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
            weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Height: ");
            Console.Write("Ft: ");
            feet = Convert.ToInt32(Console.ReadLine());
            Console.Write("In: ");
            inches = Convert.ToInt32(Console.ReadLine());

            MenuInfo();
        }

        void Check()
        {
            Console.Write("Current Weight: ");
            Console.WriteLine(weight);

            Console.WriteLine("Current Height: ");
            Console.Write(feet);
            Console.WriteLine(inches);

            MenuInfo();
        }
    }
}
