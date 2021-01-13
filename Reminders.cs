using System;
using System.IO;
using System.Collections.Generic;
/* Using Newtonsoft to be able to serialize and deserialize JSON */
using Newtonsoft.Json;

namespace APPLICATIONS
{
    /* Class Program */
    class Reminder
    {
        /* Method set to public for the Program-class to have access to it */
        public void ReminderList()
        {

            /* Where the reminders are stored in a JSON-file */
            string jsonPath = @"posts.json";
            var jsonData = System.IO.File.ReadAllText(jsonPath);
            /* Deserialize JSON */
            var reminderList = JsonConvert.DeserializeObject<List<Create>>(jsonData)
            ?? new List<Create>();

            /* Check if the file exists */
            if (File.Exists(jsonPath))
            {
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Reminders:");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                /* Reminders starts on index 1 */
                int indexValue = 1;
                foreach (var post in reminderList)
                {
                    /* Print index-value and reminders to console and loop for every reminder available */
                
                    Console.WriteLine($"({indexValue}) {post.YourReminder}");
                    indexValue++;
                }
            };
                    /* Creates a reminder */
                    var reminders = new Create();

                    reminders.CreateReminder( out string Post);

                    reminderList.Add(new Create()
                    {
                        YourReminder = Post,
                    });
                    /* Serialize JSON */
                    jsonData = JsonConvert.SerializeObject(reminderList);
                    File.WriteAllText(jsonPath, jsonData);
                    /* Check if file exists */
                    if (File.Exists(jsonPath))
                    {
                    Console.Clear();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Reminders:");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                        int indexValue = 1;
                        foreach (var reminder in reminderList)
                        {
                            /* Print index-value and reminder to console */
                        
                            Console.WriteLine($"({indexValue}) {reminder.YourReminder}");
                            indexValue++;
                }

            }
        }
    }
}