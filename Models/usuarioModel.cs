using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace proyecto_sena.Models
{
    public class usuarioModel
    {
        public int usuario_Id { get; set; }
        [Required(ErrorMessage = "Nombre obligatorio")]
        public required string usuario_Nombre { get; set; }
         [Required(ErrorMessage = "Apellido es obligatorio")]
        public required string usuario_Apellido { get; set; }
         [Required(ErrorMessage = "correo es obligatorio")]
        public required string usuario_correo { get; set; }
        [Required(ErrorMessage = "Contraseña es obligaorio")]
          [MinLength(6,ErrorMessage = "Contraseña debe tener menos de 6 caracteres")]
        public required string usuario_Contraseña { get; set; }
    }
}