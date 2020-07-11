using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode
{
    class Refactoring
    {
        /// <summary>
        /// đổi tên biến và tách hằng
        /// </summary>
        const char ADDITION = '+';
        const char SUBTRACTION = '-';
        const char MULTIPLICATION = '*';
        const char DIVISION = '/';
        public static int Calculate(int firstOperand, int secondOperand, char mathOperator)
        {
            switch (mathOperator)
            {
                case ADDITION:
                    return firstOperand + secondOperand;
                case SUBTRACTION:
                    return firstOperand - secondOperand;
                case MULTIPLICATION:
                    return firstOperand * secondOperand;
                case DIVISION:
                    if (secondOperand != 0)
                        return firstOperand / secondOperand;
                    else
                        throw new Exception("Can not divide by 0");
                default:
                    throw new Exception("Unsupported operation");
            }
        }
        /// <summary>
        /// tách biến
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static String FizzBuzz(int number)
        {
            bool isFizz = number % 3 == 0;
            bool isBuzz = number % 5 == 0;
            if (isFizz && isBuzz)
                return "FizzBuzz";

            if (isFizz)
                return "Fizz";

            if (isBuzz)
                return "Buzz";

            return number + "";
        }





    }
}
