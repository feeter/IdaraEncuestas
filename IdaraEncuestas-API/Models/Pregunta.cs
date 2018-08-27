namespace IdaraEncuestas_API.Models
{
    public class Pregunta
    {
        public int Id { get; set; }
        public int CuestionarioId { get; set; }
        public string Texto { get; set; }
        public bool ConOpciones { get; set; }
        public string Tipo { get; set; }
    }
}