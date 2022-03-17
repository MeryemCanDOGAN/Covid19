namespace CovidApp 
{
    public class Account
    {
        public int Id { get; set; } 
        public string? PhoneNumber { get; set; }
        public bool IsVisibility { get; set; }
        public bool Blocked { get; set; }
    }
}