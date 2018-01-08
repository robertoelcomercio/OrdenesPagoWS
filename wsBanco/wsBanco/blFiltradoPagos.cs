using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wsBanco
{
    public class blFiltradoPagos
    {

        List<Banco> listaBancos  = new List<Banco>();
        List<Sucursal> listaSucursales  = new List<Sucursal>();
        List<OrdenesPago > listaOrdenes  = new List<OrdenesPago>();

        public List<OrdenesPago> ListadoOrdenes(string sMoneda )
        {

            LlenadoDatos();


            List<OrdenesPago> ListadoOP = new List<OrdenesPago>();

            OrdenesPago oOP = listaOrdenes.Find(x => x.moneda==sMoneda);

            ListadoOP.Add(oOP);


            return ListadoOP;

        }

        public void LlenadoDatos()
        {
            Banco oEntidad = new Banco();

            oEntidad.idBanco = "1";
            oEntidad.nombre  = "BCP";
            oEntidad.direccion  = "Av Larco 440";
            oEntidad.fecharegistro  = "01/01/2018";

            listaBancos.Add(oEntidad);



            Sucursal  oEntidadSuc  = new Sucursal();

            oEntidadSuc.idBanco = "1";
            oEntidadSuc.idSucursal = "1";
            oEntidadSuc.nombre = "Sucursal Miraflores";
            oEntidadSuc.direccion = "Av Arequipa 5560";
            oEntidadSuc.fecharegistro = "01/01/2018";


            Sucursal oEntidadSuc2 = new Sucursal();

            oEntidadSuc2.idBanco = "1";
            oEntidadSuc2.idSucursal = "2";
            oEntidadSuc2.nombre = "Sucursal San Isidro";
            oEntidadSuc2.direccion = "Av Camino Real 220";
            oEntidadSuc2.fecharegistro = "01/01/2018";


            listaSucursales .Add(oEntidadSuc);
            listaSucursales.Add(oEntidadSuc2);



            OrdenesPago  oEntidadOP = new OrdenesPago();      
            oEntidadOP.idSucursal = "1";
            oEntidadOP.monto  = "500";
            oEntidadOP.moneda  = "DOL";
            oEntidadOP.fechapago = "01/01/2018";

            OrdenesPago oEntidadOP2 = new OrdenesPago();
            oEntidadOP2.idSucursal = "1";
            oEntidadOP2.monto = "2000";
            oEntidadOP2.moneda = "PEN";
            oEntidadOP2.fechapago = "01/01/2018";

            listaOrdenes.Add(oEntidadOP);
            listaOrdenes.Add(oEntidadOP2);


        }



    }
}