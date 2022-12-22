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
    public partial class FormModifierOiseau : Form
    {
        //Instancier un objet Oiseau
        AdoNET Oiseau = new AdoNET();
        public FormModifierOiseau()
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
            //Parcourir les lignes du DataTable DtOiseau
            foreach (DataRow row in Oiseau.DtOiseau.Rows)
            {
                //Trouver la ligne qui correspond au numéro oiseau entré par l'utilisateur
                if (row[0].ToString() == textBox_num_oiseau.Text)
                {
                    //Apporter toutes les modifications sur les champs de la ligne
                    row[0] = textBox_num_oiseau.Text.Trim();
                    row[1] = textBox_poids_oiseau.Text.Trim();
                    row[2] = comboBox_espece_oiseau.Text.Trim();
                    row[3] = comboBox_couleur_oiseau.Text.Trim();
                    row[4] = textBox_longueur_bec.Text.Trim();
                }

                try
                {
                    //Sauvegarder dans la base de données
                    SqlCommandBuilder builder = new SqlCommandBuilder(Oiseau.Adapter);

                    Oiseau.Adapter.Update(Oiseau.DsZoo, Oiseau.DtOiseau.ToString());

                    //Afficher un message qui confimre la modification
                    MessageBox.Show("L'oiseau a été modifier!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        /// <summary>
        /// Gestionnaire d'événement du chargement
        /// du formulaire modifier oiseau
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormModifierOiseau_Load(object sender, EventArgs e)
        {
            //Écriture de la requête Sql qui va être utilisé dans l’objet Command
            string Query = "Select * from Oiseau;";

            Oiseau.Command.CommandText = Query;

            //Mettre dans la propriété Connection de l’objet Command l’objet
            //Connection qu’on a préparé (instancié)
            Oiseau.Command.Connection = Oiseau.Connection;

            //Préparer l'objet Adapter qui sert d’intermédiaire entre la source
            //de données et le DataSet. SelectCommand est utilisée car notre
            //commande est une commande Select
            Oiseau.Adapter.SelectCommand = Oiseau.Command;

            //Remplir le DataSet Oiseau.DsZoo avec le résultat de la requête
            //Query (la table Oiseau). Pour cela il faut utiliser la méthode Fill
            Oiseau.Adapter.Fill(Oiseau.DsZoo);

            //Table retoruné
            Oiseau.DtOiseau = Oiseau.DsZoo.Tables[0];
        }
    }
}
