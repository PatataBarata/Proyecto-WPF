using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_WPF
{
    class Venta : INotifyPropertyChanged
    {
        private int idSesion;
        private int cantidad;
        private string medioPago;
        private Sesion sesion;

        public Venta()
        {
        }

        public Venta(int idSesion, int cantidad, string medioPago)
        {
            this.idSesion = idSesion;
            this.cantidad = cantidad;
            this.medioPago = medioPago;
            
        }

        public Venta(int idSesion, int cantidad, string medioPago, Sesion sesion) : this(idSesion, cantidad, medioPago)
        {
            this.sesion = sesion;
        }

        public Sesion Sesion
        {
            get => sesion;
            set
            {
                this.sesion = value;
                this.NotifyPropertyChanged("Sesion");
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

        public int Cantidad
        {
            get => cantidad; set
            {
                this.cantidad = value;
                this.NotifyPropertyChanged("Cantidad");
            }
        }
        public string MedioPago
        {
            get => medioPago; set
            {
                this.medioPago = value;
                this.NotifyPropertyChanged("MedioPago");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

