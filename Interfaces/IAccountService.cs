namespace CovidApp
{
    public interface IAccountService
    {
        Task Create(Account account);
        Task Update(Account account);
        Task Delete(int id);
        Task<List<Account>> GetAll();
        Task<List<Account>> GetAllByBlocked(bool isBlocked);
        Task<List<Account>> GetAllByVisibility(bool isVisible);
        Task<Account> FindByPhoneNumberAsync(string phoneNumber);
        Task<Account> FindById(int id);
        Task UpdatePhoneNumber(string oldPhoneNumber, string newPhoneNumber);
        Task ChangeVisibilityById(int id);
        Task ChangeIsBlockedById(int id);
    }
}