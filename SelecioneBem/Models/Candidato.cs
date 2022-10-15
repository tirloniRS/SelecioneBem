namespace SelecioneBem.Models
{
    public class Candidato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Linkedin { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public ICollection<Vaga> vagas = new List<Vaga>();
        public ICollection<Entrevista> Entrevistas = new List<Entrevista>();

        public Candidato()
        {
        }

        public Candidato(int id, string nome, string celular, string email, string linkedin, string cidade, string estado)
        {
            Id = id;
            Nome = nome;
            Celular = celular;
            Email = email;
            Linkedin = linkedin;
            Cidade = cidade;
            Estado = estado;
        }
    }
}
