using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalTest.Pattern
{
    public class CompteBancaire
    {
        //public CompteCréé CompteCréé { get; set; }

        //public DépotRéalisé DepotRealise { get; set; }

        private string NuméroDeCompte { get; set; }

        public Montant Montant { get; set; }

        public CompteBancaire(CompteCréé compteCréé)
        {
            this.NuméroDeCompte = compteCréé.NuméroDeCompte;
        }

        public CompteBancaire(CompteCréé compteCréé, DépotRéalisé dépotRéalisé)
        {
            this.NuméroDeCompte = compteCréé.NuméroDeCompte;
            this.Montant = dépotRéalisé.MontantDepot;
        }

        public static IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
            yield return new CompteCréé(numéroDeCompte, autorisationDeCrédit);
        }

        public IEnumerable<IEvenementMetier> FaireUnDepot(Montant montantDepot, DateTime dateDepot)
        {
            yield return new DépotRéalisé(NuméroDeCompte, montantDepot, dateDepot);
        }

        public IEnumerable<IEvenementMetier> FaireUnRetrait(Montant montantRetrait, DateTime dateRetrait)
        {
            if (Montant.Valeur - montantRetrait.Valeur < 0)
            {
                //yield return new RetraitRéalisé(NuméroDeCompte, montantRetrait, dateRetrait);
                //yield return new BalanceNégativeDétectée(NuméroDeCompte, Montant, dateRetrait);
                throw new RetraitNonAutorisé();
            }
            else
            {
                yield return new RetraitRéalisé(NuméroDeCompte, montantRetrait, dateRetrait);
            }
        }
    }
}