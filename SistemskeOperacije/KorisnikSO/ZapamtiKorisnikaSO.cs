using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.KorisnikSO
{
    public class ZapamtiKorisnikaSO : OpstaSO
    {
        protected override void IzvrsiOperaciju(object obj)
        {
            Rezultat=repozitorijum.Sacuvaj((OpstiDomenskiObjekat)obj);
        }
    }
}
