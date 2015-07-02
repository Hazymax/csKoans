using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.BasesCSharp
{
    public class Calculatrice
    {

        public IOperation[] Ioperation { get; set; }

        public Calculatrice(IOperation[] iop)
        {
            Ioperation = iop;
        }

        public int Calculer(String str)
        {
            if (Ioperation == null) { return 0; }

            int result = 0;

            foreach (var ope in Ioperation)
            {
                if ((ope.PeutCalculer(str)) == true)
                {
                    result = ope.Calculer(str);
                }
            }

            return result;
        }

    }
}
