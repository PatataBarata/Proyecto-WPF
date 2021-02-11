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
        private Sesion sesion;
        private int cantidad;
        private string medioPago;

        public Venta()
        {
        }

        public Venta(Sesion sesion, int cantidad, string medioPago)
        {
            Sesion = sesion;
            Cantidad = cantidad;
            MedioPago = medioPago;
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

