namespace _1
{
    partial class Form2
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.Usd = new MetroFramework.Controls.MetroTextBox();
            this.Ubutton = new MetroFramework.Controls.MetroRadioButton();
            this.Ebutton = new MetroFramework.Controls.MetroRadioButton();
            this.Pbutton = new MetroFramework.Controls.MetroRadioButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.Eur = new MetroFramework.Controls.MetroTextBox();
            this.Pln = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(161, 200);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(88, 24);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Exit";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Usd
            // 
            this.Usd.Location = new System.Drawing.Point(120, 63);
            this.Usd.Name = "Usd";
            this.Usd.Size = new System.Drawing.Size(129, 23);
            this.Usd.TabIndex = 5;
            // 
            // Ubutton
            // 
            this.Ubutton.AutoSize = true;
            this.Ubutton.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.Ubutton.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.Ubutton.Location = new System.Drawing.Point(51, 63);
            this.Ubutton.Name = "Ubutton";
            this.Ubutton.Size = new System.Drawing.Size(53, 19);
            this.Ubutton.Style = MetroFramework.MetroColorStyle.Purple;
            this.Ubutton.TabIndex = 9;
            this.Ubutton.TabStop = true;
            this.Ubutton.Text = "USD";
            this.Ubutton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Ubutton.UseStyleColors = true;
            this.Ubutton.UseVisualStyleBackColor = true;
            // 
            // Ebutton
            // 
            this.Ebutton.AutoSize = true;
            this.Ebutton.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.Ebutton.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.Ebutton.Location = new System.Drawing.Point(51, 105);
            this.Ebutton.Name = "Ebutton";
            this.Ebutton.Size = new System.Drawing.Size(51, 19);
            this.Ebutton.Style = MetroFramework.MetroColorStyle.Purple;
            this.Ebutton.TabIndex = 10;
            this.Ebutton.TabStop = true;
            this.Ebutton.Text = "EUR";
            this.Ebutton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Ebutton.UseStyleColors = true;
            this.Ebutton.UseVisualStyleBackColor = true;
            // 
            // Pbutton
            // 
            this.Pbutton.AutoSize = true;
            this.Pbutton.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.Pbutton.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.Pbutton.Location = new System.Drawing.Point(51, 146);
            this.Pbutton.Name = "Pbutton";
            this.Pbutton.Size = new System.Drawing.Size(52, 19);
            this.Pbutton.Style = MetroFramework.MetroColorStyle.Purple;
            this.Pbutton.TabIndex = 11;
            this.Pbutton.TabStop = true;
            this.Pbutton.Text = "PLN";
            this.Pbutton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Pbutton.UseStyleColors = true;
            this.Pbutton.UseVisualStyleBackColor = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(51, 200);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(88, 24);
            this.metroButton2.TabIndex = 12;
            this.metroButton2.Text = "Count";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Eur
            // 
            this.Eur.Location = new System.Drawing.Point(120, 105);
            this.Eur.Name = "Eur";
            this.Eur.Size = new System.Drawing.Size(129, 23);
            this.Eur.TabIndex = 13;
            // 
            // Pln
            // 
            this.Pln.Location = new System.Drawing.Point(120, 146);
            this.Pln.Name = "Pln";
            this.Pln.Size = new System.Drawing.Size(129, 23);
            this.Pln.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 268);
            this.ControlBox = false;
            this.Controls.Add(this.Pln);
            this.Controls.Add(this.Eur);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.Pbutton);
            this.Controls.Add(this.Ebutton);
            this.Controls.Add(this.Ubutton);
            this.Controls.Add(this.Usd);
            this.Controls.Add(this.metroButton1);
            this.Name = "Form2";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Converter";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox Usd;
        private MetroFramework.Controls.MetroRadioButton Ubutton;
        private MetroFramework.Controls.MetroRadioButton Ebutton;
        private MetroFramework.Controls.MetroRadioButton Pbutton;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox Eur;
        private MetroFramework.Controls.MetroTextBox Pln;
    }
}