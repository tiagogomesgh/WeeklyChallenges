using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            
            if (Char.IsLetter(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int totalElements = Convert.ToInt32(vals.Count());
            if (totalElements % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
           if (numbers == null || numbers.Count() == 0)
           { 
                
              return 0;
           }
           else
           {
               double max = numbers.Max();
               double min = numbers.Min();
               double sumOfMinandMax = max + min;
                return sumOfMinandMax;
           }
 
        }
                    //^^^^^^^^ 
        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            var sum = 0;
            if (numbers == null)
                return 0;
            else
                foreach (var n in numbers)
                    sum += n;
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int result = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    result+=i;
                }
            }
                return result;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return numbers == null ? false : (numbers.Sum() % 2 != 0);
        }


        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number >= 0 ? number / 2 : 0;
        }
    }
}
