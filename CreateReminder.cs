using System;

namespace APPLICATIONS
{
    /* Class Create */
    public class Create
    {
        /*  Get and set */
        public string YourReminder { get; set; }

        /* Method CreateReminder */
        public void CreateReminder(out string Reminder)
        {

            /* Do: Let user write a reminder */
            do
            {
                Console.WriteLine();
                Console.WriteLine("Write a reminder: ");
                /* Read user input and store in posts */
                Reminder = Console.ReadLine();
                /* While: The string is empty */
            } while (string.IsNullOrEmpty(Reminder));
        }
    }
}