using System;

namespace FinalTest.Pattern
{
    public class Synth�seCompteBancaire
    {
        public Synth�seCompteBancaire(string num�roDeCompte, int debits, int credits)
        {
            this.Num�roDeCompte = num�roDeCompte;
            this.Debits = debits;
            this.Credits = credits;
        }

        public Synth�seCompteBancaire(){}

        public int Credits { get; set; }

        public int Debits { get; set; }

        public string Num�roDeCompte { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Synth�seCompteBancaire synth�se = (Synth�seCompteBancaire)obj;
            return this.Num�roDeCompte.Equals(synth�se.Num�roDeCompte) &&
                   this.Debits.Equals(synth�se.Debits) &&
                   this.Credits.Equals(synth�se.Credits);
        }
    }
}