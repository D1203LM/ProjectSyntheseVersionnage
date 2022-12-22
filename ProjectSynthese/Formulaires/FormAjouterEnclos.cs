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
    public partial class FormAjouterEnclos : Form
    {
        //Instancier un objet Enclos
        AdoNET Enclos = new AdoNET();
        public FormAjouterEnclos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gestionnaire de l'événement click du bouton ajouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ajouter_Click(object sender, EventArgs e)
        {
            //Création d'une instance
            Enclos en = new Enclos();
            en.NumEnclos = textBox_num_enclos.Text;
            //Vérifier si le textbox est vide ou le numéro ne correspond pas à la validation
            if (en.NumEnclos != textBox_num_enclos.Text
                || en.NumEnclos == "")
            {
                //Afficher le message d'erreur
                label_erreur_numero.Visible = true;
                //Effacer le text du textbox
                textBox_num_enclos.Clear();
            }
            else
            {
                //Cacher le message d'erreur
                label_erreur_numero.Visible = false;
            }

            //Vérifier la taille
            if (comboBox_taille_enclos.Text == "")
            {
                //Afficher le message d'erreur
                label_erreur_taille_enclos.Visible = true;
            }
            else
            {
                //Cacher le message d'erreur
                label_erreur_taille_enclos.Visible = false;
            }

            //Vérifier si toutes les valeurs correspondent aux contraintes
            if (en.NumEnclos == textBox_num_enclos.Text
                && comboBox_taille_enclos.Text != "")
            {
                //Inspirer du laboratoire mode indirecte
                //Ajouter l'animal à la table Oiseau
                //Instancier un objet DataRow (une ligne de la table) : DataRow UnOiseau
                DataRow UnEnclos = Enclos.DtEnclos.NewRow();

                //Mettre les valeurs entrées par l'utilisateur dans l'objet DataRow UnOiseau
                UnEnclos[0] = textBox_num_enclos.Text.Trim();
                UnEnclos[1] = comboBox_taille_enclos.Text.Trim();

                // Ajouter la ligne au DataTable DtEnclos
                Enclos.DtEnclos.Rows.Add(UnEnclos);

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

                //Effacer le text du textbox
                textBox_num_enclos.Clear();
                //Afficher un message qui confirme l'ajout
                MessageBox.Show("L'enclos a été ajouté à la table!");
            }
        }

        private void FormAjouterEnclos_Load(object sender, EventArgs e)
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