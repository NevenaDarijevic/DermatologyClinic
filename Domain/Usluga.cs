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
   public  class Usluga:OpstiDomenskiObjekat
    {
        int uslugaID;
        string NazivUsluge;
        string OpisUsluge;
        int CenaUsluge;
        TipUsluge tip;
        [DisplayName("Naziv usluge")]
        public string NazivUsluge1 { get => NazivUsluge; set => NazivUsluge = value; }
        [DisplayName("Opis usluge")]
        public string OpisUsluge1 { get => OpisUsluge; set => OpisUsluge = value; }
        [DisplayName("Cena usluge")]
        public int CenaUsluge1 { get => CenaUsluge; set => CenaUsluge = value; }

        public TipUsluge Tip { get => tip; set => tip = value; }
        [Browsable(false)]
        public int UslugaID { get => uslugaID; set => uslugaID = value; }
        [Browsable(false)]
        public string USLOV;
        [Browsable(false)]
        public string ImeTabele => "Usluga";
        [Browsable(false)]
        public string Vrednosti => $" '{NazivUsluge1}' , '{OpisUsluge1}',{ CenaUsluge1 },{Tip.IDTipaUsluge1} ";
        [Browsable(false)]
        public string ImeKoloneID => "IDUsluge";
        [Browsable(false)]
        public string JoinUslov => "on (u.IDTipaUsluge=t.IDTipaUsluge)";
        [Browsable(false)]
        public string JoinTabela => "join TipUsluge t";
        [Browsable(false)]
        public string AlijasTabele => "u";
        [Browsable(false)]
        public string KolonaZaUslov => "u.NazivUsluge";
        [Browsable(false)]


        public string SveKoloneTabeleUslov =>$" NazivUsluge = '{NazivUsluge1}' and OpisUsluge = '{OpisUsluge1}' and CenaUsluge = {CenaUsluge1 } ";
        [Browsable(false)]
        public string Azuriranje => "";
        [Browsable(false)]


        string JoinUslov1 => "";
        [Browsable(false)]
        string JoinTabela1 => "";
        [Browsable(false)]
        public string KonkretanUslov => USLOV;
        [Browsable(false)]
        public string ViseUslova => "";
        [Browsable(false)]
        string OpstiDomenskiObjekat.JoinUslov1 => "";
        [Browsable(false)]
        string OpstiDomenskiObjekat.JoinTabela1 => "";


        [Browsable(false)]
        public int USLOVINT;
        [Browsable(false)]
        public int UslovInt => USLOVINT;

        public List<OpstiDomenskiObjekat> VratiStaTreba(SqlDataReader citac)
        {
            List<OpstiDomenskiObjekat> rezultat = new List<OpstiDomenskiObjekat>();
            while (citac.Read())
            {
                rezultat.Add(new Usluga
                {
                  UslugaID = citac.GetInt32(0),
                NazivUsluge1 = citac.GetString(1),
               OpisUsluge1 = citac.GetString(2),
                CenaUsluge1 = citac.GetInt32(3),
                Tip = new TipUsluge()
                    {
                    IDTipaUsluge1 = citac.GetInt32(5),
                    NazivTipaUsluge = citac.GetString(6)

                    }
                } );
            }
            return rezultat;

            }
        }
    }

