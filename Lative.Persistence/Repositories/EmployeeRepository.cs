using Dapper;
using Lative.Domain.Entities;
using Lative.Domain.Repositories;
using Lative.Persistence.Repositories.Base;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Lative.Persistence.Repositories
{
    public class EmployeeRepository : RepositoryBase, IEmployeeRepository
    {
        public EmployeeRepository(string connectionString) : base(connectionString)
        {
        }


        public virtual Task<Employee> GetByIdAsync(int id)
        {
            return Task.Run(() => new Employee() { Id = id, StartDate = new DateTime(2021, 4, 26), EmployeeTypeId = 1 });

            //using (var connection = new SqlConnection(ConnectionString))
            //{
            //    return connection.QuerySingleOrDefaultAsync<Employee>("SELECT * FROM Employees WHERE id = @Id", new { id });
            //}
        }

        public virtual Task<Employee> AddAsync(Employee entity)
        {
            // Implement code to Insert into DB here...

            return GetByIdAsync(entity.Id);
        }

        public virtual Task<Employee> UpdateAsync(Employee entity)
        {
            // Implement code to Update record in DB here...

            return GetByIdAsync(entity.Id);
        }

        public virtual Task DeleteAsync(Employee entity)
        {
            // Implement code to Delete record in DB here...

            return Task.Run(() => { /* Code here... */ });
        }
    }
}
