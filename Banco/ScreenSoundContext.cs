using Microsoft.EntityFrameworkCore;
using CadastroDeClientesEFCore.Modelos;
using System.Collections.Generic;

namespace CadastroDeClientesEFCore.Banco
{
    public class ScreenSoundContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        private string connectionString = "Data Source=clientes.db"; // Usando SQLite

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
