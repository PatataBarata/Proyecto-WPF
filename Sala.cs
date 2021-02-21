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
        private int idSala;
        private string numeroSala;
        private int totalButacas;
        private bool disponible;

        private int numeroButacaOcupadas;
        private const int TOTALSESIONES = 3;
        private bool todasLasSesiones = false;//Lo cargo desde la BD
        
        private int butacasDisponibles { get { return totalButacas - numeroButacaOcupadas; } }
     
        public Sala()
        {
        }

        public Sala(int idSala, string numeroSala, int totalButacas, bool disponble)
        {
            NumeroSala = numeroSala;
            TotalButacas = totalButacas;
            Disponible = disponble;
            IdSala = idSala;
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

        public int IdSala
        {
            get => idSala; set
            {
                this.idSala = value;
                this.NotifyPropertyChanged("IdSala");
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
