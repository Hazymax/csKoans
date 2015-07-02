using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public class TypeReference
    {

        public int Valeur { get; set; }

        public TypeReference(int i)
        {
            this.Valeur = i;
        }

        public override bool Equals(object obj)
        {
            if (obj == null){return false;}
            TypeReference tr = (TypeReference) obj;
            return tr.Valeur.Equals(Valeur);

        }
    }
}
