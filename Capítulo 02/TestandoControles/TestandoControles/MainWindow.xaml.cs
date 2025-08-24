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

namespace TestandoControles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void numeroTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            numero.Text = numeroTextBox.Text;
        }

        private void numeroTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out int result);
        }

        private void pequenoSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            numero.Text = pequenoSlider.Value.ToString("0");
        }

        private void grandeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            numero.Text = grandeSlider.Value.ToString("000-0000-0000");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                numero.Text = radioButton.Content.ToString();
            }
        }

        private void minhaListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (minhaListBox.SelectedItem is ListBoxItem listBoxItem)
            {
                numero.Text = listBoxItem.Content.ToString();
            }
        }

        private void somenteLeituraComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (somenteLeituraComboBox.SelectedItem is ListBoxItem listBoxItem)
            {
                numero.Text = listBoxItem.Content.ToString();
            }
        }

        private void editavelComboBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                numero.Text = comboBox.Text;
            }
        }
    }
}