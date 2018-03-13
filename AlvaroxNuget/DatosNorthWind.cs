using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Newtonsoft.Json;

namespace AlvaroxNuget
{
    public class DatosNorthWind
    {
        public Productos GetProductos()
        {
            WebClient cliente = new WebClient();
            cliente.Headers["content-type"] = "application/json";
            String url = "http://services.odata.org/V4/Northwind/Northwind.svc/Products";

            String contenido = cliente.DownloadString(url);
            Productos productos = JsonConvert.DeserializeObject<Productos>(contenido);

            return productos;

        }


       
    }
}
