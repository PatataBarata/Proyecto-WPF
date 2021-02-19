using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
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

        private void InsertarPelicula(Pelicula pelicula) {

           
            connection.Open();
            comando.Connection.CreateCommand();            
            comando.CommandText = "SELECT COUNT(ID) FROM peliculas WHERE idPelicula="+pelicula.id;
            comando.ExecuteReader().Equals(1); 
                
                if (comando.ExecuteReader().Equals(1))// comprueba si la peli ya existe
            {

            comando.CommandText = "INSERT INTO @tabla VALUES (@id ,@titulo, @cartel,@anyo,@genero, @calificacion)";
            comando.Parameters.Add("@id", SqliteType.Integer);
            comando.Parameters.Add("@titulo",SqliteType.Text);
            comando.Parameters.Add("@carter", SqliteType.Text);
            comando.Parameters.Add("@genero", SqliteType.Text);
            comando.Parameters.Add("@anyo", SqliteType.Integer);
            comando.Parameters.Add("@calificacion", SqliteType.Text);
            comando.Parameters["@id"].Value = pelicula.id;
            comando.Parameters["@titulo"].Value = pelicula.Titulo;
            comando.Parameters["@cartel"].Value = pelicula.Cartel;
            comando.Parameters["@genero"].Value = pelicula.Genero;
            comando.Parameters["@año"].Value = pelicula.Año;
            comando.Parameters["@calificacion"].Value = pelicula.Calificacion;
            comando.ExecuteNonQuery();
                connection.Close();
            }

        }
        private void InsertarSala(Sala sala)
        {           
                connection.Open();
                comando.Connection.CreateCommand();
                comando.CommandText = "INSERT INTO @tabla VALUES (@numero, @capacidad, @disponible)";
               
                comando.Parameters.Add("@numero", SqliteType.Text);
                comando.Parameters.Add("@capacidad", SqliteType.Integer);
                comando.Parameters.Add("@disponible", SqliteType.Integer);
                
                comando.Parameters["@numero"].Value = sala.NumeroSala;
                comando.Parameters["@capacidad"].Value = sala.TotalButacas;
                comando.Parameters["@disponible"].Value = sala.Completa;//ver si da error o parsearlo
               
                comando.ExecuteNonQuery();
                connection.Close();           
        }
    }
}
