using System;
using System.Collections.Generic;
using System.Text;

namespace Airplane
{
    class Food : Article
    {
        public string Type { get; set; }
        public bool IsChildFood { get; set; }
        public Food(string name, string type, bool childfood) : base(name)
        {
            Type = type;
            IsChildFood = childfood;
        }
    }
}
