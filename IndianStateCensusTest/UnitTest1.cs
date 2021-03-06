using IndianState_Census_Analyzer_Problem;
using IndianStateCensusAnalyzerProblem;
using NUnit.Framework;

namespace IndianStateCensusTest
{
    [TestFixture]
    public class CountTest
    {
        [Test]
        public static void Total_Count_Of_Number()
        {
            Iteration obj1 = new Iteration();
            int result = obj1.NumberOfCount();
            Assert.AreEqual(30, result);
        }
        [Test]
        public static void Total_Count_Of_Number_Fail()
        {
            Iteration obj1 = new Iteration();
            int result = obj1.NumberOfCount();
            Assert.AreEqual(3, result);
        }
        [Test]
        public static void Total_Count_Of_Number_Fail_String()
        {
            Iteration obj1 = new Iteration();
            int result = obj1.NumberOfCount();
            Assert.AreEqual("a", result);
        }
        [Test]
        public void State_Census_Exception()
        {
            try
            {
                Iteration obj1 = new Iteration();
                obj1.CsvReader();
            }
            catch (ExceptionHandle e)
            {
                Assert.AreEqual(ExceptionHandle.ExceptionType.CENSUS_FILE_PROBLEM, e.type);
            }
        }
        [Test]
        public void State_Census_Exception_Null()
        {
            try
            {
                Iteration obj1 = new Iteration();
                obj1.CsvReader();
            }
            catch (ExceptionHandle e)
            {
                Assert.AreEqual(ExceptionHandle.ExceptionType.NO_SUCH_FEILD, e.type);
            }
        }
        [Test]
        public static void Total_Count_Of_Number_StateCode()
        {
            Iteration2 obj2 = new Iteration2();
            int result = obj2.NumberOfCountState();
            Assert.AreEqual(38, result);
        }
    }
}