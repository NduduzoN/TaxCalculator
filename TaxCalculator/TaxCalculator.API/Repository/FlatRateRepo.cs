using TaxCalculator.API.Models;

namespace TaxCalculator.API.Repository
{
    public class FlatRateRepo : IRepository<FlatRate, int>
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FlatRate>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<FlatRate> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<FlatRate> Insert(FlatRate entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(FlatRate entity)
        {
            throw new NotImplementedException();
        }
    }
}
