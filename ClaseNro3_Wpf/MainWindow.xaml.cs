using ProyectoDeClases;
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

namespace ClaseNro3_Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd;
        public MainWindow()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void BtnCrearTriangulo_Click(object sender, RoutedEventArgs e)
        {

            //Contruyo una figura y 
            Figura MiFigura = new Triangulo();

            //revizo el valor del checkbox y si es true entonces tiro valores aleatorios caso contrario pongo los valores de los textbox
            if (CbxPosicionAleatoria.IsChecked.Value)
            {
                MiFigura.Posicion.X = rnd.Next(300);
                MiFigura.Posicion.X = rnd.Next(400);
            }
            else
            {
                MiFigura.Posicion.X = Convert.ToInt32(TxtPoisicionX.Text);
                MiFigura.Posicion.X = Convert.ToInt32(TxtPoisicionY.Text);

            }



            //utilizando las propiedades polifórmicas los objetos llamo al método mostrarfigura() desde el padre.
            LbxObjetosCreados.Items.Add(MiFigura.MostrarFigura());
        }

        private void BtnCrearRectangulo_Click(object sender, RoutedEventArgs e)
        {
            // creo un punto y luego se lo paso al Constructor del rectangulo 
            Punto Mipunto = new Punto();

            //revizo el valor del checkbox y si es true entonces tiro valores aleatorios caso contrario pongo los valores de los textbox
            if (CbxPosicionAleatoria.IsChecked.Value)
            {
                Mipunto.X = rnd.Next(300);
                Mipunto.Y = rnd.Next(400);
            }
            else
            {
                Mipunto.X = Convert.ToInt32(TxtPoisicionX.Text);
                Mipunto.Y = Convert.ToInt32(TxtPoisicionY.Text);
            }


            //contruyo el rectangulo con el punto que acabo de crear
            Figura MiFigura = new Rectangulo(Mipunto);

            //utilizando las propiedades polifórmicas los objetos llamo a mostrar figura.
            LbxObjetosCreados.Items.Add(MiFigura.MostrarFigura());
        }

        private void BtnCrearCircunferencia_Click(object sender, RoutedEventArgs e)
        {
            //creando una figura
            Figura MiFigura = new Circunferencia(rnd.Next(300), rnd.Next(400));


            //revizo el valor del checkbox y si es true entonces tiro valores aleatorios caso contrario pongo los valores de los textbox
            if (CbxPosicionAleatoria.IsChecked.Value)
            {
                MiFigura = new Circunferencia(rnd.Next(300), rnd.Next(400));
            }
            else
            {
                MiFigura = new Circunferencia(Convert.ToInt32(TxtPoisicionX.Text), Convert.ToInt32(TxtPoisicionY.Text));

            }


            //utilizando las propiedades polifórmicas los objetos llamo a mostrar figura.
            LbxObjetosCreados.Items.Add(MiFigura.MostrarFigura());
        }

        private void CbxPosicionAleatoria_Checked(object sender, RoutedEventArgs e)
        {
            TxtPoisicionX.IsEnabled = false;
            TxtPoisicionY.IsEnabled = false;

        }

        private void CbxPosicionAleatoria_Unchecked(object sender, RoutedEventArgs e)
        {
            TxtPoisicionX.IsEnabled = true;
            TxtPoisicionY.IsEnabled = true;
        }
    }
}
