using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AlvaroxNuget
{
    public class Productos
    {
        [JsonProperty("value")]
        public List<Producto> ListaProductos { get; set; }

    }
}
