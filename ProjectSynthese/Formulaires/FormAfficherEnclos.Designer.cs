namespace ProjetSynthese.Formulaires
{
    partial class FormAfficherEnclos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAfficherEnclos));
            this.label_table_enclos = new System.Windows.Forms.Label();
            this.dataGridViewEnclos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnclos)).BeginInit();
            this.SuspendLayout();
            // 
            // label_table_enclos
            // 
            this.label_table_enclos.AutoSize = true;
            this.label_table_enclos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_table_enclos.Location = new System.Drawing.Point(59, 37);
            this.label_table_enclos.Name = "label_table_enclos";
            this.label_table_enclos.Size = new System.Drawing.Size(233, 25);
            this.label_table_enclos.TabIndex = 7;
            this.label_table_enclos.Text = "Voici les enclos du zoo";
            // 
            // dataGridViewEnclos
            // 
            this.dataGridViewEnclos.Location = new System.Drawing.Point(58, 122);
            this.dataGridViewEnclos.Name = "dataGridViewEnclos";
            this.dataGridViewEnclos.Size = new System.Drawing.Size(243, 271);
            this.dataGridViewEnclos.TabIndex = 6;
            // 
            // FormAfficherEnclos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.label_table_enclos);
            this.Controls.Add(this.dataGridViewEnclos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAfficherEnclos";
            this.Text = "FormAfficherEnclos";
            this.Load += new System.EventHandler(this.FormAfficherEnclos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnclos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_table_enclos;
        private System.Windows.Forms.DataGridView dataGridViewEnclos;
    }
}