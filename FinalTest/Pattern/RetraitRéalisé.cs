using System;
using System.Collections;

namespace FinalTest.Pattern
{
    public class RetraitRéalisé : IEvenementMetier
    {
        public DateTime DateRetrait { get; set; }

        public Montant MontantRetrait { get; set; }

        public string NuméroDeCompte { get; set; }

        public RetraitRéalisé(string numéroDeCompte, Montant montantRetrait, DateTime dateRetrait)
        {
            this.NuméroDeCompte = numéroDeCompte;
            this.MontantRetrait = montantRetrait;
            this.DateRetrait = dateRetrait;
        }

        public override string ToString()
        {
            return string.Format("DateRetrait: {0}, MontantRetrait: {1}, NuméroDeCompte: {2}", DateRetrait, MontantRetrait, NuméroDeCompte);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            RetraitRéalisé retraitRéalisé = (RetraitRéalisé)obj;
            return MontantRetrait.Equals(retraitRéalisé.MontantRetrait) &&
                   DateRetrait.Equals(retraitRéalisé.DateRetrait) &&
                   NuméroDeCompte.Equals(retraitRéalisé.NuméroDeCompte);
        }
    }
}