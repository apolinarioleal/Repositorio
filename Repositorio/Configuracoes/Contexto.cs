using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Configuracoes
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opcoesBuilder)
        {
            if (!opcoesBuilder.IsConfigured)
            {
                opcoesBuilder.UseSqlServer("Data Source=DESKTOP-M0VREFH\\BUSINESSSERVER;Initial Catalog=REPOSITORIO;Integrated Security=False;User ID=sa;Password=1234;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            }

        }

    }
}
