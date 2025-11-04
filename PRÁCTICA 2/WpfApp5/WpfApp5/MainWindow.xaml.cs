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

namespace WpfApp5
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

        private void TextBoxEntrada_SelectionChanged(object sender, RoutedEventArgs e)
        {
            string textoSeleccionado = TextBoxEntrada.SelectedText;

            if (string.IsNullOrEmpty(textoSeleccionado))
            {
                TextBoxMonitor.Text = "No has seleccionado nada...";
            } else
            {
                TextBoxMonitor.Text = "Has seleccionado: " + textoSeleccionado;
            }
        }
    }
}