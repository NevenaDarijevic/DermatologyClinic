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
    public class Zakazivanje:OpstiDomenskiObjekat
    {
        Termin termin;
        Usluga usluga;

        public Termin Termin { get => termin; set => termin = value; }
        public Usluga Usluga { get => usluga; set => usluga = value; }
        [Browsable(false)]
        public string ImeTabele => "";
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

        public List<OpstiDomenskiObjekat> VratiStaTreba(SqlDataReader citac)
        {
            throw new NotImplementedException();
        }
    }
}
