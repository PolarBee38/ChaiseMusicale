using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaiseMusicale
{
    class Carre:Rectangulaire
    {
        protected int _nbplacecote;
        
        //
        public Carre(int nbplaceparcote)
            : base(nbplaceparcote, nbplaceparcote)
        { }

        //GET
        public int get_nbplacecote()
        {
            return _nbplacecote;
        }

        //SET
        protected void set_nbplacecote(int cote)
        {
            _nbplacecote = cote;
        }

        //Autres Méthodes
    }
}
