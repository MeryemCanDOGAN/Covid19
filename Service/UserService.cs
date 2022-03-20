namespace CovidApp
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<int> CoronaCount()
        {
            var coronas =  await _userRepository.GetAllByIsCorona(true);
            return coronas.Count();
        }

        public async Task<int> CoronaCountByCity(int plateCode)
        {
            var coronas =  await _userRepository.GetAllByCityPlateCodeAndIsCorona(plateCode,true);
            return coronas.Count();
        }

        public async Task Create(User user)
        {
            var createdUser = await _userRepository.FindById(user.Id);
            if(createdUser is not null)
                throw new Exception("Böyle bir kullanıcı mevcut.");
            await _userRepository.Create(user);
        }

        public async Task Delete(User user)
        {
            var deletedUser = await _userRepository.FindById(user.Id);
            if(deletedUser is null)
                throw new Exception("Böyle bir kullanıcı mevcut değil.");
            await _userRepository.Delete(user);
        }

        public async Task<User> FindById(int id)
        {
            return await _userRepository.FindById(id);
        }

        public async Task<List<User>> GetAll()
        {
            return await _userRepository.GetAll();
        }

        public async Task<List<User>> GetAllUserByCityFromPlateCode(int plateCode)
        {
            return await _userRepository.GetAllUserByCityFromPlateCode(plateCode);
        }

        public async Task<List<User>> GetAllByCityPlateCodeAndIsCorona(int plateCode, bool isCorona)
        {
            return await _userRepository.GetAllByCityPlateCodeAndIsCorona(plateCode,isCorona);
        }

        public async Task<List<User>> GetAllByIsCorona(bool isCorona)
        {
            return await _userRepository.GetAllByIsCorona(isCorona);
        }

        public async Task Update(User user)
        {
            var updatedUser = await _userRepository.FindById(user.Id);
            if(updatedUser is null)
                throw new Exception("Böyle bir kullanıcı mevcut değil.");
            await _userRepository.Update(user);
        }
    }

}