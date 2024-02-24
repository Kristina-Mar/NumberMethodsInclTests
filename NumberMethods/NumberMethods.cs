namespace NumberMethods
{
    public class NumberMethods
    {
        public int LowestNumber = 0;
        public int HighestNumber = 0;
        public double Average;
        public int ReturnLowestNumber(int[] numbers)
        {
            LowestNumber = numbers[0]; // This is so that the lowest number doesn't remain 0.
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < LowestNumber)
                {
                    LowestNumber = numbers[i];
                }
            }
            return LowestNumber;
        }
        public int ReturnHighestNumber(int[] numbers)
        {
            HighestNumber = numbers[0]; // This is so that the highest number doesn't remain 0.
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > HighestNumber)
                {
                    HighestNumber = numbers[i];
                }
            }
            return HighestNumber;
        }
        public double ReturnAverage(int[] numbers)
        {
            double Sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Sum += numbers[i];
            }
            Average = Math.Round(Sum / numbers.Length, 2);
            return Average;
        }
    }
}
