using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Providers;
using System.Data.SqlClient;
using Chat.Models;

namespace Chat.Migrations
{
    public class Settings : DbMigrationContext<JabbrContext>
    {
        public Settings()
        {
            AutomaticMigrationsEnabled = false;
            SetCodeGenerator<CSharpMigrationCodeGenerator>();
            AddSqlGenerator<SqlConnection, SqlServerMigrationSqlGenerator>();
        }
    }
}
