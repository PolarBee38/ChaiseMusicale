using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaiseMusicale
{
    class Circulaire:Table
    {
        string _forme;
        
        //
        public Circulaire(int nbplaces):base(nbplaces)
        {
            _forme = "";
        }

        //GET
        public string get_forme()
        {
            return _forme;    
        }

    }
}
