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
   public  class Termin :OpstiDomenskiObjekat
    {
        int idTermina;
        DateTime DatumZakazivanja;
        DateTime DatumTermina;
        Zaposleni zaposleni;
        Korisnik korisnik;

        [Browsable(false)]
        public int IdTermina { get => idTermina; set => idTermina = value; }
        [DisplayName("Datum zakazivanja")]
        public DateTime DatumZakazivanja1 { get => DatumZakazivanja; set => DatumZakazivanja = value; }
        [DisplayName("Datum termina")]
        public DateTime DatumTermina1 { get => DatumTermina; set => DatumTermina = value; }
        public Zaposleni Zaposleni { get => zaposleni; set => zaposleni = value; }
        public Korisnik Korisnik { get => korisnik; set => korisnik = value; }
        [Browsable(false)]
        public string USLOV;
        [Browsable(false)]
        public string ImeTabele => "Termin";
        [Browsable(false)]
        public string Vrednosti => $"'{DatumZakazivanja.ToShortDateString()}','{DatumTermina.ToShortDateString()}',{zaposleni.IDZaposlenog},{korisnik.IDKorisnika}";
        [Browsable(false)]
        public string ImeKoloneID =>"IDTermina";
        [Browsable(false)]
        public string JoinUslov => "on(z.IDZaposlenog=t.IDZaposlenog)";
        [Browsable(false)]
        public string JoinTabela => "join Zaposleni z";
        [Browsable(false)]
        public string AlijasTabele => "t";
        [Browsable(false)]
        public string KolonaZaUslov => "k.ImePrezime";
        [Browsable(false)]
        public string JoinUslov1 => "on(t.IDKorisnika=k.IDKorisnika)";
        [Browsable(false)]
        public string JoinTabela1 =>"join Korisnik k";
        [Browsable(false)]
        public string SveKoloneTabeleUslov => $"t.DatumZakazivanja = '{DatumZakazivanja1.ToString("yyyyMMdd HH:mm")}'" +
                $"and t.DatumTermina='{DatumTermina1.ToString("yyyyMMdd HH:mm")}'" +
                $"and z.IDZaposlenog={Zaposleni.IDZaposlenog} and k.IDKorisnika={Korisnik.IDKorisnika}";
        [Browsable(false)]
        public string Azuriranje => "";
        [Browsable(false)]
        public string KonkretanUslov => USLOV;
        [Browsable(false)]
        public string ViseUslova => "";

        [Browsable(false)]
        public int USLOVINT;
        [Browsable(false)]
        public int UslovInt => USLOVINT;

        public List<OpstiDomenskiObjekat> VratiStaTreba(SqlDataReader citac)
        {
            List<OpstiDomenskiObjekat> rezultat = new List<OpstiDomenskiObjekat>();
            while (citac.Read())
            {
                rezultat.Add(new Termin
                { 
                    IdTermina = citac.GetInt32(0),
                DatumZakazivanja1 = (DateTime)citac.GetDateTime(1),
                DatumTermina1 = (DateTime)citac.GetDateTime(2),

               Zaposleni = new Zaposleni()
                {
                    IDZaposlenog = citac.GetInt32(5),
                    KorisnickoIme = citac.GetString(6),

                    Sifra = citac.GetString(7),
                    ImePrezime = citac.GetString(8),
                    BrojTelefona = citac.GetString(9),
                    Adresa = citac.GetString(10)
                },

                Korisnik = new Korisnik()
                {
                    IDKorisnika = citac.GetInt32(11),
                    ImePrezime = citac.GetString(12),
                    BrojTelefona = citac.GetString(13),
                    Adresa = citac.GetString(14)
                }

            });
            }
            return rezultat;
        }
    }
}
