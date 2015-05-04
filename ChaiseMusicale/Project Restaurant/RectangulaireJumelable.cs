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
        public bool jumelableAvec(Table table)
        {
            // Si les 2 tables sont jumelables et qu'elle font la même taille
            if (table == null || table as Jumelable == null || get_hauteur() != table.get_hauteur())
            {
                return false;
            }
            return true;
        }
        
        public Table jumelerAvec(Table table)
        {
            int nbPlacesMax = 0, tmp, cote1, cote2; //On suppose qu'il n'y a que 2 cotés à analyser
            if(!jumelableAvec(table))
            {
                Console.WriteLine("Les 2 tables ne sont pas jumelables");
                return null;
            }
            Rectangulaire rect = table as Rectangulaire;
            if (get_nbplacelargeur() == rect.get_nbplacelargeur() || get_nbplacelargeur() == rect.get_nbplacelongueur())
            {
                tmp = get_nbplaces() + rect.get_nbplaces() - get_nbplacelargeur() * 2;
                nbPlacesMax = tmp;  //On prend en compte le fait d'initialiser pour la première fois
            }
            if (get_nbplacelongueur() == rect.get_nbplacelongueur() || get_nbplacelongueur() == rect.get_nbplacelargeur())
            {
                tmp = get_nbplaces() + rect.get_nbplaces() - get_nbplacelongueur() * 2;
                if (tmp > nbPlacesMax)
                { 
                    cote1 = get_nbplacelongueur();
                    cote2 = tmp - 2*cote1;
                }
                else //dans le cas ou c'est tmp<nbPlacesMax-> on récupère les valeurs précédentes
                {
                    cote1 = get_nbplacelargeur();
                    cote2 = nbPlacesMax - 2*cote1;
                }
                if(cote1 == cote2)
                {
                    Carre nouvelleTable = new Carre(cote1, get_hauteur());
                    return nouvelleTable;
                }
                else
                {
                    if(cote1 < cote2)
                    {
                        tmp = cote1;
                        cote1 = cote2;
                        cote2 = tmp;
                    }
                    Rectangulaire nouvelleTable = new Rectangulaire(cote1, cote2, get_hauteur());
                    return nouvelleTable;
                }
            }
            Console.WriteLine("Erreur lors du jumelage. Recommencer.");
            return null;
        }

        public int nbPlacesMaxAvec(Table t)
        {
            int nbPlacesMax = 0, nbPlaces;
            Rectangulaire rect = t as Rectangulaire;
            if (jumelableAvec(t))
            {
                Console.WriteLine(this + " jumelé avec " + t + " permet d'avoir : ");
                if (rect != null)//Si la table a jumeler est au moin rectangulaire
                {
                    Carre carre = t as Carre;
                    if (carre != null)
                    {
                        if (get_nbplacelargeur() == carre.get_nbplacecote()
                                || get_nbplacelongueur() == carre.get_nbplacecote())
                        {
                            nbPlaces = (get_nbplacelongueur() + carre.get_nbplacecote() + get_nbplacelargeur()) * 2;
                            Console.WriteLine( nbPlaces + " places");
                            return nbPlaces;
                        }
                    }
                    else    //Dans le cas ou c'est un rectangle
                    {
                        if (get_nbplacelargeur() == rect.get_nbplacelargeur() || get_nbplacelargeur() == rect.get_nbplacelongueur())
                        {
                            nbPlaces = get_nbplaces() + rect.get_nbplaces() - get_nbplacelargeur() * 2;       
                            Console.WriteLine( nbPlaces + " places");
                            if (nbPlaces > nbPlacesMax)
                            {
                                nbPlacesMax = nbPlaces;
                            }
                        }
                        if (get_nbplacelongueur() == rect.get_nbplacelongueur() || get_nbplacelongueur() == rect.get_nbplacelargeur())
                        {
                            nbPlaces = get_nbplaces() + rect.get_nbplaces() - get_nbplacelongueur() * 2;
                            Console.WriteLine(nbPlaces + " places");
                            if (nbPlaces > nbPlacesMax)
                            {
                                nbPlacesMax = nbPlaces;
                            }
                        }

                    }
                }
            }
            return nbPlacesMax;
       }
    }
}
