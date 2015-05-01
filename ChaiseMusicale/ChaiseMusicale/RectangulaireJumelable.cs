using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaiseMusicale
{
    class RectangulaireJumelable: Rectangulaire, Jumelable
    {
        //
        public RectangulaireJumelable(int nbplacelong, int nbplacelarge, int taille) 
            : base(nbplacelarge, nbplacelong, taille){}

        //Autres Méthodes
        public bool jumelerAvec(Table t)
        {
            Rectangulaire rect = t as Rectangulaire;

            // Si les 2 tables sont jumelables et qu'elle font la même taille
            if (t == null || t as Jumelable == null || get_hauteur() != t.get_hauteur())
            {
                return false;
            }
                Console.WriteLine(this + " jumelé avec " + t + " permet d'avoir : ");
                if (rect != null)//Si la table a jumeler est au moin rectangulaire
                {
                    Carre carre = t as Carre;
                    if (carre != null)
                    {
                        if (get_nbplacelargeur() == carre.get_nbplacecote() 
                                || get_nbplacelongueur() == carre.get_nbplacecote())
                        {
                            Console.WriteLine((get_nbplacelongueur()+ carre.get_nbplacecote() + get_nbplacelargeur())*2 +" places");
                        }
                    }
                    else    //Dans le cas ou c'est un rectangle
                   {
                         if (get_nbplacelargeur() == rect.get_nbplacelargeur() || get_nbplacelargeur() == rect.get_nbplacelongueur())
                            Console.WriteLine((get_nbplaces() + rect.get_nbplaces() - get_nbplacelargeur() * 2) + " places");
                         if (get_nbplacelongueur() == rect.get_nbplacelongueur() || get_nbplacelongueur() == rect.get_nbplacelargeur())
                             Console.WriteLine((get_nbplaces() + rect.get_nbplaces() - get_nbplacelongueur() * 2) + " places");
                    }                         
           }
                return true;
       }
    }
}
