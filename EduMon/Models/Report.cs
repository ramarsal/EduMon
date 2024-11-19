namespace EduMon.Models
{
    public class Report
    {
        public int ReportId { get; set; }
        public DateTime Timestamp { get; set; }
        public required string ReportType { get; set; }

        public int UserId { get; set; }
        public required User User { get; set; }
    }
}
