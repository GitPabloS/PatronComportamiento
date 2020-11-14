using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Strategy.Core
{
    public class RifleBR55HB : Arma
    {
        public override string Disparar()
        {
            return "Disparando con el Rifle BR55HB";
        }
    }
}
