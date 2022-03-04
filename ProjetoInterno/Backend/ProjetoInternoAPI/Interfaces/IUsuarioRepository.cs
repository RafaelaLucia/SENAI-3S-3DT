﻿using Microsoft.AspNetCore.Http;
using ProjetoInternoAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoInternoAPI.Interfaces
{
    interface IUsuarioRepository
    {
        Usuario Login(string email, string senha);
        void SalvarPerfilBD(IFormFile foto, int id_usuario);
        string ConsultarPerfilBD(int id_usuario);
    }
}
