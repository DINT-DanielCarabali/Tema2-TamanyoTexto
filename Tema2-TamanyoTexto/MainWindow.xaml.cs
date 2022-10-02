using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema2_TamanyoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Tag == pequenyoRadioButton.Tag && rb.IsChecked == true)
                textoTextBlock.FontSize = 36;
            else if (rb.Tag == medianoRadioButton.Tag && rb.IsChecked == true)
                textoTextBlock.FontSize = 48;
            else if (rb.Tag == grandeRadioButton.Tag && rb.IsChecked == true)
                textoTextBlock.FontSize = 72;
        }
    }
}