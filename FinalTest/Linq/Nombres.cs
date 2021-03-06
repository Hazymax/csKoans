﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Linq
{
    public class Nombres
    {
        public List<KeyValuePair<string, int>> liste { get; set; }

        public IEnumerable<int> NombresPairs
        {
            get
            {
                return (from element in liste
                        where element.Value % 2 == 0
                        select element.Value);
            }
        }

        public String TexteNombresImpairs
        {
            get
            {
                return (from element in liste
                        where element.Value % 2 != 0
                        orderby element.Value
                        select element.Key).Aggregate((s, next) => s + ", " + next);
            }
        }

        public string PremierNombreDontLeTexteContientPlusDe5Caractères
        {
            get
            {
                return (from element in liste
                        where element.Key.Length > 5
                        select element.Key).FirstOrDefault();
            }
        }

        public IEnumerable<int> QuatreNombresSupérieursSuivant3
        {
            get
            {
                return (from element in liste
                        where element.Value > 3
                        orderby element.Value
                        select element.Value).Take(4);
            }
        }

        public Nombres(IEnumerable<KeyValuePair<string, int>> listeKvp)
        {
            liste = listeKvp.ToList();
        }
    }
}
