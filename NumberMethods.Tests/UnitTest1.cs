namespace NumberMethods.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestReturnLowestNumber()
        {
            NumberMethods numberMethods = new NumberMethods();
            int[] numbers = { 1, 5, 8, 7, 98, 35, 25, 4, 11, 15, 58, 56, 32 };
            numberMethods.ReturnLowestNumber(numbers);
            Assert.Equal(1, numberMethods.LowestNumber);
        }
        [Fact]
        public void TestReturnHighestNumber()
        {
            NumberMethods numberMethods = new NumberMethods();
            int[] numbers = { 1, 5, 8, 7, 98, 35, 25, 4, 11, 15, 58, 56, 32 };
            numberMethods.ReturnHighestNumber(numbers);
            Assert.Equal(98, numberMethods.HighestNumber);
        }
        [Fact]
        public void TestReturnAverage()
        {
            NumberMethods numberMethods = new NumberMethods();
            int[] numbers = { 1, 5, 8, 7, 98, 35, 25, 4, 11, 15, 58, 56, 32 };
            numberMethods.ReturnAverage(numbers);
            Assert.Equal(27.31, numberMethods.Average);
        }
    }
}