using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetoInternoAPI.Domains
{
    public partial class Situacao
    {
        public Situacao()
        {
            Produtos = new HashSet<Produto>();
        }

        public byte IdSituacao { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
