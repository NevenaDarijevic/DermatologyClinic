using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.TerminSO
{
    public class VratiListuKorisnikaSO : OpstaSO
    {
        protected override void IzvrsiOperaciju(object obj)
        {
            Rezultat = repozitorijum.VratiSve(new Korisnik()).Cast<Korisnik>().ToList();
        }
    }
}
