using Command_Line_To_Do_App.Models;

namespace Command_Line_To_Do_App.Commands
{
    public static class AddCommand
    {
        public static void Execute(List<TaskItem> tasks, string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a task description.");
                return;
            }

            string priority = "medium";
            string tag = "";

            List<string> descParts = new List<string>();

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "--priority" && i + 1 < args.Length)
                {
                    priority = args[i + 1].ToLower();
                    i++; 
                }
                else if (args[i] == "--tag" && i + 1 < args.Length)
                {
                    tag = args[i + 1];
                    i++;
                }
                else
                {
                    descParts.Add(args[i]);
                }
            }

            string description = string.Join(" ", descParts);

            tasks.Add(new TaskItem
            {
                Description = description,
                IsDone = false,
                CreatedAt = DateTime.Now,
                Priority = priority,
                Tag = tag
            });

            Console.WriteLine($"Added: {description} (Priority: {priority}, Tag: {tag})");
        }
    }
}
