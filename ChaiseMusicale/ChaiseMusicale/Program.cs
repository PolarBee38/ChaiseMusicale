using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaiseMusicale
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant MonResto = new Restaurant("A la chaise Musicale");
            Rectangulaire table = new Rectangulaire(1, 4);
            MonResto.ajouterTable(table);
            MonResto.ajouterTable(table);

            Console.WriteLine(MonResto.afficherTables(MonResto.get_listeTables()));
            Console.ReadKey();
        }
    }
}
