namespace Projeto_Carfel_Web.Models
{
    public class UsuarioModel
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Administrador { get; set; }

        public UsuarioModel(string nome, string email, string senha)//cadastro
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }
        public UsuarioModel(int id, string nome, string email, string senha)//list usuarios
        {
            this.ID = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }
        public UsuarioModel(string email,string senha)//login
        {
            this.Email = email;
            this.Senha = senha;
        }
    }
}