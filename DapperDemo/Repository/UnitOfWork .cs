namespace DapperDemo.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        public ICustomerRepository Customers { get; }


        public UnitOfWork(ICustomerRepository customers)
        {
            Customers = customers;
        }
    }
}
