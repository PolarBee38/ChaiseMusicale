using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaiseMusicale
{
    class Program
    {
        //fonction d'aide à la selection des tables pour optimiser le nombre de places.
        public bool reservation(int nbpersonnes)
        {
            return false;
        }

        static void Main(string[] args)
        {
            Restaurant MonResto = new Restaurant("A la chaise Musicale");
            Rectangulaire table = new Rectangulaire(1, 4, 75);
            RectangulaireJumelable table2 = new RectangulaireJumelable(1, 5, 80);
            Console.WriteLine(table2.jumelerAvec(table2));

            MonResto.ajouterTable(table);
            MonResto.ajouterTable(table);
            MonResto.ajouterTable(table2);

            Console.WriteLine(MonResto.afficherTables(MonResto.get_listeTables()));
            Console.ReadKey();

			Console.WriteLine ("Hello"); 
        }
			
			
    }
}
