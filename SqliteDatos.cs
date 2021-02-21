using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_WPF
{
    class SqliteDatos
    {

        private readonly SqliteConnection connection;
        private SqliteCommand comando;
   
        public SqliteDatos()
        {
            connection = new SqliteConnection("Data Source=Cinespepe.db");
            CrearTablas();
            actualizarBD();
        }
        private void actualizarBD() {

            if (!estanActualizadas())
            {
                ApiRestPeliculas apiRest = new ApiRestPeliculas();
                ObservableCollection<Pelicula> peliculas = apiRest.GetPelicula();
                foreach (Pelicula pelicula in peliculas)
                {
                    InsertarPelicula(pelicula);
                } 
            //mostrar mensaje que se han actualizado la base de datos?
            }
        }

        internal ObservableCollection<Sesion> GetSesion()
        {
            throw new NotImplementedException();
        }

        internal ObservableCollection<Sala> GetSalas()
        {
            ObservableCollection<Sala> salas = new ObservableCollection<Sala>();
            connection.Open();
            comando = connection.CreateCommand();
            comando.CommandText = "SELECT * FROM salas ";
            SqliteDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                Sala sala = new Sala( leer.GetString(0), leer.GetInt32(1), leer.GetBoolean(2));
                //(string numeroSala, int totalButacas, bool completa)
                salas.Add(sala);

            }
            return salas;
        }

        internal ObservableCollection<Pelicula> GetPeliculas()
        {
                ObservableCollection<Pelicula> peliculas = new ObservableCollection<Pelicula>();
            connection.Open();
            comando = connection.CreateCommand();
            comando.CommandText = "SELECT * FROM peliculas ";
            SqliteDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                Pelicula pelicula = new Pelicula(leer.GetInt32(0), leer.GetString(1), leer.GetString(2), leer.GetInt32(3), leer.GetString(4), leer.GetString(5));
                peliculas.Add(pelicula);

            }
            return peliculas;
        }
        private void CrearTablas()
        {
            connection.Open();
            comando = connection.CreateCommand();

            comando.CommandText = @"CREATE TABLE IF NOT EXISTS peliculas (
                                    idPelicula   INTEGER PRIMARY KEY,
                                    titulo       TEXT,
                                    cartel       TEXT,
                                    año          INTEGER,
                                    genero       TEXT,
                                    calificacion TEXT)";
            comando.ExecuteNonQuery();
            comando.CommandText = @"CREATE TABLE IF NOT EXISTS salas (
                                    idSala     INTEGER PRIMARY KEY AUTOINCREMENT,
                                    numero     TEXT,
                                    capacidad  INTEGER,
                                    disponible BOOLEAN DEFAULT (true) )";
            comando.ExecuteNonQuery();
            comando.CommandText = @"CREATE TABLE IF NOT EXISTS sesiones (
                                    idSesion INTEGER PRIMARY KEY AUTOINCREMENT,
                                    pelicula INTEGER REFERENCES peliculas (idPelicula),
                                    sala     INTEGER REFERENCES salas (idSala),
                                    hora     TEXT )";
            comando.ExecuteNonQuery();
            comando.CommandText = @"CREATE TABLE IF NOT EXISTS ventas (
                                    idVenta  INTEGER PRIMARY KEY AUTOINCREMENT,
                                    sesion   INTEGER REFERENCES sesiones (idSesion),
                                    cantidad INTEGER,
                                    pago     TEXT )";
            comando.ExecuteNonQuery();
            connection.Close();
        }

        public bool CountSesionPorSala(Sala sala) {
            bool confirmacion = false;
            connection.Open();
            comando = connection.CreateCommand();
            comando.CommandText = "SELECT COUND(*) FROM sala WHERE numero=" + sala.NumeroSala;
            SqliteDataReader leer = comando.ExecuteReader();
            if (Convert.ToInt32(leer.GetValue(0))==3)
                confirmacion = true;

            connection.Close();
            return confirmacion;

        }//Comprobar si funciona
        private void InsertarPelicula(Pelicula pelicula) {     
            
               
              if (!estaEnPeliculas(pelicula))
            { 
            connection.Open();
            comando = connection.CreateCommand();            
            comando.CommandText = "INSERT INTO peliculas VALUES (@idPelicula ,@titulo, @cartel,@año,@genero, @calificacion)";//da  error porque dice que tengo un comando abierto
            comando.Parameters.Add("@idPelicula", SqliteType.Integer);
            comando.Parameters.Add("@titulo",SqliteType.Text);
            comando.Parameters.Add("@cartel", SqliteType.Text);
            comando.Parameters.Add("@genero", SqliteType.Text);
            comando.Parameters.Add("@año", SqliteType.Integer);
            comando.Parameters.Add("@calificacion", SqliteType.Text);
            comando.Parameters["@idPelicula"].Value = pelicula.Id;
            comando.Parameters["@titulo"].Value = pelicula.Titulo;
            comando.Parameters["@cartel"].Value = pelicula.Cartel;
            comando.Parameters["@genero"].Value = pelicula.Genero;
            comando.Parameters["@año"].Value = pelicula.Año;
            comando.Parameters["@calificacion"].Value = pelicula.Calificacion;
            comando.ExecuteNonQuery();
                connection.Close();
            }

        }
        public void UpdateSala(Sala sala) {
            if (estaLaSala(sala))
            {
                connection.Open();
                comando = connection.CreateCommand();
                comando.CommandText = "UPDATE salas SET numero=@numero, capacidad= @capacidad, hora=@hora WHERE numero=@numero";

                comando.Parameters.Add("@numero", SqliteType.Text);
                comando.Parameters.Add("@capacidad", SqliteType.Integer);
                comando.Parameters.Add("@hora", SqliteType.Text);

                comando.Parameters["@numero"].Value = sala.NumeroSala;
                comando.Parameters["@capacidad"].Value = sala.TotalButacas;
                comando.Parameters["@hora"].Value = sala.Disponible; //¿ esto se tiene que parsear?

                comando.ExecuteNonQuery();
                connection.Close();
            }
        }
        private void UpdateSesion(Sesion sesion)
        {
            
                connection.Open();
                comando = connection.CreateCommand();
                comando.CommandText = "UPDATE sesiones SET pelicula=@pelicula, sala= @sala, disponible=@disponible WHERE idSesion=@idSesion";

                comando.Parameters.Add("@idSesion", SqliteType.Integer);
                comando.Parameters.Add("@pelicula", SqliteType.Integer);
                comando.Parameters.Add("@sala", SqliteType.Integer);
                comando.Parameters.Add("@numero", SqliteType.Integer);

                comando.Parameters["@idSesion"].Value = sesion.IdSesion;
                comando.Parameters["@pelicula"].Value = sesion.IdPelicula;
                comando.Parameters["@sala"].Value = sesion.IdSala;
                comando.Parameters["@numero"].Value = sesion.Hora; 

                comando.ExecuteNonQuery();
                connection.Close();
            
        }//coprobar antes de hacer el Update

        public void DeleteSesion(Sesion sesion) {

            connection.Open();
            comando = connection.CreateCommand();
            comando.CommandText = "DELETE FROM sesiones WHERE idSesion=@idSesion";
            comando.Parameters.Add("@idSesion", SqliteType.Integer);
            comando.Parameters["@idSesion"].Value = sesion.IdSesion;
             comando.ExecuteNonQuery();
            connection.Close();
        }
        public void InsertarSala(Sala sala)
        {
            if (!estaLaSala(sala))
            {
                connection.Open();
                comando = connection.CreateCommand();
                comando.CommandText = "INSERT INTO salas VALUES (@idSala @numero, @capacidad, @disponible)";

                comando.Parameters.Add("@idSala", SqliteType.Integer);
                comando.Parameters.Add("@numero", SqliteType.Text);
                comando.Parameters.Add("@capacidad", SqliteType.Integer);
                comando.Parameters.Add("@disponible", SqliteType.Integer);

          
                comando.Parameters["@numero"].Value = sala.NumeroSala;
                comando.Parameters["@capacidad"].Value = sala.TotalButacas;
                comando.Parameters["@disponible"].Value = sala.Disponible;

                comando.ExecuteNonQuery();
                connection.Close();
            }
        }
        private void InsertarSesion(Sesion sesion)
        {
            connection.Open();
            comando = connection.CreateCommand();
            comando.CommandText = "INSERT INTO sesiones VALUES (@pelicula, @sala, @hora)";

            comando.Parameters.Add("@pelicula", SqliteType.Integer);
            comando.Parameters.Add("@sala", SqliteType.Integer);
            comando.Parameters.Add("@hora", SqliteType.Text);

            comando.Parameters["@pelicula"].Value = sesion.IdPelicula;
            comando.Parameters["@sala"].Value = sesion.IdSala;
            comando.Parameters["@hora"].Value = sesion.Hora;

            comando.ExecuteNonQuery();
            connection.Close();
        }
        private void InsertarVentas(Venta venta)
        {
            connection.Open();
            comando = connection.CreateCommand();
            comando.CommandText = "INSERT INTO ventas VALUES (@sesion, @cantidad, @pago)";

            comando.Parameters.Add("@sesion", SqliteType.Integer);
            comando.Parameters.Add("@cantidad", SqliteType.Integer);
            comando.Parameters.Add("@pago", SqliteType.Text);

            comando.Parameters["@sesion"].Value = venta.Sesion;
            comando.Parameters["@cantidad"].Value = venta.Cantidad;
            comando.Parameters["@pago"].Value = venta.MedioPago;

            comando.ExecuteNonQuery();
            connection.Close();
        }
        private bool estaEnPeliculas(Pelicula peli) {
            bool confirmacion = false;
            connection.Open();
            comando = connection.CreateCommand();
            comando.CommandText = "SELECT * FROM peliculas WHERE idPelicula=" + peli.Id;
            SqliteDataReader leer = comando.ExecuteReader();          
            if (leer.HasRows)
                confirmacion = true;          
         
            connection.Close();
            return confirmacion;
        }
        private bool estanActualizadas() {
            bool actualizadas = false;
            DateTime fechaDeHoy = DateTime.Now.Date;
            if ((Properties.Settings.Default.Fecha) == fechaDeHoy)
            {
                actualizadas = true;
            }
                Properties.Settings.Default.Fecha= fechaDeHoy;
                Properties.Settings.Default.Save();
            return actualizadas;
        }
        private bool estaLaSala(Sala sala)
        {
            bool confirmacion = false;
            connection.Open();
            comando = connection.CreateCommand();
            comando.CommandText = "SELECT * FROM salas WHERE numero='" + sala.NumeroSala+"'";
            
            if (comando.ExecuteReader().HasRows)
                confirmacion = true;

            connection.Close();
            return confirmacion;
        }
    }

    
}
