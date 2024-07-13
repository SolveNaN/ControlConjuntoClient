using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoClient.Shared
{
    public class UsuarioDTO
    {
        public string Correo { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        //Aqui se colocan todos los demas datos que tenga el usuario como nombres, direcciones, fechas, edad, estados etc

        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string NoIdentidad { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaNacimiento { get; set; } = DateTime.Now; //     

        public string TelefonoCelular { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;//Dueño o arrendatario   
        public string Rol { get; set; } = "Usuario"; //administrador y residente, VIGILANTE 
        public string CodigoVerificacion { get; set; } = string.Empty;
    }
}
