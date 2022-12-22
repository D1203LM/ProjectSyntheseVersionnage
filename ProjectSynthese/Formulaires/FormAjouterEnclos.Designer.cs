namespace ProjetSynthese.Formulaires
{
    partial class FormAjouterEnclos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjouterEnclos));
            this.label_ajouter_enclos = new System.Windows.Forms.Label();
            this.label_erreur_taille_enclos = new System.Windows.Forms.Label();
            this.label_erreur_numero = new System.Windows.Forms.Label();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.comboBox_taille_enclos = new System.Windows.Forms.ComboBox();
            this.label_taille_enclos = new System.Windows.Forms.Label();
            this.label_choix_animal = new System.Windows.Forms.Label();
            this.textBox_num_enclos = new System.Windows.Forms.TextBox();
            this.label_num_enclos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_ajouter_enclos
            // 
            this.label_ajouter_enclos.AutoSize = true;
            this.label_ajouter_enclos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ajouter_enclos.Location = new System.Drawing.Point(47, 49);
            this.label_ajouter_enclos.Name = "label_ajouter_enclos";
            this.label_ajouter_enclos.Size = new System.Drawing.Size(179, 25);
            this.label_ajouter_enclos.TabIndex = 41;
            this.label_ajouter_enclos.Text = "Ajouter un enclos";
            // 
            // label_erreur_taille_enclos
            // 
            this.label_erreur_taille_enclos.ForeColor = System.Drawing.Color.Red;
            this.label_erreur_taille_enclos.Location = new System.Drawing.Point(54, 219);
            this.label_erreur_taille_enclos.Name = "label_erreur_taille_enclos";
            this.label_erreur_taille_enclos.Size = new System.Drawing.Size(174, 13);
            this.label_erreur_taille_enclos.TabIndex = 40;
            this.label_erreur_taille_enclos.Text = "Ce champ est obligatoire";
            this.label_erreur_taille_enclos.Visible = false;
            // 
            // label_erreur_numero
            // 
            this.label_erreur_numero.ForeColor = System.Drawing.Color.Red;
            this.label_erreur_numero.Location = new System.Drawing.Point(52, 150);
            this.label_erreur_numero.Name = "label_erreur_numero";
            this.label_erreur_numero.Size = new System.Drawing.Size(174, 13);
            this.label_erreur_numero.TabIndex = 39;
            this.label_erreur_numero.Text = "Le numéro doit comporter 3 chiffres";
            this.label_erreur_numero.Visible = false;
            // 
            // button_ajouter
            // 
            this.button_ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ajouter.Location = new System.Drawing.Point(57, 240);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(137, 31);
            this.button_ajouter.TabIndex = 38;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // comboBox_taille_enclos
            // 
            this.comboBox_taille_enclos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_taille_enclos.FormattingEnabled = true;
            this.comboBox_taille_enclos.Items.AddRange(new object[] {
            "Petit",
            "Moyen",
            "Grand"});
            this.comboBox_taille_enclos.Location = new System.Drawing.Point(57, 195);
            this.comboBox_taille_enclos.Name = "comboBox_taille_enclos";
            this.comboBox_taille_enclos.Size = new System.Drawing.Size(137, 21);
            this.comboBox_taille_enclos.TabIndex = 37;
            // 
            // label_taille_enclos
            // 
            this.label_taille_enclos.AutoSize = true;
            this.label_taille_enclos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_taille_enclos.Location = new System.Drawing.Point(52, 171);
            this.label_taille_enclos.Name = "label_taille_enclos";
            this.label_taille_enclos.Size = new System.Drawing.Size(123, 20);
            this.label_taille_enclos.TabIndex = 36;
            this.label_taille_enclos.Text = "Taille de l\'enclos";
            // 
            // label_choix_animal
            // 
            this.label_choix_animal.AutoSize = true;
            this.label_choix_animal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_choix_animal.Location = new System.Drawing.Point(53, 171);
            this.label_choix_animal.Name = "label_choix_animal";
            this.label_choix_animal.Size = new System.Drawing.Size(0, 20);
            this.label_choix_animal.TabIndex = 35;
            // 
            // textBox_num_enclos
            // 
            this.textBox_num_enclos.Location = new System.Drawing.Point(56, 127);
            this.textBox_num_enclos.Name = "textBox_num_enclos";
            this.textBox_num_enclos.Size = new System.Drawing.Size(137, 20);
            this.textBox_num_enclos.TabIndex = 34;
            // 
            // label_num_enclos
            // 
            this.label_num_enclos.AutoSize = true;
            this.label_num_enclos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_num_enclos.Location = new System.Drawing.Point(52, 103);
            this.label_num_enclos.Name = "label_num_enclos";
            this.label_num_enclos.Size = new System.Drawing.Size(143, 20);
            this.label_num_enclos.TabIndex = 33;
            this.label_num_enclos.Text = "Numéro de l\'enclos";
            // 
            // FormAjouterEnclos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 335);
            this.Controls.Add(this.label_ajouter_enclos);
            this.Controls.Add(this.label_erreur_taille_enclos);
            this.Controls.Add(this.label_erreur_numero);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.comboBox_taille_enclos);
            this.Controls.Add(this.label_taille_enclos);
            this.Controls.Add(this.label_choix_animal);
            this.Controls.Add(this.textBox_num_enclos);
            this.Controls.Add(this.label_num_enclos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAjouterEnclos";
            this.Text = "FormAjouterEnclos";
            this.Load += new System.EventHandler(this.FormAjouterEnclos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ajouter_enclos;
        private System.Windows.Forms.Label label_erreur_taille_enclos;
        private System.Windows.Forms.Label label_erreur_numero;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.ComboBox comboBox_taille_enclos;
        private System.Windows.Forms.Label label_taille_enclos;
        private System.Windows.Forms.Label label_choix_animal;
        private System.Windows.Forms.TextBox textBox_num_enclos;
        private System.Windows.Forms.Label label_num_enclos;
    }
}