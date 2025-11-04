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

namespace WpfApp7
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

        private void chkTodos_Checked(object sender, RoutedEventArgs e)
        {
            if (chkTodos.IsChecked == true)
            {
                chkTarea1.IsChecked = true;
                chkTarea2.IsChecked = true;
                chkTarea3.IsChecked = true;
            }
        }

        private void chkHijo(object sender, RoutedEventArgs e)
        {
            int contador = 0;

            if (chkTarea1.IsChecked == true) contador++;
            if (chkTarea2.IsChecked == true) contador++;
            if (chkTarea3.IsChecked == true) contador++;

            if (contador == 3)
            {
                chkTodos.IsChecked = true;
            } else if (contador == 0)
            {
                chkTodos.IsChecked = false;
            }
            else
            {
                chkTodos.IsChecked = null;
            }
        }
    }
}