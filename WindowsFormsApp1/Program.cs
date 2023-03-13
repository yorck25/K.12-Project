using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Rolle(new cRolle()));
            //Application.Run(new Liefermenge());
            //Application.Run(new Bestellung(new cBestellung()));
            //Application.Run(new Artikel(new cArtikel()));
            //Application.Run(new Abteilung(new cAbteilung()));
            //Application.Run(new Login(new cLogin()));
            //Application.Run(new Hauptmenu());
            //Application.Run(new Mitarbeiterverwaltung(new cMitarbeiter()));
            //Application.Run(new Funktion(new cFunktion()));
            Application.Run(new BestellMenge(new cBestellMenge()));
        }
    }
}
