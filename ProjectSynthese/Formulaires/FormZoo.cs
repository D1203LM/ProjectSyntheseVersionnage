using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetSynthese.Formulaires;

namespace ProjetSynthese
{
    public partial class FormZoo : Form
    {
        public FormZoo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gestionnaire d'événement menu strip du formulaire parent
        /// qui ouvre le formulaire ajouter un oiseau.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajouterUnOiseauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Création d'une instance
            FormAjouterOiseau formulaire = new FormAjouterOiseau();
            //Définir le formulaire parent
            formulaire.MdiParent = this;
            //Affichage du formulaire enfant
            formulaire.Show();
            //Cacher le lable de bienvenue
            label_bienvenue.Hide();
        }

        /// <summary>
        /// Gestionnaire d'événement menu strip du formulaire parent
        /// qui ouvre le formulaire ajouter un serpent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajouterUnSerpentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Création d'une instance
            FormAjouterSerpent formulaire = new FormAjouterSerpent();
            //Définir le formulaire parent
            formulaire.MdiParent = this;
            //Affichage du formulaire enfant
            formulaire.Show();
            //Cacher le lable de bienvenue
            label_bienvenue.Hide();
        }

        /// <summary>
        /// Gestionnaire d'événement menu strip du formulaire parent
        /// qui ouvre le formulaire ajouter un enclos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajouterUnEnclosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Création d'une instance
            FormAjouterEnclos formulaire = new FormAjouterEnclos();
            //Définir le formulaire parent
            formulaire.MdiParent = this;
            //Affichage du formulaire enfant
            formulaire.Show();
            //Cacher le lable de bienvenue
            label_bienvenue.Hide();
        }

        /// <summary>
        /// Gestionnaire d'événement menu strip du formulaire parent
        /// qui ouvre le formulaire Afficher les oiseaux
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void afficherLesOiseauxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Création d'une instance
            FormAfficherOiseaux formulaire = new FormAfficherOiseaux();
            //Définir le formulaire parent
            formulaire.MdiParent = this;
            //Affichage du formulaire enfant
            formulaire.Show();
            //Cacher le lable de bienvenue
            label_bienvenue.Hide();
        }

        /// <summary>
        /// Gestionnaire d'événement menu strip du formulaire parent
        /// qui ouvre le formulaire Afficher les serpents
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void afficherLesSerpentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Création d'une instance
            FormAfficherSerpents formulaire = new FormAfficherSerpents();
            //Définir le formulaire parent
            formulaire.MdiParent = this;
            //Affichage du formulaire enfant
            formulaire.Show();
            //Cacher le lable de bienvenue
            label_bienvenue.Hide();
        }

        /// <summary>
        /// Gestionnaire d'événement menu strip du formulaire parent
        /// qui ouvre le formulaire supprimer oiseau
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supprimerUnOiseauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Création d'une instance
            FormSupprimerOiseau formulaire = new FormSupprimerOiseau();
            //Définir le formulaire parent
            formulaire.MdiParent = this;
            //Affichage du formulaire enfant
            formulaire.Show();
            //Cacher le lable de bienvenue
            label_bienvenue.Hide();
        }

        /// <summary>
        /// Gestionnaire d'événement menu strip du formulaire parent
        /// qui ouvre le formulaire modifier oiseau
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifierUnOiseauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Création d'une instance
            FormModifierOiseau formulaire = new FormModifierOiseau();
            //Définir le formulaire parent
            formulaire.MdiParent = this;
            //Affichage du formulaire enfant
            formulaire.Show();
            //Cacher le lable de bienvenue
            label_bienvenue.Hide();
        }

        /// <summary>
        /// Gestionnaire d'événement menu strip du formulaire parent
        /// qui ouvre le formulaire modifier serpent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifierUnSerpentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Création d'une instance
            FormModifierSerpent formulaire = new FormModifierSerpent();
            //Définir le formulaire parent
            formulaire.MdiParent = this;
            //Affichage du formulaire enfant
            formulaire.Show();
            //Cacher le lable de bienvenue
            label_bienvenue.Hide();
        }

        /// <summary>
        /// Gestionnaire d'événement menu strip du formulaire parent
        /// qui ouvre le formulaire modifier enclos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifierUnEnclosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Création d'une instance
            FormModifierEnclos formulaire = new FormModifierEnclos();
            //Définir le formulaire parent
            formulaire.MdiParent = this;
            //Affichage du formulaire enfant
            formulaire.Show();
            //Cacher le lable de bienvenue
            label_bienvenue.Hide();
        }

        /// <summary>
        /// Gestionnaire d'événement menu strip du formulaire parent
        /// qui ouvre le formulaire supprimer enclos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supprimerUnEnclosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Création d'une instance
            FormSupprimerEnclos formulaire = new FormSupprimerEnclos();
            //Définir le formulaire parent
            formulaire.MdiParent = this;
            //Affichage du formulaire enfant
            formulaire.Show();
            //Cacher le lable de bienvenue
            label_bienvenue.Hide();
        }

        /// <summary>
        /// Gestionnaire d'événement menu strip du formulaire parent
        /// qui ouvre le formulaire supprimer serpent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supprimerUnSerpentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Création d'une instance
            FormSupprimerSerpent formulaire = new FormSupprimerSerpent();
            //Définir le formulaire parent
            formulaire.MdiParent = this;
            //Affichage du formulaire enfant
            formulaire.Show();
            //Cacher le lable de bienvenue
            label_bienvenue.Hide();
        }

        /// <summary>
        /// Gestionnaire d'événement menu strip du formulaire parent
        /// qui ouvre le formulaire afficher enclos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void afficherLesEnclosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Création d'une instance
            FormAfficherEnclos formulaire = new FormAfficherEnclos();
            //Définir le formulaire parent
            formulaire.MdiParent = this;
            //Affichage du formulaire enfant
            formulaire.Show();
            //Cacher le lable de bienvenue
            label_bienvenue.Hide();
        }
    }
}