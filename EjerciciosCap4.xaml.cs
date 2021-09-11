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
    /// Interaction logic for EjerciciosCap4.xaml
    /// </summary>
    public partial class EjerciciosCap4 : Window
    {
        public EjerciciosCap4()
        {
            InitializeComponent();
        }

        

        private void Tabla(object sender, RoutedEventArgs e)
        {
            

            Cap4_Ejercicio1 ej1 = new Cap4_Ejercicio1();
            //EjerciciosCap4 eje = new EjerciciosCap4();
            ej1.Owner = this;
            ej1.ShowDialog();

        }

        private void BtnEjercicio1(object sender, RoutedEventArgs e)
        {
            SegundaVentana segVentana = new SegundaVentana();
            segVentana.Owner = this;
            segVentana.ShowDialog();
        }

        private void Promedio(object sender, RoutedEventArgs e)
        {
            Cap4_Ejercicio5 ej5 = new Cap4_Ejercicio5();
             ej5.Owner = this;
             ej5.ShowDialog();
            /*
            MessageBox.Show("HOLA!!!!!" +
                "SE FUE LA LUZ 
            */
        }
    }
}
