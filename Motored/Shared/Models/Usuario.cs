using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motored.Shared.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public double DNI { get; set; }

        public string Email { get; set; }

        public string Contraseña { get; set; }

        public string ConfirmarContraseña { get; set;} 

        public string Pais { get; set;  } 

        public string Provincia { get; set;} 




    }
}
