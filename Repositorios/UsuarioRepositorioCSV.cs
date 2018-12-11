using System.Collections.Generic;
using System.IO;
using Projeto_Carfel_Web.Interfaces;
using Projeto_Carfel_Web.Models;

namespace Projeto_Carfel_Web.Repositorios {
    public class UsuarioRepositorioCSV : IUsuario {

        #region Cadastrar usuario
        public UsuarioModel Cadastrar (UsuarioModel usuario) {
            if (File.Exists ("usuarios.csv")) {
                usuario.ID = System.IO.File.ReadAllLines ("usuarios.csv").Length + 1;
            } else {
                usuario.ID = 1;
            }

            if (usuario.Nome == "Administrador" && usuario.Email == "admin@carfel.com" && usuario.Senha == "Admin") {
                usuario.Administrador = true;
            } else {
                usuario.Administrador = false;
            }

            using (StreamWriter sw = new StreamWriter ("usuarios.csv", true)) {
                sw.WriteLine ($"{usuario.ID};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.Administrador}");
            }
            return usuario;
        }
        #endregion

        #region carrega do csv
        private List<UsuarioModel> CarregarDoCSV () {
            List<UsuarioModel> lsUsuarios = new List<UsuarioModel> ();

            //abre stream de leitura de arquivo
            string[] linhas = File.ReadAllLines ("usuarios.csv");

            //le cada registro no CSV
            foreach (string linha in linhas) {
                //verifica se a linha esta vazia
                if (string.IsNullOrEmpty (linha)) {
                    continue; //pula para o proximo registro do laço
                }

                //separa dados da linha
                string[] dadosDaLinha = linha.Split (";");

                //cria os objetos com os dados da linha do CSV
                UsuarioModel usuario = new UsuarioModel (
                    id: int.Parse (dadosDaLinha[0]),
                    nome: dadosDaLinha[1],
                    email: dadosDaLinha[2],
                    senha: dadosDaLinha[3]
                );

                //adiciona usuario na lista
                lsUsuarios.Add (usuario);
            }
            return lsUsuarios;
        }
        #endregion

        #region Busca por email e senha
        public UsuarioModel BuscarPorEmailESenha (string email, string senha) {
            List<UsuarioModel> usuariosCadastrados = CarregarDoCSV ();

            foreach (UsuarioModel usuario in usuariosCadastrados) {
                if (usuario.Email == email && usuario.Senha == senha) {
                    return usuario;
                }
            }
            return null;
        }
        #endregion

    }
}