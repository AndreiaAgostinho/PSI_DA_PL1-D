using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public partial class Processo
    {
        public override string ToString()
        {

            return string.Format("Processo Nº {0} - Data {1}", this.Id, this.DataInicio);
        }
    }
}
