namespace ProjetSynthese.Formulaires
{
    partial class FormAfficherOiseaux
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAfficherOiseaux));
            this.label_table_oiseau = new System.Windows.Forms.Label();
            this.dataGridViewOiseau = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOiseau)).BeginInit();
            this.SuspendLayout();
            // 
            // label_table_oiseau
            // 
            this.label_table_oiseau.AutoSize = true;
            this.label_table_oiseau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_table_oiseau.Location = new System.Drawing.Point(275, 47);
            this.label_table_oiseau.Name = "label_table_oiseau";
            this.label_table_oiseau.Size = new System.Drawing.Size(245, 25);
            this.label_table_oiseau.TabIndex = 3;
            this.label_table_oiseau.Text = "Voici les oiseaux du zoo";
            // 
            // dataGridViewOiseau
            // 
            this.dataGridViewOiseau.Location = new System.Drawing.Point(129, 133);
            this.dataGridViewOiseau.Name = "dataGridViewOiseau";
            this.dataGridViewOiseau.Size = new System.Drawing.Size(543, 271);
            this.dataGridViewOiseau.TabIndex = 2;
            // 
            // FormAfficherOiseaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_table_oiseau);
            this.Controls.Add(this.dataGridViewOiseau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAfficherOiseaux";
            this.Text = "FormAfficherOiseaux";
            this.Load += new System.EventHandler(this.FormAfficherOiseaux_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOiseau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_table_oiseau;
        private System.Windows.Forms.DataGridView dataGridViewOiseau;
    }
}