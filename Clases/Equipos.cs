using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionDeVentasEquipos.Clases
{
    public class Equipos
    {

        private string Marca;
        private float Precio;
        private string Especificaciones;

        public Equipos(string marca, float precio, string especificaciones)
        {
            Marca1 = marca;
            Precio1 = precio;
            Especificaciones1 = especificaciones;
        }

         public string Marca1 { get => Marca; set => Marca = value; }
        public float Precio1 { get => Precio; set => Precio = value; }
        public string Especificaciones1 { get => Especificaciones; set => Especificaciones = value; }


        static void Main(string[] args)
        {
            // Crear un objeto de tipo Inmueble
         

            // Mostrar todos los datos del inmueble
            
        }
    }
}