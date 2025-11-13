using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfProjetoBd.Models;

namespace WpfProjetoBd
{
    public partial class CardFilme : UserControl
    {
        public event Action<Trailer> TrailerHover; // evento que será chamado quando o mouse estiver sobre um filme

        public CardFilme()
        {
            InitializeComponent();
        }

        private void Trailer_MouseEnter(object sender, MouseEventArgs e)
        {
            if (sender is FrameworkElement fe && fe.DataContext is Trailer trailer)
            {
                TrailerHover?.Invoke(trailer); // dispara o evento
            }
        }

        private void Avancar_Click(object sender, RoutedEventArgs e)
        { 
             scroll.ScrollToHorizontalOffset(scroll.HorizontalOffset + 206); // 200 + margem  
        }

        private void Voltar_Click(object sender, RoutedEventArgs e)
        {
             scroll.ScrollToHorizontalOffset(scroll.HorizontalOffset - 206);
        }

    }
}
