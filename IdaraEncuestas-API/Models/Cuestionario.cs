using System.Collections.Generic;

namespace IdaraEncuestas_API.Models
{
    public class Cuestionario
    {
        public int Id { get; set; }
        public int PreguntaId { get; set; }
        public string Nombre { get; set; }
    }
}