using System.Text.Json;
using Command_Line_To_Do_App.Models;

namespace Command_Line_To_Do_App.Storage
{
    public static class TaskStorage
    {
        private static readonly string filePath = "tasks.json";

        public static List<TaskItem> LoadTasks()
        {
            if (!File.Exists(filePath))
                return new List<TaskItem>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<TaskItem>>(json) ?? new List<TaskItem>();
        }

        public static void SaveTasks(List<TaskItem> tasks)
        {
            string json = JsonSerializer.Serialize(tasks, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(filePath, json);
        }
    }
}
