namespace Elektronik
{
    partial class Start
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
            this.markaL = new System.Windows.Forms.Label();
            this.numerSeryjnyBox = new System.Windows.Forms.TextBox();
            this.numerSL = new System.Windows.Forms.Label();
            this.numerSerNL = new System.Windows.Forms.Label();
            this.usterkaL = new System.Windows.Forms.Label();
            this.naprawaPoNrK = new System.Windows.Forms.Button();
            this.naprawaK = new System.Windows.Forms.Button();
            this.podzielK = new System.Windows.Forms.Button();
            this.polaczK = new System.Windows.Forms.Button();
            this.dodajTwK = new System.Windows.Forms.Button();
            this.usterkaBox = new System.Windows.Forms.TextBox();
            this.markaBox = new System.Windows.Forms.TextBox();
            this.numerSeryjnyDoNapBox = new System.Windows.Forms.TextBox();
            this.dodajKomputerK = new System.Windows.Forms.Button();
            this.listaNaprawL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // markaL
            // 
            this.markaL.AutoSize = true;
            this.markaL.Location = new System.Drawing.Point(87, 92);
            this.markaL.Name = "markaL";
            this.markaL.Size = new System.Drawing.Size(37, 13);
            this.markaL.TabIndex = 1;
            this.markaL.Text = "Marka";
            // 
            // numerSeryjnyBox
            // 
            this.numerSeryjnyBox.Location = new System.Drawing.Point(209, 147);
            this.numerSeryjnyBox.Name = "numerSeryjnyBox";
            this.numerSeryjnyBox.Size = new System.Drawing.Size(100, 20);
            this.numerSeryjnyBox.TabIndex = 2;
            // 
            // numerSL
            // 
            this.numerSL.AutoSize = true;
            this.numerSL.Location = new System.Drawing.Point(87, 144);
            this.numerSL.Name = "numerSL";
            this.numerSL.Size = new System.Drawing.Size(73, 13);
            this.numerSL.TabIndex = 3;
            this.numerSL.Text = "Numer seryjny";
            // 
            // numerSerNL
            // 
            this.numerSerNL.AutoSize = true;
            this.numerSerNL.Location = new System.Drawing.Point(44, 244);
            this.numerSerNL.Name = "numerSerNL";
            this.numerSerNL.Size = new System.Drawing.Size(116, 13);
            this.numerSerNL.TabIndex = 4;
            this.numerSerNL.Text = "Numer ser. do naprawy";
            // 
            // usterkaL
            // 
            this.usterkaL.AutoSize = true;
            this.usterkaL.Location = new System.Drawing.Point(87, 119);
            this.usterkaL.Name = "usterkaL";
            this.usterkaL.Size = new System.Drawing.Size(44, 13);
            this.usterkaL.TabIndex = 5;
            this.usterkaL.Text = "Usterka";
            // 
            // naprawaPoNrK
            // 
            this.naprawaPoNrK.Location = new System.Drawing.Point(327, 244);
            this.naprawaPoNrK.Name = "naprawaPoNrK";
            this.naprawaPoNrK.Size = new System.Drawing.Size(93, 23);
            this.naprawaPoNrK.TabIndex = 6;
            this.naprawaPoNrK.Text = "naprawa po nr";
            this.naprawaPoNrK.UseVisualStyleBackColor = true;
            this.naprawaPoNrK.Click += new System.EventHandler(this.NaprawaPoNr);
            // 
            // naprawaK
            // 
            this.naprawaK.Location = new System.Drawing.Point(327, 205);
            this.naprawaK.Name = "naprawaK";
            this.naprawaK.Size = new System.Drawing.Size(93, 23);
            this.naprawaK.TabIndex = 7;
            this.naprawaK.Text = "Naprawa";
            this.naprawaK.UseVisualStyleBackColor = true;
            this.naprawaK.Click += new System.EventHandler(this.NaprawaZ);
            // 
            // podzielK
            // 
            this.podzielK.Location = new System.Drawing.Point(234, 205);
            this.podzielK.Name = "podzielK";
            this.podzielK.Size = new System.Drawing.Size(75, 23);
            this.podzielK.TabIndex = 8;
            this.podzielK.Text = "Podziel";
            this.podzielK.UseVisualStyleBackColor = true;
            this.podzielK.Click += new System.EventHandler(this.PodzielZ);
            // 
            // polaczK
            // 
            this.polaczK.Location = new System.Drawing.Point(134, 205);
            this.polaczK.Name = "polaczK";
            this.polaczK.Size = new System.Drawing.Size(75, 23);
            this.polaczK.TabIndex = 9;
            this.polaczK.Text = "Połącz";
            this.polaczK.UseVisualStyleBackColor = true;
            this.polaczK.Click += new System.EventHandler(this.Polocz);
            // 
            // dodajTwK
            // 
            this.dodajTwK.Location = new System.Drawing.Point(327, 95);
            this.dodajTwK.Name = "dodajTwK";
            this.dodajTwK.Size = new System.Drawing.Size(111, 23);
            this.dodajTwK.TabIndex = 10;
            this.dodajTwK.Text = "Dodaj tv";
            this.dodajTwK.UseVisualStyleBackColor = true;
            this.dodajTwK.Click += new System.EventHandler(this.DodajTV);
            // 
            // usterkaBox
            // 
            this.usterkaBox.Location = new System.Drawing.Point(209, 121);
            this.usterkaBox.Name = "usterkaBox";
            this.usterkaBox.Size = new System.Drawing.Size(100, 20);
            this.usterkaBox.TabIndex = 11;
            // 
            // markaBox
            // 
            this.markaBox.Location = new System.Drawing.Point(209, 95);
            this.markaBox.Name = "markaBox";
            this.markaBox.Size = new System.Drawing.Size(100, 20);
            this.markaBox.TabIndex = 12;
            // 
            // numerSeryjnyDoNapBox
            // 
            this.numerSeryjnyDoNapBox.Location = new System.Drawing.Point(172, 244);
            this.numerSeryjnyDoNapBox.Name = "numerSeryjnyDoNapBox";
            this.numerSeryjnyDoNapBox.Size = new System.Drawing.Size(137, 20);
            this.numerSeryjnyDoNapBox.TabIndex = 13;
            // 
            // dodajKomputerK
            // 
            this.dodajKomputerK.Location = new System.Drawing.Point(327, 134);
            this.dodajKomputerK.Name = "dodajKomputerK";
            this.dodajKomputerK.Size = new System.Drawing.Size(111, 23);
            this.dodajKomputerK.TabIndex = 14;
            this.dodajKomputerK.Text = "Dodaj komputer";
            this.dodajKomputerK.UseVisualStyleBackColor = true;
            this.dodajKomputerK.Click += new System.EventHandler(this.DodajKomputer);
            // 
            // listaNaprawL
            // 
            this.listaNaprawL.AutoSize = true;
            this.listaNaprawL.Location = new System.Drawing.Point(519, 53);
            this.listaNaprawL.Name = "listaNaprawL";
            this.listaNaprawL.Size = new System.Drawing.Size(69, 13);
            this.listaNaprawL.TabIndex = 15;
            this.listaNaprawL.Text = "Lista Napraw";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 573);
            this.Controls.Add(this.listaNaprawL);
            this.Controls.Add(this.dodajKomputerK);
            this.Controls.Add(this.numerSeryjnyDoNapBox);
            this.Controls.Add(this.markaBox);
            this.Controls.Add(this.usterkaBox);
            this.Controls.Add(this.dodajTwK);
            this.Controls.Add(this.polaczK);
            this.Controls.Add(this.podzielK);
            this.Controls.Add(this.naprawaK);
            this.Controls.Add(this.naprawaPoNrK);
            this.Controls.Add(this.usterkaL);
            this.Controls.Add(this.numerSerNL);
            this.Controls.Add(this.numerSL);
            this.Controls.Add(this.numerSeryjnyBox);
            this.Controls.Add(this.markaL);
            this.Name = "Start";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label markaL;
        private System.Windows.Forms.TextBox numerSeryjnyBox;
        private System.Windows.Forms.Label numerSL;
        private System.Windows.Forms.Label numerSerNL;
        private System.Windows.Forms.Label usterkaL;
        private System.Windows.Forms.Button naprawaPoNrK;
        private System.Windows.Forms.Button naprawaK;
        private System.Windows.Forms.Button podzielK;
        private System.Windows.Forms.Button polaczK;
        private System.Windows.Forms.Button dodajTwK;
        private System.Windows.Forms.TextBox usterkaBox;
        private System.Windows.Forms.TextBox markaBox;
        private System.Windows.Forms.TextBox numerSeryjnyDoNapBox;
        private System.Windows.Forms.Button dodajKomputerK;
        private System.Windows.Forms.Label listaNaprawL;

    }
}

