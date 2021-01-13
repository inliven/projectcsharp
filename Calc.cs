using System;


namespace APPLICATIONS
{
    /* Class Calc */
    class Calc
    {
        /* Public method Calcu */
        public void Calcu()
        {
/* End app set to false */
bool endApplication = false;
/* Display title and change color to red */
Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("--- CONSOLE CALCULATOR ---");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Gray;
/* While the app is running (is not chosen to end) */
while (!endApplication)
{
    /* Set variables to empty */
    string numberInput1 = "";
    string numberInput2 = "";
    double result = 0;

   /* Ask user to write a number and press enter */
    Console.Write("Type a number and press Enter: ");
    /* Read user input */
    numberInput1 = Console.ReadLine();
    /* Double is set to 0 */
    double cleanNum1 = 0;
    /* while the value is not a double */
    while (!double.TryParse(numberInput1, out cleanNum1))
    {
        /* Error message: enter integer value*/
        Console.Write("Invalid input. Please enter an integer value: ");
        /* Read user input */
        numberInput1 = Console.ReadLine();
    }
    /* Ask user to write another number */
    Console.Write("Type another number and press Enter: ");
    /* Read user input */
    numberInput2 = Console.ReadLine();
    /* Double is set to 0 */
    double cleanNum2 = 0;
    while (!double.TryParse(numberInput2, out cleanNum2))
    {
        /* Ask user to write an integer value */
        Console.Write("Invalid input. Please enter an integer value: ");
        /* Read user input */
        numberInput2 = Console.ReadLine();
    }
                /* Ask user to choose an operator */
    Console.WriteLine();
    Console.WriteLine("Choose an operator:");
    Console.WriteLine("\ta - Add");
    Console.WriteLine("\ts - Subtract");
    Console.WriteLine("\tm - Multiply");
    Console.WriteLine("\td - Divide");
    Console.Write("Your option: ");
    /* Read user input */
    string op = Console.ReadLine();
    /* Try / Catch */
    try
    {
        /* If the input is not 0, perform operation */
        result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
        if (double.IsNaN(result))
        {
            Console.WriteLine("This operation will result in a mathematical error.\n");
        }
        /* Result */
        else
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Your result: {0:0.##}\n", result);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    catch (Exception e)
    {
        Console.WriteLine("An exception occurred.\n - Details: " + e.Message);
    }

    /* Ask user if he or she wants to continue or not */
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
    Console.ForegroundColor = ConsoleColor.Gray;
    /* If user input is n, close the app */
    if (Console.ReadLine() == "n") endApplication = true;
    Console.WriteLine("\n");
            }
        }
    }
}
    