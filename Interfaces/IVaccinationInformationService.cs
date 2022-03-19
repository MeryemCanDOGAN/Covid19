namespace CovidApp
{
    public interface IVaccinationInformationService
    {
        Task<VaccinationInformation> Create(VaccinationInformation vaccination);
        Task Delete(VaccinationInformation vaccination);
        Task<List<VaccinationInformation>> GetAllVaccinationInformation();
        Task<VaccinationInformation> GetVaccinationInformationById(int id);
        Task<VaccinationInformation> Update(VaccinationInformation vaccination);
        Task<List<User>> GetUsersByVaccinationInformationName(VaccinationName vaccinationName);
        Task<List<VaccinationInformation>> GetUserVaccinationInformationByUserId(int id);
    }
    
}