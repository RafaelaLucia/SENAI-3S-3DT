using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetoInternoAPI.Domains
{
    public partial class TipoUsuario
    {
        public TipoUsuario()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public short IdTipo { get; set; }
        public string TituloTipo { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
