namespace Command_Line_To_Do_App.Commands
{
    public static class HelpCommand
    {
        public static void ShowHelp()
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("  add <description> [--priority <low|medium|high>] [--tag <tag>]");
            Console.WriteLine("  list [--priority <low|medium|high>] [--tag <tag>]");
            Console.WriteLine("  done <task-number>");
            Console.WriteLine("  delete <task-number>");
            Console.WriteLine("  help");
            Console.WriteLine();
            Console.WriteLine("Examples:");
            Console.WriteLine("  add \"Buy milk\" --priority high --tag home");
            Console.WriteLine("  list --priority high");
            Console.WriteLine("  done 2");
            Console.WriteLine("  delete 3");
        }
    }
}
