﻿using Microsoft.Data.Sqlite;
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
        ObservableCollection<Pelicula> peliculas;



        public SqliteDatos()
        {
            connection = new SqliteConnection("Data Source=Cinespepe.db");
            CrearTablas();
            actualizarBD();
        }
        private void actualizarBD() {

            if (!estanActualizadas())//no se guarda la variable en usuario
            {
                ApiRestPeliculas apiRest = new ApiRestPeliculas();
                ObservableCollection<Pelicula> peliculas = apiRest.GetPelicula();
                foreach (Pelicula pelicula in peliculas)
                {
                    InsertarPelicula(pelicula);
                } 
            }
            //mostrar mensaje que se han actualizado la base de datos?
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
            
               
              if (noEstaEnPeliculas(pelicula))
            { 
            connection.Open();
            comando.Connection.CreateCommand();            
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

        private ObservableCollection<Pelicula> peliculasDelCine()
        {


            return peliculas;
        }

        private bool noEstaEnPeliculas(Pelicula peli) {
            bool confirmacion = false;
            connection.Open();
            comando.Connection.CreateCommand();
            comando.CommandText = "SELECT * FROM peliculas WHERE idPelicula=" + peli.Id;
            
            if (comando.ExecuteReader().HasRows)
            {
                confirmacion = true;
            }
            comando.Cancel();
            connection.Close();

            return confirmacion;
        }

        private bool estanActualizadas() {
            bool actualizadas = false;
            DateTime fechaDeHoy = DateTime.Now.Date;

            if ((Properties.Settings.Default.Fecha) == fechaDeHoy)
                actualizadas = true;
            (Properties.Settings.Default.Fecha) = fechaDeHoy;
            return actualizadas;
        }
    }

    
}
