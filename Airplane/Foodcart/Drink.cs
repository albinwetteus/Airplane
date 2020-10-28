using System;
using System.Collections.Generic;
using System.Text;

namespace Airplane
{
    class Drink: Article
    {
        public bool ContainsAlcohol { get; set; }

        public Drink(string name, bool containsAlcohol) : base(name)
        {
            ContainsAlcohol = containsAlcohol;
        }
    }
}
