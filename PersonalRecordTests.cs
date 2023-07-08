namespace Fitness
{
    public class PersonalRecordTests
    {
        static void Main(string[] args)
        {
            BenchPR_ReturnExpected();
            SquatPR_ReturnExpected();
            DeadliftPR_ReturnExpected();
        }

        static void BenchPR_ReturnExpected()
        {
            PersonalRecord.m_bench = 135.0f;
            PersonalRecord pr = new PersonalRecord();

            var expectedBench = PersonalRecord.m_bench;
            var actualBench = pr.BenchPR();

            if(actualBench == expectedBench)
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
            PersonalRecord.m_squat = 225.0f;
            PersonalRecord pr = new PersonalRecord();

            var expectedSquat = PersonalRecord.m_squat;
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
            PersonalRecord.m_deadlift = 300.0f;
            PersonalRecord pr = new PersonalRecord();

            var expectedDeadlift = PersonalRecord.m_deadlift;
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


    }
}
