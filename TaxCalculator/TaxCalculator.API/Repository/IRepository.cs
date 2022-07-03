namespace TaxCalculator.API.Repository
{
    public interface IRepository<T1,T2> where T1 :class
    {
        Task<IEnumerable<T1>> Get();
        Task<T1> Get(int id);
        Task<T1> Insert(T1 entity);
        Task Update(T1 entity);
        Task Delete(int id);
    }
}
