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
    /// Interaction logic for Cap4_Ejercicio5.xaml
    /// </summary>
    public partial class Cap4_Ejercicio5 : Window
    {
        int contador = 0;
        int[] Array = new int[100];//Declaracion del array
        int aux = 0, limEdades = 0, Mayor = 0, Menor = 0;

        public Cap4_Ejercicio5()
        {
            InitializeComponent();
        }

        private void MostrarDatos(object sender, RoutedEventArgs e)
        {
            int aux = 0;
            TextMayor.Text = Convert.ToString(MayorEdad());

            TextMenor.Text = Convert.ToString(MenorEdad());

            TextPromedio.Text = Convert.ToString(PromedioEdad());

        }

        private void GuardarEdades(object sender, RoutedEventArgs e)
        {
            aux = Convert.ToInt32(TextEdades.Text);
            Array[contador] = aux;
            contador++;
           // limEdades = Convert.ToInt32(TextLimEdades.Text);
          //  for(contador = 0; contador>=limEdades; contador++)
           // {
               
           // }
        }
        public  int MayorEdad()
        {
            for(int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > Mayor)
                {
                    Mayor = Array[i]; 
                }

            }
            return Mayor;
        }
        public int MenorEdad()
        {
            int menor = MayorEdad();
            for (int i = 0; i < contador; i++)
            {
                if (Array[i] < menor)
                {
                    menor = Array[i];
                    //Menor = Mayor;
                }
            }
            return menor;
        }
        public int PromedioEdad()
        {
            int promedio =0, promed=0;
            for(int i = 0; i < contador; i++)
            {
                promed += Array[i];
            }
            promedio = promed / contador;
            return promedio;
        }
    }
}
