using Command_Line_To_Do_App.Commands;
using Command_Line_To_Do_App.Models;
using Command_Line_To_Do_App.Storage;

namespace Command_Line_To_Do_App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load tasks once program start
            List<TaskItem> tasks = TaskStorage.LoadTasks();

            if (args.Length == 0)
            {
                HelpCommand.ShowHelp();
                return;
            }

            string command = args[0].ToLower();
            string[] commandArgs = args.Length > 1 ? args[1..] : Array.Empty<string>();

            switch (command)
            {
                case "add":
                    AddCommand.Execute(tasks, commandArgs);
                    break;

                case "list":
                    ListCommand.Execute(tasks, commandArgs);
                    break;

                case "done":
                    DoneCommand.Execute(tasks, commandArgs);
                    break;

                case "delete":
                    DeleteCommand.Execute(tasks, commandArgs);
                    break;

                case "help":
                    HelpCommand.ShowHelp();
                    break;

                default:
                    Console.WriteLine($"Unknown command: {command}");
                    HelpCommand.ShowHelp();
                    break;
            }

            // Save tasks
            TaskStorage.SaveTasks(tasks);
        }
    }
}
