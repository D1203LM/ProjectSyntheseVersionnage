namespace ProjetSynthese.Formulaires
{
    partial class FormModifierOiseau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifierOiseau));
            this.label_modif_oiseau = new System.Windows.Forms.Label();
            this.label_erreur_bec = new System.Windows.Forms.Label();
            this.label_erreur_couleur_oiseau = new System.Windows.Forms.Label();
            this.label_erreur_espece_oiseau = new System.Windows.Forms.Label();
            this.label_erreur_poids = new System.Windows.Forms.Label();
            this.label_erreur_numero = new System.Windows.Forms.Label();
            this.button_valider = new System.Windows.Forms.Button();
            this.comboBox_couleur_oiseau = new System.Windows.Forms.ComboBox();
            this.comboBox_espece_oiseau = new System.Windows.Forms.ComboBox();
            this.textBox_longueur_bec = new System.Windows.Forms.TextBox();
            this.label_Longueur_bec = new System.Windows.Forms.Label();
            this.label_couleur_oiseau = new System.Windows.Forms.Label();
            this.label_espece_oiseau = new System.Windows.Forms.Label();
            this.textBox_poids_oiseau = new System.Windows.Forms.TextBox();
            this.textBox_num_oiseau = new System.Windows.Forms.TextBox();
            this.label_choix_animal = new System.Windows.Forms.Label();
            this.label_poids_oiseau = new System.Windows.Forms.Label();
            this.label_num_oiseau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_modif_oiseau
            // 
            this.label_modif_oiseau.AutoSize = true;
            this.label_modif_oiseau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_modif_oiseau.Location = new System.Drawing.Point(47, 28);
            this.label_modif_oiseau.Name = "label_modif_oiseau";
            this.label_modif_oiseau.Size = new System.Drawing.Size(189, 25);
            this.label_modif_oiseau.TabIndex = 64;
            this.label_modif_oiseau.Text = "Modifier un oiseau";
            // 
            // label_erreur_bec
            // 
            this.label_erreur_bec.ForeColor = System.Drawing.Color.Red;
            this.label_erreur_bec.Location = new System.Drawing.Point(31, 408);
            this.label_erreur_bec.Name = "label_erreur_bec";
            this.label_erreur_bec.Size = new System.Drawing.Size(228, 18);
            this.label_erreur_bec.TabIndex = 63;
            this.label_erreur_bec.Text = "La longueur du bec doit être un nombre entier\r\n";
            this.label_erreur_bec.Visible = false;
            // 
            // label_erreur_couleur_oiseau
            // 
            this.label_erreur_couleur_oiseau.ForeColor = System.Drawing.Color.Red;
            this.label_erreur_couleur_oiseau.Location = new System.Drawing.Point(31, 340);
            this.label_erreur_couleur_oiseau.Name = "label_erreur_couleur_oiseau";
            this.label_erreur_couleur_oiseau.Size = new System.Drawing.Size(174, 13);
            this.label_erreur_couleur_oiseau.TabIndex = 62;
            this.label_erreur_couleur_oiseau.Text = "Ce champ est obligatoire";
            this.label_erreur_couleur_oiseau.Visible = false;
            // 
            // label_erreur_espece_oiseau
            // 
            this.label_erreur_espece_oiseau.ForeColor = System.Drawing.Color.Red;
            this.label_erreur_espece_oiseau.Location = new System.Drawing.Point(31, 271);
            this.label_erreur_espece_oiseau.Name = "label_erreur_espece_oiseau";
            this.label_erreur_espece_oiseau.Size = new System.Drawing.Size(174, 13);
            this.label_erreur_espece_oiseau.TabIndex = 61;
            this.label_erreur_espece_oiseau.Text = "Ce champ est obligatoire";
            this.label_erreur_espece_oiseau.Visible = false;
            // 
            // label_erreur_poids
            // 
            this.label_erreur_poids.ForeColor = System.Drawing.Color.Red;
            this.label_erreur_poids.Location = new System.Drawing.Point(31, 199);
            this.label_erreur_poids.Name = "label_erreur_poids";
            this.label_erreur_poids.Size = new System.Drawing.Size(174, 12);
            this.label_erreur_poids.TabIndex = 60;
            this.label_erreur_poids.Text = "Le poids doit être un nombre entier";
            this.label_erreur_poids.Visible = false;
            // 
            // label_erreur_numero
            // 
            this.label_erreur_numero.ForeColor = System.Drawing.Color.Red;
            this.label_erreur_numero.Location = new System.Drawing.Point(31, 129);
            this.label_erreur_numero.Name = "label_erreur_numero";
            this.label_erreur_numero.Size = new System.Drawing.Size(174, 13);
            this.label_erreur_numero.TabIndex = 59;
            this.label_erreur_numero.Text = "Le numéro doit comporter 6 chiffres";
            this.label_erreur_numero.Visible = false;
            // 
            // button_valider
            // 
            this.button_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_valider.Location = new System.Drawing.Point(85, 429);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(120, 31);
            this.button_valider.TabIndex = 58;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            this.button_valider.Click += new System.EventHandler(this.button_valider_Click);
            // 
            // comboBox_couleur_oiseau
            // 
            this.comboBox_couleur_oiseau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_couleur_oiseau.FormattingEnabled = true;
            this.comboBox_couleur_oiseau.Items.AddRange(new object[] {
            "Noir",
            "Bleu",
            "Blanc"});
            this.comboBox_couleur_oiseau.Location = new System.Drawing.Point(33, 316);
            this.comboBox_couleur_oiseau.Name = "comboBox_couleur_oiseau";
            this.comboBox_couleur_oiseau.Size = new System.Drawing.Size(214, 21);
            this.comboBox_couleur_oiseau.TabIndex = 57;
            // 
            // comboBox_espece_oiseau
            // 
            this.comboBox_espece_oiseau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_espece_oiseau.FormattingEnabled = true;
            this.comboBox_espece_oiseau.Items.AddRange(new object[] {
            "Toucan",
            "Ara",
            "Chouette"});
            this.comboBox_espece_oiseau.Location = new System.Drawing.Point(34, 247);
            this.comboBox_espece_oiseau.Name = "comboBox_espece_oiseau";
            this.comboBox_espece_oiseau.Size = new System.Drawing.Size(213, 21);
            this.comboBox_espece_oiseau.TabIndex = 56;
            // 
            // textBox_longueur_bec
            // 
            this.textBox_longueur_bec.Location = new System.Drawing.Point(34, 385);
            this.textBox_longueur_bec.Name = "textBox_longueur_bec";
            this.textBox_longueur_bec.Size = new System.Drawing.Size(213, 20);
            this.textBox_longueur_bec.TabIndex = 55;
            // 
            // label_Longueur_bec
            // 
            this.label_Longueur_bec.AutoSize = true;
            this.label_Longueur_bec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Longueur_bec.Location = new System.Drawing.Point(29, 362);
            this.label_Longueur_bec.Name = "label_Longueur_bec";
            this.label_Longueur_bec.Size = new System.Drawing.Size(129, 20);
            this.label_Longueur_bec.TabIndex = 54;
            this.label_Longueur_bec.Text = "Longueur du bec";
            // 
            // label_couleur_oiseau
            // 
            this.label_couleur_oiseau.AutoSize = true;
            this.label_couleur_oiseau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_couleur_oiseau.Location = new System.Drawing.Point(29, 293);
            this.label_couleur_oiseau.Name = "label_couleur_oiseau";
            this.label_couleur_oiseau.Size = new System.Drawing.Size(143, 20);
            this.label_couleur_oiseau.TabIndex = 53;
            this.label_couleur_oiseau.Text = "Couleur de l\'oiseau";
            // 
            // label_espece_oiseau
            // 
            this.label_espece_oiseau.AutoSize = true;
            this.label_espece_oiseau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_espece_oiseau.Location = new System.Drawing.Point(29, 223);
            this.label_espece_oiseau.Name = "label_espece_oiseau";
            this.label_espece_oiseau.Size = new System.Drawing.Size(142, 20);
            this.label_espece_oiseau.TabIndex = 52;
            this.label_espece_oiseau.Text = "Espèce de l\'oiseau";
            // 
            // textBox_poids_oiseau
            // 
            this.textBox_poids_oiseau.Location = new System.Drawing.Point(34, 176);
            this.textBox_poids_oiseau.Name = "textBox_poids_oiseau";
            this.textBox_poids_oiseau.Size = new System.Drawing.Size(213, 20);
            this.textBox_poids_oiseau.TabIndex = 51;
            // 
            // textBox_num_oiseau
            // 
            this.textBox_num_oiseau.Location = new System.Drawing.Point(34, 106);
            this.textBox_num_oiseau.Name = "textBox_num_oiseau";
            this.textBox_num_oiseau.Size = new System.Drawing.Size(213, 20);
            this.textBox_num_oiseau.TabIndex = 50;
            // 
            // label_choix_animal
            // 
            this.label_choix_animal.AutoSize = true;
            this.label_choix_animal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_choix_animal.Location = new System.Drawing.Point(30, 223);
            this.label_choix_animal.Name = "label_choix_animal";
            this.label_choix_animal.Size = new System.Drawing.Size(0, 20);
            this.label_choix_animal.TabIndex = 49;
            // 
            // label_poids_oiseau
            // 
            this.label_poids_oiseau.AutoSize = true;
            this.label_poids_oiseau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_poids_oiseau.Location = new System.Drawing.Point(30, 153);
            this.label_poids_oiseau.Name = "label_poids_oiseau";
            this.label_poids_oiseau.Size = new System.Drawing.Size(127, 20);
            this.label_poids_oiseau.TabIndex = 48;
            this.label_poids_oiseau.Text = "Poids de l\'oiseau";
            // 
            // label_num_oiseau
            // 
            this.label_num_oiseau.AutoSize = true;
            this.label_num_oiseau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_num_oiseau.Location = new System.Drawing.Point(30, 82);
            this.label_num_oiseau.Name = "label_num_oiseau";
            this.label_num_oiseau.Size = new System.Drawing.Size(144, 20);
            this.label_num_oiseau.TabIndex = 47;
            this.label_num_oiseau.Text = "Numéro de l\'oiseau";
            // 
            // FormModifierOiseau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 498);
            this.Controls.Add(this.label_modif_oiseau);
            this.Controls.Add(this.label_erreur_bec);
            this.Controls.Add(this.label_erreur_couleur_oiseau);
            this.Controls.Add(this.label_erreur_espece_oiseau);
            this.Controls.Add(this.label_erreur_poids);
            this.Controls.Add(this.label_erreur_numero);
            this.Controls.Add(this.button_valider);
            this.Controls.Add(this.comboBox_couleur_oiseau);
            this.Controls.Add(this.comboBox_espece_oiseau);
            this.Controls.Add(this.textBox_longueur_bec);
            this.Controls.Add(this.label_Longueur_bec);
            this.Controls.Add(this.label_couleur_oiseau);
            this.Controls.Add(this.label_espece_oiseau);
            this.Controls.Add(this.textBox_poids_oiseau);
            this.Controls.Add(this.textBox_num_oiseau);
            this.Controls.Add(this.label_choix_animal);
            this.Controls.Add(this.label_poids_oiseau);
            this.Controls.Add(this.label_num_oiseau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModifierOiseau";
            this.Text = "FormModifierOiseau";
            this.Load += new System.EventHandler(this.FormModifierOiseau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_modif_oiseau;
        private System.Windows.Forms.Label label_erreur_bec;
        private System.Windows.Forms.Label label_erreur_couleur_oiseau;
        private System.Windows.Forms.Label label_erreur_espece_oiseau;
        private System.Windows.Forms.Label label_erreur_poids;
        private System.Windows.Forms.Label label_erreur_numero;
        private System.Windows.Forms.Button button_valider;
        private System.Windows.Forms.ComboBox comboBox_couleur_oiseau;
        private System.Windows.Forms.ComboBox comboBox_espece_oiseau;
        private System.Windows.Forms.TextBox textBox_longueur_bec;
        private System.Windows.Forms.Label label_Longueur_bec;
        private System.Windows.Forms.Label label_couleur_oiseau;
        private System.Windows.Forms.Label label_espece_oiseau;
        private System.Windows.Forms.TextBox textBox_poids_oiseau;
        private System.Windows.Forms.TextBox textBox_num_oiseau;
        private System.Windows.Forms.Label label_choix_animal;
        private System.Windows.Forms.Label label_poids_oiseau;
        private System.Windows.Forms.Label label_num_oiseau;
    }
}