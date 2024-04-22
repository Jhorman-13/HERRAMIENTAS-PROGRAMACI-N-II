using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionDeVentasEquipos.Clases
{
    public class Monitores : Equipos
    {
        private string TipoConexionPantallas;
        private string ResolucionPantallas;

        public Monitores(string Marca, string Especificaciones, float Precio, string tipoConexion, string resolucion)
          : base(Marca, Precio, Especificaciones)
        {
            TipoConexionPantallas1 = tipoConexion;
            ResolucionPantallas1 = resolucion;
        }

        public string TipoConexionPantallas1 { get => TipoConexionPantallas; set => TipoConexionPantallas = value; }
        public string ResolucionPantallas1 { get => ResolucionPantallas; set => ResolucionPantallas = value; }
    }
}