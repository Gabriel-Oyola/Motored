using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motored.Shared.Models
{
    public class Opiniones
    {

        public int IdUsuario{ get; set; } 

        public int IdTaller { get; set; }

        public int IdOpinion { get; set; }

        public string Comentario { get; set; } 

        public DateTime Fecha { get; set; }

        public int Estrellas { get; set; }


    }
}
