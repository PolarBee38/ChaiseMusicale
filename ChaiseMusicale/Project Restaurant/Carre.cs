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
        public Carre(int nbplaceparcote, int taille)
            : base(nbplaceparcote, nbplaceparcote, taille)
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
        //Autres Méthodes
        public override string ToString()
        {
            Table t = this as Table;
            return t + "carrée de " + get_nbplaces() + " places || " + get_nbplacecote() + " de cote";
        }
    }
}
