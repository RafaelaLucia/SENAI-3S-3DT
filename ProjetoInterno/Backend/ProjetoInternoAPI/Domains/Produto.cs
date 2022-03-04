using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetoInternoAPI.Domains
{
    public partial class Produto
    {
        public int IdProduto { get; set; }
        public int IdUsuario { get; set; }
        public byte IdSituacao { get; set; }
        public int? IdImagem { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public DateTime DataOferta { get; set; }

        public virtual Imagem IdImagemNavigation { get; set; }
        public virtual Situacao IdSituacaoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
