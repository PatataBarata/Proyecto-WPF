using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_WPF
{
    class VistaModeloSesionesWindow : INotifyPropertyChanged
    {

        private Sesion nuevaSesion;
        private Sesion sesionSeleccionada;
        private ObservableCollection<Sesion> sesiones;
        
        private SqliteDatos sqliteDatos;

        public VistaModeloSesionesWindow()
        {
            sqliteDatos = new SqliteDatos();
            nuevaSesion = new Sesion();
            sesiones = sqliteDatos.GetSesion();

        }
        public void AñadirSesion() {
         //   if (sqliteDatos.CountSesionPorSala(nuevaSesion))
            {
                sesiones.Add(nuevaSesion);
                nuevaSesion = new Sesion();
            }
        }

        public void EliminarSesion() {
            sesiones.Remove(sesionSeleccionada);
            sqliteDatos.DeleteSesion(sesionSeleccionada);
        }


        public Sesion NuevaSesion
        {
            get => nuevaSesion;
            set
            {
                this.nuevaSesion = value;
                this.NotifyPropertyChanged("NuevaSesion");
            }
        }
        public Sesion SesionSeleccionada
        {
            get => sesionSeleccionada;
            set
            {
                this.sesionSeleccionada = value;
                this.NotifyPropertyChanged("SesionSeleccionada");
            }
        }
        public ObservableCollection<Sesion> Sesiones
        {
            get => sesiones;
            set
            {
                this.sesiones = value;
                this.NotifyPropertyChanged("Sesiones");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        internal void AñadirSala()
        {
            throw new NotImplementedException();
        }

        internal bool ComprobarNuevaSala()
        {
            throw new NotImplementedException();
        }
    }
}
