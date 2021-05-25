//------------------------------------------------------------------------------
// <auto-generated>
//    Este código foi gerado a partir de um modelo.
//
//    Alterações manuais a este ficheiro poderão provocar um comportamento inesperado da sua aplicação.
//    Alterações manuais a este ficheiro serão substituídas se o código for regenerado.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Projeto
    {
        public Projeto()
        {
            this.Documento = new HashSet<Documento>();
            this.Parecer = new HashSet<Parecer>();
            this.ProjetoAtribuicao = new HashSet<ProjetoAtribuicao>();
        }
    
        public int Id { get; set; }
        public string EstadoProjeto { get; set; }
        public System.DateTime DataEntrega { get; set; }
        public System.DateTime DataAprovação { get; set; }
        public int ProcessoId { get; set; }
        public int TipoProjetoId { get; set; }
    
        public virtual Processo Processo { get; set; }
        public virtual ICollection<Documento> Documento { get; set; }
        public virtual TipoProjeto TipoProjeto { get; set; }
        public virtual ICollection<Parecer> Parecer { get; set; }
        public virtual ICollection<ProjetoAtribuicao> ProjetoAtribuicao { get; set; }
    }
}
