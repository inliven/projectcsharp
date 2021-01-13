using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace APPLICATIONS
{
    /* Class Delete */
    public class Delete
    {
        /* Public method for deleting reminders */
        public void DeleteReminder()
        {
            /* Clear console */
            Console.Clear();
            var deleteValue = true;
            /* Do */
            do
            {
                /* Ask user to choose a reminder to delete from posts.json-file */
                Console.WriteLine("Choose a reminder to delete:  ");
                string jsonPath = @"posts.json";
                var jsonData = System.IO.File.ReadAllText(jsonPath);
                /* Deserialize JSON */
                var reminderList = JsonConvert.DeserializeObject<List<Create>>(jsonData)
                ?? new List<Create>();
                /* Check if JSON-file exists */
                if (File.Exists(jsonPath))
                {
                    Console.WriteLine(" ");
                    int indexValue = 1;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Reminders:");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    foreach (var reminder in reminderList)
                    {
                        /* Print index-value and reminders to console */
                        Console.WriteLine($"({indexValue}) {reminder.YourReminder}");
                        indexValue++;
                    }
                };
                /* Try / Catch */
                try
                {
                    /* Convert to Int32 */
                    int delIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                    /* Deserialize JSON */
                    reminderList = JsonConvert.DeserializeObject<List<Create>>(jsonData)
                    ?? new List<Create>();
                    /* Use built-in method RemoveAt */
                    reminderList.RemoveAt(delIndex);
                    /* Serialize JSON */
                    jsonData = JsonConvert.SerializeObject(reminderList);
                    File.WriteAllText(jsonPath, jsonData);
                    deleteValue = false;
                }
                /* If the format is wrong */
                catch (FormatException)
                {
                    /* Prints a red error message */
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Wrong input");
                    deleteValue = true;
                }
                catch (ArgumentOutOfRangeException)
                {
                    /* Prints a red error message */
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input");
                    deleteValue = true;
                }
            } while (deleteValue);
        }
    }
}