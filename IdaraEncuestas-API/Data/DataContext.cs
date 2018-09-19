using IdaraEncuestas_API.Models;
using Microsoft.EntityFrameworkCore;

namespace IdaraEncuestas_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Pregunta> Preguntas { get; set; }
        public DbSet<Respuesta> Respuestas { get; set; }
        public DbSet<User> Usuarios { get; set; }
        public DbSet<Photo> Fotos { get; set; }
    }
}