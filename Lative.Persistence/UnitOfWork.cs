using Lative.Domain;
using Lative.Domain.Entities;
using Lative.Domain.Repositories.Base;
using Lative.Persistence.Repositories;
using System;

namespace Lative.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<Employee> Employees { get; }

        public UnitOfWork(string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
                throw new Exception("Missing ConnectionString");

            Employees = new EmployeeRepository(connectionString);
        }
    }
}
