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

namespace WpfApp8
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

        private void ChkTodos_Checked(object sender, RoutedEventArgs e)
        {
            bool estadoMarcado = (ChkTodos.IsChecked == true);

            ChkDI.IsChecked = estadoMarcado;
            ChkSGE.IsChecked = estadoMarcado;
            ChkAD.IsChecked = estadoMarcado;
        }

        private void ChkModulo_Click(object sender, RoutedEventArgs e)
        {
            int contador = 0;

            if (ChkDI.IsChecked == true) contador++;
            if (ChkSGE.IsChecked == true) contador++;
            if (ChkAD.IsChecked == true) contador++;

            if (contador == 3)
            {
                ChkTodos.IsChecked = true;
            } else if (contador == 0)
            {
                ChkTodos.IsChecked = false;
            } else
            {
                ChkTodos.IsChecked = null;
            }
        }
    }
}