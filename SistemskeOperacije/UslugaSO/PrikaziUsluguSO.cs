using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.UslugaSO
{
    public class PrikaziUsluguSO : OpstaSO
    {
        protected override void IzvrsiOperaciju(object obj)
        {
            Rezultat = repozitorijum.PrikaziObjekat((OpstiDomenskiObjekat)obj);
        }
    }
}
