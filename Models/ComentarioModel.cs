using System;

namespace Carfel_Completo.Models {
    public class ComentarioModel {
        public int ID { get; set; }
        public string NomeComentario { get; set; }
        public DateTime DataComentario { get; set; }
        public string TextoComentario { get; set; }
        public bool ComentarioAprovado { get; set; }
        public ComentarioModel (string textoComentario, string nomeComentario, DateTime dataComentario, bool comentarioAprovado) //cadastro comentario
        {
            this.TextoComentario = textoComentario;
            this.NomeComentario = nomeComentario;
            this.DataComentario = dataComentario;
            this.ComentarioAprovado = comentarioAprovado;
        }
        public ComentarioModel (int id, string textoComentario, string nomeComentario, DateTime dataComentario, bool comentarioAprovado) {
            this.ID = id;
            this.TextoComentario = textoComentario;
            this.NomeComentario = nomeComentario;
            this.DataComentario = dataComentario;
            this.ComentarioAprovado = comentarioAprovado;
        }

    }

}