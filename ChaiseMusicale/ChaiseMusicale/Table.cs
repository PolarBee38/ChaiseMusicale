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

        //
        public Table(int nbplaces)
        {
            _nbPlaces = nbplaces;
        }

        //GET
        public int get_nbplaces()
        {
            return this._nbPlaces;
        }

        //SET
        private void set_nbplaces(int nbplaces) 
        {
            _nbPlaces = nbplaces;
        }

        public override string ToString()
        {
            return "Table ";
        }
    }
}
