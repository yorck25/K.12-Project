namespace WindowsFormsApp1
{
    partial class Einheit
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
            this.lBoxEinheit = new System.Windows.Forms.ListBox();
            this.herfEinNeu = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tBoxEinBez = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butEinErstellen = new System.Windows.Forms.Button();
            this.EinDetail = new System.Windows.Forms.Panel();
            this.EinDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBoxEinheit
            // 
            this.lBoxEinheit.DisplayMember = "EinheitListe";
            this.lBoxEinheit.FormattingEnabled = true;
            this.lBoxEinheit.Items.AddRange(new object[] {
            "gdfg",
            "df",
            "g",
            "dfg",
            "df",
            "g",
            "dfg"});
            this.lBoxEinheit.Location = new System.Drawing.Point(13, 26);
            this.lBoxEinheit.Name = "lBoxEinheit";
            this.lBoxEinheit.Size = new System.Drawing.Size(120, 212);
            this.lBoxEinheit.TabIndex = 0;
            this.lBoxEinheit.SelectedIndexChanged += new System.EventHandler(this.lBoxEinheit_SelectedIndexChanged);
            // 
            // herfEinNeu
            // 
            this.herfEinNeu.AutoSize = true;
            this.herfEinNeu.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfEinNeu.Location = new System.Drawing.Point(56, 9);
            this.herfEinNeu.Name = "herfEinNeu";
            this.herfEinNeu.Size = new System.Drawing.Size(77, 13);
            this.herfEinNeu.TabIndex = 1;
            this.herfEinNeu.TabStop = true;
            this.herfEinNeu.Text = "Neue Einheit...";
            this.herfEinNeu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfEinNeu_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel1.Location = new System.Drawing.Point(45, 241);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(88, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Einheit löschen...";
            // 
            // tBoxEinBez
            // 
            this.tBoxEinBez.Location = new System.Drawing.Point(3, 18);
            this.tBoxEinBez.Name = "tBoxEinBez";
            this.tBoxEinBez.Size = new System.Drawing.Size(116, 20);
            this.tBoxEinBez.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bezeichnung:";
            // 
            // butEinErstellen
            // 
            this.butEinErstellen.Location = new System.Drawing.Point(3, 45);
            this.butEinErstellen.Name = "butEinErstellen";
            this.butEinErstellen.Size = new System.Drawing.Size(75, 23);
            this.butEinErstellen.TabIndex = 5;
            this.butEinErstellen.Text = "Erstellen";
            this.butEinErstellen.UseVisualStyleBackColor = true;
            this.butEinErstellen.Click += new System.EventHandler(this.butEinErstellen_Click);
            // 
            // EinDetail
            // 
            this.EinDetail.Controls.Add(this.label1);
            this.EinDetail.Controls.Add(this.tBoxEinBez);
            this.EinDetail.Controls.Add(this.butEinErstellen);
            this.EinDetail.Location = new System.Drawing.Point(139, 26);
            this.EinDetail.Name = "EinDetail";
            this.EinDetail.Size = new System.Drawing.Size(146, 89);
            this.EinDetail.TabIndex = 7;
            this.EinDetail.Visible = false;
            // 
            // Einheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 263);
            this.Controls.Add(this.EinDetail);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.herfEinNeu);
            this.Controls.Add(this.lBoxEinheit);
            this.Name = "Einheit";
            this.Text = "Einheit";
            this.Load += new System.EventHandler(this.Einheit_Load);
            this.EinDetail.ResumeLayout(false);
            this.EinDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxEinheit;
        private System.Windows.Forms.LinkLabel herfEinNeu;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox tBoxEinBez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butEinErstellen;
        internal System.Windows.Forms.Panel EinDetail;
    }
}