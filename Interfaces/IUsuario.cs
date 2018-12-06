using Projeto_Carfel_Web.Models;

namespace Projeto_Carfel_Web.Interfaces
{
    public interface IUsuario
    {
        UsuarioModel Cadastrar(UsuarioModel usuario);
        UsuarioModel BuscarPorEmailESenha(string email,string senha);
    }
}