namespace Fitness
{
    static class PersonalRecord
    {
        public static float m_bench;
        public static float m_squat;
        public static float m_deadlift;

        static void PRMenu()
        {
            PRStats();

            Console.WriteLine("Would you like to insert your new PR?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Not a valid choice");
                    PRMenu();
                    break;
            }
        }

        private static void PRStats()
        {            
            Console.WriteLine("Here is your PR: ");
            Console.WriteLine("Bench: {0}", m_bench);
            Console.WriteLine("Squat: {0}", m_squat);
            Console.WriteLine("Deadlift: {0}", m_deadlift);
            Console.WriteLine();
        }
    }
}
