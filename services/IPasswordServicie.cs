using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_sena.services
{
    public interface IPasswordServicie
    {
        string Hashpassword(string password);
    }
}