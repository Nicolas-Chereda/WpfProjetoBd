using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProjetoBd.Models
{
    public class Usuario
    {
        private static int proximoIdUsuario = 1000;
        public int IdUsuario { get; private set; }
        public string Email {get; private set; }
        public string Senha { get; private set; }
        public string NomeUsuario { get; private set; }

        // Relacionamentos
        public List<Perfil> Perfis { get; private set; } = new List<Perfil>();
        public List<Usuario> Amigos { get; private set; } = new List<Usuario>();

        // Construtor
        public Usuario(string nome, string email, string senha)
        {
            IdUsuario = proximoIdUsuario++;
            NomeUsuario = nome;
            Email = email;
            Senha = senha;
        }

        // Adicionar Perfis e Friends
        public void AdicionarPerfil(Perfil perfil)
        {
            Perfis.Add(perfil);
        }

        public void AdicionarAmigo(Usuario amigo)
        {
            Amigos.Add(amigo);
        }
    }
}
