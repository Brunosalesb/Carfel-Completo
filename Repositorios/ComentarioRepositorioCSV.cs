using System;
using System.Collections.Generic;
using System.IO;
using Carfel_Completo.Models;
using Carfel_Completo_master.Interfaces;

namespace Carfel_Completo_master.Repositorios {
    public class ComentarioRepositorioCSV : IComentario {
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

        public List<ComentarioModel> ListarCSV (string usuarioLogado) {
            List<ComentarioModel> lsComentarios = new List<ComentarioModel> ();

            string[] linhas = File.ReadAllLines ("comentarios.csv");

            foreach (string linha in linhas) {
                string[] dadosDaLinha = linha.Split (";");
                if (string.IsNullOrEmpty (linha)) {
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
    }
}