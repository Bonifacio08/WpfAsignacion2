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
using System.Windows.Shapes;

namespace WpfAsignacion2
{
    /// <summary>
    /// Interaction logic for EjerciciosCap5.xaml
    /// </summary>
    public partial class EjerciciosCap5 : Window
    {
        public EjerciciosCap5()
        {
            InitializeComponent();
        }

        private void BtnEjercicio4(object sender, RoutedEventArgs e)
        {
            Cap5_Ejercici04 ej4 = new Cap5_Ejercici04();
            ej4.Owner = this;
            ej4.ShowDialog();
        }
        
        private void BtnEjercicio5(object sender, RoutedEventArgs e)
        {
            Cap5_Ejercicio5 ej5 = new Cap5_Ejercicio5();
            ej5.Owner = this;
            ej5.ShowDialog();
        }
        
    }
}
