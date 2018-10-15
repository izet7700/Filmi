namespace filmi
{
    partial class OneMovie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.igralci = new System.Windows.Forms.Label();
            this.scenaristi = new System.Windows.Forms.Label();
            this.producenti = new System.Windows.Forms.Label();
            this.reziserji = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "View";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 159);
            this.label2.MaximumSize = new System.Drawing.Size(1300, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // igralci
            // 
            this.igralci.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.igralci.Location = new System.Drawing.Point(12, 276);
            this.igralci.Name = "igralci";
            this.igralci.Size = new System.Drawing.Size(1300, 20);
            this.igralci.TabIndex = 2;
            // 
            // scenaristi
            // 
            this.scenaristi.AutoSize = true;
            this.scenaristi.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scenaristi.Location = new System.Drawing.Point(9, 320);
            this.scenaristi.Name = "scenaristi";
            this.scenaristi.Size = new System.Drawing.Size(0, 20);
            this.scenaristi.TabIndex = 3;
            // 
            // producenti
            // 
            this.producenti.AutoSize = true;
            this.producenti.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.producenti.Location = new System.Drawing.Point(13, 382);
            this.producenti.Name = "producenti";
            this.producenti.Size = new System.Drawing.Size(0, 20);
            this.producenti.TabIndex = 4;
            // 
            // reziserji
            // 
            this.reziserji.AutoSize = true;
            this.reziserji.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reziserji.Location = new System.Drawing.Point(13, 429);
            this.reziserji.Name = "reziserji";
            this.reziserji.Size = new System.Drawing.Size(0, 20);
            this.reziserji.TabIndex = 5;
            // 
            // OneMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 470);
            this.Controls.Add(this.reziserji);
            this.Controls.Add(this.producenti);
            this.Controls.Add(this.scenaristi);
            this.Controls.Add(this.igralci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1300, 600);
            this.Name = "OneMovie";
            this.Text = "OneMovie";
            this.Load += new System.EventHandler(this.OneMovie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label igralci;
        private System.Windows.Forms.Label scenaristi;
        private System.Windows.Forms.Label producenti;
        private System.Windows.Forms.Label reziserji;
    }
}