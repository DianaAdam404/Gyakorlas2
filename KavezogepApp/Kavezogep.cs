using System;
using System.Collections.Generic;
using System.Text;

namespace KavezogepApp
{
    internal class Kavezogep
    {
        private int vizKeszletMl;
        public void VizTolt(int ml)
        {
            if (ml < 0)
            {
                vizKeszletMl = 0;
                Console.WriteLine("Hiba! Negativ ertek!");
            }
            else vizKeszletMl += ml;
        }
        public void KaveFozes()
        {
            if (vizKeszletMl >= 150)
            {
                vizKeszletMl -= 150;
                Console.WriteLine("Kave");

            }
            else
            {
                Console.WriteLine("No kave");
            }
        }
    }
}
