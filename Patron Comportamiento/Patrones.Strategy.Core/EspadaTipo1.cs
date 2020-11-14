using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Strategy.Core
{
    public class EspadaTipo1 : Arma
    {
        public override string Disparar()
        {
            return "Empalando con la Espada de energia tipo 1";
        }
    }
}
