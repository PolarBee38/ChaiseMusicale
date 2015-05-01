using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaiseMusicale
{
    class Circulaire:Table
    {
        //private string _forme;
        
        //
        public Circulaire(int nbplaces, double hauteur):base(nbplaces, hauteur)
        {
           // _forme = "";
        }
        /*
        //GET
        public string get_forme()
        {
            return _forme;    
        }

        //SET
        private void get_forme(string form)
        {
            _forme = form;
        }*/

        //Autres Méthodes
        public override string ToString()
        {
            Table t = this as Table;
            return t+"circulaire de " + get_nbplaces() + " places";
        }

    }
}
