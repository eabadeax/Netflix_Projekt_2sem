namespace Netflix_Projekt_2sem
{
    public class User
    {
        public int UserId { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string PasswordHash { get; set; }

        public bool isAdmin { get; set; }

        public User(int userId, string email, string username, string passwordHash, bool isAdmin)
        {
            UserId = userId;
            Email = email;
            Username = username;
            PasswordHash = passwordHash;
            this.isAdmin = isAdmin;
        }
    } 
}