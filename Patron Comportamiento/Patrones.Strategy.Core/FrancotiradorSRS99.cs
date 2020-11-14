using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Strategy.Core
{
    public class FrancotiradorSRS99 : Arma
    {
        public override string Disparar()
        {
            return "Disparando a lo lejos con Francotirador SRS99";
        }
    }
}
