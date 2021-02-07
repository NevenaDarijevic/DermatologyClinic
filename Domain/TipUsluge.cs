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
    public class TipUsluge:OpstiDomenskiObjekat
    {
        int IDTipaUsluge;
        string nazivTipaUsluge;

        public int IDTipaUsluge1 { get => IDTipaUsluge; set => IDTipaUsluge = value; }
        public string NazivTipaUsluge { get => nazivTipaUsluge; set => nazivTipaUsluge = value; }
        [Browsable(false)]
        public string ImeTabele => "TipUsluge";
        [Browsable(false)]
        public string Vrednosti => $"{IDTipaUsluge1},'{NazivTipaUsluge}'";
        [Browsable(false)]
        public string ImeKoloneID => "IDTipaUsluge";
        [Browsable(false)]
        public string JoinUslov => "";
        [Browsable(false)]
        public string JoinTabela => "";
        [Browsable(false)]
        public string AlijasTabele =>"";
        [Browsable(false)]
        public string KolonaZaUslov => "";
        [Browsable(false)]
        public string JoinUslov1 => "";
        [Browsable(false)]
        public string JoinTabela1 => "";
        [Browsable(false)]
        public string SveKoloneTabeleUslov => "";
        [Browsable(false)]
        public string Azuriranje => "";
        [Browsable(false)]
        public string KonkretanUslov => "";
        [Browsable(false)]
        public string ViseUslova => "";

        [Browsable(false)]
        public int USLOVINT;
        [Browsable(false)]
        public int UslovInt => USLOVINT;
        public override string ToString()
        {
            return NazivTipaUsluge;
        }
        public List<OpstiDomenskiObjekat> VratiStaTreba(SqlDataReader citac)
        {
            List<OpstiDomenskiObjekat> rezultat = new List<OpstiDomenskiObjekat>();
            while (citac.Read())
            {
                rezultat.Add(new TipUsluge
                {
                IDTipaUsluge1 = citac.GetInt32(0),
                NazivTipaUsluge = citac.GetString(1)
                
            });
            }
            return rezultat;
        }

       
    }
}
