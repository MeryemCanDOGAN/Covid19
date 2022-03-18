namespace CovidApp
{public class AccountService:IAccountService
{
       private readonly CovidAppDbContext _context;
        public AccountService(CovidAppDbContext context)
        {
            _context = context;
        }
}
    
}