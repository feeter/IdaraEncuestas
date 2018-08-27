namespace IdaraEncuestas_API.Models
{
    public class Respuesta
    {
        public int Id { get; set; }
        public int PreguntaId { get; set; }
        public string Texto { get; set; }

        public Pregunta Preunta { get; set; }
    }
}