using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaiseMusicale
{
    public class Table
    {
        private int _nbPlaces;
        private double _hauteur; //en cm

        //
        protected Table(int nbplaces, double taille)
        {
            _nbPlaces = nbplaces;
            _hauteur = taille;
        }

        //GET
        public int get_nbplaces()
        {
            return this._nbPlaces;
        }
        public double get_hauteur()
        {
            return _hauteur;
        }

        //SET
        private void set_nbplaces(int nbplaces) 
        {
            _nbPlaces = nbplaces;
        }
        private void set_hauteur(double hauteur)
        {
            _hauteur = hauteur;
        }

        public override string ToString()
        {
            return "Table ";
        }
    }
}
