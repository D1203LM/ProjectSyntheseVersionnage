namespace ProjetSynthese.Formulaires
{
    partial class FormAfficherSerpents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAfficherSerpents));
            this.label_table_serpent = new System.Windows.Forms.Label();
            this.dataGridViewSerpent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSerpent)).BeginInit();
            this.SuspendLayout();
            // 
            // label_table_serpent
            // 
            this.label_table_serpent.AutoSize = true;
            this.label_table_serpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_table_serpent.Location = new System.Drawing.Point(275, 47);
            this.label_table_serpent.Name = "label_table_serpent";
            this.label_table_serpent.Size = new System.Drawing.Size(253, 25);
            this.label_table_serpent.TabIndex = 5;
            this.label_table_serpent.Text = "Voici les serpents du zoo";
            // 
            // dataGridViewSerpent
            // 
            this.dataGridViewSerpent.Location = new System.Drawing.Point(129, 133);
            this.dataGridViewSerpent.Name = "dataGridViewSerpent";
            this.dataGridViewSerpent.Size = new System.Drawing.Size(543, 271);
            this.dataGridViewSerpent.TabIndex = 4;
            // 
            // FormAfficherSerpents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_table_serpent);
            this.Controls.Add(this.dataGridViewSerpent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAfficherSerpents";
            this.Text = "FormAfficherSerpents";
            this.Load += new System.EventHandler(this.FormAfficherSerpents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSerpent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_table_serpent;
        private System.Windows.Forms.DataGridView dataGridViewSerpent;
    }
}