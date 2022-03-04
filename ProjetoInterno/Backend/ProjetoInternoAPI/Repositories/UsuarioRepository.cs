using Microsoft.AspNetCore.Http;
using ProjetoInternoAPI.Contexts;
using ProjetoInternoAPI.Domains;
using ProjetoInternoAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoInternoAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        ClassificadosContext ctx = new ClassificadosContext();
        public string ConsultarPerfilBD(int id_usuario)
        {
            Imagem imagemUsuario = new Imagem();
            imagemUsuario = ctx.Imagems.FirstOrDefault(i => i.IdUsuario == id_usuario);

            if (imagemUsuario != null)
            {
                return Convert.ToBase64String(imagemUsuario.Binario);
            }

            return null;
        }

        public Usuario Login(string email, string senha)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public void SalvarPerfilBD(IFormFile foto, int id_usuario)
        {
            Imagem imagemUsuario = new Imagem();

            using (var ms = new MemoryStream())
            {
                foto.CopyTo(ms);
                imagemUsuario.Binario = ms.ToArray();
                imagemUsuario.NomeArquivo = foto.FileName;
                imagemUsuario.MimeType = foto.FileName.Split('.').Last();
                imagemUsuario.IdUsuario = id_usuario;
            }

            Imagem imagemExistente = new Imagem();
            imagemExistente = ctx.Imagems.FirstOrDefault(i => i.IdUsuario == id_usuario);

            if (imagemExistente != null)
            {
                imagemExistente.Binario = imagemUsuario.Binario;
                imagemExistente.NomeArquivo = imagemUsuario.NomeArquivo;
                imagemExistente.MimeType = imagemUsuario.MimeType;
                imagemExistente.IdUsuario = id_usuario;

                ctx.Imagems.Update(imagemExistente);
            }
            else
            {
                ctx.Imagems.Add(imagemUsuario);
            }
            ctx.SaveChanges();
        }
    }
}
