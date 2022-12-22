using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProjetSynthese.Classes
{
    abstract class Animal
    {
        //Attributs privés
        private string num_animal;
        private int poids;
        private string espece;

        //Propriété de l'attribut privé num_animal
        public string NumAnimal
        {
            get { return num_animal; }
            set
            {
                //Vérifier si le numéro est composé de 6 chiffres
                if (Regex.IsMatch(value, "^[0-9]{6}$"))
                {
                    num_animal = value;
                }
            }
        }

        //Propriété de l'attribut privé poids
        public int Poids
        {
            get { return poids; }
            set
            {
                //Vérifier que le poids soit entre 0 et 100
                if (value > 0 && value <= 100)
                {
                    poids = value;
                }
            }
        }

        //Constructeur
        public Animal(string p_num_animal = "", int p_poids = 0, string p_espece = "")
        {
            this.num_animal = p_num_animal;
            this.poids = p_poids;
            this.espece = p_espece;
        }
    }
}
