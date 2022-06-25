using APIMonitoramento.Models;
using Microsoft.EntityFrameworkCore;

namespace APIMonitoramento.Contexts
{
    public class ProjetoContext:DbContext

    {
        public ProjetoContext()
        {
        }
        public ProjetoContext(DbContextOptions<ProjetoContext> options) : base(options)
        {
        }

        //Conexão com o Banco de Dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
              
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-SFQMDA8\\SQLEXPRESS; initial catalog = Monitoramento; Integrated Security = true");
            }
        }
       
        public DbSet<Projetos> Projetos { get; set; }

    }
}