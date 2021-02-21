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

namespace Proyecto_WPF
{
    /// <summary>
    /// Lógica de interacción para Salas.xaml
    /// </summary>
    public partial class SalasVentana : Window
    {
        VistaModeloSalaWindow vMS;
        public SalasVentana()
        {
            vMS = new VistaModeloSalaWindow();
            InitializeComponent();
            DataContext = vMS;
        }
        private void añadirNuevaSalaButton_Click(object sender, RoutedEventArgs e)
        {
            CambiarSalasStackPanel.Visibility = Visibility.Visible;
            aleatorioButtonSalasTextBlock.Text = añadirNuevaSalaButton.Content.ToString();
        }
        private void modificarSalaButton_Click(object sender, RoutedEventArgs e)
        {
            modificarSalasStackPanel.Visibility = Visibility.Visible;
            aleatorioButtonSalasTextBlock.Text = modificarSalaButton.Content.ToString();
        }
    
        
        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            CambiarSalasStackPanel.Visibility = Visibility.Collapsed;      
            vMS.cancelarAccion();
        }

        private void aleatorioButtonSalas_Click(object sender, RoutedEventArgs e)
        {
           if (vMS.ComprobarNuevaSala())

                vMS.AñadirSala();
        }

        private void modificarAleatorioButtonSalas_Click(object sender, RoutedEventArgs e)
        {
            modificarSalasStackPanel.Visibility = Visibility.Visible;
        }

    }
}
