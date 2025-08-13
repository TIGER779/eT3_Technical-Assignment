using Command_Line_To_Do_App.Models;

namespace Command_Line_To_Do_App.Commands
{
    public static class ListCommand
    {
        public static void Execute(List<TaskItem> tasks, string[] args)
        {
            string? filterPriority = null;
            string? filterTag = null;

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "--priority" && i + 1 < args.Length)
                    filterPriority = args[i + 1].ToLower();

                if (args[i] == "--tag" && i + 1 < args.Length)
                    filterTag = args[i + 1];
            }

            var filteredTasks = tasks.Where(t =>
                (filterPriority == null || t.Priority == filterPriority) &&
                (filterTag == null || t.Tag == filterTag)
            ).ToList();

            if (filteredTasks.Count == 0)
            {
                Console.WriteLine("No tasks found.");
                return;
            }

            // Display the tasks with colored boxes
            string doneSign = "✔";
            string notDoneSign = "✘";
            int boxWidth = 5; // fixed width for the colored box

            for (int i = 0; i < filteredTasks.Count; i++)
            {
                var task = filteredTasks[i];
                Console.Write($"[{i + 1}]. {task.Description} (Priority: {task.Priority}, Tag: {task.Tag}, Created: {task.CreatedAt:g}) ");

                if (task.IsDone)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(doneSign.PadLeft((boxWidth + doneSign.Length) / 2).PadRight(boxWidth));
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(notDoneSign.PadLeft((boxWidth + notDoneSign.Length) / 2).PadRight(boxWidth));
                }

                Console.ResetColor();
                Console.WriteLine();
            }

        }
    }
}
