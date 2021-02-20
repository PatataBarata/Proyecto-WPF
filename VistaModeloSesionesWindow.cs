using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_WPF
{
    class VistaModeloSesionesWindow
    {

        private Sesion nuevaSesion;
        private Sesion salaSeleccionada;
        private ObservableCollection<Sesion> sesiones;
        private SqliteDatos sqliteDatos;

        public VistaModeloSesionesWindow()
        {
            sqliteDatos = new SqliteDatos();
            nuevaSesion = new Sesion();
            sesiones = sqliteDatos.GetSesion();

        }


    }
}
