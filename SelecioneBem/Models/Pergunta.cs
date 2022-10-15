namespace SelecioneBem.Models
{
    public class Pergunta
    {
        public int Id { get; set; }
        public string descricao { get; set; }
        public string Nota { get; set; }
        public Competencia Competencia { get; set; }
        public ICollection<Entrevista> entrevistas = new List<Entrevista>();

        public Pergunta()
        {
        }

        public Pergunta(int id, string descricao, string nota)
        {
            Id = id;
            this.descricao = descricao;
            Nota = nota;
        }
    }
}
