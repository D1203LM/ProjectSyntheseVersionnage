namespace ProjetSynthese.Formulaires
{
    partial class FormModifierEnclos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifierEnclos));
            this.button_valider = new System.Windows.Forms.Button();
            this.label_erreur_taille_enclos = new System.Windows.Forms.Label();
            this.label_erreur_numero = new System.Windows.Forms.Label();
            this.comboBox_taille_enclos = new System.Windows.Forms.ComboBox();
            this.label_taille_enclos = new System.Windows.Forms.Label();
            this.label_choix_animal = new System.Windows.Forms.Label();
            this.textBox_num_enclos = new System.Windows.Forms.TextBox();
            this.label_num_enclos = new System.Windows.Forms.Label();
            this.label_modif_enclos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_valider
            // 
            this.button_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_valider.Location = new System.Drawing.Point(87, 253);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(120, 31);
            this.button_valider.TabIndex = 73;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            this.button_valider.Click += new System.EventHandler(this.button_valider_Click);
            // 
            // label_erreur_taille_enclos
            // 
            this.label_erreur_taille_enclos.ForeColor = System.Drawing.Color.Red;
            this.label_erreur_taille_enclos.Location = new System.Drawing.Point(35, 215);
            this.label_erreur_taille_enclos.Name = "label_erreur_taille_enclos";
            this.label_erreur_taille_enclos.Size = new System.Drawing.Size(174, 13);
            this.label_erreur_taille_enclos.TabIndex = 72;
            this.label_erreur_taille_enclos.Text = "Ce champ est obligatoire";
            this.label_erreur_taille_enclos.Visible = false;
            // 
            // label_erreur_numero
            // 
            this.label_erreur_numero.ForeColor = System.Drawing.Color.Red;
            this.label_erreur_numero.Location = new System.Drawing.Point(33, 146);
            this.label_erreur_numero.Name = "label_erreur_numero";
            this.label_erreur_numero.Size = new System.Drawing.Size(174, 13);
            this.label_erreur_numero.TabIndex = 71;
            this.label_erreur_numero.Text = "Le numéro doit comporter 3 chiffres";
            this.label_erreur_numero.Visible = false;
            // 
            // comboBox_taille_enclos
            // 
            this.comboBox_taille_enclos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_taille_enclos.FormattingEnabled = true;
            this.comboBox_taille_enclos.Items.AddRange(new object[] {
            "Petit",
            "Moyen",
            "Grand"});
            this.comboBox_taille_enclos.Location = new System.Drawing.Point(38, 191);
            this.comboBox_taille_enclos.Name = "comboBox_taille_enclos";
            this.comboBox_taille_enclos.Size = new System.Drawing.Size(211, 21);
            this.comboBox_taille_enclos.TabIndex = 70;
            // 
            // label_taille_enclos
            // 
            this.label_taille_enclos.AutoSize = true;
            this.label_taille_enclos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_taille_enclos.Location = new System.Drawing.Point(33, 167);
            this.label_taille_enclos.Name = "label_taille_enclos";
            this.label_taille_enclos.Size = new System.Drawing.Size(123, 20);
            this.label_taille_enclos.TabIndex = 69;
            this.label_taille_enclos.Text = "Taille de l\'enclos";
            // 
            // label_choix_animal
            // 
            this.label_choix_animal.AutoSize = true;
            this.label_choix_animal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_choix_animal.Location = new System.Drawing.Point(34, 167);
            this.label_choix_animal.Name = "label_choix_animal";
            this.label_choix_animal.Size = new System.Drawing.Size(0, 20);
            this.label_choix_animal.TabIndex = 68;
            // 
            // textBox_num_enclos
            // 
            this.textBox_num_enclos.Location = new System.Drawing.Point(37, 123);
            this.textBox_num_enclos.Name = "textBox_num_enclos";
            this.textBox_num_enclos.Size = new System.Drawing.Size(213, 20);
            this.textBox_num_enclos.TabIndex = 67;
            // 
            // label_num_enclos
            // 
            this.label_num_enclos.AutoSize = true;
            this.label_num_enclos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_num_enclos.Location = new System.Drawing.Point(33, 99);
            this.label_num_enclos.Name = "label_num_enclos";
            this.label_num_enclos.Size = new System.Drawing.Size(143, 20);
            this.label_num_enclos.TabIndex = 66;
            this.label_num_enclos.Text = "Numéro de l\'enclos";
            // 
            // label_modif_enclos
            // 
            this.label_modif_enclos.AutoSize = true;
            this.label_modif_enclos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_modif_enclos.Location = new System.Drawing.Point(32, 39);
            this.label_modif_enclos.Name = "label_modif_enclos";
            this.label_modif_enclos.Size = new System.Drawing.Size(188, 25);
            this.label_modif_enclos.TabIndex = 65;
            this.label_modif_enclos.Text = "Modifier un enclos";
            // 
            // FormModifierEnclos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 329);
            this.Controls.Add(this.button_valider);
            this.Controls.Add(this.label_erreur_taille_enclos);
            this.Controls.Add(this.label_erreur_numero);
            this.Controls.Add(this.comboBox_taille_enclos);
            this.Controls.Add(this.label_taille_enclos);
            this.Controls.Add(this.label_choix_animal);
            this.Controls.Add(this.textBox_num_enclos);
            this.Controls.Add(this.label_num_enclos);
            this.Controls.Add(this.label_modif_enclos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModifierEnclos";
            this.Text = "FormModifierEnclos";
            this.Load += new System.EventHandler(this.FormModifierEnclos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_valider;
        private System.Windows.Forms.Label label_erreur_taille_enclos;
        private System.Windows.Forms.Label label_erreur_numero;
        private System.Windows.Forms.ComboBox comboBox_taille_enclos;
        private System.Windows.Forms.Label label_taille_enclos;
        private System.Windows.Forms.Label label_choix_animal;
        private System.Windows.Forms.TextBox textBox_num_enclos;
        private System.Windows.Forms.Label label_num_enclos;
        private System.Windows.Forms.Label label_modif_enclos;
    }
}