namespace Fitness
{
    public class FitnessApp
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("Welcome to the Fitness App!");

            Console.WriteLine("1. Info");
            Console.WriteLine("2. Calorie Intake");
            Console.WriteLine("3. PR Stats");
            Console.WriteLine("4. Quit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Info info = new();
                    info.InfoMenu();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Not a valid choice!");
                    Menu();
                    break;
            }
        }
    }
}