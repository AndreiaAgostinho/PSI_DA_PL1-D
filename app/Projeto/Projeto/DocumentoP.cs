using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public partial class Documento
    {
        public override string ToString()
        {
            return string.Format("Título do documento: {0}", Titulo);
        }
    }
}
