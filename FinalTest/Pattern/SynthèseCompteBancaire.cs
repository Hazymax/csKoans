using System;

namespace FinalTest.Pattern
{
    public class SynthèseCompteBancaire
    {
        public SynthèseCompteBancaire(string numéroDeCompte, int debits, int credits)
        {
            this.NuméroDeCompte = numéroDeCompte;
            this.Debits = debits;
            this.Credits = credits;
        }

        public SynthèseCompteBancaire(){}

        public int Credits { get; set; }

        public int Debits { get; set; }

        public string NuméroDeCompte { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            SynthèseCompteBancaire synthèse = (SynthèseCompteBancaire)obj;
            return this.NuméroDeCompte.Equals(synthèse.NuméroDeCompte) &&
                   this.Debits.Equals(synthèse.Debits) &&
                   this.Credits.Equals(synthèse.Credits);
        }
    }
}