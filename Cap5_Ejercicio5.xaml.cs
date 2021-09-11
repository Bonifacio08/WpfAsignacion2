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
    /// Interaction logic for Cap5_Ejercicio5.xaml
    /// </summary>
    public partial class Cap5_Ejercicio5 : Window
    {
        //Instanciamos la clase
        Convercion c = new Convercion();
        //
        public Cap5_Ejercicio5()
        {
            InitializeComponent();
        }

        private void Mostrar_Click(object sender, RoutedEventArgs e)
        {
            TextLetra.Text = c.enletras(TextNum.Text);
        }
    }
}
