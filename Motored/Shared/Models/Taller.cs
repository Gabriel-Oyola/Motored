using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motored.Shared.Models
{
    public class Taller
    { 
        public int IdTaller { get; set; } 

        public int IDUsuario { get; set;  } 

        public string NombreTaller { get; set;}

        public string País { get; set; }

        public string Provincia { get; set; }

        public string Localidad { get; set; }

        public string Direccion  { get; set; }

        public string Email  { get; set; }

        public double NumeroContacto { get; set; } 

        public DateTime Horarios { get; set;}

        public string Link { get; set; }


        //Analizar si agregar atributo reseñas 








    }
}
