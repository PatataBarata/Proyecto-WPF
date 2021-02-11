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
        private Pelicula pelicula;
        private Sala sala;
        private string hora;
        private enum sesion {primera, segunda, tercera }

        public Sesion()
        {
        }

        public Sesion(Pelicula pelicula, Sala sala, string hora)
        {
            Pelicula = pelicula;
            Sala = sala;
            Hora = hora;
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
        


        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
