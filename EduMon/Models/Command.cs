namespace EduMon.Models
{
    public class Command
    {
        public int CommandId { get; set; }
        public required string CommandType { get; set; }
        public DateTime Timestamp { get; set; }

        public int IssueBy { get; set; }
        public required User User { get; set; }
    }
}
