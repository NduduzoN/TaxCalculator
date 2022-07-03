using TaxCalculator.API.Models;

namespace TaxCalculator.API.Repository
{
    public class ProgressiveTaxRepo : IRepository<ProgressiveTax, int>
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProgressiveTax>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<ProgressiveTax> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProgressiveTax> Insert(ProgressiveTax entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(ProgressiveTax entity)
        {
            throw new NotImplementedException();
        }
    }
}
