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
    /// Interaction logic for SegundaVentana.xaml
    /// </summary>
    public partial class SegundaVentana : Window
    {
        public SegundaVentana()
        {
            InitializeComponent();
            //MessageBox.Show("ok");
        }

        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            int res = 0;
            int auxInt = 0;
            String auxString;
            auxString = TextNumero.Text;
            auxInt = Convert.ToInt32(auxString);

            int auxIntB = 0;
            string auxStringB;
            auxStringB = TextElevar.Text;
            auxIntB = Convert.ToInt32(auxStringB);
            //res = Math.Pow(auxInt,auxIntB);
            MessageBox.Show($"Resultado: {Math.Pow(auxInt, auxIntB)}");
        }



        private void BtnCalcular_Click_1(object sender, RoutedEventArgs e)
        {
            int auxInt = 0, auxIntB = 0, res = 0;
            String auxString, auxStringB;
            auxString = TextNumero.Text;
            auxInt = Convert.ToInt32(auxString);
            //int auxIntB = 0;
            //string auxStringB;
            auxStringB = TextElevar.Text;
            auxIntB = Convert.ToInt32(auxStringB);
            MessageBox.Show($"Resultado: {Math.Pow(auxInt, auxIntB)}");
        }
    }
}
