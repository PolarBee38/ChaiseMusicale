using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaiseMusicale
{
    class CarreJumelable : Carre, Jumelable
    {
        public CarreJumelable(int nbplaceparcote, int taille)
            : base(nbplaceparcote, taille)
        { }
    }
}
