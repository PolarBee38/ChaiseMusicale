using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaiseMusicale
{
    public class Restaurant
    {
        private string _nomRestaurant; 
        private List<Table> _tablesDisponibles;
        private List<Table> _tablesReservees;

        //
        public Restaurant(string nom)
        {
            _nomRestaurant = nom;
            _tablesDisponibles = new List<Table>{};
            _tablesReservees = new List<Table> {};
        }

        //GET
        public string get_nomRestaurant()
        {
            return _nomRestaurant;
        }
        public List<Table> get_tablesDisponibles()
        {
            return _tablesDisponibles;
        }
        public List<Table> get_tablesReservees()
        {
            return _tablesReservees;
        }
        public List<Table> get_listeTables()
        { 
            List<Table> listeTotale = get_tablesReservees().Concat(get_tablesDisponibles()).ToList();
            return listeTotale;
        }

        //SET
        public void ajouterTable(Table table)
        {
            _tablesDisponibles.Add(table);
        }

        //Autres Méthodes
        public string afficherTables(List<Table> listeTables)
        {
            string chaine = "TABLES DE '"+ get_nomRestaurant() + "' : \n";
            foreach(Table table in listeTables)
            {
                chaine = chaine + table + "\n";
            }
            return chaine;
        }


    }
}
