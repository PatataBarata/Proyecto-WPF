using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_WPF
{
    public class Sala : INotifyPropertyChanged
    {
        private string numeroSala;
        private int totalButacas;
        private bool disponible;

        private int numeroButacaOcupadas;
        private const int TOTALSESIONES = 3;
        private bool todasLasSesiones = false;
        private int numeroSesiones=0;
        private int butacasDisponibles { get { return totalButacas - numeroButacaOcupadas; } }
     
        public Sala()
        {
        }

        public Sala(string numeroSala, int totalButacas, bool disponble)
        {
            NumeroSala = numeroSala;
            TotalButacas = totalButacas;
            Disponible = true;
            
        }

        public int contarSesiones() {



            return numeroSesiones;
        }
        public string NumeroSala
        {
            get => numeroSala;
            set
            {
                this.numeroSala= value;
                this.NotifyPropertyChanged("NumeroSala");
            }
        }
      

        public int TotalButacas
        {
            get => totalButacas; set
            {
                this.totalButacas = value;
                this.NotifyPropertyChanged("TotalButacas");
            }
        }
   
        public bool Disponible
        {
            get => disponible; set
            {
                this.disponible = value;
                this.NotifyPropertyChanged("Disponible");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

       
    }
}
