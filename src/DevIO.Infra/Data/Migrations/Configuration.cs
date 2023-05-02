using DevIO.Infra.Data.Context;
using System.Data.Entity.Migrations;

namespace DevIO.Infra.Migrations
{
    
    internal sealed class Configuration : DbMigrationsConfiguration<MeuAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}
