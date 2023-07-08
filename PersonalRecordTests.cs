namespace Fitness
{
    public class PersonalRecordTests
    {
        static void Main(string[] args)
        {
            BenchPR_ReturnExpected();
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
    }
}
