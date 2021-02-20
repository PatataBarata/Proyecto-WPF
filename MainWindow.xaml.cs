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
        VistaModeloMainWindow vm;
        public MainWindow()
        {
            vm = new VistaModeloMainWindow();

            InitializeComponent();
            DataContext=vm;

        }

        private void SalasButton_Click(object sender, RoutedEventArgs e)
        {
            SalasVentana salaVentana = new SalasVentana();
            salaVentana.Owner = this;
            //abre ventana de Salas  
            salaVentana.ShowInTaskbar = false;//puede ir en el XAML
            salaVentana.WindowStartupLocation = WindowStartupLocation.CenterOwner;//puede ir en el XAML
            salaVentana.Show();
        }

        private void SesionesButton_Click(object sender, RoutedEventArgs e)
        {
            SesionesVentana sesionesVentana = new SesionesVentana();
            sesionesVentana.Owner = this;
            //abre ventana de Sesiones
            sesionesVentana.ShowInTaskbar = false;//puede ir en el XAML
            sesionesVentana.WindowStartupLocation = WindowStartupLocation.CenterOwner;//puede ir en el XAML
            sesionesVentana.Show();
        }
    }
}
