using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyecto_sena.Data;
using proyecto_sena.Models;
using proyecto_sena.services;

namespace proyecto_sena.implementacion
{
    public class usuarioservice : Iusuarioservice
    {

        private readonly DBcontext dBcontext;
        private readonly IPasswordServicie passwordServicie;
        public usuarioservice(DBcontext dBcontext, IPasswordServicie passwordServicie)
        {
            this.dBcontext = dBcontext;
            this.passwordServicie = passwordServicie;
        }
        public async Task Crearusuario(usuarioModel usuario)
        {
            if (usuario != null)
            {
                usuario.usuario_Contraseña = passwordServicie.Hashpassword(usuario.usuario_Contraseña);
                dBcontext.usuarios.Add(usuario);
                await dBcontext.SaveChangesAsync();
            }

        }
      
    }
}