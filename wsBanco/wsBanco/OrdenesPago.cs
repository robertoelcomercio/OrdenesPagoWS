using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wsBanco
{
    public class OrdenesPago
    {
        public string idSucursal  { set; get; }
        public string monto { set; get; }
        public string moneda { set; get; }
        public string estado { set; get; }
        public string fechapago { set; get; }

    }
}