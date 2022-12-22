using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProjetSynthese.Classes
{
    class Enclos
    {
        //Attribus privés
        private string num_enclos;
        private string taille_enclos;

        //Propriété de l'attribut privé num_enclos
        public string NumEnclos
        {
            get { return num_enclos; }
            set
            {
                //Vérifier si le numéro est composé de 3 chiffres
                if (Regex.IsMatch(value, "^[0-9]{3}$"))
                {
                    num_enclos = value;
                }
            }
        }

        //Constructeur
        public Enclos(string p_num_enclos = "", string p_taille_enclos = "")
        {
            this.num_enclos = p_num_enclos;
            this.taille_enclos = p_taille_enclos;
        }
    }
}
