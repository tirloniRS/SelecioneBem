namespace SelecioneBem.Models
{
    public class Competencia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public ICollection<Pergunta> Perguntas = new List<Pergunta>();

        public Competencia()
        {
        }

        public Competencia(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }
    }
}
