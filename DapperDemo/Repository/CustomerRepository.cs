using Dapper.Data;
using DapperDemo.Entity;

namespace DapperDemo.Repository
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly ISqlDataAccess _db;
        public CustomerRepository(ISqlDataAccess db)
        {
            _db = db;
        }



        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer?> Get(int id)
        {
            var results = await _db.LoadData<Customer, dynamic>("dbo.spCustomer_Get", new { Id = id });
            return results.FirstOrDefault();
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _db.LoadData<Customer, dynamic>("dbo.spCustomer_GetAll", new { });

        }

        public async Task Insert(Customer entity)
        {
            var results = await _db.LoadData<Customer, dynamic>("dbo.spCustomer_Insert", new { entity.FirstName, entity.LastName, entity.Age });
            var x = results.FirstOrDefault();

        }

        public Task Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
