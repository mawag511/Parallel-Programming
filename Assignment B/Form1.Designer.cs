
namespace Assignment_B
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.startstop = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.countTB = new System.Windows.Forms.TextBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.durationTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startstop
            // 
            this.startstop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startstop.Location = new System.Drawing.Point(177, 534);
            this.startstop.Name = "startstop";
            this.startstop.Size = new System.Drawing.Size(198, 27);
            this.startstop.TabIndex = 0;
            this.startstop.Text = "START";
            this.startstop.UseVisualStyleBackColor = true;
            this.startstop.Click += new System.EventHandler(this.startstop_Click);
            // 
            // restart
            // 
            this.restart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.restart.Location = new System.Drawing.Point(395, 534);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(202, 27);
            this.restart.TabIndex = 1;
            this.restart.Text = "CLEAR";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // countTB
            // 
            this.countTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.countTB.Enabled = false;
            this.countTB.Location = new System.Drawing.Point(716, 538);
            this.countTB.Name = "countTB";
            this.countTB.ReadOnly = true;
            this.countTB.Size = new System.Drawing.Size(153, 20);
            this.countTB.TabIndex = 2;
            this.countTB.Text = "0";
            // 
            // countLabel
            // 
            this.countLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(662, 541);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(48, 13);
            this.countLabel.TabIndex = 3;
            this.countLabel.Text = "COUNT:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1234, 516);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // durationLabel
            // 
            this.durationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(895, 541);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(67, 13);
            this.durationLabel.TabIndex = 5;
            this.durationLabel.Text = "DURATION:";
            this.durationLabel.Visible = false;
            // 
            // durationTB
            // 
            this.durationTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durationTB.Enabled = false;
            this.durationTB.Location = new System.Drawing.Point(968, 538);
            this.durationTB.Name = "durationTB";
            this.durationTB.ReadOnly = true;
            this.durationTB.Size = new System.Drawing.Size(184, 20);
            this.durationTB.TabIndex = 6;
            this.durationTB.Text = "0";
            this.durationTB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1257, 591);
            this.Controls.Add(this.durationTB);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.countTB);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.startstop);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment B";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startstop;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.TextBox countTB;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.TextBox durationTB;
    }
}

