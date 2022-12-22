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
    public partial class FormAjouterOiseau : Form
    {
        //Instancier un objet Oiseau
        AdoNET Oiseau = new AdoNET();
        public FormAjouterOiseau()
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
            Oiseau o = new Oiseau();
            o.NumAnimal = textBox_num_oiseau.Text;
            //Vérifier si le textbox est vide ou le numéro ne correspond pas à la validation
            if (o.NumAnimal != textBox_num_oiseau.Text
                || o.NumAnimal == "")
            {
                //Afficher le message d'erreur
                label_erreur_numero.Visible = true;
                //Effacer le text du textbox
                textBox_num_oiseau.Clear();
            }
            else
            {
                //Cacher le message d'erreur
                label_erreur_numero.Visible = false;
            }

            //Vérifier le poids
            //Inspirer de : https://stackify.com/csharp-exception-handling-best-practices/#:~:text=The%20C%23%20try%20and%20catch,error%2C%20or%20crash%20the%20application.
            // et : https://stackoverflow.com/questions/11931770/get-integer-from-textbox
            try
            {
                o.Poids = int.Parse(textBox_poids_oiseau.Text);
                if (o.Poids != int.Parse(textBox_poids_oiseau.Text)
                    || o.Poids == 0)
                {
                    //Afficher le message d'erreur
                    label_erreur_poids.Visible = true;
                    //Effacer le text du textbox
                    textBox_poids_oiseau.Clear();
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
            if (comboBox_espece_oiseau.Text == "")
            {
                //Afficher le message d'erreur
                label_erreur_espece_oiseau.Visible = true;
            }
            else
            {
                //Cacher le message d'erreur
                label_erreur_espece_oiseau.Visible = false;
            }

            //Vérifier la couleur
            if (comboBox_couleur_oiseau.Text == "")
            {
                //Afficher le message d'erreur
                label_erreur_couleur_oiseau.Visible = true;
            }
            else
            {
                //Cacher le message d'erreur
                label_erreur_couleur_oiseau.Visible = false;
            }

            //Vérifier le bec
            try
            {
                o.LongueurBec = int.Parse(textBox_longueur_bec.Text);
                if (o.LongueurBec != int.Parse(textBox_longueur_bec.Text)
                    || o.LongueurBec == 0)
                {
                    //Afficher le message d'erreur
                    label_erreur_bec.Visible = true;
                    //Effacer le text du textbox
                    textBox_longueur_bec.Clear();
                }
                else
                {
                    //Cacher le message d'erreur
                    label_erreur_bec.Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le poids doit être un entier");
            }

            //Vérifier si toutes les valeurs correspondent aux contraintes
            try
            {
                if (o.NumAnimal == textBox_num_oiseau.Text
                && o.Poids == int.Parse(textBox_poids_oiseau.Text)
                && comboBox_espece_oiseau.Text != ""
                && comboBox_couleur_oiseau.Text != ""
                && o.LongueurBec == int.Parse(textBox_longueur_bec.Text))
                {
                    //Inspirer du laboratoire mode indirecte
                    //Ajouter l'animal à la table Oiseau
                    //Instancier un objet DataRow (une ligne de la table) : DataRow UnOiseau
                    DataRow UnOiseau = Oiseau.DtOiseau.NewRow();

                    //Mettre les valeurs entrées par l'utilisateur dans l'objet DataRow UnOiseau
                    UnOiseau[0] = textBox_num_oiseau.Text.Trim();
                    UnOiseau[1] = textBox_poids_oiseau.Text.Trim();
                    UnOiseau[2] = comboBox_espece_oiseau.Text.Trim();
                    UnOiseau[3] = comboBox_couleur_oiseau.Text.Trim();
                    UnOiseau[4] = textBox_longueur_bec.Text.Trim();

                    // Ajouter la ligne au DataTable DtOiseau
                    Oiseau.DtOiseau.Rows.Add(UnOiseau);

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

                    //Effacer le text du textbox
                    textBox_num_oiseau.Clear();
                    textBox_poids_oiseau.Clear();
                    textBox_longueur_bec.Clear();
                    //Afficher un message qui confirme l'ajout
                    MessageBox.Show("L'Oiseau a été ajouté à la Table!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FormAjouterOiseau_Load(object sender, EventArgs e)
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

            //Remplir le DataSet Ado.DsZoo avec le résultat de la requête
            //Query (la table Oiseau). Pour cela il faut utiliser la méthode Fill
            Oiseau.Adapter.Fill(Oiseau.DsZoo);

            //Table retoruné
            Oiseau.DtOiseau = Oiseau.DsZoo.Tables[0];
        }
    }
}
