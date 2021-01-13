using System;


namespace APPLICATIONS
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Menu with different application choices */
            bool appMenu = true;
            while (appMenu)
            {
                appMenu = Menu();
            }
        }
        private static bool Menu()
        {
            /* Print to console */
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--- Applications ---");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ");
            /* Write options for user to choose between */
            Console.WriteLine("Choose an option:");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("[1] Play Rock, Paper and Scissors");
            Console.WriteLine("[2] Calculator");
            Console.WriteLine("[3] Reminders");
            Console.WriteLine(" ");
            Console.WriteLine("[4] Write a reminder");
            Console.WriteLine("[5] Delete a reminder");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[X] Exit");
            Console.ForegroundColor = ConsoleColor.Gray;
        

            /* Switch / Cases */

            /* Read user input */
            switch (Console.ReadLine())
            {
                /* Choice 1: play Rock, Paper and Scissors */
                case "1":
                    var play = new GameOne();
                    play.RPSGame();
                    return true;
                /* Choice 2: Use the calculator */
                case "2":
                var calc = new Calc();
                calc.Calcu();
                    return true;
                /* Choice 3: Read reminders */
                case "3":
                    var reading = new Read();
                    reading.ReadReminder();
                    return true;
                /* Choice 4: Write a reminder */
                case "4":
                    var remind = new Reminder();
                    remind.ReminderList();
                    return true;
                    /* Delete a reminder */
                case "5":
                    var del = new Delete();
                    del.DeleteReminder();
                    return true;
                /* Choice 5: Exit the application */
                case "X":
                    Console.Clear();
                    return false;
                default:
                    return true;
            }
        }
    }
}