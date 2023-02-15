namespace WindowsFormsApp1
{
    partial class Hauptmenu
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
            this.components = new System.ComponentModel.Container();
            this.hauptmenuÖffnenSidebar = new System.Windows.Forms.Button();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.hmenuNavElemente = new System.Windows.Forms.Panel();
            this.butHmenuLieferschein = new System.Windows.Forms.Button();
            this.butHmenuMaterial = new System.Windows.Forms.Button();
            this.butHmenuMitarbeiter = new System.Windows.Forms.Button();
            this.butHmenuLieferant = new System.Windows.Forms.Button();
            this.butHmenuLager = new System.Windows.Forms.Button();
            this.butHmenuArtikel = new System.Windows.Forms.Button();
            this.hmenuAccElemente = new System.Windows.Forms.Panel();
            this.butHmenuÄndern = new System.Windows.Forms.Button();
            this.butHmenuAbmelden = new System.Windows.Forms.Button();
            this.butHauptmenuÖffnenAcc = new System.Windows.Forms.Button();
            this.butHauptmenuÖffnenNachrichten = new System.Windows.Forms.Button();
            this.hmenuBenachrichtigungList = new System.Windows.Forms.Panel();
            this.lBoxBenachrichtigung = new System.Windows.Forms.ListBox();
            this.hmenuDetailBenachrichtigung = new System.Windows.Forms.Panel();
            this.tBoxSender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butHmenuNachrichtLöschen = new System.Windows.Forms.Button();
            this.tBoxNachricht = new System.Windows.Forms.RichTextBox();
            this.lBoxHmenuBestand = new System.Windows.Forms.ListBox();
            this.hmenuDetailABestand = new System.Windows.Forms.Panel();
            this.butHmenuBestätigen = new System.Windows.Forms.Button();
            this.butHmenuNeuBestellen = new System.Windows.Forms.Button();
            this.tBoxHmenuAMAxBestand = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxHmenuAMinBestand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxHmenuABestand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxHmenuAName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hmenuNavElemente.SuspendLayout();
            this.hmenuAccElemente.SuspendLayout();
            this.hmenuBenachrichtigungList.SuspendLayout();
            this.hmenuDetailBenachrichtigung.SuspendLayout();
            this.hmenuDetailABestand.SuspendLayout();
            this.SuspendLayout();
            // 
            // hauptmenuÖffnenSidebar
            // 
            this.hauptmenuÖffnenSidebar.Location = new System.Drawing.Point(12, 12);
            this.hauptmenuÖffnenSidebar.Name = "hauptmenuÖffnenSidebar";
            this.hauptmenuÖffnenSidebar.Size = new System.Drawing.Size(59, 37);
            this.hauptmenuÖffnenSidebar.TabIndex = 0;
            this.hauptmenuÖffnenSidebar.Text = "---------";
            this.hauptmenuÖffnenSidebar.UseVisualStyleBackColor = true;
            this.hauptmenuÖffnenSidebar.Click += new System.EventHandler(this.hauptmenuÖffnenSidebar_Click);
            // 
            // hmenuNavElemente
            // 
            this.hmenuNavElemente.Controls.Add(this.butHmenuLieferschein);
            this.hmenuNavElemente.Controls.Add(this.butHmenuMaterial);
            this.hmenuNavElemente.Controls.Add(this.butHmenuMitarbeiter);
            this.hmenuNavElemente.Controls.Add(this.butHmenuLieferant);
            this.hmenuNavElemente.Controls.Add(this.butHmenuLager);
            this.hmenuNavElemente.Controls.Add(this.butHmenuArtikel);
            this.hmenuNavElemente.Location = new System.Drawing.Point(12, 55);
            this.hmenuNavElemente.Name = "hmenuNavElemente";
            this.hmenuNavElemente.Size = new System.Drawing.Size(140, 365);
            this.hmenuNavElemente.TabIndex = 1;
            this.hmenuNavElemente.Visible = false;
            // 
            // butHmenuLieferschein
            // 
            this.butHmenuLieferschein.Location = new System.Drawing.Point(3, 251);
            this.butHmenuLieferschein.Name = "butHmenuLieferschein";
            this.butHmenuLieferschein.Size = new System.Drawing.Size(125, 41);
            this.butHmenuLieferschein.TabIndex = 5;
            this.butHmenuLieferschein.Text = "Lieferscheinverwaltung";
            this.butHmenuLieferschein.UseVisualStyleBackColor = true;
            // 
            // butHmenuMaterial
            // 
            this.butHmenuMaterial.Location = new System.Drawing.Point(3, 314);
            this.butHmenuMaterial.Name = "butHmenuMaterial";
            this.butHmenuMaterial.Size = new System.Drawing.Size(125, 41);
            this.butHmenuMaterial.TabIndex = 4;
            this.butHmenuMaterial.Text = "Materialentnahmescheinverwaltung";
            this.butHmenuMaterial.UseVisualStyleBackColor = true;
            // 
            // butHmenuMitarbeiter
            // 
            this.butHmenuMitarbeiter.Location = new System.Drawing.Point(3, 80);
            this.butHmenuMitarbeiter.Name = "butHmenuMitarbeiter";
            this.butHmenuMitarbeiter.Size = new System.Drawing.Size(125, 41);
            this.butHmenuMitarbeiter.TabIndex = 3;
            this.butHmenuMitarbeiter.Text = "MItarbeiterverwaltung";
            this.butHmenuMitarbeiter.UseVisualStyleBackColor = true;
            this.butHmenuMitarbeiter.Click += new System.EventHandler(this.butHmenuMitarbeiter_Click);
            // 
            // butHmenuLieferant
            // 
            this.butHmenuLieferant.Location = new System.Drawing.Point(3, 137);
            this.butHmenuLieferant.Name = "butHmenuLieferant";
            this.butHmenuLieferant.Size = new System.Drawing.Size(125, 41);
            this.butHmenuLieferant.TabIndex = 2;
            this.butHmenuLieferant.Text = "Lieferantenveraltung";
            this.butHmenuLieferant.UseVisualStyleBackColor = true;
            // 
            // butHmenuLager
            // 
            this.butHmenuLager.Location = new System.Drawing.Point(3, 195);
            this.butHmenuLager.Name = "butHmenuLager";
            this.butHmenuLager.Size = new System.Drawing.Size(125, 41);
            this.butHmenuLager.TabIndex = 1;
            this.butHmenuLager.Text = "Lagerverwaltung";
            this.butHmenuLager.UseVisualStyleBackColor = true;
            // 
            // butHmenuArtikel
            // 
            this.butHmenuArtikel.Location = new System.Drawing.Point(3, 19);
            this.butHmenuArtikel.Name = "butHmenuArtikel";
            this.butHmenuArtikel.Size = new System.Drawing.Size(125, 41);
            this.butHmenuArtikel.TabIndex = 0;
            this.butHmenuArtikel.Text = "Artikelverwaltung";
            this.butHmenuArtikel.UseVisualStyleBackColor = true;
            // 
            // hmenuAccElemente
            // 
            this.hmenuAccElemente.Controls.Add(this.butHmenuÄndern);
            this.hmenuAccElemente.Controls.Add(this.butHmenuAbmelden);
            this.hmenuAccElemente.Location = new System.Drawing.Point(777, 68);
            this.hmenuAccElemente.Name = "hmenuAccElemente";
            this.hmenuAccElemente.Size = new System.Drawing.Size(141, 113);
            this.hmenuAccElemente.TabIndex = 2;
            this.hmenuAccElemente.Visible = false;
            // 
            // butHmenuÄndern
            // 
            this.butHmenuÄndern.Location = new System.Drawing.Point(7, 9);
            this.butHmenuÄndern.Name = "butHmenuÄndern";
            this.butHmenuÄndern.Size = new System.Drawing.Size(125, 41);
            this.butHmenuÄndern.TabIndex = 2;
            this.butHmenuÄndern.Text = "Details ändern";
            this.butHmenuÄndern.UseVisualStyleBackColor = true;
            this.butHmenuÄndern.Click += new System.EventHandler(this.butHmenuÄndern_Click);
            // 
            // butHmenuAbmelden
            // 
            this.butHmenuAbmelden.Location = new System.Drawing.Point(7, 56);
            this.butHmenuAbmelden.Name = "butHmenuAbmelden";
            this.butHmenuAbmelden.Size = new System.Drawing.Size(125, 41);
            this.butHmenuAbmelden.TabIndex = 1;
            this.butHmenuAbmelden.Text = "Abmelden";
            this.butHmenuAbmelden.UseVisualStyleBackColor = true;
            this.butHmenuAbmelden.Click += new System.EventHandler(this.butHmenuAbmelden_Click);
            // 
            // butHauptmenuÖffnenAcc
            // 
            this.butHauptmenuÖffnenAcc.Location = new System.Drawing.Point(852, 12);
            this.butHauptmenuÖffnenAcc.Name = "butHauptmenuÖffnenAcc";
            this.butHauptmenuÖffnenAcc.Size = new System.Drawing.Size(57, 37);
            this.butHauptmenuÖffnenAcc.TabIndex = 3;
            this.butHauptmenuÖffnenAcc.Text = "ACC";
            this.butHauptmenuÖffnenAcc.UseVisualStyleBackColor = true;
            this.butHauptmenuÖffnenAcc.Click += new System.EventHandler(this.button1hauptmenuÖffnenAcc_Click);
            // 
            // butHauptmenuÖffnenNachrichten
            // 
            this.butHauptmenuÖffnenNachrichten.Location = new System.Drawing.Point(691, 12);
            this.butHauptmenuÖffnenNachrichten.Name = "butHauptmenuÖffnenNachrichten";
            this.butHauptmenuÖffnenNachrichten.Size = new System.Drawing.Size(65, 37);
            this.butHauptmenuÖffnenNachrichten.TabIndex = 4;
            this.butHauptmenuÖffnenNachrichten.Text = "Benachrichtigungen";
            this.butHauptmenuÖffnenNachrichten.UseVisualStyleBackColor = true;
            this.butHauptmenuÖffnenNachrichten.Click += new System.EventHandler(this.butHauptmenuÖffnenNachrichten_Click);
            // 
            // hmenuBenachrichtigungList
            // 
            this.hmenuBenachrichtigungList.Controls.Add(this.lBoxBenachrichtigung);
            this.hmenuBenachrichtigungList.Location = new System.Drawing.Point(635, 68);
            this.hmenuBenachrichtigungList.Name = "hmenuBenachrichtigungList";
            this.hmenuBenachrichtigungList.Size = new System.Drawing.Size(136, 113);
            this.hmenuBenachrichtigungList.TabIndex = 5;
            this.hmenuBenachrichtigungList.Visible = false;
            // 
            // lBoxBenachrichtigung
            // 
            this.lBoxBenachrichtigung.FormattingEnabled = true;
            this.lBoxBenachrichtigung.Items.AddRange(new object[] {
            "Test 1",
            "Test2",
            "Test3"});
            this.lBoxBenachrichtigung.Location = new System.Drawing.Point(9, 9);
            this.lBoxBenachrichtigung.Name = "lBoxBenachrichtigung";
            this.lBoxBenachrichtigung.Size = new System.Drawing.Size(120, 95);
            this.lBoxBenachrichtigung.TabIndex = 0;
            this.lBoxBenachrichtigung.SelectedIndexChanged += new System.EventHandler(this.lBoxBenachrichtigung_SelectedIndexChanged);
            // 
            // hmenuDetailBenachrichtigung
            // 
            this.hmenuDetailBenachrichtigung.Controls.Add(this.tBoxSender);
            this.hmenuDetailBenachrichtigung.Controls.Add(this.label1);
            this.hmenuDetailBenachrichtigung.Controls.Add(this.butHmenuNachrichtLöschen);
            this.hmenuDetailBenachrichtigung.Controls.Add(this.tBoxNachricht);
            this.hmenuDetailBenachrichtigung.Location = new System.Drawing.Point(635, 192);
            this.hmenuDetailBenachrichtigung.Name = "hmenuDetailBenachrichtigung";
            this.hmenuDetailBenachrichtigung.Size = new System.Drawing.Size(283, 155);
            this.hmenuDetailBenachrichtigung.TabIndex = 6;
            this.hmenuDetailBenachrichtigung.Visible = false;
            // 
            // tBoxSender
            // 
            this.tBoxSender.Location = new System.Drawing.Point(149, 34);
            this.tBoxSender.Name = "tBoxSender";
            this.tBoxSender.Size = new System.Drawing.Size(100, 20);
            this.tBoxSender.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gesendet von:";
            // 
            // butHmenuNachrichtLöschen
            // 
            this.butHmenuNachrichtLöschen.Location = new System.Drawing.Point(149, 111);
            this.butHmenuNachrichtLöschen.Name = "butHmenuNachrichtLöschen";
            this.butHmenuNachrichtLöschen.Size = new System.Drawing.Size(125, 41);
            this.butHmenuNachrichtLöschen.TabIndex = 2;
            this.butHmenuNachrichtLöschen.Text = "Löschen";
            this.butHmenuNachrichtLöschen.UseVisualStyleBackColor = true;
            // 
            // tBoxNachricht
            // 
            this.tBoxNachricht.Location = new System.Drawing.Point(9, 4);
            this.tBoxNachricht.Name = "tBoxNachricht";
            this.tBoxNachricht.Size = new System.Drawing.Size(120, 148);
            this.tBoxNachricht.TabIndex = 0;
            this.tBoxNachricht.Text = "";
            // 
            // lBoxHmenuBestand
            // 
            this.lBoxHmenuBestand.FormattingEnabled = true;
            this.lBoxHmenuBestand.Items.AddRange(new object[] {
            "Test 1",
            "Test 2",
            "Test 3"});
            this.lBoxHmenuBestand.Location = new System.Drawing.Point(228, 55);
            this.lBoxHmenuBestand.Name = "lBoxHmenuBestand";
            this.lBoxHmenuBestand.Size = new System.Drawing.Size(154, 355);
            this.lBoxHmenuBestand.TabIndex = 7;
            this.lBoxHmenuBestand.SelectedIndexChanged += new System.EventHandler(this.lBoxHmenuBestand_SelectedIndexChanged);
            // 
            // hmenuDetailABestand
            // 
            this.hmenuDetailABestand.Controls.Add(this.butHmenuBestätigen);
            this.hmenuDetailABestand.Controls.Add(this.butHmenuNeuBestellen);
            this.hmenuDetailABestand.Controls.Add(this.tBoxHmenuAMAxBestand);
            this.hmenuDetailABestand.Controls.Add(this.label5);
            this.hmenuDetailABestand.Controls.Add(this.tBoxHmenuAMinBestand);
            this.hmenuDetailABestand.Controls.Add(this.label4);
            this.hmenuDetailABestand.Controls.Add(this.tBoxHmenuABestand);
            this.hmenuDetailABestand.Controls.Add(this.label3);
            this.hmenuDetailABestand.Controls.Add(this.tBoxHmenuAName);
            this.hmenuDetailABestand.Controls.Add(this.label2);
            this.hmenuDetailABestand.Location = new System.Drawing.Point(408, 55);
            this.hmenuDetailABestand.Name = "hmenuDetailABestand";
            this.hmenuDetailABestand.Size = new System.Drawing.Size(200, 355);
            this.hmenuDetailABestand.TabIndex = 8;
            this.hmenuDetailABestand.Visible = false;
            // 
            // butHmenuBestätigen
            // 
            this.butHmenuBestätigen.Location = new System.Drawing.Point(20, 289);
            this.butHmenuBestätigen.Name = "butHmenuBestätigen";
            this.butHmenuBestätigen.Size = new System.Drawing.Size(126, 41);
            this.butHmenuBestätigen.TabIndex = 9;
            this.butHmenuBestätigen.Text = "Bestätigen";
            this.butHmenuBestätigen.UseVisualStyleBackColor = true;
            this.butHmenuBestätigen.Click += new System.EventHandler(this.butHmenuBestätigen_Click);
            // 
            // butHmenuNeuBestellen
            // 
            this.butHmenuNeuBestellen.Location = new System.Drawing.Point(20, 242);
            this.butHmenuNeuBestellen.Name = "butHmenuNeuBestellen";
            this.butHmenuNeuBestellen.Size = new System.Drawing.Size(126, 41);
            this.butHmenuNeuBestellen.TabIndex = 8;
            this.butHmenuNeuBestellen.Text = "Neu Bestellen";
            this.butHmenuNeuBestellen.UseVisualStyleBackColor = true;
            // 
            // tBoxHmenuAMAxBestand
            // 
            this.tBoxHmenuAMAxBestand.Location = new System.Drawing.Point(20, 195);
            this.tBoxHmenuAMAxBestand.Name = "tBoxHmenuAMAxBestand";
            this.tBoxHmenuAMAxBestand.Size = new System.Drawing.Size(100, 20);
            this.tBoxHmenuAMAxBestand.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Maximaler Bestand";
            // 
            // tBoxHmenuAMinBestand
            // 
            this.tBoxHmenuAMinBestand.Location = new System.Drawing.Point(20, 141);
            this.tBoxHmenuAMinBestand.Name = "tBoxHmenuAMinBestand";
            this.tBoxHmenuAMinBestand.Size = new System.Drawing.Size(100, 20);
            this.tBoxHmenuAMinBestand.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mindest Bestand";
            // 
            // tBoxHmenuABestand
            // 
            this.tBoxHmenuABestand.Location = new System.Drawing.Point(20, 89);
            this.tBoxHmenuABestand.Name = "tBoxHmenuABestand";
            this.tBoxHmenuABestand.Size = new System.Drawing.Size(100, 20);
            this.tBoxHmenuABestand.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aktueller Bestand";
            // 
            // tBoxHmenuAName
            // 
            this.tBoxHmenuAName.Location = new System.Drawing.Point(20, 33);
            this.tBoxHmenuAName.Name = "tBoxHmenuAName";
            this.tBoxHmenuAName.Size = new System.Drawing.Size(100, 20);
            this.tBoxHmenuAName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Artikel Name";
            // 
            // Hauptmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 456);
            this.Controls.Add(this.hmenuDetailABestand);
            this.Controls.Add(this.lBoxHmenuBestand);
            this.Controls.Add(this.hmenuDetailBenachrichtigung);
            this.Controls.Add(this.hmenuBenachrichtigungList);
            this.Controls.Add(this.butHauptmenuÖffnenNachrichten);
            this.Controls.Add(this.butHauptmenuÖffnenAcc);
            this.Controls.Add(this.hmenuAccElemente);
            this.Controls.Add(this.hmenuNavElemente);
            this.Controls.Add(this.hauptmenuÖffnenSidebar);
            this.Name = "Hauptmenu";
            this.Text = "Hauptmenu";
            this.hmenuNavElemente.ResumeLayout(false);
            this.hmenuAccElemente.ResumeLayout(false);
            this.hmenuBenachrichtigungList.ResumeLayout(false);
            this.hmenuDetailBenachrichtigung.ResumeLayout(false);
            this.hmenuDetailBenachrichtigung.PerformLayout();
            this.hmenuDetailABestand.ResumeLayout(false);
            this.hmenuDetailABestand.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hauptmenuÖffnenSidebar;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Panel hmenuNavElemente;
        private System.Windows.Forms.Button butHmenuLieferschein;
        private System.Windows.Forms.Button butHmenuMaterial;
        private System.Windows.Forms.Button butHmenuMitarbeiter;
        private System.Windows.Forms.Button butHmenuLieferant;
        private System.Windows.Forms.Button butHmenuLager;
        private System.Windows.Forms.Button butHmenuArtikel;
        private System.Windows.Forms.Panel hmenuAccElemente;
        private System.Windows.Forms.Button butHmenuÄndern;
        private System.Windows.Forms.Button butHmenuAbmelden;
        private System.Windows.Forms.Button butHauptmenuÖffnenAcc;
        private System.Windows.Forms.Button butHauptmenuÖffnenNachrichten;
        private System.Windows.Forms.Panel hmenuBenachrichtigungList;
        private System.Windows.Forms.ListBox lBoxBenachrichtigung;
        private System.Windows.Forms.Panel hmenuDetailBenachrichtigung;
        private System.Windows.Forms.TextBox tBoxSender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butHmenuNachrichtLöschen;
        private System.Windows.Forms.RichTextBox tBoxNachricht;
        private System.Windows.Forms.ListBox lBoxHmenuBestand;
        private System.Windows.Forms.Panel hmenuDetailABestand;
        private System.Windows.Forms.Button butHmenuBestätigen;
        private System.Windows.Forms.Button butHmenuNeuBestellen;
        private System.Windows.Forms.TextBox tBoxHmenuAMAxBestand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxHmenuAMinBestand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxHmenuABestand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxHmenuAName;
        private System.Windows.Forms.Label label2;
    }
}