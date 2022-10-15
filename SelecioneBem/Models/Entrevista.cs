namespace SelecioneBem.Models
{
    public class Entrevista
    {
        public int Id { get; set; }
        public DateTime dt_inicio { get; set; }
        public DateTime dt_fim { get; set; }
        public ICollection<Pergunta> Perguntas = new List<Pergunta>();
        public Candidato Candidato { get; set; }

        public Entrevista()
        {
        }

        public Entrevista(int id, DateTime dt_inicio, DateTime dt_fim)
        {
            Id = id;
            this.dt_inicio = dt_inicio;
            this.dt_fim = dt_fim;
        }
    }
}
