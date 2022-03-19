namespace CovidApp
{
    public class VaccinationInformationRepository : IVaccinationInformationRepository
    {
        private readonly CovidAppDbContext _context;

        public VaccinationInformationRepository(CovidAppDbContext context)
        {
            this._context = context;
        }

        public Task<VaccinationInformation> Create(VaccinationInformation vaccination)
        {
            throw new NotImplementedException();
        }

        public Task Delete(VaccinationInformation vaccination)
        {
            throw new NotImplementedException();
        }

        public Task<List<VaccinationInformation>> GetAllVaccinationInformation()
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetUsersByVaccinationInformationName(VaccinationName vaccinationName)
        {
            throw new NotImplementedException();
        }

        public Task<List<VaccinationInformation>> GetUserVaccinationInformationByUserId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<VaccinationInformation> GetVaccinationInformationById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<VaccinationInformation> Update(VaccinationInformation vaccination)
        {
            throw new NotImplementedException();
        }
    }

}