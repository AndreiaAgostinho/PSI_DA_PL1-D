using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public partial class Promotor
    {
        public override string ToString()
        {
            return string.Format("Nome: {0} NIF: {1} ", Nome, NIF);
        }
    }
}
