namespace CSharpTest
{
    class Test
    {
        // Task 1
        public static int SumDigits(int num)
        {
            int sum = 0;
            while (num > 9)
            {
                int tempNum = num;
                sum = 0;
                while (tempNum > 0)
                {
                    sum += tempNum % 10;
                    tempNum /= 10;
                }
                num = sum;
            }
            return sum;
        }

        // Task 2
        public static Dictionary<string, int> CountCoins(double cents)
        {
            Dictionary<string, int> coins = new()
            {
                {"Quarters", 0 },
                {"Dimes", 0 },
                {"Nickels", 0 },
                {"Pennies", 0 }
            };

            if (cents < 0)
            {
                return coins;
            }

            cents = Math.Floor(cents);
            int coinsSum = 0;

            coins["Quarters"] = (int)(cents / 25);
            coinsSum += coins["Quarters"] * 25;
            coins["Dimes"] = (int)((cents - coinsSum) / 10);
            coinsSum += coins["Dimes"] * 10;
            coins["Nickels"] = (int)((cents - coinsSum) / 5);
            coinsSum += coins["Nickels"] * 5;
            coins["Pennies"] = (int)(cents - coinsSum);

            return coins;
        }

        // Task 3
        public static int MaximizeNumber(int num)
        {
            List<int> digits = new();
            while (num > 0)
            {
                digits.Add(num % 10);
                num /= 10;
            }
            digits = digits.OrderDescending().ToList();
            string resultStr = string.Join("", digits);
            _ = int.TryParse(resultStr, out int result);
            return result;
        }

        // Task 4
        public static int SumTriangleLine(int rowIndex)
        {
            const int diff = 2;
            const int firstNum = 1;

            int lastIdx = 0;

            // Getting index of the last element in row
            for (int i = 1; i <= rowIndex; i++)
            {
                lastIdx += i;
            }

            // Get the value of the last element in row
            int lastNumber = firstNum + (lastIdx - 1) * diff;

            // Sum all elements in row, starting from the last one
            int sum = 0;
            int currentNumber = lastNumber;
            for (int i = 0; i < rowIndex; i++)
            {
                sum += currentNumber;
                currentNumber -= diff;
            }

            return sum;
        }

        // Task 5
        public static int ReturnFiveStrLen => "Five!".Length;

        public static int ReturnFiveBitwiseSubtract => 'F' & ~'A';

        enum Five
        {
            Zero,
            One,
            Two,
            Three,
            Four,
            Five
        };

        public static int ReturnFiveEnum => (int)Five.Five;

        public static void Main()
        {
            Console.WriteLine($"Task 1\n f(942) => {SumDigits(942)}");

            var coins = CountCoins(56);
            string coinsStr = string.Empty;
            foreach (var item in coins)
            {
                coinsStr += $"{item.Key}: {item.Value}, ";
            }
            coinsStr = coinsStr.TrimEnd(',', ' ');
            Console.WriteLine($"Task 2\n f(56) => {coinsStr}");

            Console.WriteLine($"Task 3\n f(42145) => {MaximizeNumber(42145)}");

            Console.WriteLine($"Task 4\n f(2) => {SumTriangleLine(2)}");

            Console.WriteLine($"Task 5" +
                $"\n String length method: {ReturnFiveStrLen}" +
                $"\n Bitwise subtract method: {ReturnFiveStrLen}" +
                $"\n Dummy enum method: {ReturnFiveEnum}");
        }
    }
}