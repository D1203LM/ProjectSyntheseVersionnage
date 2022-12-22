namespace ProjetSynthese.Formulaires
{
    partial class FormModifierSerpent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifierSerpent));
            this.label_erreur_venimeux = new System.Windows.Forms.Label();
            this.label_erreur_couleur_serpent = new System.Windows.Forms.Label();
            this.label_erreur_espece_serpent = new System.Windows.Forms.Label();
            this.label_erreur_poids = new System.Windows.Forms.Label();
            this.label_erreur_numero = new System.Windows.Forms.Label();
            this.comboBox_venimeux = new System.Windows.Forms.ComboBox();
            this.comboBox_couleur_serpent = new System.Windows.Forms.ComboBox();
            this.comboBox_espece_serpent = new System.Windows.Forms.ComboBox();
            this.label_venimeux = new System.Windows.Forms.Label();
            this.label_couleur_serpent = new System.Windows.Forms.Label();
            this.label_espece_serpent = new System.Windows.Forms.Label();
            this.textBox_poids_serpent = new System.Windows.Forms.TextBox();
            this.textBox_num_serpent = new System.Windows.Forms.TextBox();
            this.label_choix_animal = new System.Windows.Forms.Label();
            this.label_poids_serpent = new System.Windows.Forms.Label();
            this.label_num_serpent = new System.Windows.Forms.Label();
            this.label_modif_serpent = new System.Windows.Forms.Label();
            this.button_valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_erreur_venimeux
            // 
            this.label_erreur_venimeux.ForeColor = System.Drawing.Color.Red;
            this.label_erreur_venimeux.Location = new System.Drawing.Point(33, 402);
            this.label_erreur_venimeux.Name = "label_erreur_venimeux";
            this.label_erreur_venimeux.Size = new System.Drawing.Size(174, 13);
            this.label_erreur_venimeux.TabIndex = 106;
            this.label_erreur_venimeux.Text = "Ce champ est obligatoire";
            this.label_erreur_venimeux.Visible = false;
            // 
            // label_erreur_couleur_serpent
            // 
            this.label_erreur_couleur_serpent.ForeColor = System.Drawing.Color.Red;
            this.label_erreur_couleur_serpent.Location = new System.Drawing.Point(33, 333);
            this.label_erreur_couleur_serpent.Name = "label_erreur_couleur_serpent";
            this.label_erreur_couleur_serpent.Size = new System.Drawing.Size(174, 13);
            this.label_erreur_couleur_serpent.TabIndex = 105;
            this.label_erreur_couleur_serpent.Text = "Ce champ est obligatoire";
            this.label_erreur_couleur_serpent.Visible = false;
            // 
            // label_erreur_espece_serpent
            // 
            this.label_erreur_espece_serpent.ForeColor = System.Drawing.Color.Red;
            this.label_erreur_espece_serpent.Location = new System.Drawing.Point(32, 264);
            this.label_erreur_espece_serpent.Name = "label_erreur_espece_serpent";
            this.label_erreur_espece_serpent.Size = new System.Drawing.Size(174, 13);
            this.label_erreur_espece_serpent.TabIndex = 104;
            this.label_erreur_espece_serpent.Text = "Ce champ est obligatoire";
            this.label_erreur_espece_serpent.Visible = false;
            // 
            // label_erreur_poids
            // 
            this.label_erreur_poids.ForeColor = System.Drawing.Color.Red;
            this.label_erreur_poids.Location = new System.Drawing.Point(33, 192);
            this.label_erreur_poids.Name = "label_erreur_poids";
            this.label_erreur_poids.Size = new System.Drawing.Size(174, 12);
            this.label_erreur_poids.TabIndex = 103;
            this.label_erreur_poids.Text = "Le poids doit être un nombre entier";
            this.label_erreur_poids.Visible = false;
            // 
            // label_erreur_numero
            // 
            this.label_erreur_numero.ForeColor = System.Drawing.Color.Red;
            this.label_erreur_numero.Location = new System.Drawing.Point(33, 122);
            this.label_erreur_numero.Name = "label_erreur_numero";
            this.label_erreur_numero.Size = new System.Drawing.Size(174, 13);
            this.label_erreur_numero.TabIndex = 102;
            this.label_erreur_numero.Text = "Le numéro doit comporter 6 chiffres";
            this.label_erreur_numero.Visible = false;
            // 
            // comboBox_venimeux
            // 
            this.comboBox_venimeux.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_venimeux.FormattingEnabled = true;
            this.comboBox_venimeux.Items.AddRange(new object[] {
            "Non",
            "Oui"});
            this.comboBox_venimeux.Location = new System.Drawing.Point(35, 378);
            this.comboBox_venimeux.Name = "comboBox_venimeux";
            this.comboBox_venimeux.Size = new System.Drawing.Size(213, 21);
            this.comboBox_venimeux.TabIndex = 101;
            // 
            // comboBox_couleur_serpent
            // 
            this.comboBox_couleur_serpent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_couleur_serpent.FormattingEnabled = true;
            this.comboBox_couleur_serpent.Items.AddRange(new object[] {
            "Noir",
            "Vert",
            "Orange"});
            this.comboBox_couleur_serpent.Location = new System.Drawing.Point(35, 309);
            this.comboBox_couleur_serpent.Name = "comboBox_couleur_serpent";
            this.comboBox_couleur_serpent.Size = new System.Drawing.Size(213, 21);
            this.comboBox_couleur_serpent.TabIndex = 100;
            // 
            // comboBox_espece_serpent
            // 
            this.comboBox_espece_serpent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_espece_serpent.FormattingEnabled = true;
            this.comboBox_espece_serpent.Items.AddRange(new object[] {
            "Cobra",
            "Mamba",
            "Anaconda"});
            this.comboBox_espece_serpent.Location = new System.Drawing.Point(36, 240);
            this.comboBox_espece_serpent.Name = "comboBox_espece_serpent";
            this.comboBox_espece_serpent.Size = new System.Drawing.Size(212, 21);
            this.comboBox_espece_serpent.TabIndex = 99;
            // 
            // label_venimeux
            // 
            this.label_venimeux.AutoSize = true;
            this.label_venimeux.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_venimeux.Location = new System.Drawing.Point(31, 355);
            this.label_venimeux.Name = "label_venimeux";
            this.label_venimeux.Size = new System.Drawing.Size(79, 20);
            this.label_venimeux.TabIndex = 98;
            this.label_venimeux.Text = "Venimeux";
            // 
            // label_couleur_serpent
            // 
            this.label_couleur_serpent.AutoSize = true;
            this.label_couleur_serpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_couleur_serpent.Location = new System.Drawing.Point(31, 286);
            this.label_couleur_serpent.Name = "label_couleur_serpent";
            this.label_couleur_serpent.Size = new System.Drawing.Size(143, 20);
            this.label_couleur_serpent.TabIndex = 97;
            this.label_couleur_serpent.Text = "Couleur de l\'oiseau";
            // 
            // label_espece_serpent
            // 
            this.label_espece_serpent.AutoSize = true;
            this.label_espece_serpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_espece_serpent.Location = new System.Drawing.Point(31, 216);
            this.label_espece_serpent.Name = "label_espece_serpent";
            this.label_espece_serpent.Size = new System.Drawing.Size(143, 20);
            this.label_espece_serpent.TabIndex = 96;
            this.label_espece_serpent.Text = "Espèce du serpent";
            // 
            // textBox_poids_serpent
            // 
            this.textBox_poids_serpent.Location = new System.Drawing.Point(36, 169);
            this.textBox_poids_serpent.Name = "textBox_poids_serpent";
            this.textBox_poids_serpent.Size = new System.Drawing.Size(212, 20);
            this.textBox_poids_serpent.TabIndex = 95;
            // 
            // textBox_num_serpent
            // 
            this.textBox_num_serpent.Location = new System.Drawing.Point(36, 99);
            this.textBox_num_serpent.Name = "textBox_num_serpent";
            this.textBox_num_serpent.Size = new System.Drawing.Size(212, 20);
            this.textBox_num_serpent.TabIndex = 94;
            // 
            // label_choix_animal
            // 
            this.label_choix_animal.AutoSize = true;
            this.label_choix_animal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_choix_animal.Location = new System.Drawing.Point(32, 216);
            this.label_choix_animal.Name = "label_choix_animal";
            this.label_choix_animal.Size = new System.Drawing.Size(0, 20);
            this.label_choix_animal.TabIndex = 93;
            // 
            // label_poids_serpent
            // 
            this.label_poids_serpent.AutoSize = true;
            this.label_poids_serpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_poids_serpent.Location = new System.Drawing.Point(32, 146);
            this.label_poids_serpent.Name = "label_poids_serpent";
            this.label_poids_serpent.Size = new System.Drawing.Size(128, 20);
            this.label_poids_serpent.TabIndex = 92;
            this.label_poids_serpent.Text = "Poids du serpent";
            // 
            // label_num_serpent
            // 
            this.label_num_serpent.AutoSize = true;
            this.label_num_serpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_num_serpent.Location = new System.Drawing.Point(32, 75);
            this.label_num_serpent.Name = "label_num_serpent";
            this.label_num_serpent.Size = new System.Drawing.Size(145, 20);
            this.label_num_serpent.TabIndex = 91;
            this.label_num_serpent.Text = "Numéro du serpent";
            // 
            // label_modif_serpent
            // 
            this.label_modif_serpent.AutoSize = true;
            this.label_modif_serpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_modif_serpent.Location = new System.Drawing.Point(31, 25);
            this.label_modif_serpent.Name = "label_modif_serpent";
            this.label_modif_serpent.Size = new System.Drawing.Size(197, 25);
            this.label_modif_serpent.TabIndex = 90;
            this.label_modif_serpent.Text = "Modifier un serpent";
            // 
            // button_valider
            // 
            this.button_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_valider.Location = new System.Drawing.Point(75, 427);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(120, 31);
            this.button_valider.TabIndex = 89;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            this.button_valider.Click += new System.EventHandler(this.button_valider_Click);
            // 
            // FormModifierSerpent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 477);
            this.Controls.Add(this.label_erreur_venimeux);
            this.Controls.Add(this.label_erreur_couleur_serpent);
            this.Controls.Add(this.label_erreur_espece_serpent);
            this.Controls.Add(this.label_erreur_poids);
            this.Controls.Add(this.label_erreur_numero);
            this.Controls.Add(this.comboBox_venimeux);
            this.Controls.Add(this.comboBox_couleur_serpent);
            this.Controls.Add(this.comboBox_espece_serpent);
            this.Controls.Add(this.label_venimeux);
            this.Controls.Add(this.label_couleur_serpent);
            this.Controls.Add(this.label_espece_serpent);
            this.Controls.Add(this.textBox_poids_serpent);
            this.Controls.Add(this.textBox_num_serpent);
            this.Controls.Add(this.label_choix_animal);
            this.Controls.Add(this.label_poids_serpent);
            this.Controls.Add(this.label_num_serpent);
            this.Controls.Add(this.label_modif_serpent);
            this.Controls.Add(this.button_valider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModifierSerpent";
            this.Text = "FormModifierSerpent";
            this.Load += new System.EventHandler(this.FormModifierSerpent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_erreur_venimeux;
        private System.Windows.Forms.Label label_erreur_couleur_serpent;
        private System.Windows.Forms.Label label_erreur_espece_serpent;
        private System.Windows.Forms.Label label_erreur_poids;
        private System.Windows.Forms.Label label_erreur_numero;
        private System.Windows.Forms.ComboBox comboBox_venimeux;
        private System.Windows.Forms.ComboBox comboBox_couleur_serpent;
        private System.Windows.Forms.ComboBox comboBox_espece_serpent;
        private System.Windows.Forms.Label label_venimeux;
        private System.Windows.Forms.Label label_couleur_serpent;
        private System.Windows.Forms.Label label_espece_serpent;
        private System.Windows.Forms.TextBox textBox_poids_serpent;
        private System.Windows.Forms.TextBox textBox_num_serpent;
        private System.Windows.Forms.Label label_choix_animal;
        private System.Windows.Forms.Label label_poids_serpent;
        private System.Windows.Forms.Label label_num_serpent;
        private System.Windows.Forms.Label label_modif_serpent;
        private System.Windows.Forms.Button button_valider;
    }
}