using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfProjetoBd.Models;

namespace WpfProjetoBd
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Password;

            if (email == "admin" && senha == "123")
            {
                Usuario admin = new Usuario("ADM", "admin", "123");

                PaginaPrincipal pagina = new PaginaPrincipal(admin);
                pagina.Show();
                this.Close();
                return;
            }

            foreach (var usuario in Registro.usuarios)
            {
                if (email == usuario.Email && senha == usuario.Senha)
                {
                    PaginaPrincipal pagina = new PaginaPrincipal(usuario);
                    pagina.Show();
                    this.Close();
                    return;
                }
            }

            MessageBox.Show("Email ou senha inválidos!", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void BtnCriarConta_Click(object sender, RoutedEventArgs e)
        {
            Registro telaRegistro = new Registro();

            telaRegistro.Show();

            this.Close();
        }
    }
}
