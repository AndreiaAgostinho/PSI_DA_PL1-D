using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public partial class Funcionario
    {
        public override string ToString()
        {
            return string.Format("Funcionário: {0}", Nome);
        }
    }
}
