namespace SelecioneBem.Models
{
    public class Vaga
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Area { get; set; }
        public string Gestor { get; set; }
        public DateTime dt_abertura { get; set; }
        public DateTime dt_encerramento { get; set; }
        public ICollection<Candidato> Candidatos = new List<Candidato>();
    }
}
