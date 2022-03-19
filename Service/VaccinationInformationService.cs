namespace CovidApp
{
    public class VaccinationInformationService : IVaccinationInformationService
    {
        private readonly IVaccinationInformationRepository _vaccinationInformationRepository;

        public VaccinationInformationService(IVaccinationInformationRepository vaccinationInformationRepository)
        {
            this._vaccinationInformationRepository = vaccinationInformationRepository;
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