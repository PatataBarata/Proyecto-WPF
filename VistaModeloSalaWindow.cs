using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_WPF
{
    class VistaModeloSalaWindow : INotifyPropertyChanged
    {
        private Sala nuevaSala;
        private Sala salaSeleccionada;
        private ObservableCollection<Sala> listaSalas;

        private SqliteDatos sqliteDatos;
        
        public VistaModeloSalaWindow()
        {
            sqliteDatos = new SqliteDatos();
            nuevaSala = new Sala() ;
            listaSalas = sqliteDatos.GetSalas();
       
        }
        public void AñadirSala()
        {
            ListaSalas.Add(NuevaSala);
            sqliteDatos.InsertarSala(NuevaSala);
            NuevaSala = new Sala();
        }
        public bool ComprobarNuevaSala()
        {
            if (NuevaSala.TotalButacas!= 0 || NuevaSala.NumeroSala != "")
                return true;
            else
                return false;
        }
        public Sala NuevaSala
        {
            get => nuevaSala; set
            {
                this.nuevaSala = value;
                this.NotifyPropertyChanged("NuevaSala");
            }
        }
        public Sala SalaSeleccionada
        {
            get => salaSeleccionada; set
            {
                this.salaSeleccionada = value;
                this.NotifyPropertyChanged("SalaSeleccionada");
            }
        }
        public ObservableCollection<Sala> ListaSalas
        {
            get => listaSalas; set
            {
                this.listaSalas = value;
                this.NotifyPropertyChanged("ListaSalas");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
