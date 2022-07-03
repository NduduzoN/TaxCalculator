using TaxCalculator.API.Models;

namespace TaxCalculator.API.Repository
{
    public class CalculationLogRepo : IRepository<CalculationLog, int>
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CalculationLog>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<CalculationLog> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CalculationLog> Insert(CalculationLog entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(CalculationLog entity)
        {
            throw new NotImplementedException();
        }
    }
}
