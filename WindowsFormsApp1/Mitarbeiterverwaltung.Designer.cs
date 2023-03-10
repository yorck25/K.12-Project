namespace WindowsFormsApp1
{
    partial class Mitarbeiterverwaltung
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
            this.lBoxMverMitarbeiter = new System.Windows.Forms.ListBox();
            this.MverDetailMitarbeiter = new System.Windows.Forms.Panel();
            this.butMitPwAnzeigen = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tBoxMitPw = new System.Windows.Forms.TextBox();
            this.DateMit = new System.Windows.Forms.DateTimePicker();
            this.tBoxMitHausNr = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tBoxMitPLZ = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tBoxMitStraße = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cBoxMitAbr = new System.Windows.Forms.ComboBox();
            this.cBoxMitFunk = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cBoxMitRolle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxMitAbt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxMitBenutzer = new System.Windows.Forms.TextBox();
            this.tBoxMitEmail = new System.Windows.Forms.TextBox();
            this.tBoxMitOrt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxMitName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tBoxMitVName = new System.Windows.Forms.TextBox();
            this.butMverDetailSchließen = new System.Windows.Forms.Button();
            this.butMitAbt = new System.Windows.Forms.Button();
            this.butMitRolle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.herfMitPwÄndern = new System.Windows.Forms.LinkLabel();
            this.MverDetailMitarbeiter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBoxMverMitarbeiter
            // 
            this.lBoxMverMitarbeiter.DisplayMember = "MitarbeiterListe";
            this.lBoxMverMitarbeiter.FormattingEnabled = true;
            this.lBoxMverMitarbeiter.Items.AddRange(new object[] {
            "Yorck",
            "Tilman"});
            this.lBoxMverMitarbeiter.Location = new System.Drawing.Point(31, 25);
            this.lBoxMverMitarbeiter.Name = "lBoxMverMitarbeiter";
            this.lBoxMverMitarbeiter.Size = new System.Drawing.Size(120, 355);
            this.lBoxMverMitarbeiter.TabIndex = 0;
            this.lBoxMverMitarbeiter.SelectedIndexChanged += new System.EventHandler(this.lBoxMverMitarbeiter_SelectedIndexChanged);
            // 
            // MverDetailMitarbeiter
            // 
            this.MverDetailMitarbeiter.Controls.Add(this.herfMitPwÄndern);
            this.MverDetailMitarbeiter.Controls.Add(this.butMitPwAnzeigen);
            this.MverDetailMitarbeiter.Controls.Add(this.label15);
            this.MverDetailMitarbeiter.Controls.Add(this.tBoxMitPw);
            this.MverDetailMitarbeiter.Controls.Add(this.DateMit);
            this.MverDetailMitarbeiter.Controls.Add(this.tBoxMitHausNr);
            this.MverDetailMitarbeiter.Controls.Add(this.label14);
            this.MverDetailMitarbeiter.Controls.Add(this.tBoxMitPLZ);
            this.MverDetailMitarbeiter.Controls.Add(this.label13);
            this.MverDetailMitarbeiter.Controls.Add(this.tBoxMitStraße);
            this.MverDetailMitarbeiter.Controls.Add(this.label12);
            this.MverDetailMitarbeiter.Controls.Add(this.label11);
            this.MverDetailMitarbeiter.Controls.Add(this.cBoxMitAbr);
            this.MverDetailMitarbeiter.Controls.Add(this.cBoxMitFunk);
            this.MverDetailMitarbeiter.Controls.Add(this.label9);
            this.MverDetailMitarbeiter.Controls.Add(this.cBoxMitRolle);
            this.MverDetailMitarbeiter.Controls.Add(this.label1);
            this.MverDetailMitarbeiter.Controls.Add(this.cBoxMitAbt);
            this.MverDetailMitarbeiter.Controls.Add(this.label7);
            this.MverDetailMitarbeiter.Controls.Add(this.tBoxMitBenutzer);
            this.MverDetailMitarbeiter.Controls.Add(this.tBoxMitEmail);
            this.MverDetailMitarbeiter.Controls.Add(this.tBoxMitOrt);
            this.MverDetailMitarbeiter.Controls.Add(this.label6);
            this.MverDetailMitarbeiter.Controls.Add(this.tBoxMitName);
            this.MverDetailMitarbeiter.Controls.Add(this.label5);
            this.MverDetailMitarbeiter.Controls.Add(this.label4);
            this.MverDetailMitarbeiter.Controls.Add(this.label3);
            this.MverDetailMitarbeiter.Controls.Add(this.label2);
            this.MverDetailMitarbeiter.Controls.Add(this.label10);
            this.MverDetailMitarbeiter.Controls.Add(this.tBoxMitVName);
            this.MverDetailMitarbeiter.Controls.Add(this.butMverDetailSchließen);
            this.MverDetailMitarbeiter.Location = new System.Drawing.Point(184, 25);
            this.MverDetailMitarbeiter.Name = "MverDetailMitarbeiter";
            this.MverDetailMitarbeiter.Size = new System.Drawing.Size(266, 355);
            this.MverDetailMitarbeiter.TabIndex = 1;
            this.MverDetailMitarbeiter.Visible = false;
            this.MverDetailMitarbeiter.Paint += new System.Windows.Forms.PaintEventHandler(this.MverDetailMitarbeiter_Paint);
            // 
            // butMitPwAnzeigen
            // 
            this.butMitPwAnzeigen.Location = new System.Drawing.Point(234, 184);
            this.butMitPwAnzeigen.Name = "butMitPwAnzeigen";
            this.butMitPwAnzeigen.Size = new System.Drawing.Size(17, 20);
            this.butMitPwAnzeigen.TabIndex = 77;
            this.butMitPwAnzeigen.Text = "Anzeigen";
            this.butMitPwAnzeigen.UseVisualStyleBackColor = true;
            this.butMitPwAnzeigen.Click += new System.EventHandler(this.butMitPwAnzeigen_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(124, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 76;
            this.label15.Text = "Passwort";
            // 
            // tBoxMitPw
            // 
            this.tBoxMitPw.Location = new System.Drawing.Point(127, 184);
            this.tBoxMitPw.Name = "tBoxMitPw";
            this.tBoxMitPw.Size = new System.Drawing.Size(100, 20);
            this.tBoxMitPw.TabIndex = 75;
            // 
            // DateMit
            // 
            this.DateMit.Location = new System.Drawing.Point(10, 145);
            this.DateMit.Name = "DateMit";
            this.DateMit.Size = new System.Drawing.Size(96, 20);
            this.DateMit.TabIndex = 74;
            // 
            // tBoxMitHausNr
            // 
            this.tBoxMitHausNr.Location = new System.Drawing.Point(10, 105);
            this.tBoxMitHausNr.Name = "tBoxMitHausNr";
            this.tBoxMitHausNr.Size = new System.Drawing.Size(100, 20);
            this.tBoxMitHausNr.TabIndex = 73;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 72;
            this.label14.Text = "Hausnummer:";
            // 
            // tBoxMitPLZ
            // 
            this.tBoxMitPLZ.Location = new System.Drawing.Point(127, 68);
            this.tBoxMitPLZ.Name = "tBoxMitPLZ";
            this.tBoxMitPLZ.Size = new System.Drawing.Size(100, 20);
            this.tBoxMitPLZ.TabIndex = 71;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(124, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 70;
            this.label13.Text = "PLZ:";
            // 
            // tBoxMitStraße
            // 
            this.tBoxMitStraße.Location = new System.Drawing.Point(11, 68);
            this.tBoxMitStraße.Name = "tBoxMitStraße";
            this.tBoxMitStraße.Size = new System.Drawing.Size(100, 20);
            this.tBoxMitStraße.TabIndex = 69;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 68;
            this.label12.Text = "Straße:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(124, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 67;
            this.label11.Text = "Abrechnungsnummer:";
            // 
            // cBoxMitAbr
            // 
            this.cBoxMitAbr.FormattingEnabled = true;
            this.cBoxMitAbr.Location = new System.Drawing.Point(127, 281);
            this.cBoxMitAbr.Name = "cBoxMitAbr";
            this.cBoxMitAbr.Size = new System.Drawing.Size(100, 21);
            this.cBoxMitAbr.TabIndex = 66;
            // 
            // cBoxMitFunk
            // 
            this.cBoxMitFunk.DisplayMember = "FunktionListe";
            this.cBoxMitFunk.FormattingEnabled = true;
            this.cBoxMitFunk.Location = new System.Drawing.Point(11, 281);
            this.cBoxMitFunk.Name = "cBoxMitFunk";
            this.cBoxMitFunk.Size = new System.Drawing.Size(100, 21);
            this.cBoxMitFunk.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Funtion:";
            // 
            // cBoxMitRolle
            // 
            this.cBoxMitRolle.DisplayMember = "RolleListe";
            this.cBoxMitRolle.FormattingEnabled = true;
            this.cBoxMitRolle.Location = new System.Drawing.Point(127, 233);
            this.cBoxMitRolle.Name = "cBoxMitRolle";
            this.cBoxMitRolle.Size = new System.Drawing.Size(100, 21);
            this.cBoxMitRolle.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Rolle:";
            // 
            // cBoxMitAbt
            // 
            this.cBoxMitAbt.DisplayMember = "AbteilungsListe";
            this.cBoxMitAbt.FormattingEnabled = true;
            this.cBoxMitAbt.Location = new System.Drawing.Point(11, 233);
            this.cBoxMitAbt.Name = "cBoxMitAbt";
            this.cBoxMitAbt.Size = new System.Drawing.Size(100, 21);
            this.cBoxMitAbt.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Abteilung:";
            // 
            // tBoxMitBenutzer
            // 
            this.tBoxMitBenutzer.Location = new System.Drawing.Point(127, 144);
            this.tBoxMitBenutzer.Name = "tBoxMitBenutzer";
            this.tBoxMitBenutzer.Size = new System.Drawing.Size(100, 20);
            this.tBoxMitBenutzer.TabIndex = 59;
            // 
            // tBoxMitEmail
            // 
            this.tBoxMitEmail.Location = new System.Drawing.Point(11, 184);
            this.tBoxMitEmail.Name = "tBoxMitEmail";
            this.tBoxMitEmail.Size = new System.Drawing.Size(100, 20);
            this.tBoxMitEmail.TabIndex = 58;
            // 
            // tBoxMitOrt
            // 
            this.tBoxMitOrt.Location = new System.Drawing.Point(127, 105);
            this.tBoxMitOrt.Name = "tBoxMitOrt";
            this.tBoxMitOrt.Size = new System.Drawing.Size(100, 20);
            this.tBoxMitOrt.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Benutzername: ";
            // 
            // tBoxMitName
            // 
            this.tBoxMitName.Location = new System.Drawing.Point(127, 27);
            this.tBoxMitName.Name = "tBoxMitName";
            this.tBoxMitName.Size = new System.Drawing.Size(100, 20);
            this.tBoxMitName.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "E-Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Geburtstags Datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Ort:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nachname:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Vorname:";
            // 
            // tBoxMitVName
            // 
            this.tBoxMitVName.Location = new System.Drawing.Point(11, 27);
            this.tBoxMitVName.Name = "tBoxMitVName";
            this.tBoxMitVName.Size = new System.Drawing.Size(100, 20);
            this.tBoxMitVName.TabIndex = 49;
            // 
            // butMverDetailSchließen
            // 
            this.butMverDetailSchließen.Location = new System.Drawing.Point(11, 308);
            this.butMverDetailSchließen.Name = "butMverDetailSchließen";
            this.butMverDetailSchließen.Size = new System.Drawing.Size(89, 32);
            this.butMverDetailSchließen.TabIndex = 12;
            this.butMverDetailSchließen.Text = "Speichern";
            this.butMverDetailSchließen.UseVisualStyleBackColor = true;
            this.butMverDetailSchließen.Click += new System.EventHandler(this.butMverDetailSchließen_Click);
            // 
            // butMitAbt
            // 
            this.butMitAbt.Location = new System.Drawing.Point(675, 43);
            this.butMitAbt.Name = "butMitAbt";
            this.butMitAbt.Size = new System.Drawing.Size(81, 36);
            this.butMitAbt.TabIndex = 2;
            this.butMitAbt.Text = "Abteilung hinzufühgen";
            this.butMitAbt.UseVisualStyleBackColor = true;
            this.butMitAbt.Click += new System.EventHandler(this.butMitAbt_Click);
            // 
            // butMitRolle
            // 
            this.butMitRolle.Location = new System.Drawing.Point(675, 85);
            this.butMitRolle.Name = "butMitRolle";
            this.butMitRolle.Size = new System.Drawing.Size(81, 36);
            this.butMitRolle.TabIndex = 3;
            this.butMitRolle.Text = "Rolle hinzufühgen";
            this.butMitRolle.UseVisualStyleBackColor = true;
            this.butMitRolle.Click += new System.EventHandler(this.butMitRolle_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(675, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Funktion hinzufühgen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // herfMitPwÄndern
            // 
            this.herfMitPwÄndern.AutoSize = true;
            this.herfMitPwÄndern.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfMitPwÄndern.Location = new System.Drawing.Point(177, 167);
            this.herfMitPwÄndern.Name = "herfMitPwÄndern";
            this.herfMitPwÄndern.Size = new System.Drawing.Size(86, 13);
            this.herfMitPwÄndern.TabIndex = 78;
            this.herfMitPwÄndern.TabStop = true;
            this.herfMitPwÄndern.Text = "Passwort ändern";
            this.herfMitPwÄndern.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfMitPwÄndern_LinkClicked);
            // 
            // Mitarbeiterverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 413);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.butMitRolle);
            this.Controls.Add(this.butMitAbt);
            this.Controls.Add(this.MverDetailMitarbeiter);
            this.Controls.Add(this.lBoxMverMitarbeiter);
            this.Name = "Mitarbeiterverwaltung";
            this.Text = "Mitarbeiterverwaltung";
            this.Load += new System.EventHandler(this.Mitarbeiterverwaltung_Load);
            this.MverDetailMitarbeiter.ResumeLayout(false);
            this.MverDetailMitarbeiter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxMverMitarbeiter;
        private System.Windows.Forms.Panel MverDetailMitarbeiter;
        private System.Windows.Forms.Button butMverDetailSchließen;
        private System.Windows.Forms.Button butMitAbt;
        private System.Windows.Forms.Button butMitRolle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker DateMit;
        private System.Windows.Forms.TextBox tBoxMitHausNr;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tBoxMitPLZ;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tBoxMitStraße;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cBoxMitAbr;
        private System.Windows.Forms.ComboBox cBoxMitFunk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBoxMitRolle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxMitAbt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBoxMitBenutzer;
        private System.Windows.Forms.TextBox tBoxMitEmail;
        private System.Windows.Forms.TextBox tBoxMitOrt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxMitName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tBoxMitVName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tBoxMitPw;
        private System.Windows.Forms.Button butMitPwAnzeigen;
        private System.Windows.Forms.LinkLabel herfMitPwÄndern;
    }
}