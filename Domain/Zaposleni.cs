using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Zaposleni:OpstiDomenskiObjekat
    {
        public int IDZaposlenog { get; set; }
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }
        public string ImePrezime { get; set; }
        public string BrojTelefona { get; set; }
        public string Adresa { get; set; }
        [Browsable(false)]
        public string ImeTabele =>"Zaposleni";
        [Browsable(false)]
        public string Vrednosti => "";
        [Browsable(false)]
        public string ImeKoloneID => "";
        [Browsable(false)]
        public string JoinUslov => "";
        [Browsable(false)]
        public string JoinTabela => "";
        [Browsable(false)]
        public string AlijasTabele => "";
        [Browsable(false)]
        public string KolonaZaUslov => "";
        [Browsable(false)]
        public string JoinUslov1 => "";
        [Browsable(false)]
        public string JoinTabela1 => "";
        [Browsable(false)]
        public string SveKoloneTabeleUslov =>"";
        [Browsable(false)]
        public string Azuriranje => "";
        [Browsable(false)]
        public string KonkretanUslov => "";
        [Browsable(false)]
        public string ViseUslova => $"KorisnickoIme='{KorisnickoIme}' and Sifra='{Sifra}'";


        [Browsable(false)]
        public int USLOVINT;
        [Browsable(false)]
        public int UslovInt => USLOVINT;

        public override string ToString()
        {
            return ImePrezime;
        }

        public List<OpstiDomenskiObjekat> VratiStaTreba(SqlDataReader citac)
        {
            List<OpstiDomenskiObjekat> rezultat = new List<OpstiDomenskiObjekat>();
            while (citac.Read())
            {
                rezultat.Add(new Zaposleni {
                    IDZaposlenog = citac.GetInt32(0),
                KorisnickoIme = citac.GetString(1),
                Sifra = citac.GetString(2),
               ImePrezime = citac.GetString(3),
                BrojTelefona = citac.GetString(4),
                Adresa = citac.GetString(5)
               }
            );
          }
            return rezultat;

        }
    }
}
