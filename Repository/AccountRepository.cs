namespace CovidApp
{
    public class AccountRepository:IAccountRepository
    {
        private readonly CovidAppDbContext _context;
        public AccountRepository(CovidAppDbContext context)
        {
            _context = context;
        }

    }
}