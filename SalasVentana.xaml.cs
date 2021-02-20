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
        public SalasVentana()
        {
            InitializeComponent();
        }

        private void añadirNuevaSalaButton_Click(object sender, RoutedEventArgs e)
        {
            CambiarSalasStackPanel.Visibility = Visibility.Visible;
            aleatorioButtonSalasTextBlock.Text = añadirNuevaSalaButton.Content.ToString();
        }

        private void modificarSalaButton_Click(object sender, RoutedEventArgs e)
        {

            if (true)//si ha seleccionado una sala para modificar¨
            {
                CambiarSalasStackPanel.Visibility = Visibility.Visible;
            aleatorioButtonSalasTextBlock.Text = modificarSalaButton.Content.ToString();
        }
            else{
                
            MessageBox.Show("Elige una sala para modificar");}
}

        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            CambiarSalasStackPanel.Visibility = Visibility.Collapsed;
            //limpiar los campos de los TextBox
        }
    }
}
