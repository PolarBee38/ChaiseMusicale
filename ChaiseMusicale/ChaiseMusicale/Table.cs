using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaiseMusicale
{
    abstract class Table
    {
        protected int _nbplaces;

        //
        public Table(int nbplaces)
        {
            _nbplaces = nbplaces;
        }

        //
        public int get_nbplaces()
        {
            return this._nbplaces;
        }
        protected void set_nbplaces(int nbplaces) 
        {
            _nbplaces = nbplaces;
        }


    }
}
