using System;

namespace Lative.Persistence.Repositories.Base
{
    public abstract class RepositoryBase
    {
        protected readonly string ConnectionString;

        public RepositoryBase(string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
                throw new Exception("Missing ConnectionString");

            ConnectionString = connectionString;
        }

    }
}
