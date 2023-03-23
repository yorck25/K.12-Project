namespace WindowsFormsApp1
{
    partial class Registrieren
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
            this.butRegErstellen = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.herfRegVorhanden = new System.Windows.Forms.LinkLabel();
            this.cBoxRegFunk = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cBoxRegRolle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxRegAbt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxRegUname = new System.Windows.Forms.TextBox();
            this.tBoxRegEmail = new System.Windows.Forms.TextBox();
            this.tBoxRegOrt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxRegName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tBoxRegVname = new System.Windows.Forms.TextBox();
            this.tBoxRegStraße = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tBoxRegPLZ = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tBoxRegHausNr = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DateReg = new System.Windows.Forms.DateTimePicker();
            this.tBoxRegPw = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.regFehler = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.butRegFehler = new System.Windows.Forms.Button();
            this.butLoginPasAnzeigen = new System.Windows.Forms.Button();
            this.regFehler.SuspendLayout();
            this.SuspendLayout();
            // 
            // butRegErstellen
            // 
            this.butRegErstellen.Location = new System.Drawing.Point(11, 332);
            this.butRegErstellen.Name = "butRegErstellen";
            this.butRegErstellen.Size = new System.Drawing.Size(97, 34);
            this.butRegErstellen.TabIndex = 18;
            this.butRegErstellen.Text = "Konto erstellen";
            this.butRegErstellen.UseVisualStyleBackColor = true;
            this.butRegErstellen.Click += new System.EventHandler(this.butRegErstellen_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Du hast bereits ein Konto?";
            // 
            // herfRegVorhanden
            // 
            this.herfRegVorhanden.AutoSize = true;
            this.herfRegVorhanden.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfRegVorhanden.Location = new System.Drawing.Point(147, 316);
            this.herfRegVorhanden.Name = "herfRegVorhanden";
            this.herfRegVorhanden.Size = new System.Drawing.Size(57, 13);
            this.herfRegVorhanden.TabIndex = 21;
            this.herfRegVorhanden.TabStop = true;
            this.herfRegVorhanden.Text = "Zum Login";
            this.herfRegVorhanden.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfRegVorhanden_LinkClicked);
            // 
            // cBoxRegFunk
            // 
            this.cBoxRegFunk.DisplayMember = "FunktionListe";
            this.cBoxRegFunk.FormattingEnabled = true;
            this.cBoxRegFunk.Location = new System.Drawing.Point(12, 282);
            this.cBoxRegFunk.Name = "cBoxRegFunk";
            this.cBoxRegFunk.Size = new System.Drawing.Size(100, 21);
            this.cBoxRegFunk.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Funtion:";
            // 
            // cBoxRegRolle
            // 
            this.cBoxRegRolle.DisplayMember = "RolleListe";
            this.cBoxRegRolle.FormattingEnabled = true;
            this.cBoxRegRolle.Location = new System.Drawing.Point(128, 234);
            this.cBoxRegRolle.Name = "cBoxRegRolle";
            this.cBoxRegRolle.Size = new System.Drawing.Size(100, 21);
            this.cBoxRegRolle.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Rolle:";
            // 
            // cBoxRegAbt
            // 
            this.cBoxRegAbt.DisplayMember = "AbteilungsListe";
            this.cBoxRegAbt.FormattingEnabled = true;
            this.cBoxRegAbt.Location = new System.Drawing.Point(12, 234);
            this.cBoxRegAbt.Name = "cBoxRegAbt";
            this.cBoxRegAbt.Size = new System.Drawing.Size(100, 21);
            this.cBoxRegAbt.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Abteilung:";
            // 
            // tBoxRegUname
            // 
            this.tBoxRegUname.Location = new System.Drawing.Point(128, 145);
            this.tBoxRegUname.Name = "tBoxRegUname";
            this.tBoxRegUname.Size = new System.Drawing.Size(100, 20);
            this.tBoxRegUname.TabIndex = 33;
            // 
            // tBoxRegEmail
            // 
            this.tBoxRegEmail.Location = new System.Drawing.Point(12, 185);
            this.tBoxRegEmail.Name = "tBoxRegEmail";
            this.tBoxRegEmail.Size = new System.Drawing.Size(100, 20);
            this.tBoxRegEmail.TabIndex = 32;
            // 
            // tBoxRegOrt
            // 
            this.tBoxRegOrt.Location = new System.Drawing.Point(128, 106);
            this.tBoxRegOrt.Name = "tBoxRegOrt";
            this.tBoxRegOrt.Size = new System.Drawing.Size(100, 20);
            this.tBoxRegOrt.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Benutzername:";
            // 
            // tBoxRegName
            // 
            this.tBoxRegName.Location = new System.Drawing.Point(128, 28);
            this.tBoxRegName.Name = "tBoxRegName";
            this.tBoxRegName.Size = new System.Drawing.Size(100, 20);
            this.tBoxRegName.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "E-Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Geburtstags Datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ort:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nachname:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Vorname:";
            // 
            // tBoxRegVname
            // 
            this.tBoxRegVname.Location = new System.Drawing.Point(12, 28);
            this.tBoxRegVname.Name = "tBoxRegVname";
            this.tBoxRegVname.Size = new System.Drawing.Size(100, 20);
            this.tBoxRegVname.TabIndex = 22;
            // 
            // tBoxRegStraße
            // 
            this.tBoxRegStraße.Location = new System.Drawing.Point(12, 69);
            this.tBoxRegStraße.Name = "tBoxRegStraße";
            this.tBoxRegStraße.Size = new System.Drawing.Size(100, 20);
            this.tBoxRegStraße.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Straße:";
            // 
            // tBoxRegPLZ
            // 
            this.tBoxRegPLZ.Location = new System.Drawing.Point(128, 69);
            this.tBoxRegPLZ.Name = "tBoxRegPLZ";
            this.tBoxRegPLZ.Size = new System.Drawing.Size(100, 20);
            this.tBoxRegPLZ.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(125, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "PLZ:";
            // 
            // tBoxRegHausNr
            // 
            this.tBoxRegHausNr.Location = new System.Drawing.Point(11, 106);
            this.tBoxRegHausNr.Name = "tBoxRegHausNr";
            this.tBoxRegHausNr.Size = new System.Drawing.Size(100, 20);
            this.tBoxRegHausNr.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "Hausnummer:";
            // 
            // DateReg
            // 
            this.DateReg.Location = new System.Drawing.Point(11, 146);
            this.DateReg.Name = "DateReg";
            this.DateReg.Size = new System.Drawing.Size(96, 20);
            this.DateReg.TabIndex = 48;
            // 
            // tBoxRegPw
            // 
            this.tBoxRegPw.Location = new System.Drawing.Point(128, 185);
            this.tBoxRegPw.Name = "tBoxRegPw";
            this.tBoxRegPw.Size = new System.Drawing.Size(100, 20);
            this.tBoxRegPw.TabIndex = 49;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(125, 169);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 50;
            this.label15.Text = "Passwort";
            // 
            // regFehler
            // 
            this.regFehler.BackColor = System.Drawing.Color.Gray;
            this.regFehler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regFehler.Controls.Add(this.label11);
            this.regFehler.Controls.Add(this.butRegFehler);
            this.regFehler.Location = new System.Drawing.Point(26, 53);
            this.regFehler.Name = "regFehler";
            this.regFehler.Size = new System.Drawing.Size(219, 100);
            this.regFehler.TabIndex = 51;
            this.regFehler.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 52);
            this.label11.TabIndex = 1;
            this.label11.Text = "Es liegt ein Fehler vor.\r\nKontrolieren Sie ihre eingetragenen Werte. \r\nFalls der " +
    "Fehler weiterhin besteht\r\n starten Sie das Program neu.";
            // 
            // butRegFehler
            // 
            this.butRegFehler.Location = new System.Drawing.Point(59, 60);
            this.butRegFehler.Name = "butRegFehler";
            this.butRegFehler.Size = new System.Drawing.Size(75, 23);
            this.butRegFehler.TabIndex = 0;
            this.butRegFehler.Text = "Bestätigen";
            this.butRegFehler.UseVisualStyleBackColor = true;
            this.butRegFehler.Click += new System.EventHandler(this.butRegFehler_Click);
            // 
            // butLoginPasAnzeigen
            // 
            this.butLoginPasAnzeigen.Location = new System.Drawing.Point(234, 184);
            this.butLoginPasAnzeigen.Name = "butLoginPasAnzeigen";
            this.butLoginPasAnzeigen.Size = new System.Drawing.Size(21, 20);
            this.butLoginPasAnzeigen.TabIndex = 52;
            this.butLoginPasAnzeigen.Text = "Anzeigen";
            this.butLoginPasAnzeigen.UseVisualStyleBackColor = true;
            this.butLoginPasAnzeigen.Click += new System.EventHandler(this.butLoginPasAnzeigen_Click);
            // 
            // Registrieren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(373, 415);
            this.Controls.Add(this.butLoginPasAnzeigen);
            this.Controls.Add(this.regFehler);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tBoxRegPw);
            this.Controls.Add(this.DateReg);
            this.Controls.Add(this.tBoxRegHausNr);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tBoxRegPLZ);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tBoxRegStraße);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cBoxRegFunk);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cBoxRegRolle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxRegAbt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tBoxRegUname);
            this.Controls.Add(this.tBoxRegEmail);
            this.Controls.Add(this.tBoxRegOrt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBoxRegName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tBoxRegVname);
            this.Controls.Add(this.herfRegVorhanden);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.butRegErstellen);
            this.Name = "Registrieren";
            this.Text = "Registrieren";
            this.Load += new System.EventHandler(this.Registrieren_Load);
            this.regFehler.ResumeLayout(false);
            this.regFehler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butRegErstellen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel herfRegVorhanden;
        private System.Windows.Forms.ComboBox cBoxRegFunk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBoxRegRolle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxRegAbt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBoxRegUname;
        private System.Windows.Forms.TextBox tBoxRegEmail;
        private System.Windows.Forms.TextBox tBoxRegOrt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxRegName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tBoxRegVname;
        private System.Windows.Forms.TextBox tBoxRegStraße;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tBoxRegPLZ;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tBoxRegHausNr;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker DateReg;
        private System.Windows.Forms.TextBox tBoxRegPw;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel regFehler;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button butRegFehler;
        private System.Windows.Forms.Button butLoginPasAnzeigen;
    }
}