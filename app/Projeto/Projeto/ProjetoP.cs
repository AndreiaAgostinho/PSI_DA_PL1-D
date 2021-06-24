using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public partial class Projeto
    {
        public override string ToString()
        {
            return string.Format("Processo Nº{0} - {1} - Documentos {2}", ProcessoId, TipoProjeto, Documento.Count);
        }
    }
}
