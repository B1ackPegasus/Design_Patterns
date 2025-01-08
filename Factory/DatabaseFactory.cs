namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType databaseType)
        {
            switch (databaseType)
            {
                case DatabaseType.Oracle:
                    return new OracleDatabase();
                case DatabaseType.SqlServer:
                    return new SqlServerDatabase();
                default:
                    throw new ArgumentException("Unsupported database type!");
            }
        }
    }
}
