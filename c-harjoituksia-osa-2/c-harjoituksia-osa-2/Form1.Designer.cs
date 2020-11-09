namespace c_harjoituksia_osa_2
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
            this.Luku1Label = new System.Windows.Forms.Label();
            this.Luku2Label = new System.Windows.Forms.Label();
            this.Luku1Laatikko = new System.Windows.Forms.TextBox();
            this.Luku2Laatikko = new System.Windows.Forms.TextBox();
            this.testausbutton = new System.Windows.Forms.Button();
            this.VastausLaatikko = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Luku1Label
            // 
            this.Luku1Label.AutoSize = true;
            this.Luku1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luku1Label.Location = new System.Drawing.Point(59, 68);
            this.Luku1Label.Name = "Luku1Label";
            this.Luku1Label.Size = new System.Drawing.Size(71, 24);
            this.Luku1Label.TabIndex = 0;
            this.Luku1Label.Text = "Luku: 1";
            // 
            // Luku2Label
            // 
            this.Luku2Label.AutoSize = true;
            this.Luku2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luku2Label.Location = new System.Drawing.Point(59, 126);
            this.Luku2Label.Name = "Luku2Label";
            this.Luku2Label.Size = new System.Drawing.Size(76, 24);
            this.Luku2Label.TabIndex = 1;
            this.Luku2Label.Text = "Luku: 2 ";
            // 
            // Luku1Laatikko
            // 
            this.Luku1Laatikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luku1Laatikko.Location = new System.Drawing.Point(249, 71);
            this.Luku1Laatikko.Name = "Luku1Laatikko";
            this.Luku1Laatikko.Size = new System.Drawing.Size(100, 29);
            this.Luku1Laatikko.TabIndex = 2;
            // 
            // Luku2Laatikko
            // 
            this.Luku2Laatikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luku2Laatikko.Location = new System.Drawing.Point(249, 126);
            this.Luku2Laatikko.Name = "Luku2Laatikko";
            this.Luku2Laatikko.Size = new System.Drawing.Size(100, 29);
            this.Luku2Laatikko.TabIndex = 3;
            // 
            // testausbutton
            // 
            this.testausbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testausbutton.Location = new System.Drawing.Point(63, 176);
            this.testausbutton.Name = "testausbutton";
            this.testausbutton.Size = new System.Drawing.Size(286, 39);
            this.testausbutton.TabIndex = 4;
            this.testausbutton.Text = "Onko samat luvut";
            this.testausbutton.UseVisualStyleBackColor = true;
            this.testausbutton.Click += new System.EventHandler(this.testausbutton_Click);
            // 
            // VastausLaatikko
            // 
            this.VastausLaatikko.AutoSize = true;
            this.VastausLaatikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLaatikko.Location = new System.Drawing.Point(63, 250);
            this.VastausLaatikko.Name = "VastausLaatikko";
            this.VastausLaatikko.Size = new System.Drawing.Size(173, 24);
            this.VastausLaatikko.TabIndex = 5;
            this.VastausLaatikko.Text = "Vastaus tulee tahan";
            this.VastausLaatikko.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VastausLaatikko);
            this.Controls.Add(this.testausbutton);
            this.Controls.Add(this.Luku2Laatikko);
            this.Controls.Add(this.Luku1Laatikko);
            this.Controls.Add(this.Luku2Label);
            this.Controls.Add(this.Luku1Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Luku1Label;
        private System.Windows.Forms.Label Luku2Label;
        private System.Windows.Forms.TextBox Luku1Laatikko;
        private System.Windows.Forms.TextBox Luku2Laatikko;
        private System.Windows.Forms.Button testausbutton;
        private System.Windows.Forms.Label VastausLaatikko;
    }
}

