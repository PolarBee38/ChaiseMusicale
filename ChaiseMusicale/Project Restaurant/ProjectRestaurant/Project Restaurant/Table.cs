using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaiseMusicale
{
	abstract class Table
    {
        private int _nbPlaces;
        private int _hauteur; //en cm

        //
        protected Table(int nbplaces, int taille)
        {
            _nbPlaces = nbplaces;
            _hauteur = taille;
        }

        //GET
        public int get_nbplaces()
        {
            return this._nbPlaces;
        }
        public int get_hauteur()
        {
            return _hauteur;
        }

        //SET
        private void set_nbplaces(int nbplaces) 
        {
            _nbPlaces = nbplaces;
        }
        private void set_hauteur(int hauteur)
        {
            _hauteur = hauteur;
        }

        public override string ToString()
        {
            return "Table ";
        }
    }
}
