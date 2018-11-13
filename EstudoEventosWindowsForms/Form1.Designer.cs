namespace EstudoEventosWindowsForms
{
    partial class FrmQtdClick
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
            this.btnClique = new System.Windows.Forms.Button();
            this.PgbQtdClick = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnClique
            // 
            this.btnClique.Location = new System.Drawing.Point(26, 31);
            this.btnClique.Name = "btnClique";
            this.btnClique.Size = new System.Drawing.Size(75, 23);
            this.btnClique.TabIndex = 0;
            this.btnClique.Text = "Clique Aqui!";
            this.btnClique.UseVisualStyleBackColor = true;
            this.btnClique.Click += new System.EventHandler(this.BtnClique_Click);
            // 
            // PgbQtdClick
            // 
            this.PgbQtdClick.Location = new System.Drawing.Point(26, 75);
            this.PgbQtdClick.Name = "PgbQtdClick";
            this.PgbQtdClick.Size = new System.Drawing.Size(447, 23);
            this.PgbQtdClick.TabIndex = 0;
            // 
            // FrmQtdClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PgbQtdClick);
            this.Controls.Add(this.btnClique);
            this.Name = "FrmQtdClick";
            this.Text = "Quantidade de clique";
            this.Load += new System.EventHandler(this.FrmQtdClick_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClique;
        private System.Windows.Forms.ProgressBar PgbQtdClick;
    }
}

