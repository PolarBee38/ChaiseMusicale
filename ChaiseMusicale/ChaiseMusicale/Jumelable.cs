using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaiseMusicale
{
    public interface Jumelable
    {
        bool jumelableAvec(Table table); //retourne vraie si les tables sont jumelables, faux sinon
        Table jumelerAvec(Table table); //retourne la nouvelle table reprenant les 2 tables
        int nbPlacesMaxAvec(Table table); //retourne le nombre de places max de 2 tables
    }
}
