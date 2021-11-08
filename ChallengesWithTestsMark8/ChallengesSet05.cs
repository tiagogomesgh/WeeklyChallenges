using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int output = ((startNumber / n) + 1) * n;
            return output;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var b in businesses)
            {
                if (b.TotalRevenue == 0)
                    b.Name = "CLOSED";
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            return numbers == numbers.ToList().Skip(1).OrderBy(x => x).ToArray();
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;

            var result = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    result += numbers[i];
                }
            }

            return result;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
                return new double[] { };
            return elements.Where(x => x % 4 == 0).Select(x => x).ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                        return true;
                }
            }
            return false;
        }
    }
}
