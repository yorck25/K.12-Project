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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.butMverDetailSchließen = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.MverDetailMitarbeiter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBoxMverMitarbeiter
            // 
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
            this.MverDetailMitarbeiter.Controls.Add(this.comboBox3);
            this.MverDetailMitarbeiter.Controls.Add(this.label9);
            this.MverDetailMitarbeiter.Controls.Add(this.comboBox2);
            this.MverDetailMitarbeiter.Controls.Add(this.label8);
            this.MverDetailMitarbeiter.Controls.Add(this.comboBox1);
            this.MverDetailMitarbeiter.Controls.Add(this.label7);
            this.MverDetailMitarbeiter.Controls.Add(this.butMverDetailSchließen);
            this.MverDetailMitarbeiter.Controls.Add(this.textBox6);
            this.MverDetailMitarbeiter.Controls.Add(this.textBox5);
            this.MverDetailMitarbeiter.Controls.Add(this.textBox4);
            this.MverDetailMitarbeiter.Controls.Add(this.textBox3);
            this.MverDetailMitarbeiter.Controls.Add(this.label6);
            this.MverDetailMitarbeiter.Controls.Add(this.textBox2);
            this.MverDetailMitarbeiter.Controls.Add(this.label5);
            this.MverDetailMitarbeiter.Controls.Add(this.label4);
            this.MverDetailMitarbeiter.Controls.Add(this.label3);
            this.MverDetailMitarbeiter.Controls.Add(this.label2);
            this.MverDetailMitarbeiter.Controls.Add(this.label1);
            this.MverDetailMitarbeiter.Controls.Add(this.textBox1);
            this.MverDetailMitarbeiter.Location = new System.Drawing.Point(184, 25);
            this.MverDetailMitarbeiter.Name = "MverDetailMitarbeiter";
            this.MverDetailMitarbeiter.Size = new System.Drawing.Size(266, 355);
            this.MverDetailMitarbeiter.TabIndex = 1;
            this.MverDetailMitarbeiter.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(26, 210);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 21);
            this.comboBox3.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Funtion:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(142, 162);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Rolle:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Abteilung:";
            // 
            // butMverDetailSchließen
            // 
            this.butMverDetailSchließen.Location = new System.Drawing.Point(26, 302);
            this.butMverDetailSchließen.Name = "butMverDetailSchließen";
            this.butMverDetailSchließen.Size = new System.Drawing.Size(89, 32);
            this.butMverDetailSchließen.TabIndex = 12;
            this.butMverDetailSchließen.Text = "Schließen";
            this.butMverDetailSchließen.UseVisualStyleBackColor = true;
            this.butMverDetailSchließen.Click += new System.EventHandler(this.butMverDetailSchließen_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(142, 111);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(26, 111);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(142, 63);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(26, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "User Name:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "E-Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Geburtstags Datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adresse:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nachname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vorname:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Abteilung hinzufühgen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(675, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Rolle hinzufühgen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(675, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Funktion hinzufühgen";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Mitarbeiterverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 413);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MverDetailMitarbeiter);
            this.Controls.Add(this.lBoxMverMitarbeiter);
            this.Name = "Mitarbeiterverwaltung";
            this.Text = "Mitarbeiterverwaltung";
            this.MverDetailMitarbeiter.ResumeLayout(false);
            this.MverDetailMitarbeiter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxMverMitarbeiter;
        private System.Windows.Forms.Panel MverDetailMitarbeiter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button butMverDetailSchließen;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}