using System;

namespace FinalTest.Pattern
{
    public class BalanceNégativeDétectée : IEvenementMetier
    {

        public Montant Montant { get; set; }

        public DateTime DateRetrait { get; set; }

        public string NuméroDeCompte { get; set; }

        public BalanceNégativeDétectée(string numéroDeCompte, Montant montant, DateTime dateRetrait)
        {
            this.NuméroDeCompte = numéroDeCompte;
            this.Montant = montant;
            this.DateRetrait = dateRetrait;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            BalanceNégativeDétectée balance = (BalanceNégativeDétectée)obj;
            return balance.Montant.Equals(this.Montant) &&
                   balance.NuméroDeCompte.Equals(this.NuméroDeCompte) &&
                   balance.DateRetrait.Equals(this.DateRetrait);
        }

        public override string ToString()
        {
            return string.Format("Montant: {0}, DateRetrait: {1}, NuméroDeCompte: {2}", Montant, DateRetrait, NuméroDeCompte);
        }
    }
}