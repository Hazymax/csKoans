using System;

namespace FinalTest.Pattern
{
    public class Montant
    {
        public int Valeur { get; set; }

        public override string ToString()
        {
            return string.Format("Valeur: {0}", Valeur);
        }

        public Montant(int i)
        {
            this.Valeur = i;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Montant montant = (Montant) obj;
            return montant.Valeur.Equals(this.Valeur);
        }
    }
}