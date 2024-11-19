namespace EduMon.Models
{
    public class Alert
    {
        public int AlertId { get; set; }
        public required string AlertType { get; set; }
        public DateTime Timestamp { get; set; }
        public bool ResolvedStatus { get; set; }

        public int ComputerId { get; set; }
        public required Computer Computer { get; set; }
    }
}
