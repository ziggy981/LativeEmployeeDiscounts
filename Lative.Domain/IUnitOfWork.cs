using Lative.Domain.Entities;
using Lative.Domain.Repositories.Base;

namespace Lative.Domain
{
    public interface IUnitOfWork
    {
        IRepository<Employee> Employees { get; }
    }
}
