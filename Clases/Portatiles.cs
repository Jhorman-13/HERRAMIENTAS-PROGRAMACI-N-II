﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace GestionDeVentasEquipos.Clases
{
    public class Portatiles : Equipos 
    {
        private string Modelo;
        public Portatiles(string Marca, string modelo, string Especificaciones, float Precio)
            : base(Marca, Precio, Especificaciones)
        {
            Modelo1 = modelo;
        }

      
         public string Modelo1 { get => Modelo; set => Modelo = value; }
        
        
       
      
    }
}