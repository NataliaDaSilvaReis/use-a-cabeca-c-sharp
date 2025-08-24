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

namespace JogoDeCombinar
{
    using System.Windows.Threading;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        int decimosDeSegundosDecorridos;
        int correspondenciasEncontradas;
        int melhorTempo = int.MaxValue;
        List<string> emojisAnimais = new List<string>(16);


        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(.1);
            timer.Tick += Timer_Tick;
            ConfigurarJogo();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            decimosDeSegundosDecorridos++;
            tempoTextBlock.Text = (decimosDeSegundosDecorridos / 10F).ToString("0.0s");

            if (correspondenciasEncontradas == 8)
            {
                timer.Stop();

                if (decimosDeSegundosDecorridos < melhorTempo)
                {
                    melhorTempo = decimosDeSegundosDecorridos;
                    melhorTempoTextBlock.Text = "Melhor tempo: " + (melhorTempo / 10F).ToString("0.0s");
                }

                tempoTextBlock.Text = tempoTextBlock.Text + " - Jogar de novo?";
            }
        }

        private void ConfigurarJogo()
        {
            List<string> listaEmojisAnimais = new List<string>()
            {
                "🦒", "🦝",
                "🐭", "🐘",
                "🦕", "🐋",
                "🦜", "🐓",
                "🦑", "🦁",
                "🐯", "🐰",
                "🐻", "🐼",
                "🐸", "🐍",
                "🐊", "🦖",
                "🐢", "🐬",
                "🦈", "🦭",
            };


            Random random = new Random();

            for (int i = 0; i < 8; i++)
            {
                int index = random.Next(listaEmojisAnimais.Count);
                emojisAnimais.Add(listaEmojisAnimais[index]);
                emojisAnimais.Add(listaEmojisAnimais[index]);
                listaEmojisAnimais.RemoveAt(index);
            }

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                if (textBlock.Name != "tempoTextBlock" && textBlock.Name != "melhorTempoTextBlock")
                {
                    int index = random.Next(emojisAnimais.Count);
                    string proximoEmoji = emojisAnimais[index];
                    textBlock.Text = proximoEmoji;
                    textBlock.Visibility = Visibility.Visible;
                    emojisAnimais.RemoveAt(index);
                }
            }

            timer.Start();
            decimosDeSegundosDecorridos = 0;
            correspondenciasEncontradas = 0;
        }

        /*
         * Se for o primeiro no par sendo clicado, veja qual TextBlock foi clicado e 
         * faça o animal desaparecer.
         * Se for o segundo, faça-o desaparecer (se combinar) ou 
         * retorne o primeiro (se não combinar).
         */
        TextBlock ultimoTextBlockClicado;
        bool correspondencia = false;

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;

            if (correspondencia == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                ultimoTextBlockClicado = textBlock;
                correspondencia = true;
            }
            else if (textBlock.Text == ultimoTextBlockClicado.Text)
            {
                correspondenciasEncontradas++;
                textBlock.Visibility = Visibility.Hidden;
                correspondencia = false;
            }
            else
            {
                ultimoTextBlockClicado.Visibility = Visibility.Visible;
                correspondencia = false;
            }
        }

        private void TempoTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (correspondenciasEncontradas == 8)
            {
                ConfigurarJogo();
            }
        }
    }
}