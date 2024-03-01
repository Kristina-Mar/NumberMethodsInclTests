namespace NumberMethods.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 5, 8, 7, 98, 35, 25, 4, 11, 15, 58, 56, 32 }, 1)]
        [InlineData(new int[] { 2, 2, 4 }, 2)]
        public void TestReturnLowestNumber(int[] numbers, double result)
        {
            Methods numberMethods = new Methods();
            numberMethods.ReturnLowestNumber(numbers);
            Assert.Equal(result, numberMethods.LowestNumber);
        }
        [Theory]
        [InlineData(new int[] { 1, 5, 8, 7, 98, 35, 25, 4, 11, 15, 58, 56, 32 }, 98)]
        [InlineData(new int[] { 2, 2, 4 }, 4)]
        public void TestReturnHighestNumber(int[] numbers, double result)
        {
            Methods numberMethods = new Methods();
            numberMethods.ReturnHighestNumber(numbers);
            Assert.Equal(result, numberMethods.HighestNumber);
        }
        [Theory]
        [InlineData(new int[] { 1, 5, 8, 7, 98, 35, 25, 4, 11, 15, 58, 56, 32 }, 27.31)]
        [InlineData(new int[] { 2, 2, 4 }, 2.67)]
        public void TestReturnAverage(int[] numbers, double result)
        {
            Methods numberMethods = new Methods();
            numberMethods.ReturnAverage(numbers);
            Assert.Equal(result, numberMethods.Average);
        }
    }
}