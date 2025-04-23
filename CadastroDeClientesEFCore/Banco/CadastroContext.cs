using Microsoft.EntityFrameworkCore;
using CadastroDeClientesEFCore.Modelos;

namespace CadastroDeClientesEFCore.Banco
{
    public class CadastroContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        private string connectionString = "Data Source= (localdb)\\MSSQLLocalDB;Initial Catalog=CadastroV0;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"; // Usando SQLite

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}