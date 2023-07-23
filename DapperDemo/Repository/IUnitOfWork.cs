namespace DapperDemo.Repository
{
    public interface IUnitOfWork
    {
        ICustomerRepository Customers { get; }
    }
}
