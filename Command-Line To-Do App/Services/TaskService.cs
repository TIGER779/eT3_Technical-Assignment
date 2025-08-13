using System.Text.Json;
using Command_Line_To_Do_App.Models;

namespace Command_Line_To_Do_App.Services
{
    public class TaskService
    {
        private readonly string _filePath;
        public List<TaskItem> Tasks { get; private set; } = new();

        public TaskService(string filePath)
        {
            _filePath = filePath;
            Load();
        }

        public void AddTask(TaskItem task)
        {
            Tasks.Add(task);
            Save();
        }

        public void DeleteTask(int index)
        {
            if (index < 0 || index >= Tasks.Count) throw new ArgumentOutOfRangeException();
            Tasks.RemoveAt(index);
            Save();
        }

        public void UpdateTaskStatus(int index, bool isDone)
        {
            if (index < 0 || index >= Tasks.Count) throw new ArgumentOutOfRangeException();
            Tasks[index].IsDone = isDone;
            Save();
        }

        public List<TaskItem> FilterTasks(string? priority, string? tag)
        {
            return Tasks.Where(t =>
                (priority == null || t.Priority == priority) &&
                (tag == null || t.Tag == tag)
            ).ToList();
        }

        private void Load()
        {
            if (File.Exists(_filePath))
            {
                string json = File.ReadAllText(_filePath);
                Tasks = JsonSerializer.Deserialize<List<TaskItem>>(json) ?? new List<TaskItem>();
            }
        }

        private void Save()
        {
            string json = JsonSerializer.Serialize(Tasks, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}
