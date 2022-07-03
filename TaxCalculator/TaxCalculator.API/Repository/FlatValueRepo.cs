using TaxCalculator.API.Models;

namespace TaxCalculator.API.Repository
{
    public class FlatValueRepo : IRepository<FlatValue, int>
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FlatValue>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<FlatValue> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<FlatValue> Insert(FlatValue entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(FlatValue entity)
        {
            throw new NotImplementedException();
        }
    }
}
