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
    /// Lógica de interacción para SesionesVentana.xaml
    /// </summary>
    public partial class SesionesVentana : Window
    {
        public SesionesVentana()
        {
            InitializeComponent();
        }

        private void añadirNuevaSesionButton_Click(object sender, RoutedEventArgs e)
        {
            GestorSesionesStackPanel.Visibility = Visibility.Visible;
            aleatorioSesionesButton.Text = añadirNuevaSesionButton.Content.ToString();
        }

        private void modificarSesionButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (false)//si ha seleccionado una sala para modificar
            {
                GestorSesionesStackPanel.Visibility = Visibility.Visible;
                aleatorioSesionesButton.Text = modificarSesionButton.Content.ToString();
            }
            else

                MessageBox.Show("Elige una Sesion para modificar");
        }
     
        private void eliminarSesionButton_Click(object sender, RoutedEventArgs e)
        {
            //    vMS.EliminarSesion();
            if (false)//si ha seleccionado una sala para modificar
            {
                GestorSesionesStackPanel.Visibility = Visibility.Visible;
                aleatorioSesionesButton.Text = eliminarSesionButton.Content.ToString();
            }
            else

                MessageBox.Show("Elige una Sesion para Eliminar");
        }

        private void cancelarAñadirSesionButton_Click(object sender, RoutedEventArgs e)
        {
            GestorSesionesStackPanel.Visibility = Visibility.Collapsed;
            // limpiar los TextBox
        }
    }
}
