namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Label1Luku = new System.Windows.Forms.Label();
            this.Label2Luku = new System.Windows.Forms.Label();
            this.Tekstilaaikko1 = new System.Windows.Forms.TextBox();
            this.Tekstilaatikko2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.VastausLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1Luku
            // 
            this.Label1Luku.AutoSize = true;
            this.Label1Luku.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1Luku.Location = new System.Drawing.Point(125, 80);
            this.Label1Luku.Name = "Label1Luku";
            this.Label1Luku.Size = new System.Drawing.Size(71, 24);
            this.Label1Luku.TabIndex = 0;
            this.Label1Luku.Text = "Luku: 1";
            // 
            // Label2Luku
            // 
            this.Label2Luku.AutoSize = true;
            this.Label2Luku.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2Luku.Location = new System.Drawing.Point(125, 127);
            this.Label2Luku.Name = "Label2Luku";
            this.Label2Luku.Size = new System.Drawing.Size(71, 24);
            this.Label2Luku.TabIndex = 1;
            this.Label2Luku.Text = "Luku: 2";
            // 
            // Tekstilaaikko1
            // 
            this.Tekstilaaikko1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tekstilaaikko1.Location = new System.Drawing.Point(225, 77);
            this.Tekstilaaikko1.Name = "Tekstilaaikko1";
            this.Tekstilaaikko1.Size = new System.Drawing.Size(100, 29);
            this.Tekstilaaikko1.TabIndex = 2;
            this.Tekstilaaikko1.TextChanged += new System.EventHandler(this.Tekstilaaikko1_TextChanged);
            // 
            // Tekstilaatikko2
            // 
            this.Tekstilaatikko2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tekstilaatikko2.Location = new System.Drawing.Point(225, 120);
            this.Tekstilaatikko2.Name = "Tekstilaatikko2";
            this.Tekstilaatikko2.Size = new System.Drawing.Size(100, 29);
            this.Tekstilaatikko2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(128, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Laske Yhteen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VastausLabel
            // 
            this.VastausLabel.AutoSize = true;
            this.VastausLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLabel.Location = new System.Drawing.Point(128, 287);
            this.VastausLabel.Name = "VastausLabel";
            this.VastausLabel.Size = new System.Drawing.Size(206, 26);
            this.VastausLabel.TabIndex = 5;
            this.VastausLabel.Text = "Tähän tulee vastaus";
            this.VastausLabel.Visible = false;
            this.VastausLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VastausLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tekstilaatikko2);
            this.Controls.Add(this.Tekstilaaikko1);
            this.Controls.Add(this.Label2Luku);
            this.Controls.Add(this.Label1Luku);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1Luku;
        private System.Windows.Forms.Label Label2Luku;
        private System.Windows.Forms.TextBox Tekstilaaikko1;
        private System.Windows.Forms.TextBox Tekstilaatikko2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label VastausLabel;
    }
}

