namespace ProjetSynthese.Formulaires
{
    partial class FormSupprimerOiseau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupprimerOiseau));
            this.button_supprimer = new System.Windows.Forms.Button();
            this.label_erreur_numero = new System.Windows.Forms.Label();
            this.textBox_num_oiseau = new System.Windows.Forms.TextBox();
            this.label_num_oiseau = new System.Windows.Forms.Label();
            this.label_supprimer_oiseau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_supprimer
            // 
            this.button_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_supprimer.Location = new System.Drawing.Point(40, 160);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(137, 31);
            this.button_supprimer.TabIndex = 38;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // label_erreur_numero
            // 
            this.label_erreur_numero.ForeColor = System.Drawing.Color.Red;
            this.label_erreur_numero.Location = new System.Drawing.Point(37, 120);
            this.label_erreur_numero.Name = "label_erreur_numero";
            this.label_erreur_numero.Size = new System.Drawing.Size(174, 13);
            this.label_erreur_numero.TabIndex = 37;
            this.label_erreur_numero.Text = "Le numéro doit comporter 6 chiffres";
            this.label_erreur_numero.Visible = false;
            // 
            // textBox_num_oiseau
            // 
            this.textBox_num_oiseau.Location = new System.Drawing.Point(40, 97);
            this.textBox_num_oiseau.Name = "textBox_num_oiseau";
            this.textBox_num_oiseau.Size = new System.Drawing.Size(137, 20);
            this.textBox_num_oiseau.TabIndex = 36;
            // 
            // label_num_oiseau
            // 
            this.label_num_oiseau.AutoSize = true;
            this.label_num_oiseau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_num_oiseau.Location = new System.Drawing.Point(36, 73);
            this.label_num_oiseau.Name = "label_num_oiseau";
            this.label_num_oiseau.Size = new System.Drawing.Size(144, 20);
            this.label_num_oiseau.TabIndex = 35;
            this.label_num_oiseau.Text = "Numéro de l\'oiseau";
            // 
            // label_supprimer_oiseau
            // 
            this.label_supprimer_oiseau.AutoSize = true;
            this.label_supprimer_oiseau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_supprimer_oiseau.Location = new System.Drawing.Point(23, 24);
            this.label_supprimer_oiseau.Name = "label_supprimer_oiseau";
            this.label_supprimer_oiseau.Size = new System.Drawing.Size(210, 25);
            this.label_supprimer_oiseau.TabIndex = 34;
            this.label_supprimer_oiseau.Text = "Supprimer un oiseau";
            // 
            // FormSupprimerOiseau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 234);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.label_erreur_numero);
            this.Controls.Add(this.textBox_num_oiseau);
            this.Controls.Add(this.label_num_oiseau);
            this.Controls.Add(this.label_supprimer_oiseau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSupprimerOiseau";
            this.Text = "FormSupprimerOiseau";
            this.Load += new System.EventHandler(this.FormSupprimerOiseau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Label label_erreur_numero;
        private System.Windows.Forms.TextBox textBox_num_oiseau;
        private System.Windows.Forms.Label label_num_oiseau;
        private System.Windows.Forms.Label label_supprimer_oiseau;
    }
}