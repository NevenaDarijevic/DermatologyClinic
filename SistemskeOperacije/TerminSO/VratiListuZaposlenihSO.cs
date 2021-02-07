using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.TerminSO
{
    public class VratiListuZaposlenihSO : OpstaSO
    {
        protected override void IzvrsiOperaciju(object obj)
        {
            Rezultat = repozitorijum.VratiSve((OpstiDomenskiObjekat)obj).Cast<Zaposleni>().ToList();
        }
    }
}
