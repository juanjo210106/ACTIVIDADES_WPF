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

            Grid grid = new Grid();

            Button button = new Button();
            button.Content = "Botón";
            button.Margin = new Thickness(100);
            button.FontWeight = FontWeights.Bold;
            button.HorizontalAlignment = HorizontalAlignment.Center;
            button.VerticalAlignment = VerticalAlignment.Bottom;
            button.Width = 60;
            button.Height = 20;
            
            WrapPanel wrapPanel = new WrapPanel();
            wrapPanel.HorizontalAlignment = HorizontalAlignment.Center;
            wrapPanel.VerticalAlignment = VerticalAlignment.Center;

            TextBlock textBlock1 = new TextBlock();
            textBlock1.Text = "Bloque 1";
            textBlock1.Margin = new Thickness(20);
            textBlock1.Padding = new Thickness(20);
            textBlock1.Background = Brushes.Green;
            textBlock1.Foreground = Brushes.White;

            TextBlock textBlock2 = new TextBlock();
            textBlock2.Text = "Bloque 2";
            textBlock2.Margin = new Thickness(20);
            textBlock2.Padding = new Thickness(20);
            textBlock2.Background = Brushes.Blue;
            textBlock2.Foreground = Brushes.White;

            TextBlock textBlock3 = new TextBlock();
            textBlock1.Margin = new Thickness(20);
            textBlock3.Padding = new Thickness(20);
            textBlock3.Text = "Bloque 3";

            wrapPanel.Children.Add(textBlock1);
            wrapPanel.Children.Add(textBlock2);
            wrapPanel.Children.Add(textBlock3);


            grid.Children.Add(button);
            grid.Children.Add(wrapPanel);
            

            this.Content = grid;
        }
    }
}