namespace Command_Line_To_Do_App.Models
{
    public class TaskItem
    {
        public string Description { get; set; } = "";
        public bool IsDone { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Priority { get; set; } = "medium"; // Default priority
        public string Tag { get; set; } = "";
    }
}
