using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.UslugaSO
{
    public class VratiListuTipovaSO : OpstaSO
    {
        protected override void IzvrsiOperaciju(object obj)
        {
            Rezultat = repozitorijum.VratiSve(new TipUsluge()).Cast<TipUsluge>().ToList();
        }
    }
}
