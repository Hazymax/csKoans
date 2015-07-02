using System;
using System.Collections;

namespace FinalTest.Pattern
{
    public class CompteCréé : IEvenementMetier
    {

        public string NuméroDeCompte { get; set; }

        public int AutorisationDeCrédit { get; set; }

        public CompteCréé(string numéroDeCompte, int autorisationDeCrédit)
        {
            this.NuméroDeCompte = numéroDeCompte;
            this.AutorisationDeCrédit = autorisationDeCrédit;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            CompteCréé compteCréé = (CompteCréé)obj;
            return compteCréé.NuméroDeCompte.Equals(this.NuméroDeCompte) &&
                   compteCréé.AutorisationDeCrédit.Equals(this.AutorisationDeCrédit);
        }
    }
}