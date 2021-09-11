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
    /// Interaction logic for Cap5_Ejercici04.xaml
    /// </summary>
    public partial class Cap5_Ejercici04 : Window
    {
        public Cap5_Ejercici04()
        {
            InitializeComponent();
        }

        private void Mostrar_Click(object sender, RoutedEventArgs e)
        {
            int n = 0, res = 1;
            string auxString;
            auxString = TextNumero.Text;
            n = Convert.ToInt32(auxString);
            
            for (int i = n; i >=2; i--){
                res *=  i;
            }
            MessageBox.Show($"Resultado: {res}");
        }
    }
}
