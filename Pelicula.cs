using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Proyecto_WPF
{
    [Serializable]
    internal class Pelicula : INotifyPropertyChanged
    {
        private string titulo;
       
        private string genero;
        private string calificacion;
        private string cartel;
        private int año;
        public int id;
       // public ObservableCollection<Pelicula> peliculas;

        public Pelicula()
        {
       
        }
        // (@idPelicula ,@titulo, @cartel,@año,@genero, @calificacion)
        public Pelicula(int id, string titulo, string cartel, int año, string genero, string calificacion)
        {
            this.Titulo = titulo;
        
            this.Genero = genero;
            this.Calificacion = calificacion;
            this.Cartel = cartel;
            this.Año = año;
            this.Id = id;
        }

        public string Titulo
        {
            get => titulo; 
            set { this.titulo = value;
                this.NotifyPropertyChanged("Titulo");              } 
        }


    
        public string Genero { get => genero; set
            {
                this.genero = value;
                this.NotifyPropertyChanged("Genero");
            }
        }
        public string Calificacion { get => calificacion; set
            {
                this.calificacion = value;
                this.NotifyPropertyChanged("Calificacion");
            }
        }
        public string Cartel { get => cartel; set
            {
                this.cartel = value;
                this.NotifyPropertyChanged("Cartel");
            }
        }
        public int Año { get => año; set
            {
                this.año = value;
                this.NotifyPropertyChanged("Año");
            }
        }
        public int Id
        {
            get => id; set
            {
                this.id = value;
                this.NotifyPropertyChanged("Id");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}