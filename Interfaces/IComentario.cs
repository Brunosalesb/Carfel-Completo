using System.Collections.Generic;
using Carfel_Completo.Models;

namespace Carfel_Completo_master.Interfaces
{
    public interface IComentario
    {
        ComentarioModel CadastrarComentario(ComentarioModel comentario);
         List<ComentarioModel> ListarCSV(string usuarioLogado);
        void Aprovar(int id);

    }
}