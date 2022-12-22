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
    public partial class FormAjouterSerpent : Form
    {
        AdoNET Serpent = new AdoNET();
        public FormAjouterSerpent()
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
            Serpent s = new Serpent();
            s.NumAnimal = textBox_num_serpent.Text;
            //Vérifier si le textebox est vide ou le numéro ne correspond pas à la validation
            if (s.NumAnimal != textBox_num_serpent.Text
                || s.NumAnimal == "")
            {
                //Afficher le message d'erreur
                label_erreur_numero.Visible = true;
                //Effacer le text du textbox
                textBox_num_serpent.Clear();
            }
            else
            {
                //Cacher le message d'erreur
                label_erreur_numero.Visible = false;
            }

            //Vérifier le poids
            //Inspiré de : https://stackify.com/csharp-exception-handling-best-practices/#:~:text=The%20C%23%20try%20and%20catch,error%2C%20or%20crash%20the%20application.
            // et : https://stackoverflow.com/questions/11931770/get-integer-from-textbox
            try
            {
                s.Poids = int.Parse(textBox_poids_serpent.Text);
                if (s.Poids != int.Parse(textBox_poids_serpent.Text)
                    || s.Poids == 0)
                {
                    //Afficher le message d'erreur
                    label_erreur_poids.Visible = true;
                    //Effacer le text du textbox
                    textBox_poids_serpent.Clear();
                }
                else
                {
                    //Cacher le message d'erreur
                    label_erreur_poids.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le poids doit être un entier");
            }

            //Vérifier l'espèce
            if (comboBox_espece_serpent.Text == "")
            {
                //Afficher le message d'erreur
                label_erreur_espece_serpent.Visible = true;
            }
            else
            {
                //Cacher le message d'erreur
                label_erreur_espece_serpent.Visible = false;
            }

            //Vérifier la couleur
            if (comboBox_couleur_serpent.Text == "")
            {
                //Afficher le message d'erreur
                label_erreur_couleur_serpent.Visible = true;
            }
            else
            {
                //Cacher le message d'erreur
                label_erreur_couleur_serpent.Visible = false;
            }

            //Vérifier venimeux
            if (comboBox_venimeux.Text == "")
            {
                //Afficher le message d'erreur
                label_erreur_venimeux.Visible = true;
            }
            else
            {
                //Cacher le message d'erreur
                label_erreur_venimeux.Visible = false;
            }

            //Vérifier si toutes les valeurs correspondent aux contraintes
            try
            {
                if (s.NumAnimal == textBox_num_serpent.Text
                && s.Poids == int.Parse(textBox_poids_serpent.Text)
                && comboBox_espece_serpent.Text != ""
                && comboBox_couleur_serpent.Text != ""
                && comboBox_venimeux.Text != "")
                {
                    //Inspirer du laboratoire mode indirecte
                    //Ajouter l'animal à la table Serpent
                    //Instancier un objet DataRow (une ligne de la table) : DataRow UnSerpent
                    DataRow UnSerpent = Serpent.DtSerpent.NewRow();

                    //Mettre les valeurs entrées par l'utilisateur dans l'objet DataRow UnOiseau
                    UnSerpent[0] = textBox_num_serpent.Text.Trim();
                    UnSerpent[1] = textBox_poids_serpent.Text.Trim();
                    UnSerpent[2] = comboBox_espece_serpent.Text.Trim();
                    UnSerpent[3] = comboBox_couleur_serpent.Text.Trim();
                    UnSerpent[4] = comboBox_venimeux.Text.Trim();

                    // Ajouter la ligne au DataTable DtOiseau
                    Serpent.DtSerpent.Rows.Add(UnSerpent);

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

                    //Effacer le text du textbox
                    textBox_num_serpent.Clear();
                    textBox_poids_serpent.Clear();
                    //Afficher un message qui confirme l'ajout
                    MessageBox.Show("L'animal a été ajouté à la liste!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormAjouterSerpent_Load(object sender, EventArgs e)
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

            //Remplir le DataSet Ado.DsZoo avec le résultat de la requête
            //Query (la table Oiseau). Pour cela il faut utiliser la méthode Fill
            Serpent.Adapter.Fill(Serpent.DsZoo);

            //Table retoruné
            Serpent.DtSerpent = Serpent.DsZoo.Tables[0];
        }
    }
}
