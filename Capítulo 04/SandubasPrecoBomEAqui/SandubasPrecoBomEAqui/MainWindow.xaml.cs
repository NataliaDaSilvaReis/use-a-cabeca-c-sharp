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

namespace SandubasPrecoBomEAqui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FacaOMenu();
        }



        private void FacaOMenu()
        {
            ItemDoMenu[] itensDoMenu = new ItemDoMenu[5];
            string precoGuacamole;

            for (int i = 0; i < 5; i++)
            {
                itensDoMenu[i] = new ItemDoMenu();

                if (i >= 3)
                {
                    itensDoMenu[i].paes = new string[] { "bagel simples", "bagel de cebola", "bagel integral", "tudo bagel" };
                }

                itensDoMenu[i].Gerar();

            }

            item1.Text = itensDoMenu[0].descricao;
            preco1.Text = itensDoMenu[0].preco;
            item2.Text = itensDoMenu[1].descricao;
            preco2.Text = itensDoMenu[1].preco;
            item3.Text = itensDoMenu[2].descricao;
            preco3.Text = itensDoMenu[2].preco;
            item4.Text = itensDoMenu[3].descricao;
            preco4.Text = itensDoMenu[3].preco;
            item5.Text = itensDoMenu[4].descricao;
            preco5.Text = itensDoMenu[4].preco;

            ItemDoMenu itemEspecialDoMenu = new ItemDoMenu()
            {
                proteinas = new string[] { "Presunto orgânico", "Hambúrguer de cogumelo", "Mortadela" },
                paes = new string[] { "pãozinho sem glúten", "wrap", "pão pita" },
                condimentos = new string[] { "mostarda dijon", "missô", "au jus" }
            };

            itemEspecialDoMenu.Gerar();

            item6.Text = itemEspecialDoMenu.descricao;
            preco6.Text = itemEspecialDoMenu.preco;

            ItemDoMenu itemDoMenuGuacamole = new ItemDoMenu();
            itemDoMenuGuacamole.Gerar();
            precoGuacamole = itemDoMenuGuacamole.preco;

            guacamole.Text = "Adicione guacamole por: " + itemDoMenuGuacamole.preco;

        }
    }
}