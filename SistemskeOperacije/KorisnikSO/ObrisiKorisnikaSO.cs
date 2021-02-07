using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.KorisnikSO
{
    public class ObrisiKorisnikaSO : OpstaSO
    {
        protected override void IzvrsiOperaciju(Object obj)
        {
            Rezultat = repozitorijum.ObrisiObjekat((OpstiDomenskiObjekat)obj);
        }
    }
}
