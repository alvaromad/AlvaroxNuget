using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AlvaroxNuget
{
    public class Producto
    {
        [JsonProperty("ProductID")]
        public int IdProducto { get; set; }
        [JsonProperty("ProductName")]
        public String Nombre { get; set; }
        [JsonProperty("QuantityPerUnit")]
        public String Cantidad { get; set; }
        [JsonProperty("UnitPrice")]
        public String Precio { get; set; }
        [JsonProperty("SupplierID")]
        public int IdProveedor { get; set; }

    }
}
