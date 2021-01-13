using System;

namespace APPLICATIONS
{
    /* Class Calculator */
    class Calculator
    {
        /* Double for decimals */
        public static double DoOperation(double num1, double num2, string op)
        {
            /* Deafult: Not a number, used in division */
            double result = double.NaN; 

            /* Switch-case to caluculate the math */
            switch (op)
            {
                /* a for add */
                case "a":
                    result = num1 + num2;
                    break;
                    /* s for substraction */
                case "s":
                    result = num1 - num2;
                    break;
                    /* m for multiplication */
                case "m":
                    result = num1 * num2;
                    break;
                    /* d for division */
                case "d":
                    /* If user writes a non-zero value */
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                /* Return if wrong input */
                default:
                    break;
            }
            /* Or return the result */
            return result;
        }
    }

}
