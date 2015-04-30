using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaiseMusicale
{
    class Rectangulaire:Table
    {
        private int _nbPlaceLongueur;
        private int _nbPlaceLargeur;
        
        //
        public Rectangulaire(int cotecour, int cotelong):base((cotecour+cotelong)*2)
        {
            _nbPlaceLargeur = cotecour;
            _nbPlaceLongueur = cotelong;
        }

        //GET
        public int get_nbplacelongueur()
        {
            return _nbPlaceLongueur;    
        }
        public int get_nbplacelargeur()
        {
            return _nbPlaceLargeur;
        }

        //SET
        private void set_nbplacelongueur(int longueur)
        {
            _nbPlaceLongueur = longueur;
        }
        private void set_nbplacelargeur(int largeur)
        {
            _nbPlaceLargeur = largeur;
        }

        //Autres Méthodes
        public override string ToString()
        { 
            return base.ToString()+"rectangulaire || " +get_nbplaces()+" places || " + get_nbplacelongueur() + " en longueur || " +get_nbplacelargeur()+ " en largeur";
        }
    }
}
