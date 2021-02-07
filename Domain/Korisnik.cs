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
    public class Korisnik:OpstiDomenskiObjekat
    {
        [Browsable(false)]
       public int IDKorisnika { get; set; }
       public string ImePrezime { get; set; }
        [Browsable(false)]
        public string BrojTelefona { get; set; }
        [Browsable(false)]
        public string Adresa { get; set; }
        [Browsable(false)]
        public string USLOV;
        [Browsable(false)]
        public int USLOVINT;
        [Browsable(false)]
        public string ImeTabele=>"Korisnik";
        [Browsable(false)]
        public string Vrednosti =>$"'{ImePrezime}','{BrojTelefona}','{Adresa}'";
        [Browsable(false)]
        public string ImeKoloneID => "IDKorisnika";
        [Browsable(false)]
        public string JoinUslov => "";
        [Browsable(false)]
        public string JoinTabela => "";
        [Browsable(false)]
        public string AlijasTabele =>"k";
        [Browsable(false)]
        public string KolonaZaUslov => "ImePrezime";
        [Browsable(false)]
        public string JoinUslov1 => "";
        [Browsable(false)]
        public string JoinTabela1 => "";
        [Browsable(false)]
        public string SveKoloneTabeleUslov => $"ImePrezime = '{ImePrezime}' and BrojTelefona = '{BrojTelefona}' and Adresa = '{Adresa}'";
        [Browsable(false)]
        public string Azuriranje => $"ImePrezime='{ImePrezime}',BrojTelefona='{BrojTelefona}',Adresa='{Adresa}'";
        [Browsable(false)]
        public string KonkretanUslov =>USLOV;
        [Browsable(false)]
        public string ViseUslova => "";
        [Browsable(false)]
        public int UslovInt =>USLOVINT;

        public override string ToString()
        {
            return ImePrezime;
        }

        public List<OpstiDomenskiObjekat> VratiStaTreba(SqlDataReader citac)
        {
            List<OpstiDomenskiObjekat> rezultat = new List<OpstiDomenskiObjekat>();
            while (citac.Read())
            {
                rezultat.Add(new Korisnik
                {
                    IDKorisnika = citac.GetInt32(0),
                    ImePrezime = citac.GetString(1),
                    BrojTelefona=citac.GetString(2),
                    Adresa=citac.GetString(3)
                });
            }
            return rezultat;
        }
    }
}
