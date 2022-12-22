using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetSynthese.Classes;

namespace ProjetSynthese.Formulaires
{
    public partial class FormAfficherOiseaux : Form
    {
        //Instancier un objet Ado qui sera utilisé pour se connecter à la
        //base de données et y accéder
        AdoNET Ado = new AdoNET();
        public FormAfficherOiseaux()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gestionnaire d'événement du chargement
        /// du formulaire afficher oiseaux
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAfficherOiseaux_Load(object sender, EventArgs e)
        {

            //Écriture de la requête Sql qui va être utilisé dans l’objet Command
            string Query = "Select * from Oiseau;";

            Ado.Command.CommandText = Query;

            //Mettre dans la propriété Connection de l’objet Command l’objet
            //Connection qu’on a préparé (instancié)
            Ado.Command.Connection = Ado.Connection;

            //Préparer l'objet Adapter qui sert d’intermédiaire entre la source
            //de données et le DataSet. SelectCommand est utilisée car notre
            //commande est une commande Select
            Ado.Adapter.SelectCommand = Ado.Command;

            //Remplir le DataSet Ado.DsZoo avec le résultat de la requête
            //Query (la table Oiseau). Pour cela il faut utiliser la méthode Fill
            Ado.Adapter.Fill(Ado.DsZoo);

            //Table retoruné
            Ado.DtOiseau = Ado.DsZoo.Tables[0];

            //Afficher la table Ado.DtOiseau dans notre dataGridView
            this.dataGridViewOiseau.DataSource = Ado.DtOiseau;
        }
    }
}
