using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSynthese.Classes
{
    class Oiseau : Animal, IDeplacer
    {
        //Attribut privés
        private string couleur_plumes;
        private int longueur_bec;

        //Propriété de l'attribut privé longueur_bec
        public int LongueurBec
        {
            get { return longueur_bec; }
            set
            {
                //Vérifier que la longueur du bec soit entre 0 et 10
                if (value > 0 && value <= 10)
                {
                    longueur_bec = value;
                }
            }
        }

        //Inspirer de l'exercice interface
        //Implémentation de la méthode Deplacer()
        public void Deplacer()
        {
            Console.WriteLine("Je vole!");
        }

        //Contructeur
        public Oiseau(string p_num_animal = "", int p_poids = 0,
            string p_espece = "", string p_couleur_plumes = "",
            int p_longueur_bec = 0)
        {
            this.couleur_plumes = p_couleur_plumes;
            this.longueur_bec = p_longueur_bec;
        }
    }
}

