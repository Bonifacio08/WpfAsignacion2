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

namespace WpfAsignacion2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //InitializeComponent();
            InitializeComponent();
        }
        private void Cap4_Click(object sender, RoutedEventArgs e)
        {
            /*SegundaVentana VentanaP = new SegundaVentana();
            VentanaP.Owner = this;
            VentanaP.ShowDialog();
            */
            EjerciciosCap4 MenuCap4 = new EjerciciosCap4();
            MenuCap4.Owner = this;
            MenuCap4.ShowDialog();

        }

        private void Cap5_Click(object sender, RoutedEventArgs e)
        {
            EjerciciosCap5 MenuCap5 = new EjerciciosCap5();
            MenuCap5.Owner = this;
            MenuCap5.ShowDialog();
        }
    }
}
