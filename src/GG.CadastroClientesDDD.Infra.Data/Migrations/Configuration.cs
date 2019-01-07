using GG.CadastroClientesDDD.Infra.Data.Context;
using System.Data.Entity.Migrations;

namespace GG.CadastroClientesDDD.Infra.Data.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<CadastroClientesDDDContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}
