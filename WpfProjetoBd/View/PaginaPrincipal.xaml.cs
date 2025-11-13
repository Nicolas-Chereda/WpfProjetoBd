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

            var trailers = new List<Trailer>
                {
                    new Trailer { Titulo = "Gato de Botas", Capa = "https://www.casadosquadrinhos.com.br/wp-content/uploads/2023/03/imagem-destacada-A.png", Categoria = "Ação", Descricao="Em Gato de Botas 2: O Último Pedido, O Gato de Botas descobre que sua paixão pela aventura cobrou seu preço: por conta de seu gosto pelo perigo e pelo desrespeito à segurança pessoal, ele queimou oito de suas nove vidas. Com apenas uma vida restante, o Gato precisa pedir ajuda para uma antiga parceira - que atualmente é sua rival e inimiga mortal, Kitty Pata Mansa - para continuar vivo. Então, o destemido bichano parte em uma jornada épica pela Floresta Negra para encontrar a mítica Estrela dos Desejos, capaz de proporcionar o legendário Último Desejo e restaurar suas nove vidas." },
                    new Trailer { Titulo = "Toy Story", Capa = "https://disney.images.edge.bamgrid.com/ripcut-delivery/v2/variant/disney/518292de-1782-47c0-a96e-bd903a73d466/compose?aspectRatio=1.78&format=webp&width=1200", Categoria = "Drama", Descricao = "O aniversário do garoto Andy está chegando e seus brinquedos ficam nervosos, temendo que ele ganhe novos brinquedos que possam substituí-los. Liderados pelo caubói Woody, o brinquedo predileto de Andy, eles recebem Buzz Lightyear, o boneco de um patrulheiro espacial, que logo passa a receber mais atenção do garoto. Com ciúmes, Woody tenta ensiná-lo uma lição, mas Buzz cai pela janela. É o início da aventura do caubói, que precisa resgatar Buzz para limpar sua barra com os outros brinquedos." },
                    new Trailer { Titulo = "Gato de Botas", Capa = "https://www.casadosquadrinhos.com.br/wp-content/uploads/2023/03/imagem-destacada-A.png", Categoria = "Ação", Descricao="Em Gato de Botas 2: O Último Pedido, O Gato de Botas descobre que sua paixão pela aventura cobrou seu preço: por conta de seu gosto pelo perigo e pelo desrespeito à segurança pessoal, ele queimou oito de suas nove vidas. Com apenas uma vida restante, o Gato precisa pedir ajuda para uma antiga parceira - que atualmente é sua rival e inimiga mortal, Kitty Pata Mansa - para continuar vivo. Então, o destemido bichano parte em uma jornada épica pela Floresta Negra para encontrar a mítica Estrela dos Desejos, capaz de proporcionar o legendário Último Desejo e restaurar suas nove vidas." },
                    new Trailer { Titulo = "Toy Story", Capa = "https://disney.images.edge.bamgrid.com/ripcut-delivery/v2/variant/disney/518292de-1782-47c0-a96e-bd903a73d466/compose?aspectRatio=1.78&format=webp&width=1200", Categoria = "Drama", Descricao = "O aniversário do garoto Andy está chegando e seus brinquedos ficam nervosos, temendo que ele ganhe novos brinquedos que possam substituí-los. Liderados pelo caubói Woody, o brinquedo predileto de Andy, eles recebem Buzz Lightyear, o boneco de um patrulheiro espacial, que logo passa a receber mais atenção do garoto. Com ciúmes, Woody tenta ensiná-lo uma lição, mas Buzz cai pela janela. É o início da aventura do caubói, que precisa resgatar Buzz para limpar sua barra com os outros brinquedos." },
                    new Trailer { Titulo = "Gato de Botas", Capa = "https://www.casadosquadrinhos.com.br/wp-content/uploads/2023/03/imagem-destacada-A.png", Categoria = "Ação", Descricao="Em Gato de Botas 2: O Último Pedido, O Gato de Botas descobre que sua paixão pela aventura cobrou seu preço: por conta de seu gosto pelo perigo e pelo desrespeito à segurança pessoal, ele queimou oito de suas nove vidas. Com apenas uma vida restante, o Gato precisa pedir ajuda para uma antiga parceira - que atualmente é sua rival e inimiga mortal, Kitty Pata Mansa - para continuar vivo. Então, o destemido bichano parte em uma jornada épica pela Floresta Negra para encontrar a mítica Estrela dos Desejos, capaz de proporcionar o legendário Último Desejo e restaurar suas nove vidas." },
                    new Trailer { Titulo = "Toy Story", Capa = "https://disney.images.edge.bamgrid.com/ripcut-delivery/v2/variant/disney/518292de-1782-47c0-a96e-bd903a73d466/compose?aspectRatio=1.78&format=webp&width=1200", Categoria = "Drama", Descricao = "O aniversário do garoto Andy está chegando e seus brinquedos ficam nervosos, temendo que ele ganhe novos brinquedos que possam substituí-los. Liderados pelo caubói Woody, o brinquedo predileto de Andy, eles recebem Buzz Lightyear, o boneco de um patrulheiro espacial, que logo passa a receber mais atenção do garoto. Com ciúmes, Woody tenta ensiná-lo uma lição, mas Buzz cai pela janela. É o início da aventura do caubói, que precisa resgatar Buzz para limpar sua barra com os outros brinquedos." },
                    new Trailer { Titulo = "Gato de Botas", Capa = "https://www.casadosquadrinhos.com.br/wp-content/uploads/2023/03/imagem-destacada-A.png", Categoria = "Ação", Descricao="Em Gato de Botas 2: O Último Pedido, O Gato de Botas descobre que sua paixão pela aventura cobrou seu preço: por conta de seu gosto pelo perigo e pelo desrespeito à segurança pessoal, ele queimou oito de suas nove vidas. Com apenas uma vida restante, o Gato precisa pedir ajuda para uma antiga parceira - que atualmente é sua rival e inimiga mortal, Kitty Pata Mansa - para continuar vivo. Então, o destemido bichano parte em uma jornada épica pela Floresta Negra para encontrar a mítica Estrela dos Desejos, capaz de proporcionar o legendário Último Desejo e restaurar suas nove vidas." },
                    new Trailer { Titulo = "Toy Story", Capa = "https://disney.images.edge.bamgrid.com/ripcut-delivery/v2/variant/disney/518292de-1782-47c0-a96e-bd903a73d466/compose?aspectRatio=1.78&format=webp&width=1200", Categoria = "Drama", Descricao = "O aniversário do garoto Andy está chegando e seus brinquedos ficam nervosos, temendo que ele ganhe novos brinquedos que possam substituí-los. Liderados pelo caubói Woody, o brinquedo predileto de Andy, eles recebem Buzz Lightyear, o boneco de um patrulheiro espacial, que logo passa a receber mais atenção do garoto. Com ciúmes, Woody tenta ensiná-lo uma lição, mas Buzz cai pela janela. É o início da aventura do caubói, que precisa resgatar Buzz para limpar sua barra com os outros brinquedos." },
                    new Trailer { Titulo = "Gato de Botas", Capa = "https://www.casadosquadrinhos.com.br/wp-content/uploads/2023/03/imagem-destacada-A.png", Categoria = "Ação", Descricao="Em Gato de Botas 2: O Último Pedido, O Gato de Botas descobre que sua paixão pela aventura cobrou seu preço: por conta de seu gosto pelo perigo e pelo desrespeito à segurança pessoal, ele queimou oito de suas nove vidas. Com apenas uma vida restante, o Gato precisa pedir ajuda para uma antiga parceira - que atualmente é sua rival e inimiga mortal, Kitty Pata Mansa - para continuar vivo. Então, o destemido bichano parte em uma jornada épica pela Floresta Negra para encontrar a mítica Estrela dos Desejos, capaz de proporcionar o legendário Último Desejo e restaurar suas nove vidas." },
                    new Trailer { Titulo = "Toy Story", Capa = "https://disney.images.edge.bamgrid.com/ripcut-delivery/v2/variant/disney/518292de-1782-47c0-a96e-bd903a73d466/compose?aspectRatio=1.78&format=webp&width=1200", Categoria = "Drama", Descricao = "O aniversário do garoto Andy está chegando e seus brinquedos ficam nervosos, temendo que ele ganhe novos brinquedos que possam substituí-los. Liderados pelo caubói Woody, o brinquedo predileto de Andy, eles recebem Buzz Lightyear, o boneco de um patrulheiro espacial, que logo passa a receber mais atenção do garoto. Com ciúmes, Woody tenta ensiná-lo uma lição, mas Buzz cai pela janela. É o início da aventura do caubói, que precisa resgatar Buzz para limpar sua barra com os outros brinquedos." },
                    new Trailer { Titulo = "Gato de Botas", Capa = "https://www.casadosquadrinhos.com.br/wp-content/uploads/2023/03/imagem-destacada-A.png", Categoria = "Ação", Descricao="Em Gato de Botas 2: O Último Pedido, O Gato de Botas descobre que sua paixão pela aventura cobrou seu preço: por conta de seu gosto pelo perigo e pelo desrespeito à segurança pessoal, ele queimou oito de suas nove vidas. Com apenas uma vida restante, o Gato precisa pedir ajuda para uma antiga parceira - que atualmente é sua rival e inimiga mortal, Kitty Pata Mansa - para continuar vivo. Então, o destemido bichano parte em uma jornada épica pela Floresta Negra para encontrar a mítica Estrela dos Desejos, capaz de proporcionar o legendário Último Desejo e restaurar suas nove vidas." },
                    new Trailer { Titulo = "Toy Story", Capa = "https://disney.images.edge.bamgrid.com/ripcut-delivery/v2/variant/disney/518292de-1782-47c0-a96e-bd903a73d466/compose?aspectRatio=1.78&format=webp&width=1200", Categoria = "Drama", Descricao = "O aniversário do garoto Andy está chegando e seus brinquedos ficam nervosos, temendo que ele ganhe novos brinquedos que possam substituí-los. Liderados pelo caubói Woody, o brinquedo predileto de Andy, eles recebem Buzz Lightyear, o boneco de um patrulheiro espacial, que logo passa a receber mais atenção do garoto. Com ciúmes, Woody tenta ensiná-lo uma lição, mas Buzz cai pela janela. É o início da aventura do caubói, que precisa resgatar Buzz para limpar sua barra com os outros brinquedos." },
                };

            // Agrupa e cria objetos anônimos (sem precisar da classe Categoria)
            var categorias = trailers
                .GroupBy(t => t.Categoria)
                .Select(g => new { Nome = g.Key, Filmes = g.ToList() })
                .ToList();

            DataContext = categorias;
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

        private void CardFilme_Loaded(object sender, RoutedEventArgs e)
        {
            if (sender is CardFilme card)
            {
                // conecta o evento do user control ao método abaixo
                card.TrailerHover += CardFilme_TrailerHover;
            }
        }

        private void CardFilme_TrailerHover(Trailer trailer)
        {
            // atualiza o banner
            TituloBanner.Text = trailer.Titulo;
            DescricaoBanner.Text = trailer.Descricao;
            ImagemBanner.Source = new BitmapImage(new Uri(trailer.Capa, UriKind.RelativeOrAbsolute));
        }
    }

}
