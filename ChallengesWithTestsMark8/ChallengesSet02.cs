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
            int str1L = str1.Length;
            int str2L = str2.Length;
            if (str1L > str2L)
            {
                return str1L;
            }
            else
            {
                return str2L;
            }
        }

        public int Sum(int[] numbers)
        {
            var sum = numbers.Sum();
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
            int sum = numbers.Sum();
            if (sum % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            if (sum == 0)
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number / 2 == 0)
            {
                return number / 2;

            }
            else
            {
                return 0;
            }
        }
    }
}
