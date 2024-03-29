﻿using System.Data.SqlClient;

namespace InfraStructure
{
    public abstract class ContextBase
    {
        private readonly string _connectionString;

        public ContextBase()
        {
            this._connectionString = "Data Source =.\\SQLEXPRESS; Initial Catalog = SISTEMA_LDAP; Integrated Security = True";
        }

        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(this._connectionString);
        }
    }
}