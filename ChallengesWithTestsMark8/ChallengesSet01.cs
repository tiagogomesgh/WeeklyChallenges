using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            var expectedDifference = minuend - subtrahend;
            return expectedDifference;
        }

        public int Add(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
            
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            int[] smallest = { number1, number2 };
            int result = Math.Min(number1, number2);
            return result;
            
        }

        public long Multiply(long factor1, long factor2)
        {
            long result = factor1 * factor2;
            return result;
        }

        public string GetGreeting(string nameOfPerson)
        {

            string name = nameOfPerson;

            var greeting = "Hello, " + name + "!";
            var emptyGreet = "Hello!";

            if (name == "")
            {
                return emptyGreet;
            }
            else
            {
                return greeting;
            }
            

            
        }

        public string GetHey()
        {

            string hey = "HEY!";
                return hey;


        }
    }
}
