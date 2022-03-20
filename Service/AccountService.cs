namespace CovidApp
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task Create(Account account)
        {
            var createdAccount = await _accountRepository.FindById(account.Id);
            if(createdAccount is not null)
                throw new Exception("Böyle bir kullanıcı zaten var");
            await _accountRepository.Create(account);
        }

        public async Task Delete(int id)
        {
            var deletedAccount = await _accountRepository.FindById(id);
            if(deletedAccount is null)
                throw new Exception("Böyle bir kullanıcı bulunamadı");
            await _accountRepository.Delete(deletedAccount);
        }

        public async Task<Account> FindById(int id)
        {
            return await _accountRepository.FindById(id);
        }

        public async Task<Account> FindByPhoneNumber(string phoneNumber)
        {
            return await _accountRepository.FindByPhoneNumber(phoneNumber);
        }

        public async Task<List<Account>> GetAll()
        {
            return await _accountRepository.GetAll();
        }

        public async Task<List<Account>> GetAllByBlocked(bool isBlocked)
        {
            return await _accountRepository.GetAllByBlocked(isBlocked);
        }

        public async Task<List<Account>> GetAllByVisibility(bool isVisible)
        {
            return await _accountRepository.GetAllByVisibility(isVisible);
        }

        public async Task Update(Account account)
        {
            var updatedAccount = await _accountRepository.FindById(account.Id);
            if(updatedAccount is null)
                throw new Exception("Böyle bir kullanıcı bulunamadı");
            await _accountRepository.Update(account);
        }

        public async Task UpdatePhoneNumber(string oldPhoneNumber, string newPhoneNumber)
        {
            var updatedAccount = await _accountRepository.FindByPhoneNumber(oldPhoneNumber);
            if(updatedAccount is null)
                throw new Exception("Bu telefon numarası ile kayıtlı kullanıcı bulunamadı.");
            updatedAccount.PhoneNumber=newPhoneNumber;
            await _accountRepository.Update(updatedAccount);
        }

        public async Task ChangeIsBlockedById(int id)
        {
            var account = await _accountRepository.FindById(id);
            if(account is null)
                throw new Exception("Böyle bir kullanıcı bulunamadı.");
            account.Blocked = !account.Blocked;
            await _accountRepository.Update(account);
        }

        public async Task ChangeVisibilityById(int id)
        {
            var account = await _accountRepository.FindById(id);
            if(account is null)
                throw new Exception("Böyle bir kullanıcı bulunamadı.");
            account.IsVisibility = !account.IsVisibility;
            await _accountRepository.Update(account);
        }
    }

}