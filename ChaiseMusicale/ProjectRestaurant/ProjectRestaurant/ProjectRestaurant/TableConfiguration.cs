using System;

namespace ChaiseMusicale
{
    public class TableConfiguration
    {
        private string _name;
        //private List<table> table; 
        public TableConfiguration(string name, List<Table> table)
        {
            _name = name;
            table = new List<Table>(table);
        }

        public string name
        {
            get { return _name; }
            //set {_name = value;}
        }

        public void updateStatus(Table table)
        {

        }


    }
}

