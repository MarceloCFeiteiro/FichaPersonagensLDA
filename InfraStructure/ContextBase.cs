using System.Data.SqlClient;

namespace InfraStructure
{
    public abstract class ContextBase
    {
        private readonly string _connectionString;

        public ContextBase()
        {
            this._connectionString = "";
        }

        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(this._connectionString);
        }
    }
}