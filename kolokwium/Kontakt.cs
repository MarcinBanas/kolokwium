using System;
using System.Collections.Generic;
using System.Text;

namespace kolokwium
{
    class Kontakt
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int NrTelefonu { get; set; }
        public int DataUrodzenia { get; set; }

        Kontakt(string imie,string nazwisko,int nrtelefonu,int dataurodzenia)
        {
            try
            {
                if (char.IsUpper(imie, 1) && char.IsUpper(nazwisko,1))
                {
                    imie = Imie;
                    nazwisko = Nazwisko;
                    nrtelefonu = NrTelefonu;
                    dataurodzenia = DataUrodzenia;
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Bledne dane"); ;
            }
            imie = Imie;
            nazwisko = Nazwisko;
            nrtelefonu = NrTelefonu;
            dataurodzenia = DataUrodzenia;
        }
    }
}
