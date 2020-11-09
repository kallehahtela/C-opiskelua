namespace jakojäännös
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
            this.luku1 = new System.Windows.Forms.Label();
            this.luku2 = new System.Windows.Forms.Label();
            this.luku1tekstilaatikko = new System.Windows.Forms.TextBox();
            this.luku2tekstilaatikko = new System.Windows.Forms.TextBox();
            this.laskupainike = new System.Windows.Forms.Button();
            this.tuloslabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // luku1
            // 
            this.luku1.AutoSize = true;
            this.luku1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luku1.Location = new System.Drawing.Point(80, 66);
            this.luku1.Name = "luku1";
            this.luku1.Size = new System.Drawing.Size(76, 26);
            this.luku1.TabIndex = 0;
            this.luku1.Text = "luku: 1";
            this.luku1.Click += new System.EventHandler(this.label1_Click);
            // 
            // luku2
            // 
            this.luku2.AutoSize = true;
            this.luku2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luku2.Location = new System.Drawing.Point(80, 127);
            this.luku2.Name = "luku2";
            this.luku2.Size = new System.Drawing.Size(76, 26);
            this.luku2.TabIndex = 1;
            this.luku2.Text = "luku: 2";
            this.luku2.Click += new System.EventHandler(this.label2_Click);
            // 
            // luku1tekstilaatikko
            // 
            this.luku1tekstilaatikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luku1tekstilaatikko.Location = new System.Drawing.Point(252, 63);
            this.luku1tekstilaatikko.Name = "luku1tekstilaatikko";
            this.luku1tekstilaatikko.Size = new System.Drawing.Size(122, 32);
            this.luku1tekstilaatikko.TabIndex = 2;
            // 
            // luku2tekstilaatikko
            // 
            this.luku2tekstilaatikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luku2tekstilaatikko.Location = new System.Drawing.Point(252, 127);
            this.luku2tekstilaatikko.Name = "luku2tekstilaatikko";
            this.luku2tekstilaatikko.Size = new System.Drawing.Size(122, 32);
            this.luku2tekstilaatikko.TabIndex = 3;
            // 
            // laskupainike
            // 
            this.laskupainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laskupainike.Location = new System.Drawing.Point(85, 178);
            this.laskupainike.Name = "laskupainike";
            this.laskupainike.Size = new System.Drawing.Size(289, 55);
            this.laskupainike.TabIndex = 4;
            this.laskupainike.Text = "Laske";
            this.laskupainike.UseVisualStyleBackColor = true;
            this.laskupainike.Click += new System.EventHandler(this.laskupainike_Click);
            // 
            // tuloslabel
            // 
            this.tuloslabel.AutoSize = true;
            this.tuloslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuloslabel.Location = new System.Drawing.Point(85, 263);
            this.tuloslabel.Name = "tuloslabel";
            this.tuloslabel.Size = new System.Drawing.Size(177, 26);
            this.tuloslabel.TabIndex = 5;
            this.tuloslabel.Text = "Tulos tulee tähän";
            this.tuloslabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tuloslabel);
            this.Controls.Add(this.laskupainike);
            this.Controls.Add(this.luku2tekstilaatikko);
            this.Controls.Add(this.luku1tekstilaatikko);
            this.Controls.Add(this.luku2);
            this.Controls.Add(this.luku1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label luku1;
        private System.Windows.Forms.Label luku2;
        private System.Windows.Forms.TextBox luku1tekstilaatikko;
        private System.Windows.Forms.TextBox luku2tekstilaatikko;
        private System.Windows.Forms.Button laskupainike;
        private System.Windows.Forms.Label tuloslabel;
    }
}

