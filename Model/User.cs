namespace CovidApp
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }    
        public Gender Gender { get; set; }
        public DateOnly Birthdate { get; set; }
        public virtual ICollection<Passport>? Passports { get; set; }
    }
}