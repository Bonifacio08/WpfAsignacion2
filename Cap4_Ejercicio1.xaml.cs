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
    /// Interaction logic for Cap4_Ejercicio1.xaml
    /// </summary>
    public partial class Cap4_Ejercicio1 : Window
    {
        public Cap4_Ejercicio1()
        {
            InitializeComponent();
            //MessageBox.Show("")
        }

        private void Clik(object sender, RoutedEventArgs e)
        {
            int auxInt = 0, tabla = 10, res = 0;
            String auxString;
            auxString = TextNume.Text;
            auxInt = Convert.ToInt32(auxString);

            for (int i = 1; i <= 10; i++)
            {
                res = auxInt * i;
                TextRes.Text += ($"{i} x {auxInt} = {res}\n");
            }
        }
       
    }
}
