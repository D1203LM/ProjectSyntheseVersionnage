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
    public partial class FormSupprimerEnclos : Form
    {
        AdoNET Enclos = new AdoNET();
        public FormSupprimerEnclos()
        {
            InitializeComponent();
        }

        //Inspirer du laboratoire mode indirecte
        //Méthode fait crash le programme, mais lors du redémarrage,
        // on peut voir que l'élément à été supprimé de la table.
        /// <summary>
        /// Gestionnaire de l'événement click du bouton supprimer
        /// qui supprime l'enlos qui comporte le numéro entrer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_supprimer_Click(object sender, EventArgs e)
        {
            //Parcourir les lignes de la table
            foreach (DataRow row in Enclos.DtEnclos.Rows)
            {
                //Si on trouve l'enclos dans la table (on cherche par 
                //numéro de l'enclos)
                if (row[0].ToString().Equals(textBox_num_enclos.Text.Trim()))
                {
                    row.Delete();
                }

                try
                {
                    //Sauvegarder dans la base de données
                    SqlCommandBuilder builder = new SqlCommandBuilder(Enclos.Adapter);

                    Enclos.Adapter.Update(Enclos.DsZoo, Enclos.DtEnclos.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Gestionnaire d'événement du chargement
        /// du formulaire supprimer enclos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSupprimerEnclos_Load(object sender, EventArgs e)
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
            //Query (la table Enclos). Pour cela il faut utiliser la méthode Fill
            Enclos.Adapter.Fill(Enclos.DsZoo);

            //Table retoruné
            Enclos.DtEnclos = Enclos.DsZoo.Tables[0];
        }
    }
}
