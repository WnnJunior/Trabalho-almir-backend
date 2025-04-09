using Microsoft.EntityFrameworkCore;

namespace TrabalhoCarros.Model
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Carro> Carros { get; set; }
    }
}
