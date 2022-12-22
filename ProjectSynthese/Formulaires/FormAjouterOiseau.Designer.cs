namespace ProjetSynthese.Formulaires
{
    partial class FormAjouterOiseau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjouterOiseau));
            this.label_ajouter_oiseau = new System.Windows.Forms.Label();
            this.label_erreur_bec = new System.Windows.Forms.Label();
            this.label_erreur_couleur_oiseau = new System.Windows.Forms.Label();
            this.label_erreur_espece_oiseau = new System.Windows.Forms.Label();
            this.label_erreur_poids = new System.Windows.Forms.Label();
            this.label_erreur_numero = new System.Windows.Forms.Label();
            this.button_ajouter = new System.Windows.Forms.Button();
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
            // label_ajouter_oiseau
            // 
            this.label_ajouter_oiseau.AutoSize = true;
            this.label_ajouter_oiseau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ajouter_oiseau.Location = new System.Drawing.Point(31, 32);
            this.label_ajouter_oiseau.Name = "label_ajouter_oiseau";
            this.label_ajouter_oiseau.Size = new System.Drawing.Size(180, 25);
            this.label_ajouter_oiseau.TabIndex = 46;
            this.label_ajouter_oiseau.Text = "Ajouter un oiseau";
            // 
            // label_erreur_bec
            // 
            this.label_erreur_bec.ForeColor = System.Drawing.Color.Red;
            this.label_erreur_bec.Location = new System.Drawing.Point(37, 416);
            this.label_erreur_bec.Name = "label_erreur_bec";
            this.label_erreur_bec.Size = new System.Drawing.Size(228, 18);
            this.label_erreur_bec.TabIndex = 45;
            this.label_erreur_bec.Text = "La longueur du bec doit être un nombre entier\r\n";
            this.label_erreur_bec.Visible = false;
            // 
            // label_erreur_couleur_oiseau
            // 
            this.label_erreur_couleur_oiseau.ForeColor = System.Drawing.Color.Red;
            this.label_erreur_couleur_oiseau.Location = new System.Drawing.Point(37, 348);
            this.label_erreur_couleur_oiseau.Name = "label_erreur_couleur_oiseau";
            this.label_erreur_couleur_oiseau.Size = new System.Drawing.Size(174, 13);
            this.label_erreur_couleur_oiseau.TabIndex = 44;
            this.label_erreur_couleur_oiseau.Text = "Ce champ est obligatoire";
            this.label_erreur_couleur_oiseau.Visible = false;
            // 
            // label_erreur_espece_oiseau
            // 
            this.label_erreur_espece_oiseau.ForeColor = System.Drawing.Color.Red;
            this.label_erreur_espece_oiseau.Location = new System.Drawing.Point(37, 279);
            this.label_erreur_espece_oiseau.Name = "label_erreur_espece_oiseau";
            this.label_erreur_espece_oiseau.Size = new System.Drawing.Size(174, 13);
            this.label_erreur_espece_oiseau.TabIndex = 43;
            this.label_erreur_espece_oiseau.Text = "Ce champ est obligatoire";
            this.label_erreur_espece_oiseau.Visible = false;
            // 
            // label_erreur_poids
            // 
            this.label_erreur_poids.ForeColor = System.Drawing.Color.Red;
            this.label_erreur_poids.Location = new System.Drawing.Point(37, 207);
            this.label_erreur_poids.Name = "label_erreur_poids";
            this.label_erreur_poids.Size = new System.Drawing.Size(174, 12);
            this.label_erreur_poids.TabIndex = 42;
            this.label_erreur_poids.Text = "Le poids doit être un nombre entier";
            this.label_erreur_poids.Visible = false;
            // 
            // label_erreur_numero
            // 
            this.label_erreur_numero.ForeColor = System.Drawing.Color.Red;
            this.label_erreur_numero.Location = new System.Drawing.Point(37, 137);
            this.label_erreur_numero.Name = "label_erreur_numero";
            this.label_erreur_numero.Size = new System.Drawing.Size(174, 13);
            this.label_erreur_numero.TabIndex = 41;
            this.label_erreur_numero.Text = "Le numéro doit comporter 6 chiffres";
            this.label_erreur_numero.Visible = false;
            // 
            // button_ajouter
            // 
            this.button_ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ajouter.Location = new System.Drawing.Point(40, 437);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(137, 31);
            this.button_ajouter.TabIndex = 40;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // comboBox_couleur_oiseau
            // 
            this.comboBox_couleur_oiseau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_couleur_oiseau.FormattingEnabled = true;
            this.comboBox_couleur_oiseau.Items.AddRange(new object[] {
            "Noir",
            "Bleu",
            "Blanc"});
            this.comboBox_couleur_oiseau.Location = new System.Drawing.Point(39, 324);
            this.comboBox_couleur_oiseau.Name = "comboBox_couleur_oiseau";
            this.comboBox_couleur_oiseau.Size = new System.Drawing.Size(138, 21);
            this.comboBox_couleur_oiseau.TabIndex = 39;
            // 
            // comboBox_espece_oiseau
            // 
            this.comboBox_espece_oiseau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_espece_oiseau.FormattingEnabled = true;
            this.comboBox_espece_oiseau.Items.AddRange(new object[] {
            "Toucan",
            "Ara",
            "Chouette"});
            this.comboBox_espece_oiseau.Location = new System.Drawing.Point(40, 255);
            this.comboBox_espece_oiseau.Name = "comboBox_espece_oiseau";
            this.comboBox_espece_oiseau.Size = new System.Drawing.Size(137, 21);
            this.comboBox_espece_oiseau.TabIndex = 38;
            // 
            // textBox_longueur_bec
            // 
            this.textBox_longueur_bec.Location = new System.Drawing.Point(40, 393);
            this.textBox_longueur_bec.Name = "textBox_longueur_bec";
            this.textBox_longueur_bec.Size = new System.Drawing.Size(137, 20);
            this.textBox_longueur_bec.TabIndex = 37;
            // 
            // label_Longueur_bec
            // 
            this.label_Longueur_bec.AutoSize = true;
            this.label_Longueur_bec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Longueur_bec.Location = new System.Drawing.Point(35, 370);
            this.label_Longueur_bec.Name = "label_Longueur_bec";
            this.label_Longueur_bec.Size = new System.Drawing.Size(129, 20);
            this.label_Longueur_bec.TabIndex = 36;
            this.label_Longueur_bec.Text = "Longueur du bec";
            // 
            // label_couleur_oiseau
            // 
            this.label_couleur_oiseau.AutoSize = true;
            this.label_couleur_oiseau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_couleur_oiseau.Location = new System.Drawing.Point(35, 301);
            this.label_couleur_oiseau.Name = "label_couleur_oiseau";
            this.label_couleur_oiseau.Size = new System.Drawing.Size(143, 20);
            this.label_couleur_oiseau.TabIndex = 35;
            this.label_couleur_oiseau.Text = "Couleur de l\'oiseau";
            // 
            // label_espece_oiseau
            // 
            this.label_espece_oiseau.AutoSize = true;
            this.label_espece_oiseau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_espece_oiseau.Location = new System.Drawing.Point(35, 231);
            this.label_espece_oiseau.Name = "label_espece_oiseau";
            this.label_espece_oiseau.Size = new System.Drawing.Size(142, 20);
            this.label_espece_oiseau.TabIndex = 34;
            this.label_espece_oiseau.Text = "Espèce de l\'oiseau";
            // 
            // textBox_poids_oiseau
            // 
            this.textBox_poids_oiseau.Location = new System.Drawing.Point(40, 184);
            this.textBox_poids_oiseau.Name = "textBox_poids_oiseau";
            this.textBox_poids_oiseau.Size = new System.Drawing.Size(137, 20);
            this.textBox_poids_oiseau.TabIndex = 33;
            // 
            // textBox_num_oiseau
            // 
            this.textBox_num_oiseau.Location = new System.Drawing.Point(40, 114);
            this.textBox_num_oiseau.Name = "textBox_num_oiseau";
            this.textBox_num_oiseau.Size = new System.Drawing.Size(137, 20);
            this.textBox_num_oiseau.TabIndex = 32;
            // 
            // label_choix_animal
            // 
            this.label_choix_animal.AutoSize = true;
            this.label_choix_animal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_choix_animal.Location = new System.Drawing.Point(36, 231);
            this.label_choix_animal.Name = "label_choix_animal";
            this.label_choix_animal.Size = new System.Drawing.Size(0, 20);
            this.label_choix_animal.TabIndex = 31;
            // 
            // label_poids_oiseau
            // 
            this.label_poids_oiseau.AutoSize = true;
            this.label_poids_oiseau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_poids_oiseau.Location = new System.Drawing.Point(36, 161);
            this.label_poids_oiseau.Name = "label_poids_oiseau";
            this.label_poids_oiseau.Size = new System.Drawing.Size(127, 20);
            this.label_poids_oiseau.TabIndex = 30;
            this.label_poids_oiseau.Text = "Poids de l\'oiseau";
            // 
            // label_num_oiseau
            // 
            this.label_num_oiseau.AutoSize = true;
            this.label_num_oiseau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_num_oiseau.Location = new System.Drawing.Point(36, 90);
            this.label_num_oiseau.Name = "label_num_oiseau";
            this.label_num_oiseau.Size = new System.Drawing.Size(144, 20);
            this.label_num_oiseau.TabIndex = 29;
            this.label_num_oiseau.Text = "Numéro de l\'oiseau";
            // 
            // FormAjouterOiseau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 497);
            this.Controls.Add(this.label_ajouter_oiseau);
            this.Controls.Add(this.label_erreur_bec);
            this.Controls.Add(this.label_erreur_couleur_oiseau);
            this.Controls.Add(this.label_erreur_espece_oiseau);
            this.Controls.Add(this.label_erreur_poids);
            this.Controls.Add(this.label_erreur_numero);
            this.Controls.Add(this.button_ajouter);
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
            this.Name = "FormAjouterOiseau";
            this.Text = "FormAjouterOiseau";
            this.Load += new System.EventHandler(this.FormAjouterOiseau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ajouter_oiseau;
        private System.Windows.Forms.Label label_erreur_bec;
        private System.Windows.Forms.Label label_erreur_couleur_oiseau;
        private System.Windows.Forms.Label label_erreur_espece_oiseau;
        private System.Windows.Forms.Label label_erreur_poids;
        private System.Windows.Forms.Label label_erreur_numero;
        private System.Windows.Forms.Button button_ajouter;
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