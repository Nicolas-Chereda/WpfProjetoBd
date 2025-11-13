using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProjetoBd.Models
{
    public class Amigo
    {
        public int proximoIdAmizade = 1000;
        public int IdAmizade { get; private set; }
        public int IdUsuario { get; private set; }
        public int IdUsuarioAmigo { get; private set; }

        //Relação
        public Usuario Usuario { get; private set; }
        public Usuario UsuarioAmigo { get; private set; }

        //Construtor
        public Amigo(Usuario usuario, Usuario amigo)
        {
            IdAmizade = proximoIdAmizade++;
            Usuario = usuario;
            UsuarioAmigo = amigo;
            IdUsuario = usuario.IdUsuario;
            IdUsuarioAmigo = amigo.IdUsuario;

            usuario.AdicionarAmigo(amigo);
        }
    }

}
