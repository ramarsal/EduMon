namespace EduMon.Models
{
    public class User
    {
        public int UserId { get; set; }
        public required string UserName { get; set; }
        public required string PasswordHash { get; set; }
        public required string Role {  get; set; }
        public required string Email { get; set; }
        public DateTime? Lastlogin { get; set; }

        public ICollection<Report> Reports { get; set; } = new List<Report>();
        public ICollection<Command> Commands { get; set; } = new List<Command>();
    }
}
