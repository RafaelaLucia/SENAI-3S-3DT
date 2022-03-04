using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetoInternoAPI.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Produtos = new HashSet<Produto>();
        }

        public int IdUsuario { get; set; }
        public short? IdTipo { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual TipoUsuario IdTipoNavigation { get; set; }
        public virtual Imagem Imagem { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
