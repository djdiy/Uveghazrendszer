using System;
using System.Collections.Generic;
using System.Text;

namespace Uveghazrendszer
{
    internal class Adattar
    {
        List<Kezelo> kezelok;
        List<NovenyFaj> novenyek;
        UveghazRacs uveghaz;


        public Adattar()
        {
            kezelok = new List<Kezelo>() { new Kezelo("Gipsz Jakap", "GJ", Szerepkor.KERTESZ), 
                                           new Kezelo("Aranka néni", "Ari", Szerepkor.ADMIN)};
            novenyek = new List<NovenyFaj>();
            this.uveghaz = new UveghazRacs(4);
            uveghaz.Parcellazas();
        }
        internal UveghazRacs Uveghaz { get => uveghaz; set => uveghaz = value; }

        public void UjNoveny(NovenyFaj noveny)
        {
            novenyek.Add(noveny);
        }

        public void NovenyekListazasa()
        {
            foreach(var item in novenyek)
            {
                Console.WriteLine(item);
            }
        }

        public void Ultetes()
        {
            uveghaz.Ultetes(novenyek);
        }
    }
}
