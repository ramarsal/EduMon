namespace EduMon.Models
{
    public class Computer
    {
        public int ComputerId { get; set; }
        public required string IpAddress { get; set; }
        public required string Status { get; set; }
        public decimal CpuUsage { get; set; }
        public decimal NetworkUsage { get; set; }
        public decimal MemoryUsage { get; set; }
        public required string LabLocation { get; set; }

        public ICollection<ActivityLog> ActivityLogs { get; set; } = new List<ActivityLog>();
        public ICollection<Alert> Alerts { get; set; } = new List<Alert>();
    }
}
