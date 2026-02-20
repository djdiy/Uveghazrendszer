using System;
using System.Collections.Generic;
using System.Text;

namespace Uveghazrendszer
{
    internal class NovenyFaj
    {
        string nev;
        int nedvessegtartalom; //idealis = 100
        int egeszsegszint; // max = 100
        int optimalisSuruseg;


        public NovenyFaj(string nev, int optimalisSuruseg)
        {
            this.nev = nev;
            this.optimalisSuruseg = optimalisSuruseg;
            this.nedvessegtartalom = 100;
            this.egeszsegszint = 100;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Nedvessegtartalom { get => nedvessegtartalom; set => nedvessegtartalom = value; }
        public int Egeszsegszint { get => egeszsegszint; set => egeszsegszint = value; }
        public int OptimalisSuruseg { get => optimalisSuruseg; set => optimalisSuruseg = value; }

        public string Azonosito
        {
            get
            {
                return this.nev.Substring(0, 3);
            }
        }


        public override string ToString()
        {
            return $"{this.nev} nedvesseg: {this.nedvessegtartalom} egeszseg: {this.egeszsegszint} egyedszam: {this.optimalisSuruseg}";
        }
    }
}
