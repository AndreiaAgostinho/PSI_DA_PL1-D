using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public partial class TipoDocumento
    {
        public override string ToString()
        {
            return string.Format("{0}", Designacao);
        }
    }
}
