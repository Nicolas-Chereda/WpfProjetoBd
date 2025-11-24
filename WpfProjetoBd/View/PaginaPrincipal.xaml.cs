using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using WpfProjetoBd.Models;
using WpfProjetoBd.View.UserControls;

namespace WpfProjetoBd
{
    /// <summary>
    /// Lógica interna para MainWindow.xaml
    /// </summary>
    public partial class PaginaPrincipal : Window
    {
        public ObservableCollection<Trailer> Trailers { get; set; }
        public Trailer FilmeSelecionado { get; set; }

        public PaginaPrincipal(Usuario usuario)
        {
            InitializeComponent();

            var telaDeFilmes = new TelaDeFilmes();
            telaDeFilmes.TrailerClick += AbrirDetalhesDoFilme;

            ConteudoPrincipal.Content = telaDeFilmes;
        }

        private void BtnInicio_Click(object sender, RoutedEventArgs e)
        {
            ConteudoPrincipal.Content = new TelaDeFilmes();
        }

        private void BtnAmigos_Click(object sender, RoutedEventArgs e)
        {
            ConteudoPrincipal.Content = new TelaDeFilmes();
        }

        private void AbrirDetalhesDoFilme(Trailer trailer)
        {
            ConteudoPrincipal.Content = new FichaGenéricaFilme(trailer);
        }
    }
}


