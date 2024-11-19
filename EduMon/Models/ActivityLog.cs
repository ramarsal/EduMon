namespace EduMon.Models
{
    public class ActivityLog
    {
        public int LogId { get; set; }
        public DateTime Timestamp { get; set; }
        public required string ActivityDescription { get; set; }
        public decimal CpuUsage { get; set; }
        public decimal NetworkUsage { get; set; }
        public decimal MemoryUsage { get; set; }

        public int ComputerId { get; set; }
        public required Computer Computer { get; set; }
    }
}
