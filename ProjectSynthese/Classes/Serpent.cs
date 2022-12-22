using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSynthese.Classes
{
    class Serpent : Animal
    {
        //Attributs privés
        private string couleur_ecailles;
        private string venimeux;

        //Inspirer de l'exercice interface
        //Implémentation de la méthode Deplacer()
        public void Deplacer()
        {
            Console.WriteLine("Je rampe!");
        }

        //Constructeur
        public Serpent(string p_num_animal = "", int p_poids = 0,
            string p_espece = "", string p_couleur_ecailles = "",
            string p_venimeux = "")
        {
            this.couleur_ecailles = p_couleur_ecailles;
            this.venimeux = p_venimeux;
        }
    }
}
