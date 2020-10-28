using System;
using System.Collections.Generic;
using System.Text;

namespace Airplane
{
    public class Foodcart
    {

        public int NumberOfArticles { get; set; }
        public Article[] Inventory { get; set; }

        public Foodcart(int numberOfArticles)
        {
            NumberOfArticles = numberOfArticles;
            Inventory = new Article[NumberOfArticles];
        }
        void AddToInventory(Article article)
        {

        }

        void ShowMenu()
        {

        }
    }
}
