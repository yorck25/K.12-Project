namespace WindowsFormsApp1
{
    partial class Kostenstelle
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
            this.KstDetail = new System.Windows.Forms.Panel();
            this.butKstBearbeiten = new System.Windows.Forms.Button();
            this.AbtMitProAbt = new System.Windows.Forms.Panel();
            this.herfKstAbt = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lBoxKstAbt = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxKstBez = new System.Windows.Forms.TextBox();
            this.herfKstLöschen = new System.Windows.Forms.LinkLabel();
            this.lBoxKst = new System.Windows.Forms.ListBox();
            this.butKstSpeichern = new System.Windows.Forms.Button();
            this.KstDetail.SuspendLayout();
            this.AbtMitProAbt.SuspendLayout();
            this.SuspendLayout();
            // 
            // KstDetail
            // 
            this.KstDetail.Controls.Add(this.butKstSpeichern);
            this.KstDetail.Controls.Add(this.butKstBearbeiten);
            this.KstDetail.Controls.Add(this.AbtMitProAbt);
            this.KstDetail.Controls.Add(this.label1);
            this.KstDetail.Controls.Add(this.tBoxKstBez);
            this.KstDetail.Location = new System.Drawing.Point(138, 8);
            this.KstDetail.Name = "KstDetail";
            this.KstDetail.Size = new System.Drawing.Size(413, 329);
            this.KstDetail.TabIndex = 13;
            this.KstDetail.Visible = false;
            // 
            // butKstBearbeiten
            // 
            this.butKstBearbeiten.Location = new System.Drawing.Point(17, 64);
            this.butKstBearbeiten.Name = "butKstBearbeiten";
            this.butKstBearbeiten.Size = new System.Drawing.Size(81, 32);
            this.butKstBearbeiten.TabIndex = 9;
            this.butKstBearbeiten.Text = "Bearbeiten";
            this.butKstBearbeiten.UseVisualStyleBackColor = true;
            // 
            // AbtMitProAbt
            // 
            this.AbtMitProAbt.Controls.Add(this.herfKstAbt);
            this.AbtMitProAbt.Controls.Add(this.label3);
            this.AbtMitProAbt.Controls.Add(this.lBoxKstAbt);
            this.AbtMitProAbt.Location = new System.Drawing.Point(202, 9);
            this.AbtMitProAbt.Name = "AbtMitProAbt";
            this.AbtMitProAbt.Size = new System.Drawing.Size(200, 239);
            this.AbtMitProAbt.TabIndex = 7;
            // 
            // herfKstAbt
            // 
            this.herfKstAbt.AutoSize = true;
            this.herfKstAbt.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfKstAbt.Location = new System.Drawing.Point(5, 205);
            this.herfKstAbt.Name = "herfKstAbt";
            this.herfKstAbt.Size = new System.Drawing.Size(113, 13);
            this.herfKstAbt.TabIndex = 2;
            this.herfKstAbt.TabStop = true;
            this.herfKstAbt.Text = "Abteilung bearbeiten...";
            this.herfKstAbt.Visible = false;
            this.herfKstAbt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfKstAbt_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Abteilung in der Kostenstelle";
            // 
            // lBoxKstAbt
            // 
            this.lBoxKstAbt.FormattingEnabled = true;
            this.lBoxKstAbt.Items.AddRange(new object[] {
            "TEst"});
            this.lBoxKstAbt.Location = new System.Drawing.Point(3, 29);
            this.lBoxKstAbt.Name = "lBoxKstAbt";
            this.lBoxKstAbt.Size = new System.Drawing.Size(120, 173);
            this.lBoxKstAbt.TabIndex = 0;
            this.lBoxKstAbt.SelectedIndexChanged += new System.EventHandler(this.lBoxKstAbt_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bezeichnung:";
            // 
            // tBoxKstBez
            // 
            this.tBoxKstBez.Location = new System.Drawing.Point(17, 38);
            this.tBoxKstBez.Name = "tBoxKstBez";
            this.tBoxKstBez.Size = new System.Drawing.Size(151, 20);
            this.tBoxKstBez.TabIndex = 1;
            // 
            // herfKstLöschen
            // 
            this.herfKstLöschen.AutoSize = true;
            this.herfKstLöschen.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfKstLöschen.Location = new System.Drawing.Point(28, 332);
            this.herfKstLöschen.Name = "herfKstLöschen";
            this.herfKstLöschen.Size = new System.Drawing.Size(117, 13);
            this.herfKstLöschen.TabIndex = 12;
            this.herfKstLöschen.TabStop = true;
            this.herfKstLöschen.Text = "Kostenstelle Löschen...";
            // 
            // lBoxKst
            // 
            this.lBoxKst.FormattingEnabled = true;
            this.lBoxKst.Items.AddRange(new object[] {
            "TEst"});
            this.lBoxKst.Location = new System.Drawing.Point(12, 26);
            this.lBoxKst.Name = "lBoxKst";
            this.lBoxKst.Size = new System.Drawing.Size(120, 303);
            this.lBoxKst.TabIndex = 11;
            this.lBoxKst.SelectedIndexChanged += new System.EventHandler(this.lBoxKst_SelectedIndexChanged);
            // 
            // butKstSpeichern
            // 
            this.butKstSpeichern.Location = new System.Drawing.Point(104, 64);
            this.butKstSpeichern.Name = "butKstSpeichern";
            this.butKstSpeichern.Size = new System.Drawing.Size(81, 32);
            this.butKstSpeichern.TabIndex = 10;
            this.butKstSpeichern.Text = "Speichern";
            this.butKstSpeichern.UseVisualStyleBackColor = true;
            this.butKstSpeichern.Click += new System.EventHandler(this.butKstSpeichern_Click);
            // 
            // Kostenstelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 367);
            this.Controls.Add(this.KstDetail);
            this.Controls.Add(this.herfKstLöschen);
            this.Controls.Add(this.lBoxKst);
            this.Name = "Kostenstelle";
            this.Text = "Kostenstelle";
            this.KstDetail.ResumeLayout(false);
            this.KstDetail.PerformLayout();
            this.AbtMitProAbt.ResumeLayout(false);
            this.AbtMitProAbt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel KstDetail;
        private System.Windows.Forms.Button butKstBearbeiten;
        private System.Windows.Forms.Panel AbtMitProAbt;
        private System.Windows.Forms.LinkLabel herfKstAbt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lBoxKstAbt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxKstBez;
        private System.Windows.Forms.LinkLabel herfKstLöschen;
        private System.Windows.Forms.ListBox lBoxKst;
        private System.Windows.Forms.Button butKstSpeichern;
    }
}