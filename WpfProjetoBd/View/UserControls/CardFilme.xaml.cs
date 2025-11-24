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
    /// Interação lógica para CardFilme.xam
    /// </summary>
    public partial class CardFilme : UserControl
    {
        public event Action<Trailer> TrailerHover;
        public event Action<Trailer> TrailerClick;

        public CardFilme()
        {
            InitializeComponent();
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            if (DataContext is Trailer t)
                TrailerHover?.Invoke(t);
        }

        private void Card_MouseClick(object sender, MouseButtonEventArgs e)
        {
            if (DataContext is Trailer t)
            {
                TrailerClick?.Invoke(t);
            }
        }

        private void BordaHover_MouseEnter(object sender, MouseEventArgs e)
        {
            BordaHover.BorderThickness = new Thickness(2);
            BordaHover.BorderBrush = Brushes.White;
        }

        private void BordaHover_MouseLeave(object sender, MouseEventArgs e)
        {
            BordaHover.BorderThickness = new Thickness(0);
            BordaHover.BorderBrush = Brushes.Transparent;
        }
    }
}

