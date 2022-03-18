namespace CovidApp
{
    public class AddressRepository : IAddressRepository
    {
        public Task<Address> CreateAddress(Address address)
        {
            throw new NotImplementedException();
        }

        public Task<City> CreateCity(City city)
        {
            throw new NotImplementedException();
        }

        public Task<District> CreateDistrict(District district)
        {
            throw new NotImplementedException();
        }

        public Task<Address> DeleteAddress(int id)
        {
            throw new NotImplementedException();
        }

        public Task<City> DeleteCity(City city)
        {
            throw new NotImplementedException();
        }

        public Task<District> DeleteDistrict(District district)
        {
            throw new NotImplementedException();
        }

        public Task<City> FindCityByName(string CityName)
        {
            throw new NotImplementedException();
        }

        public Task<District> FindDistrictByName(string DistirctName)
        {
            throw new NotImplementedException();
        }

        public Task<Address> GetAddressById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Address>> GetAllAddress()
        {
            throw new NotImplementedException();
        }

        public Task<List<City>> GetAllCity()
        {
            throw new NotImplementedException();
        }

        public Task<List<District>> GetAllDistrictsByCityId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Address> UpdateAddress(Address address)
        {
            throw new NotImplementedException();
        }
    }

}