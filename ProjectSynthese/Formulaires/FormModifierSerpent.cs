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
    public partial class FormModifierSerpent : Form
    {
        //Instancier un objet Serpent
        AdoNET Serpent = new AdoNET();
        public FormModifierSerpent()
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
            //Parcourir les lignes du DataTable DtSerpent
            foreach (DataRow row in Serpent.DtSerpent.Rows)
            {
                //Trouver la ligne qui correspond au numéro serpent entré par l'utilisateur
                if (row[0].ToString() == textBox_num_serpent.Text)
                {
                    //Apporter toutes les modifications sur les champs de la ligne
                    row[0] = textBox_num_serpent.Text.Trim();
                    row[1] = textBox_poids_serpent.Text.Trim();
                    row[2] = comboBox_espece_serpent.Text.Trim();
                    row[3] = comboBox_couleur_serpent.Text.Trim();
                    row[4] = comboBox_venimeux.Text.Trim();
                }

                try
                {
                    //Sauvegarder dans la base de données
                    SqlCommandBuilder builder = new SqlCommandBuilder(Serpent.Adapter);

                    Serpent.Adapter.Update(Serpent.DsZoo, Serpent.DtSerpent.ToString());

                    //Afficher un message qui confimre la modification
                    MessageBox.Show("Le serpent a été modifier!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Gestionnaire d'événement du chargement
        /// du formulaire modifier serpent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormModifierSerpent_Load(object sender, EventArgs e)
        {
            //Écriture de la requête Sql qui va être utilisé dans l’objet Command
            string Query = "Select * from Serpent;";

            Serpent.Command.CommandText = Query;

            //Mettre dans la propriété Connection de l’objet Command l’objet
            //Connection qu’on a préparé (instancié)
            Serpent.Command.Connection = Serpent.Connection;

            //Préparer l'objet Adapter qui sert d’intermédiaire entre la source
            //de données et le DataSet. SelectCommand est utilisée car notre
            //commande est une commande Select
            Serpent.Adapter.SelectCommand = Serpent.Command;

            //Remplir le DataSet Serpent.DsZoo avec le résultat de la requête
            //Query (la table serpent). Pour cela il faut utiliser la méthode Fill
            Serpent.Adapter.Fill(Serpent.DsZoo);

            //Table retoruné
            Serpent.DtSerpent = Serpent.DsZoo.Tables[0];
        }
    }
}
