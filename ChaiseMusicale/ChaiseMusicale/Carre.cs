using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaiseMusicale
{
    class Carre:Rectangulaire
    {
        private int _nbPlaceCote;
        
        //
        public Carre(int nbplaceparcote)
            : base(nbplaceparcote, nbplaceparcote)
        { }

        //GET
        public int get_nbplacecote()
        {
            return _nbPlaceCote;
        }

        //SET
        protected void set_nbplacecote(int cote)
        {
            _nbPlaceCote = cote;
        }

        //Autres Méthodes
    }
}
