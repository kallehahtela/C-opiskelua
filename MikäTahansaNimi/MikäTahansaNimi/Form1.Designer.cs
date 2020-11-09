namespace MikäTahansaNimi
{
    partial class TekstiLaatikko
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
            this.EtusivuPainike = new System.Windows.Forms.Button();
            this.Tekstitahan = new System.Windows.Forms.Label();
            this.TekstiLattikko = new System.Windows.Forms.TextBox();
            this.ViestiLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EtusivuPainike
            // 
            this.EtusivuPainike.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EtusivuPainike.Location = new System.Drawing.Point(522, 306);
            this.EtusivuPainike.Name = "EtusivuPainike";
            this.EtusivuPainike.Size = new System.Drawing.Size(192, 83);
            this.EtusivuPainike.TabIndex = 0;
            this.EtusivuPainike.Text = "Paina Minua";
            this.EtusivuPainike.UseVisualStyleBackColor = false;
            this.EtusivuPainike.Click += new System.EventHandler(this.keskipainike_Click);
            // 
            // Tekstitahan
            // 
            this.Tekstitahan.AutoSize = true;
            this.Tekstitahan.Location = new System.Drawing.Point(441, 176);
            this.Tekstitahan.Name = "Tekstitahan";
            this.Tekstitahan.Size = new System.Drawing.Size(82, 13);
            this.Tekstitahan.TabIndex = 1;
            this.Tekstitahan.Text = "Anna etunimesi:";
            this.Tekstitahan.Click += new System.EventHandler(this.Tekstitahan_Click);
            // 
            // TekstiLattikko
            // 
            this.TekstiLattikko.Location = new System.Drawing.Point(654, 176);
            this.TekstiLattikko.Name = "TekstiLattikko";
            this.TekstiLattikko.Size = new System.Drawing.Size(199, 20);
            this.TekstiLattikko.TabIndex = 3;
            // 
            // ViestiLabel
            // 
            this.ViestiLabel.AutoSize = true;
            this.ViestiLabel.Location = new System.Drawing.Point(441, 231);
            this.ViestiLabel.Name = "ViestiLabel";
            this.ViestiLabel.Size = new System.Drawing.Size(104, 13);
            this.ViestiLabel.TabIndex = 4;
            this.ViestiLabel.Text = "Tähän tulee vastaus";
            // 
            // TekstiLaatikko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 459);
            this.Controls.Add(this.ViestiLabel);
            this.Controls.Add(this.TekstiLattikko);
            this.Controls.Add(this.Tekstitahan);
            this.Controls.Add(this.EtusivuPainike);
            this.Name = "TekstiLaatikko";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EtusivuPainike;
        private System.Windows.Forms.Label Tekstitahan;
        private System.Windows.Forms.TextBox TekstiLattikko;
        private System.Windows.Forms.Label ViestiLabel;
    }
}

