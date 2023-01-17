using System.Data;

namespace Microservice.Framework.Sql.Connections
{
    public interface ISqlConnectionFactory
    {
        Task<IDbConnection> OpenConnectionAsync(
            string connectionString,
            CancellationToken cancellationToken);
    }
}
