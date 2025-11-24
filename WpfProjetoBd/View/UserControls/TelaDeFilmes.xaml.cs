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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfProjetoBd.Controllers;
using WpfProjetoBd.Models;

namespace WpfProjetoBd.View.UserControls
{
    /// <summary>
    /// Interação lógica para TelaDeFilmes.xam
    /// </summary>
    public partial class TelaDeFilmes : UserControl
    {

        public event Action<Trailer> TrailerClick;
        public TelaDeFilmes()
        {
            InitializeComponent();

            var controller = new TrailerController();

            DataContext = controller.ObterCategorias();
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (sender is ScrollViewer scroll)
            {
                // move o scroll verticalmente (Delta positivo/negativo)
                scroll.ScrollToVerticalOffset(scroll.VerticalOffset - e.Delta);
                e.Handled = true; // impede propagação para outros scrolls
            }
        }

        private void CardFilme_TrailerHover(Trailer trailer)
        {
            // atualiza o banner
            TituloBanner.Text = trailer.Titulo;
            DescricaoBanner.Text = trailer.Descricao;
            ImagemBanner.Source = new BitmapImage(new Uri(trailer.Capa, UriKind.RelativeOrAbsolute));
        }

        private void Lista_TrailerClick(Trailer trailer)
        {
            TrailerClick?.Invoke(trailer);
        }
    }
}
