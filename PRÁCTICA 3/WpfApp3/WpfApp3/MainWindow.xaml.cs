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

namespace WpfApp3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string user = userT.Text.Trim();
            string password = passwordT.Password.Trim();

            if (user.Equals("usuario") && password.Equals("1234"))
            {
                MessageBox.Show("Inicio de sesión correcto", "Iniciando Sesión");
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas", "ERROR");
            }
        }
    }
}