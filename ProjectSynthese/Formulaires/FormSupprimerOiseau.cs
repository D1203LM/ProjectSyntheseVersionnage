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
    public partial class FormSupprimerOiseau : Form
    {
        AdoNET Oiseau = new AdoNET();
        public FormSupprimerOiseau()
        {
            InitializeComponent();
        }

        //Inspirer du laboratoire mode indirecte
        //Méthode fait crash le programme, mais lors du redémarrage,
        // on peut voir que l'élément à été supprimé de la table.
        /// <summary>
        /// Gestionnaire de l'événement click du bouton supprimer
        /// qui supprime l'oiseau qui comporte le numéro entrer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_supprimer_Click(object sender, EventArgs e)
        {
            //Parcourir les lignes de la table
            foreach (DataRow row in Oiseau.DtOiseau.Rows)
            {
                //Si on trouve l'oiseau dans la table (on cherche par 
                //numéro de l'oiseau)

                if (row[0].ToString().Equals(textBox_num_oiseau.Text.Trim()))
                {
                    row.Delete();
                }

                try
                {
                    //Sauvegarder dans la base de données
                    SqlCommandBuilder builder = new SqlCommandBuilder(Oiseau.Adapter);

                    Oiseau.Adapter.Update(Oiseau.DsZoo, Oiseau.DtOiseau.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Gestionnaire d'événement du chargement
        /// du formulaire supprimer Oiseau
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSupprimerOiseau_Load(object sender, EventArgs e)
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