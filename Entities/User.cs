namespace AuthenticationLogin.Entities
{
    public class User
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string  Email { get; set; }
        public string Password { get; set; }
    }
}
