using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetSynthese.Classes;

namespace ProjetSynthese.Formulaires
{
    public partial class FormModifierEnclos : Form
    {
        //Instancier un objet Enclos
        AdoNET Enclos = new AdoNET();
        public FormModifierEnclos()
        {
            InitializeComponent();
        }

        //Inspiré du laboratoire mode indirecte
        /// <summary>
        /// Gestionnaire de l'événement click du bouton valider
        /// qui modifie l'animal avec les nouvelles valeurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_valider_Click(object sender, EventArgs e)
        {
            //Parcourir les lignes du DataTable DtEnclos
            foreach (DataRow row in Enclos.DtEnclos.Rows)
            {
                //Trouver la ligne qui correspond au numéro enclos entré par l'utilisateur
                if (row[0].ToString() == textBox_num_enclos.Text)
                {
                    //Apporter toutes les modifications sur les champs de la ligne
                    row[0] = textBox_num_enclos.Text.Trim();
                    row[1] = comboBox_taille_enclos.Text.Trim();
                }

                try
                {
                    //Sauvegarder dans la base de données
                    SqlCommandBuilder builder = new SqlCommandBuilder(Enclos.Adapter);

                    Enclos.Adapter.Update(Enclos.DsZoo, Enclos.DtEnclos.ToString());

                    //Afficher un message qui confimre la modification
                    MessageBox.Show("L'enclos a été modifier!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Gestionnaire d'événement du chargement
        /// du formulaire modifier enclos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormModifierEnclos_Load(object sender, EventArgs e)
        {
            //Écriture de la requête Sql qui va être utilisé dans l’objet Command
            string Query = "Select * from Enclos;";

            Enclos.Command.CommandText = Query;

            //Mettre dans la propriété Connection de l’objet Command l’objet
            //Connection qu’on a préparé (instancié)
            Enclos.Command.Connection = Enclos.Connection;

            //Préparer l'objet Adapter qui sert d’intermédiaire entre la source
            //de données et le DataSet. SelectCommand est utilisée car notre
            //commande est une commande Select
            Enclos.Adapter.SelectCommand = Enclos.Command;

            //Remplir le DataSet Enclos.DsZoo avec le résultat de la requête
            //Query (la table enclos). Pour cela il faut utiliser la méthode Fill
            Enclos.Adapter.Fill(Enclos.DsZoo);

            //Table retoruné
            Enclos.DtEnclos = Enclos.DsZoo.Tables[0];
        }
    }
}
