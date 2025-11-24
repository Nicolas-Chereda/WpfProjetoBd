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

namespace WpfProjetoBd.View.UserControls
{
    /// <summary>
    /// Interação lógica para ListaDeFilmes.xam
    /// </summary>
    public partial class ListaDeFilmes : UserControl
    {
        public event Action<Trailer> TrailerHover; // evento que será chamado quando o mouse estiver sobre um filme
        public event Action<Trailer> TrailerClick;

        public ListaDeFilmes()
        {
            InitializeComponent();
        }
        private void CardCarregado(object sender, RoutedEventArgs e)
        {
            if (sender is CardFilme card)
            {
                card.TrailerHover += (trailer) =>
                {
                    TrailerHover?.Invoke((Trailer)trailer);
                }; 

                card.TrailerClick += (trailer) =>
                {
                    TrailerClick?.Invoke((Trailer)trailer);
                };
            }
        }

        private void Avancar_Click(object sender, RoutedEventArgs e) { scroll.ScrollToHorizontalOffset(scroll.HorizontalOffset + 206); } // 200 + margem
        private void Voltar_Click(object sender, RoutedEventArgs e) { scroll.ScrollToHorizontalOffset(scroll.HorizontalOffset - 206); }
    }
}
