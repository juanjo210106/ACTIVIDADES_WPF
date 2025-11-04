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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int intentos = 0;
        private int maxIntentos = 2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (intentos >= maxIntentos)
            {
                MessageBox.Show("Ya no te quedan intentos.", "LIMITE ALCANZADO");
                return;
            }

            intentos++;

            if (oVerdadera.IsChecked == true)
            {
                MessageBox.Show("Has acertado la respuesta correcta", "CORRECTO");
                return;
            }
            else
            {
                if (intentos < maxIntentos)
                {
                    MessageBox.Show("Te quedan " + intentos + " intentos");
                } else
                {
                    MessageBox.Show("Se acabo...");
                }
            }
        }
    }
}