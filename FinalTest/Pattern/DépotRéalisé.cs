using System;
using System.Collections;

namespace FinalTest.Pattern
{
    public class DépotRéalisé : IEvenementMetier
    {

        public string NuméroDeCompte { get; set; }

        public Montant MontantDepot { get; set; }

        public DateTime DateDepot { get; set; }

        public DépotRéalisé(string numéroDeCompte, Montant montantDepot, DateTime dateDepot)
        {
            this.NuméroDeCompte = numéroDeCompte;
            this.MontantDepot = montantDepot;
            this.DateDepot = dateDepot;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            DépotRéalisé dépotRéalisé = (DépotRéalisé)obj;
            return NuméroDeCompte.Equals(dépotRéalisé.NuméroDeCompte) &&
                   MontantDepot.Equals(dépotRéalisé.MontantDepot) &&
                   DateDepot.Equals(dépotRéalisé.DateDepot);
        }
    }
}