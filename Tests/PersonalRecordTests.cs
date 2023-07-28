namespace Fitness.Tests
{
    using PersonalRecord;

    public class PersonalRecordTests
    {
        public static void PRTests(string[] args)
        {
            BenchPR_ReturnExpected();
            SquatPR_ReturnExpected();
            DeadliftPR_ReturnExpected();
            TotalPR_ReturnExpected();
        }

        static void BenchPR_ReturnExpected()
        {
            float expectedBench = 135.0f;
            PersonalRecord pr = new PersonalRecord();

            pr.m_bench = expectedBench;
            var actualBench = pr.BenchPR();

            if (actualBench == expectedBench)
            {
                Console.WriteLine("BenchPR returns the correct output");
            }
            else
            {
                Console.WriteLine("BenchPR returns the incorrect output");
            }
        }

        static void SquatPR_ReturnExpected()
        {
            float expectedSquat = 225.0f;
            PersonalRecord pr = new PersonalRecord();

            pr.m_squat = expectedSquat;
            var actualSquat = pr.SquatPR();

            if (actualSquat == expectedSquat)
            {
                Console.WriteLine("SquatPR returns the correct output");
            }
            else
            {
                Console.WriteLine("SquatPR returns the incorrect output");
            }
        }

        static void DeadliftPR_ReturnExpected()
        {
            float expectedDeadlift = 300.0f;
            PersonalRecord pr = new PersonalRecord();
            
            pr.m_deadlift = expectedDeadlift;
            var actualDeadlift = pr.DeadliftPR();

            if (actualDeadlift == expectedDeadlift)
            {
                Console.WriteLine("DeadliftPR returns the correct output");
            }
            else
            {
                Console.WriteLine("DeadliftPR returns the incorrect output");
            }
        }

        static void TotalPR_ReturnExpected()
        {
            float expectedBench = 135.0f;
            float expectedSquat = 225.0f;
            float expectedDeadlift = 300.0f;

            float expectedTotal = expectedBench + expectedSquat + expectedDeadlift;

            PersonalRecord pr = new PersonalRecord();

            pr.m_bench = expectedBench;
            pr.m_squat = expectedSquat;
            pr.m_deadlift = expectedDeadlift;
            var actualTotal = pr.PRStats();

            if (actualTotal == expectedTotal)
            {
                Console.WriteLine("TotalPR returns the correct output");
            }
            else
            {
                Console.WriteLine("TotalPR returns the incorrect output");
            }
        }
    }
}
