namespace GrauGraficzne
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
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosowanie = new System.Windows.Forms.GroupBox();
            this.labelZakresOd = new System.Windows.Forms.Label();
            this.textBoxZakresOd = new System.Windows.Forms.TextBox();
            this.buttonWylosuj = new System.Windows.Forms.Button();
            this.textBoxZakresDo = new System.Windows.Forms.TextBox();
            this.labelZakresDo = new System.Windows.Forms.Label();
            this.buttonPrzebij = new System.Windows.Forms.Button();
            this.labelKomunikat1 = new System.Windows.Forms.Label();
            this.groupBoxPropozycja = new System.Windows.Forms.GroupBox();
            this.textBoxPropozycja = new System.Windows.Forms.TextBox();
            this.buttonZatwierdz = new System.Windows.Forms.Button();
            this.labelOdpowiedz = new System.Windows.Forms.Label();
            this.groupBoxLosowanie.SuspendLayout();
            this.groupBoxPropozycja.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(21, 27);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa Gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBoxLosowanie
            // 
            this.groupBoxLosowanie.Controls.Add(this.labelZakresDo);
            this.groupBoxLosowanie.Controls.Add(this.textBoxZakresDo);
            this.groupBoxLosowanie.Controls.Add(this.buttonWylosuj);
            this.groupBoxLosowanie.Controls.Add(this.textBoxZakresOd);
            this.groupBoxLosowanie.Controls.Add(this.labelZakresOd);
            this.groupBoxLosowanie.Location = new System.Drawing.Point(12, 95);
            this.groupBoxLosowanie.Name = "groupBoxLosowanie";
            this.groupBoxLosowanie.Size = new System.Drawing.Size(209, 114);
            this.groupBoxLosowanie.TabIndex = 1;
            this.groupBoxLosowanie.TabStop = false;
            this.groupBoxLosowanie.Text = "Losowanie";
            this.groupBoxLosowanie.Visible = false;
            this.groupBoxLosowanie.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelZakresOd
            // 
            this.labelZakresOd.AutoSize = true;
            this.labelZakresOd.Location = new System.Drawing.Point(7, 20);
            this.labelZakresOd.Name = "labelZakresOd";
            this.labelZakresOd.Size = new System.Drawing.Size(58, 13);
            this.labelZakresOd.TabIndex = 0;
            this.labelZakresOd.Text = "Zakres od:";
            // 
            // textBoxZakresOd
            // 
            this.textBoxZakresOd.Location = new System.Drawing.Point(86, 20);
            this.textBoxZakresOd.Name = "textBoxZakresOd";
            this.textBoxZakresOd.Size = new System.Drawing.Size(100, 20);
            this.textBoxZakresOd.TabIndex = 1;
            this.textBoxZakresOd.TextChanged += new System.EventHandler(this.textBoxZakresOd_TextChanged);
            // 
            // buttonWylosuj
            // 
            this.buttonWylosuj.Location = new System.Drawing.Point(86, 76);
            this.buttonWylosuj.Name = "buttonWylosuj";
            this.buttonWylosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonWylosuj.TabIndex = 2;
            this.buttonWylosuj.Text = "Wylosuj";
            this.buttonWylosuj.UseVisualStyleBackColor = true;
            this.buttonWylosuj.Click += new System.EventHandler(this.buttonWylosuj_Click);
            // 
            // textBoxZakresDo
            // 
            this.textBoxZakresDo.Location = new System.Drawing.Point(86, 50);
            this.textBoxZakresDo.Name = "textBoxZakresDo";
            this.textBoxZakresDo.Size = new System.Drawing.Size(100, 20);
            this.textBoxZakresDo.TabIndex = 4;
            // 
            // labelZakresDo
            // 
            this.labelZakresDo.AutoSize = true;
            this.labelZakresDo.Location = new System.Drawing.Point(7, 57);
            this.labelZakresDo.Name = "labelZakresDo";
            this.labelZakresDo.Size = new System.Drawing.Size(58, 13);
            this.labelZakresDo.TabIndex = 5;
            this.labelZakresDo.Text = "Zakres do:";
            // 
            // buttonPrzebij
            // 
            this.buttonPrzebij.Location = new System.Drawing.Point(123, 27);
            this.buttonPrzebij.Name = "buttonPrzebij";
            this.buttonPrzebij.Size = new System.Drawing.Size(75, 23);
            this.buttonPrzebij.TabIndex = 2;
            this.buttonPrzebij.Text = "Przebij";
            this.buttonPrzebij.UseVisualStyleBackColor = true;
            this.buttonPrzebij.Visible = false;
            this.buttonPrzebij.Click += new System.EventHandler(this.buttonPrzebij_Click);
            // 
            // labelKomunikat1
            // 
            this.labelKomunikat1.AutoSize = true;
            this.labelKomunikat1.Location = new System.Drawing.Point(21, 216);
            this.labelKomunikat1.Name = "labelKomunikat1";
            this.labelKomunikat1.Size = new System.Drawing.Size(0, 13);
            this.labelKomunikat1.TabIndex = 3;
            // 
            // groupBoxPropozycja
            // 
            this.groupBoxPropozycja.Controls.Add(this.labelOdpowiedz);
            this.groupBoxPropozycja.Controls.Add(this.buttonZatwierdz);
            this.groupBoxPropozycja.Controls.Add(this.textBoxPropozycja);
            this.groupBoxPropozycja.Location = new System.Drawing.Point(12, 271);
            this.groupBoxPropozycja.Name = "groupBoxPropozycja";
            this.groupBoxPropozycja.Size = new System.Drawing.Size(209, 116);
            this.groupBoxPropozycja.TabIndex = 4;
            this.groupBoxPropozycja.TabStop = false;
            this.groupBoxPropozycja.Text = "Propozycja";
            this.groupBoxPropozycja.Visible = false;
            // 
            // textBoxPropozycja
            // 
            this.textBoxPropozycja.Location = new System.Drawing.Point(9, 42);
            this.textBoxPropozycja.Name = "textBoxPropozycja";
            this.textBoxPropozycja.Size = new System.Drawing.Size(76, 20);
            this.textBoxPropozycja.TabIndex = 0;
            // 
            // buttonZatwierdz
            // 
            this.buttonZatwierdz.Location = new System.Drawing.Point(111, 40);
            this.buttonZatwierdz.Name = "buttonZatwierdz";
            this.buttonZatwierdz.Size = new System.Drawing.Size(75, 23);
            this.buttonZatwierdz.TabIndex = 1;
            this.buttonZatwierdz.Text = "Zatwierdz";
            this.buttonZatwierdz.UseVisualStyleBackColor = true;
            this.buttonZatwierdz.Click += new System.EventHandler(this.buttonZatwierdz_Click);
            // 
            // labelOdpowiedz
            // 
            this.labelOdpowiedz.AutoSize = true;
            this.labelOdpowiedz.Location = new System.Drawing.Point(19, 88);
            this.labelOdpowiedz.Name = "labelOdpowiedz";
            this.labelOdpowiedz.Size = new System.Drawing.Size(46, 13);
            this.labelOdpowiedz.TabIndex = 2;
            this.labelOdpowiedz.Text = "Trafiono";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 413);
            this.Controls.Add(this.groupBoxPropozycja);
            this.Controls.Add(this.labelKomunikat1);
            this.Controls.Add(this.buttonPrzebij);
            this.Controls.Add(this.groupBoxLosowanie);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Zgadywanka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxLosowanie.ResumeLayout(false);
            this.groupBoxLosowanie.PerformLayout();
            this.groupBoxPropozycja.ResumeLayout(false);
            this.groupBoxPropozycja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosowanie;
        private System.Windows.Forms.Label labelZakresDo;
        private System.Windows.Forms.TextBox textBoxZakresDo;
        private System.Windows.Forms.Button buttonWylosuj;
        private System.Windows.Forms.TextBox textBoxZakresOd;
        private System.Windows.Forms.Label labelZakresOd;
        private System.Windows.Forms.Button buttonPrzebij;
        private System.Windows.Forms.Label labelKomunikat1;
        private System.Windows.Forms.GroupBox groupBoxPropozycja;
        private System.Windows.Forms.Label labelOdpowiedz;
        private System.Windows.Forms.Button buttonZatwierdz;
        private System.Windows.Forms.TextBox textBoxPropozycja;
    }
}

