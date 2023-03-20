namespace WindowsFormsApp1
{
    partial class Lager
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
            this.LVWDetail = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxLVWStr = new System.Windows.Forms.TextBox();
            this.butLVWErstellen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxLVWPLZ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxLVWOrt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxLVWBez = new System.Windows.Forms.TextBox();
            this.herfLvwLöschen = new System.Windows.Forms.LinkLabel();
            this.herfLVWNeu = new System.Windows.Forms.LinkLabel();
            this.lBoxLagerort = new System.Windows.Forms.ListBox();
            this.lvwBestätigungLöschen = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.butLvwbestätigen = new System.Windows.Forms.Button();
            this.LVWDetail.SuspendLayout();
            this.lvwBestätigungLöschen.SuspendLayout();
            this.SuspendLayout();
            // 
            // LVWDetail
            // 
            this.LVWDetail.Controls.Add(this.label4);
            this.LVWDetail.Controls.Add(this.tBoxLVWStr);
            this.LVWDetail.Controls.Add(this.butLVWErstellen);
            this.LVWDetail.Controls.Add(this.label3);
            this.LVWDetail.Controls.Add(this.tBoxLVWPLZ);
            this.LVWDetail.Controls.Add(this.label2);
            this.LVWDetail.Controls.Add(this.tBoxLVWOrt);
            this.LVWDetail.Controls.Add(this.label1);
            this.LVWDetail.Controls.Add(this.tBoxLVWBez);
            this.LVWDetail.Location = new System.Drawing.Point(180, 29);
            this.LVWDetail.Name = "LVWDetail";
            this.LVWDetail.Size = new System.Drawing.Size(136, 213);
            this.LVWDetail.TabIndex = 11;
            this.LVWDetail.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Str:";
            // 
            // tBoxLVWStr
            // 
            this.tBoxLVWStr.Location = new System.Drawing.Point(3, 154);
            this.tBoxLVWStr.Name = "tBoxLVWStr";
            this.tBoxLVWStr.Size = new System.Drawing.Size(116, 20);
            this.tBoxLVWStr.TabIndex = 9;
            // 
            // butLVWErstellen
            // 
            this.butLVWErstellen.Location = new System.Drawing.Point(3, 180);
            this.butLVWErstellen.Name = "butLVWErstellen";
            this.butLVWErstellen.Size = new System.Drawing.Size(75, 23);
            this.butLVWErstellen.TabIndex = 5;
            this.butLVWErstellen.Text = "Erstellen";
            this.butLVWErstellen.UseVisualStyleBackColor = true;
            this.butLVWErstellen.Click += new System.EventHandler(this.butLVWErstellen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "PLZ:";
            // 
            // tBoxLVWPLZ
            // 
            this.tBoxLVWPLZ.Location = new System.Drawing.Point(3, 113);
            this.tBoxLVWPLZ.Name = "tBoxLVWPLZ";
            this.tBoxLVWPLZ.Size = new System.Drawing.Size(116, 20);
            this.tBoxLVWPLZ.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ort:";
            // 
            // tBoxLVWOrt
            // 
            this.tBoxLVWOrt.Location = new System.Drawing.Point(3, 70);
            this.tBoxLVWOrt.Name = "tBoxLVWOrt";
            this.tBoxLVWOrt.Size = new System.Drawing.Size(116, 20);
            this.tBoxLVWOrt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bezeichnung:";
            // 
            // tBoxLVWBez
            // 
            this.tBoxLVWBez.Location = new System.Drawing.Point(3, 28);
            this.tBoxLVWBez.Name = "tBoxLVWBez";
            this.tBoxLVWBez.Size = new System.Drawing.Size(116, 20);
            this.tBoxLVWBez.TabIndex = 3;
            // 
            // herfLvwLöschen
            // 
            this.herfLvwLöschen.AutoSize = true;
            this.herfLvwLöschen.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfLvwLöschen.Location = new System.Drawing.Point(33, 244);
            this.herfLvwLöschen.Name = "herfLvwLöschen";
            this.herfLvwLöschen.Size = new System.Drawing.Size(99, 13);
            this.herfLvwLöschen.TabIndex = 10;
            this.herfLvwLöschen.TabStop = true;
            this.herfLvwLöschen.Text = "Lagerort Löschen...";
            this.herfLvwLöschen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfLvwLöschen_LinkClicked);
            // 
            // herfLVWNeu
            // 
            this.herfLVWNeu.AutoSize = true;
            this.herfLVWNeu.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfLVWNeu.Location = new System.Drawing.Point(48, 13);
            this.herfLVWNeu.Name = "herfLVWNeu";
            this.herfLVWNeu.Size = new System.Drawing.Size(84, 13);
            this.herfLVWNeu.TabIndex = 9;
            this.herfLVWNeu.TabStop = true;
            this.herfLVWNeu.Text = "Neuer Lagerort..";
            this.herfLVWNeu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfLVWNeu_LinkClicked);
            // 
            // lBoxLagerort
            // 
            this.lBoxLagerort.DisplayMember = "LagerortListe";
            this.lBoxLagerort.FormattingEnabled = true;
            this.lBoxLagerort.Items.AddRange(new object[] {
            "gdfg",
            "df",
            "g",
            "dfg",
            "df",
            "g",
            "dfg"});
            this.lBoxLagerort.Location = new System.Drawing.Point(12, 29);
            this.lBoxLagerort.Name = "lBoxLagerort";
            this.lBoxLagerort.Size = new System.Drawing.Size(120, 212);
            this.lBoxLagerort.TabIndex = 8;
            this.lBoxLagerort.SelectedIndexChanged += new System.EventHandler(this.lBoxLagerort_SelectedIndexChanged);
            // 
            // lvwBestätigungLöschen
            // 
            this.lvwBestätigungLöschen.BackColor = System.Drawing.Color.Gray;
            this.lvwBestätigungLöschen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwBestätigungLöschen.Controls.Add(this.label5);
            this.lvwBestätigungLöschen.Controls.Add(this.butLvwbestätigen);
            this.lvwBestätigungLöschen.Location = new System.Drawing.Point(99, 62);
            this.lvwBestätigungLöschen.Name = "lvwBestätigungLöschen";
            this.lvwBestätigungLöschen.Size = new System.Drawing.Size(200, 100);
            this.lvwBestätigungLöschen.TabIndex = 11;
            this.lvwBestätigungLöschen.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Die Ausgewählte Rolle wird gelösche";
            // 
            // butLvwbestätigen
            // 
            this.butLvwbestätigen.Location = new System.Drawing.Point(59, 47);
            this.butLvwbestätigen.Name = "butLvwbestätigen";
            this.butLvwbestätigen.Size = new System.Drawing.Size(75, 23);
            this.butLvwbestätigen.TabIndex = 0;
            this.butLvwbestätigen.Text = "Bestätigen";
            this.butLvwbestätigen.UseVisualStyleBackColor = true;
            this.butLvwbestätigen.Click += new System.EventHandler(this.butLvwbestätigen_Click);
            // 
            // Lager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 396);
            this.Controls.Add(this.lvwBestätigungLöschen);
            this.Controls.Add(this.herfLvwLöschen);
            this.Controls.Add(this.herfLVWNeu);
            this.Controls.Add(this.lBoxLagerort);
            this.Controls.Add(this.LVWDetail);
            this.Name = "Lager";
            this.Text = "Lager";
            this.Load += new System.EventHandler(this.Lager_Load);
            this.LVWDetail.ResumeLayout(false);
            this.LVWDetail.PerformLayout();
            this.lvwBestätigungLöschen.ResumeLayout(false);
            this.lvwBestätigungLöschen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel LVWDetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxLVWStr;
        private System.Windows.Forms.Button butLVWErstellen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxLVWPLZ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxLVWOrt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxLVWBez;
        private System.Windows.Forms.LinkLabel herfLvwLöschen;
        private System.Windows.Forms.LinkLabel herfLVWNeu;
        private System.Windows.Forms.ListBox lBoxLagerort;
        private System.Windows.Forms.Panel lvwBestätigungLöschen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butLvwbestätigen;
    }
}