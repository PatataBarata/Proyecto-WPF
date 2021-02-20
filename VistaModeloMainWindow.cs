using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_WPF
{
    class VistaModeloMainWindow : INotifyPropertyChanged
    {
        public SqliteDatos sqliteDatos;
        public ObservableCollection<Pelicula> peliculas;
      
      
   
        public VistaModeloMainWindow()
        {
            sqliteDatos = new SqliteDatos();           
            peliculas = sqliteDatos.GetPeliculas();
            
        }
    
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Pelicula> Peliculas
        {
            get => peliculas; set
            {
                this.peliculas = value;
                this.NotifyPropertyChanged("Peliculas");
            }
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
