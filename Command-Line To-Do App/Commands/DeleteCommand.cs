using Command_Line_To_Do_App.Models;

namespace Command_Line_To_Do_App.Commands
{
    public static class DeleteCommand
    {
        public static void Execute(List<TaskItem> tasks, string[] args)
        {
            if (args.Length == 0 || !int.TryParse(args[0], out int index))
            {
                Console.WriteLine("Please provide a valid task number.");
                return;
            }

            if (index < 1 || index > tasks.Count)
            {
                Console.WriteLine("Invalid task number.");
                return;
            }

            tasks.RemoveAt(index - 1);
            Console.WriteLine($"Deleted task #{index}.");
        }
    }
}
