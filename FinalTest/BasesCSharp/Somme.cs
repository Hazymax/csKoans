using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalTest.BasesCSharp;

namespace FinalTest
{
    public class Somme : IOperation
    {
        public bool PeutCalculer(string str)
        {
            if (str.Contains("+") == true)
            {
                var chaineCut = str.Split('+');
                if (chaineCut.Length == 2) { return true; }
            }

            return false;
        }

        public int Calculer(string str)
        {
            if (PeutCalculer(str) == true)
            {
                var chaineCut = str.Split('+');
                int nb1;
                int nb2;
                int.TryParse(chaineCut[0], out nb1);
                int.TryParse(chaineCut[1], out nb2);
                return nb1 + nb2;
            }

            return 0;
        }
    }
}
