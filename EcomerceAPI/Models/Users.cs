namespace EcommerceAPI.Models
{
    public class Users
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } = "user";
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string? ProfileImage { get; set; } // Cho phép NULL
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
    }
}