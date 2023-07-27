
namespace Fitness.PersonalRecord
{
    using FitnessApp;

    public class PersonalRecord
    {
        public static float m_bench;
        public static float m_squat;
        public static float m_deadlift;

        static bool isTesting = true;

        public static void PRMenu()
        {
            PRStats();

            Console.WriteLine("Would you like to insert your new PR?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PersonalRecord pr = new PersonalRecord();
                    pr.CreatePRStats();
                    PRMenu();
                    break;
                case 2:
                    FitnessApp.Menu();
                    break;
                default:
                    Console.WriteLine("Not a valid choice");
                    PRMenu();
                    break;
            }
        }

        void CreatePRStats()
        {
            BenchPR();
            SquatPR();
            DeadliftPR();
        }

        public float BenchPR()
        {
            if (isTesting == false)
            {
                Console.Write("Enter your bench PR (in pounds): ");
                try
                {
                    m_bench = Convert.ToSingle(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input, must be a number.");
                }
            }
            return m_bench;
        }

        public float SquatPR()
        {
            if (isTesting == false)
            {
                Console.Write("Enter your squat PR (in pounds): ");
                try
                {
                    m_squat = Convert.ToSingle(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input, must be a number.");
                }
            }
            return m_squat;
        }

        public float DeadliftPR()
        {
            if (isTesting == false)
            {
                Console.Write("Enter your deadlift PR (in pounds): ");
                try
                {
                    m_deadlift = Convert.ToSingle(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input, must be a number.");
                }
            }
            return m_deadlift;
        }

        public static float PRStats()
        {
            float total = m_bench + m_squat + m_deadlift;

            if (isTesting == false)
            {
                Console.WriteLine("Here is your PR: ");
                Console.WriteLine("Bench: {0}", m_bench);
                Console.WriteLine("Squat: {0}", m_squat);
                Console.WriteLine("Deadlift: {0}", m_deadlift);
                Console.WriteLine("Total pounds: {0}", total);
                Console.WriteLine();
            }
            return total;
        }
    }
}
