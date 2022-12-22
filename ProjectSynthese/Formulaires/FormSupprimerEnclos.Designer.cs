namespace ProjetSynthese.Formulaires
{
    partial class FormSupprimerEnclos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupprimerEnclos));
            this.button_supprimer = new System.Windows.Forms.Button();
            this.label_erreur_numero = new System.Windows.Forms.Label();
            this.textBox_num_enclos = new System.Windows.Forms.TextBox();
            this.label_num_enclos = new System.Windows.Forms.Label();
            this.label_supprimer_enclos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_supprimer
            // 
            this.button_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_supprimer.Location = new System.Drawing.Point(40, 159);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(137, 31);
            this.button_supprimer.TabIndex = 43;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // label_erreur_numero
            // 
            this.label_erreur_numero.ForeColor = System.Drawing.Color.Red;
            this.label_erreur_numero.Location = new System.Drawing.Point(37, 119);
            this.label_erreur_numero.Name = "label_erreur_numero";
            this.label_erreur_numero.Size = new System.Drawing.Size(174, 13);
            this.label_erreur_numero.TabIndex = 42;
            this.label_erreur_numero.Text = "Le numéro doit comporter 3 chiffres";
            this.label_erreur_numero.Visible = false;
            // 
            // textBox_num_enclos
            // 
            this.textBox_num_enclos.Location = new System.Drawing.Point(40, 96);
            this.textBox_num_enclos.Name = "textBox_num_enclos";
            this.textBox_num_enclos.Size = new System.Drawing.Size(137, 20);
            this.textBox_num_enclos.TabIndex = 41;
            // 
            // label_num_enclos
            // 
            this.label_num_enclos.AutoSize = true;
            this.label_num_enclos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_num_enclos.Location = new System.Drawing.Point(36, 72);
            this.label_num_enclos.Name = "label_num_enclos";
            this.label_num_enclos.Size = new System.Drawing.Size(143, 20);
            this.label_num_enclos.TabIndex = 40;
            this.label_num_enclos.Text = "Numéro de l\'enclos";
            // 
            // label_supprimer_enclos
            // 
            this.label_supprimer_enclos.AutoSize = true;
            this.label_supprimer_enclos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_supprimer_enclos.Location = new System.Drawing.Point(23, 23);
            this.label_supprimer_enclos.Name = "label_supprimer_enclos";
            this.label_supprimer_enclos.Size = new System.Drawing.Size(209, 25);
            this.label_supprimer_enclos.TabIndex = 39;
            this.label_supprimer_enclos.Text = "Supprimer un enclos";
            // 
            // FormSupprimerEnclos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 224);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.label_erreur_numero);
            this.Controls.Add(this.textBox_num_enclos);
            this.Controls.Add(this.label_num_enclos);
            this.Controls.Add(this.label_supprimer_enclos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSupprimerEnclos";
            this.Text = "FormSupprimerEnclos";
            this.Load += new System.EventHandler(this.FormSupprimerEnclos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Label label_erreur_numero;
        private System.Windows.Forms.TextBox textBox_num_enclos;
        private System.Windows.Forms.Label label_num_enclos;
        private System.Windows.Forms.Label label_supprimer_enclos;
    }
}