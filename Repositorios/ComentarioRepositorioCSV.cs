using System;
using System.Collections.Generic;
using System.IO;
using Carfel_Completo.Models;
using Carfel_Completo_master.Interfaces;

namespace Carfel_Completo_master.Repositorios {
    public class ComentarioRepositorioCSV : IComentario {

        #region Cadastrar comentario     
        public ComentarioModel CadastrarComentario (ComentarioModel comentario) {
            if (File.Exists ("comentarios.csv")) {
                comentario.ID = System.IO.File.ReadAllLines ("comentarios.csv").Length + 1;
            } else {
                comentario.ID = 1;
            }

            using (StreamWriter sw = new StreamWriter ("comentarios.csv", true)) {
                sw.WriteLine ($"{comentario.ID};{comentario.NomeComentario};{comentario.TextoComentario};{comentario.DataComentario};{comentario.ComentarioAprovado}");
            }
            return comentario;
        }
        #endregion

        #region Listar
        public List<ComentarioModel> ListarCSV (string usuarioLogado) {
            List<ComentarioModel> lsComentarios = new List<ComentarioModel> ();

            string[] linhas = File.ReadAllLines ("comentarios.csv");

                for (int i = linhas.Length - 1; i >= 0; i--)
                {
                string[] dadosDaLinha = linhas[i].Split (";");
                if (string.IsNullOrEmpty (linhas[i])) {
                    continue;
                }
                if (usuarioLogado != "Administrador" && bool.Parse (dadosDaLinha[4]) == false) {
                    continue;
                }

                ComentarioModel comentario = new ComentarioModel (
                    id: int.Parse (dadosDaLinha[0]),
                    nomeComentario: dadosDaLinha[1],
                    textoComentario: dadosDaLinha[2],
                    dataComentario: DateTime.Parse (dadosDaLinha[3]),
                    comentarioAprovado: bool.Parse (dadosDaLinha[4])
                );

                lsComentarios.Add (comentario);
            }
            return lsComentarios;
        }
        #endregion

        #region Aprovar comentario
        public void Aprovar (int id) {
            string[] linhas = File.ReadAllLines ("comentarios.csv");

            for (int i = 0; i < linhas.Length; i++) {
                string[] dadosDaLinha = linhas[i].Split (";");

                if (id.ToString () == dadosDaLinha[0]) {
                    linhas[i] = ($"{dadosDaLinha[0]};{dadosDaLinha[1]};{dadosDaLinha[2]};{dadosDaLinha[3]};{true}");
                    break;
                }
            }
            File.WriteAllLines("comentarios.csv",linhas);
        }
        #endregion

        #region Rejeitar comentario
        public void Rejeitar(int id){
            string[] linhas = File.ReadAllLines("comentarios.csv");

            for (int i = 0; i < linhas.Length; i++)
            {
                string[] dadosDaLinha = linhas[i].Split(";");

                if (id.ToString() == dadosDaLinha[0])
                {
                    linhas[i] = "";
                    break;
                }
            }
            File.WriteAllLines("comentarios.csv",linhas);
        }
        #endregion
    }
}