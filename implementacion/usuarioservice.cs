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
        public usuarioservice(DBcontext dBcontext)
        {
            this.dBcontext = dBcontext;
        }
        public async void Crearusuario(usuarioModel usuario)
        {
            if (usuario != null)
            {
                dBcontext.usuarios.Add(usuario);
                await dBcontext.SaveChangesAsync();
            }

        }
    }
}