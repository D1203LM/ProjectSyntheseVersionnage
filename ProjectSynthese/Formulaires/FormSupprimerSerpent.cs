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
    public partial class FormSupprimerSerpent : Form
    {
        AdoNET Serpent = new AdoNET();
        public FormSupprimerSerpent()
        {
            InitializeComponent();
        }

        //Inspirer du laboratoire mode indirecte
        //Méthode fait crash le programme, mais lors du redémarrage,
        // on peut voir que l'élément à été supprimé de la table.
        /// <summary>
        /// Gestionnaire de l'événement click du bouton supprimer
        /// qui supprime le serpent qui comporte le numéro entrer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_supprimer_Click(object sender, EventArgs e)
        {
            //Parcourir les lignes de la table
            foreach (DataRow row in Serpent.DtSerpent.Rows)
            {
                //Si on trouve le serpent dans la table (on cherche par 
                //numéro du serpent)
                if (row[0].ToString().Equals(textBox_num_serpent.Text.Trim()))
                {
                    row.Delete();
                }

                try
                {
                    //Sauvegarder dans la base de données
                    SqlCommandBuilder builder = new SqlCommandBuilder(Serpent.Adapter);

                    Serpent.Adapter.Update(Serpent.DsZoo, Serpent.DtSerpent.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Gestionnaire d'événement du chargement
        /// du formulaire supprimer serpent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSupprimerSerpent_Load(object sender, EventArgs e)
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
            //Query (la table Serpent). Pour cela il faut utiliser la méthode Fill
            Serpent.Adapter.Fill(Serpent.DsZoo);

            //Table retoruné
            Serpent.DtSerpent = Serpent.DsZoo.Tables[0];
        }
    }
}
