using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_WPF
{
    class ApiRestPeliculas
    {
        public ObservableCollection<Pelicula> GetPelicula() {

            var cliente = new RestClient(Properties.Settings.Default.URLApirest);
            var peticion = new RestRequest(Properties.Settings.Default.GetPeliculas, Method.GET);
            var responde = cliente.Execute(peticion);
            return JsonConvert.DeserializeObject<ObservableCollection<Pelicula>>(responde.Content);
        }
    }
}
