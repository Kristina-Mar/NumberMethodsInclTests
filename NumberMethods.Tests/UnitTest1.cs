namespace NumberMethods.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestReturnLowestNumber()
        {
            Methods numberMethods = new Methods();
            int[] numbers = { 1, 5, 8, 7, 98, 35, 25, 4, 11, 15, 58, 56, 32 };
            numberMethods.ReturnLowestNumber(numbers);
            Assert.Equal(1, numberMethods.LowestNumber);

            int[] numbers2 = { 2, 2, 4 };
            numberMethods.ReturnLowestNumber(numbers2);
            Assert.Equal(2, numberMethods.LowestNumber);
        }
        [Fact]
        public void TestReturnHighestNumber()
        {
            Methods numberMethods = new Methods();
            int[] numbers = { 1, 5, 8, 7, 98, 35, 25, 4, 11, 15, 58, 56, 32 };
            numberMethods.ReturnHighestNumber(numbers);
            Assert.Equal(98, numberMethods.HighestNumber);

            int[] numbers2 = { 2, 2, 4 };
            numberMethods.ReturnHighestNumber(numbers2);
            Assert.Equal(4, numberMethods.HighestNumber);
        }
        [Fact]
        public void TestReturnAverage()
        {
            Methods numberMethods = new Methods();
            int[] numbers = { 1, 5, 8, 7, 98, 35, 25, 4, 11, 15, 58, 56, 32 };
            numberMethods.ReturnAverage(numbers);
            Assert.Equal(27.31, numberMethods.Average);

            int[] numbers2 = { 2, 2, 4 };
            numberMethods.ReturnAverage(numbers2);
            Assert.Equal(2.67, numberMethods.Average);
        }
    }
}