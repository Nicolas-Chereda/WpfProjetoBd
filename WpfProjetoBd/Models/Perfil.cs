using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfProjetoBd.Models;

namespace WpfProjetoBd.Models
{
    public class Perfil
    {
        private static int proximoIdPerfil = 1000;
        public int IdPerfil { get; private set; }
        public int IdUsuario { get; private set; }
        public string NomePerfil { get; private set; }
        
        public string Tipo; //Criança ou normal

        //Relação
        public Usuario Usuario { get; private set; }

        //Construtor
        public Perfil(string nomePerfil, string tipo, Usuario usuario)
        {
            IdPerfil = proximoIdPerfil++;
            NomePerfil = nomePerfil;
            Tipo = tipo;
            Usuario = usuario;
            IdUsuario = usuario.IdUsuario;
        }
    }
}