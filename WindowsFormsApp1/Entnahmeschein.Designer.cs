namespace WindowsFormsApp1
{
    partial class Entnahmeschein
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.herfEsNeu = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxEsVonMit = new System.Windows.Forms.ComboBox();
            this.cBoxEsFürMit = new System.Windows.Forms.ComboBox();
            this.butEsErstellen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(126, 329);
            this.listBox1.TabIndex = 0;
            // 
            // herfEsNeu
            // 
            this.herfEsNeu.AutoSize = true;
            this.herfEsNeu.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfEsNeu.Location = new System.Drawing.Point(9, 9);
            this.herfEsNeu.Name = "herfEsNeu";
            this.herfEsNeu.Size = new System.Drawing.Size(130, 13);
            this.herfEsNeu.TabIndex = 1;
            this.herfEsNeu.TabStop = true;
            this.herfEsNeu.Text = "Neuen Entnahmeschein...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butEsErstellen);
            this.panel1.Controls.Add(this.cBoxEsFürMit);
            this.panel1.Controls.Add(this.cBoxEsVonMit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(159, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 160);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bearbeitet von:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ausgabe an:";
            // 
            // cBoxEsVonMit
            // 
            this.cBoxEsVonMit.FormattingEnabled = true;
            this.cBoxEsVonMit.Location = new System.Drawing.Point(17, 30);
            this.cBoxEsVonMit.Name = "cBoxEsVonMit";
            this.cBoxEsVonMit.Size = new System.Drawing.Size(121, 21);
            this.cBoxEsVonMit.TabIndex = 2;
            // 
            // cBoxEsFürMit
            // 
            this.cBoxEsFürMit.FormattingEnabled = true;
            this.cBoxEsFürMit.Location = new System.Drawing.Point(17, 71);
            this.cBoxEsFürMit.Name = "cBoxEsFürMit";
            this.cBoxEsFürMit.Size = new System.Drawing.Size(121, 21);
            this.cBoxEsFürMit.TabIndex = 3;
            // 
            // butEsErstellen
            // 
            this.butEsErstellen.Location = new System.Drawing.Point(17, 111);
            this.butEsErstellen.Name = "butEsErstellen";
            this.butEsErstellen.Size = new System.Drawing.Size(75, 23);
            this.butEsErstellen.TabIndex = 4;
            this.butEsErstellen.Text = "Erstellen";
            this.butEsErstellen.UseVisualStyleBackColor = true;
            // 
            // Entnahmeschein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 397);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.herfEsNeu);
            this.Controls.Add(this.listBox1);
            this.Name = "Entnahmeschein";
            this.Text = "Entnahmeschein";
            this.Load += new System.EventHandler(this.Entnahmeschein_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.LinkLabel herfEsNeu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butEsErstellen;
        private System.Windows.Forms.ComboBox cBoxEsFürMit;
        private System.Windows.Forms.ComboBox cBoxEsVonMit;
        private System.Windows.Forms.Label label2;
    }
}