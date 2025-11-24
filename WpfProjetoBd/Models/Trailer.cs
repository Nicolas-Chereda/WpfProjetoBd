using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProjetoBd.Models
{
    public class Trailer
    {
        private static int proximoIdTrailer = 1000;
        public int IdTrailer { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public string Capa {  get; private set; }
        public string TrailerUrl { get; private set; }
        public decimal AvaliacaoMedia { get; private set; }
        public string AvaliacaoTexto { get; private set; }
        public string Categoria { get; private set; }

        //Construtor
        public Trailer(string titulo, string capa, string categoria, string descricao)
        {
            IdTrailer = proximoIdTrailer++;
            Titulo = titulo;
            Capa = capa;
            Descricao = descricao;
            Categoria = categoria;
        }

        // Atualizar a avaliação
        public void AtualizarAvaliacao(decimal media, string texto)
        {
            AvaliacaoMedia = media;
            AvaliacaoTexto = texto;
        }
    }

}
