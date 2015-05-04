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
        public Rectangulaire(int cotecour, int cotelong, int taille):base((cotecour+cotelong)*2, taille)
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
            return base.ToString()+"rectangulaire de "+ get_nbplaces()+" places || " + get_nbplacelongueur() + " de long || " +get_nbplacelargeur()+ " de large";
        }
    }
}
