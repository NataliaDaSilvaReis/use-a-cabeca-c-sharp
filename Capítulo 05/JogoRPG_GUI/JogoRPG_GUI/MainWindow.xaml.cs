using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JogoRPG_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random random = new Random();
        DanoDeEspada danoDeEspada = new DanoDeEspada();

        public MainWindow()
        {

            InitializeComponent();
            danoDeEspada.DefinirMagia(false);
            danoDeEspada.DefinirFlamejante(false);
            RolarDado();

        }

        public void RolarDado()
        {

            danoDeEspada.Rolar = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
            danoDeEspada.DefinirFlamejante(flamejante.IsChecked.Value);
            danoDeEspada.DefinirMagia(magico.IsChecked.Value);

            MostrarDano();

        }

        void MostrarDano()
        {

            dano.Text = $"Rolou {danoDeEspada.Rolar} por {danoDeEspada.Dano} HP";

        }

        private void Click_Botao(object sender, RoutedEventArgs e)
        {

            RolarDado();

        }

        private void Flamejante_Marcado(object sender, RoutedEventArgs e)
        {

            danoDeEspada.DefinirFlamejante(true);
            MostrarDano();

        }

        private void Flamejante_Desmarcado(object sender, RoutedEventArgs e)
        {

            danoDeEspada.DefinirFlamejante(false);
            MostrarDano();

        }

        private void Magico_Marcado(object sender, RoutedEventArgs e)
        {

            danoDeEspada.DefinirMagia(true);
            MostrarDano();

        }

        private void Magico_Desmarcado(object sender, RoutedEventArgs e)
        {

            danoDeEspada.DefinirMagia(false);
            MostrarDano();

        }
    }
}