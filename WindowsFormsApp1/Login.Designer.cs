namespace WindowsFormsApp1
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxLoginEmail = new System.Windows.Forms.TextBox();
            this.tBoxLoginPas = new System.Windows.Forms.TextBox();
            this.butLoginPasAnzeigen = new System.Windows.Forms.Button();
            this.butLoginAnmelden = new System.Windows.Forms.Button();
            this.butLoginReg = new System.Windows.Forms.Button();
            this.LoginFehlermeldung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(59, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nutzername:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(59, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passwort:";
            // 
            // tBoxLoginEmail
            // 
            this.tBoxLoginEmail.Location = new System.Drawing.Point(63, 39);
            this.tBoxLoginEmail.Name = "tBoxLoginEmail";
            this.tBoxLoginEmail.Size = new System.Drawing.Size(169, 20);
            this.tBoxLoginEmail.TabIndex = 2;
            // 
            // tBoxLoginPas
            // 
            this.tBoxLoginPas.Location = new System.Drawing.Point(63, 98);
            this.tBoxLoginPas.Name = "tBoxLoginPas";
            this.tBoxLoginPas.Size = new System.Drawing.Size(142, 20);
            this.tBoxLoginPas.TabIndex = 3;
            // 
            // butLoginPasAnzeigen
            // 
            this.butLoginPasAnzeigen.Location = new System.Drawing.Point(211, 98);
            this.butLoginPasAnzeigen.Name = "butLoginPasAnzeigen";
            this.butLoginPasAnzeigen.Size = new System.Drawing.Size(21, 20);
            this.butLoginPasAnzeigen.TabIndex = 4;
            this.butLoginPasAnzeigen.Text = "Anzeigen";
            this.butLoginPasAnzeigen.UseVisualStyleBackColor = true;
            this.butLoginPasAnzeigen.Click += new System.EventHandler(this.butLoginPasAnzeigen_Click);
            // 
            // butLoginAnmelden
            // 
            this.butLoginAnmelden.Location = new System.Drawing.Point(63, 154);
            this.butLoginAnmelden.Name = "butLoginAnmelden";
            this.butLoginAnmelden.Size = new System.Drawing.Size(144, 47);
            this.butLoginAnmelden.TabIndex = 5;
            this.butLoginAnmelden.Text = "Anmelden";
            this.butLoginAnmelden.UseVisualStyleBackColor = true;
            this.butLoginAnmelden.Click += new System.EventHandler(this.butLoginAnmelden_Click);
            // 
            // butLoginReg
            // 
            this.butLoginReg.Location = new System.Drawing.Point(63, 125);
            this.butLoginReg.Name = "butLoginReg";
            this.butLoginReg.Size = new System.Drawing.Size(144, 23);
            this.butLoginReg.TabIndex = 6;
            this.butLoginReg.Text = "Registrieren";
            this.butLoginReg.UseVisualStyleBackColor = true;
            this.butLoginReg.Click += new System.EventHandler(this.butLoginReg_Click);
            // 
            // LoginFehlermeldung
            // 
            this.LoginFehlermeldung.AutoSize = true;
            this.LoginFehlermeldung.ForeColor = System.Drawing.Color.Red;
            this.LoginFehlermeldung.Location = new System.Drawing.Point(60, -1);
            this.LoginFehlermeldung.Name = "LoginFehlermeldung";
            this.LoginFehlermeldung.Size = new System.Drawing.Size(178, 13);
            this.LoginFehlermeldung.TabIndex = 7;
            this.LoginFehlermeldung.Text = "Nutzername oder Passwort ist flasch";
            this.LoginFehlermeldung.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 244);
            this.Controls.Add(this.LoginFehlermeldung);
            this.Controls.Add(this.butLoginReg);
            this.Controls.Add(this.butLoginAnmelden);
            this.Controls.Add(this.butLoginPasAnzeigen);
            this.Controls.Add(this.tBoxLoginPas);
            this.Controls.Add(this.tBoxLoginEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxLoginEmail;
        private System.Windows.Forms.TextBox tBoxLoginPas;
        private System.Windows.Forms.Button butLoginPasAnzeigen;
        private System.Windows.Forms.Button butLoginAnmelden;
        private System.Windows.Forms.Button butLoginReg;
        private System.Windows.Forms.Label LoginFehlermeldung;
    }
}