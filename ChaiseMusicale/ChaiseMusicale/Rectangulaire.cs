using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaiseMusicale
{
    class Rectangulaire:Table
    {
        protected int _nbplacelongueur;
        protected int _nbplacelargeur;

        
        //
        public Rectangulaire(int cotecour, int cotelong):base(cotecour*cotelong)
        {
            _nbplacelargeur = cotecour;
            _nbplacelongueur = cotelong;
        }

        //GET
        public int get_nbplacelongueur()
        {
            return _nbplacelongueur;    
        }
        public int get_nbplacelargeur()
        {
            return _nbplacelargeur;
        }

        //SET
        protected void set_nbplacelongueur(int longueur)
        {
            _nbplacelongueur = longueur;
        }
        protected void set_nbplacelargeur(int largeur)
        {
            _nbplacelargeur = largeur;
        }

        //Autres Méthodes
    }
}
