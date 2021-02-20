using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_WPF
{
    class Sesion : INotifyPropertyChanged

    {
        private int idSesion;
        private int idPelicula;
        private int idSala;
        private string hora;
        private Pelicula pelicula;
        private Sala sala;
        public Sesion()
        {
        }

        public Sesion(string hora, Pelicula pelicula, Sala sala)
        {
            this.hora = hora;
            this.pelicula = pelicula;
            this.sala = sala;
        }

        public Sesion(int idSesion, int idPelicula, int idSala, string hora, Pelicula pelicula, Sala sala)
        {
            this.idSesion = idSesion;
            this.idPelicula = idPelicula;
            this.idSala = idSala;
            this.hora = hora;
            this.pelicula = pelicula;
            this.sala = sala;
        }

        public Pelicula Pelicula
        {
            get => pelicula;
            set
            {
                this.pelicula = value;
                this.NotifyPropertyChanged("Pelicula");
            }
        }

        public Sala Sala
        {
            get => sala; set
            {
                this.sala = value;
                this.NotifyPropertyChanged("Sala");
            }
        }
        public string Hora
        {
            get => hora; set
            {
                this.hora = value;
                this.NotifyPropertyChanged("Hora");
            }
        }
        public int IdPelicula
        {
            get => idPelicula; set
            {
                this.idPelicula = value;
                this.NotifyPropertyChanged("IdPelicula");
            }
        }
        public int IdSala
        {
            get => idSala; set
            {
                this.idSala = value;
                this.NotifyPropertyChanged("IdSala");
            }
        }
        public int IdSesion
        {
            get => idSesion; set
            {
                this.idSesion = value;
                this.NotifyPropertyChanged("IdSesion");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
