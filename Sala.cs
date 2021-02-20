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
        private bool completa;

        private int numeroButacaOcupadas;
        private const int TOTALSESIONES = 3;
        private bool todasLasSesiones = false;
        private int butacasDisponibles { get { return totalButacas - numeroButacaOcupadas; } }
     
        public Sala()
        {
        }

        public Sala(string numeroSala, int totalButacas, int numeroButaca, bool completa)
        {
            NumeroSala = numeroSala;
            TotalButacas = totalButacas;
            NumeroButaca = numeroButaca;
            Completa = completa;
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
        public int NumeroButaca
        {
            get => numeroButacaOcupadas; set
            {
                this.numeroButacaOcupadas = value;
                this.NotifyPropertyChanged("NumeroButacasOcupadas");
            }
        }
        public bool Completa
        {
            get => completa; set
            {
                this.completa = value;
                this.NotifyPropertyChanged("Completa");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

       
    }
}
