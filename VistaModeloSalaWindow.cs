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
        private ObservableCollection<Sala> salas;
        private SqliteDatos sqliteDatos;
        
        public VistaModeloSalaWindow()
        {
            sqliteDatos = new SqliteDatos();
            nuevaSala = new Sala();
            salas = sqliteDatos.GetSalas();
       
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

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
