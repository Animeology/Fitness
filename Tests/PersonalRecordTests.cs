namespace Fitness.Tests
{
    using PersonalRecord;

    public class PersonalRecordTests
    {
        public void AllPRTests()
        {
            BenchPR_ReturnExpected();
            SquatPR_ReturnExpected();
            DeadliftPR_ReturnExpected();
            TotalPR_ReturnExpected();
        }

        void BenchPR_ReturnExpected()
        {
            float expectedBench = 135.0f;
            PersonalRecord pr = new PersonalRecord();

            pr.m_bench = expectedBench;
            var actualBench = pr.BenchPR();

            if (actualBench != expectedBench)
            {
                throw new Exception("BenchPR returns the incorrect output");
            }            
        }

        void SquatPR_ReturnExpected()
        {
            float expectedSquat = 225.0f;
            PersonalRecord pr = new PersonalRecord();

            pr.m_squat = expectedSquat;
            var actualSquat = pr.SquatPR();

            if (actualSquat != expectedSquat)
            {
                throw new Exception("SquatPR returns the incorrect output");
            }
        }

        void DeadliftPR_ReturnExpected()
        {
            float expectedDeadlift = 300.0f;
            PersonalRecord pr = new PersonalRecord();
            
            pr.m_deadlift = expectedDeadlift;
            var actualDeadlift = pr.DeadliftPR();

            if (actualDeadlift != expectedDeadlift)
            {
                throw new Exception("DeadliftPR returns the incorrect output");
            }
        }

        void TotalPR_ReturnExpected()
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

            if (actualTotal != expectedTotal)
            {
                throw new Exception("TotalPR returns the incorrect output");
            }
        }
    }
}
