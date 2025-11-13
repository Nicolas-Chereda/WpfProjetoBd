using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProjetoBd.Models
{
    public class Mensagem
    {
        private static int proximoIdMensagem = 1000;
        public int IdMensagem { get; private set; }
        public int IdRemetente { get; private set; }
        public int IdDestinatario { get; private set; }
        public string Texto { get; private set; }
        public DateTime DataEnvio { get; private set; }

        //Relações
        public Usuario Remetente { get; private set; }
        public Usuario Destinatario { get; private set; }

        //Construtor
        public Mensagem(Usuario remetente, Usuario destinatario, string texto)
        {
            IdMensagem = proximoIdMensagem++;
            Remetente = remetente;
            Destinatario = destinatario;
            Texto = texto;
            DataEnvio = DateTime.Now;

            IdRemetente = remetente.IdUsuario;
            IdDestinatario = destinatario.IdUsuario;
        }
    }

}
