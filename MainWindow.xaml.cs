using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Proyecto_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
             Pelicula pelicula= new Pelicula();
           DataContext = pelicula;
            
        }

        private void SalasButton_Click(object sender, RoutedEventArgs e)
        {
            //abre ventana de Salas asdasdas 
        }

        private void SesionesButton_Click(object sender, RoutedEventArgs e)
        {
            



            //abre ventana de Sesiones
        }
    }
}
