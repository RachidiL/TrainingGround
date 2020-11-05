using ConsoleUI.Models;
using ConsoleUI.WithGenerics;
using ConsoleUI.WithoutGenerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<int> ages = new List<int>();
            Console.ReadLine();

            DemostrateTextFileStorage();

            Console.WriteLine();
            Console.WriteLine("Press enter to shut down...");
            Console.ReadLine();
        }

        private static void DemostrateTextFileStorage()
        {
            List<Person> people = new List<Person>();
            List<LogEntry> logs = new List<LogEntry>();
            var peopleFil = @"D:\dev\TrainingGround\Advanced topics in C#\TestData\people.csv";
            var logFile = @"D:\dev\TrainingGround\Advanced topics in C#\TestData\logs.csv";

            PopulateLists(people, logs);

            /*** new way of doing thingd - generics ***/
            GenericTextFileProcessor.SaveToTextFile<Person>(people, peopleFil);

            GenericTextFileProcessor.SaveToTextFile<LogEntry>(logs, logFile);

            var newPeople = GenericTextFileProcessor.LoadFromTextFile<Person>(peopleFil);

            foreach (var p in newPeople)
            {
                Console.WriteLine($"{p.FirstName} {p.LastName} (IsAlive = {p.IsAlive})");
            }

            var newLogs = GenericTextFileProcessor.LoadFromTextFile<LogEntry>(logFile);

            foreach (var log in newLogs)
            {
                Console.WriteLine($"{log.ErrorCode} {log.Message} at {log.TimeOfEvent.ToShortTimeString()}");
            }
            /*#############################################################*/
            /*** old way of doing thingd - non-generics ***/

            //OriginalTextFileProcessor.SaveLogs(logs, logFile);

            //var newLogs = OriginalTextFileProcessor.LoadLogs(logFile);

            //foreach (var log in newLogs)
            //{
            //    Console.WriteLine($"{log.ErrorCode} {log.Message} at {log.TimeOfEvent.ToShortTimeString()}");
            //}

            //OriginalTextFileProcessor.SavePeople(people, peopleFil);

            //var newPeople = OriginalTextFileProcessor.LoadPeople(peopleFil);

            //foreach (var p in newPeople)
            //{
            //    Console.WriteLine($"{p.FirstName} {p.LastName} (IsAlive = {p.IsAlive})");
            //}
            /*#############################################################*/
        }

        private static void PopulateLists(List<Person> people, List<LogEntry> logs)
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Johnson" });
            people.Add(new Person { FirstName = "Manfred", LastName = "Klaus" });
            people.Add(new Person { FirstName = "Henriete", LastName = "Duenger" });

            logs.Add(new LogEntry { Message = "I blew up", ErrorCode = 9999});
            logs.Add(new LogEntry { Message = "I'm to awesome", ErrorCode = 1337});
            logs.Add(new LogEntry { Message = "I was tired", ErrorCode = 2222});
        }
    }
}
