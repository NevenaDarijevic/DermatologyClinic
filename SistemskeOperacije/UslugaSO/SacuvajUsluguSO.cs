using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.UslugaSO
{
    public class SacuvajUsluguSO : OpstaSO
    {
        protected override void IzvrsiOperaciju(object obj)
        {
            List<Usluga> usluge = (List<Usluga>)obj;
            foreach (Usluga u in usluge)
            {
                  repozitorijum.Sacuvaj((OpstiDomenskiObjekat)u);
            }

        }
    }
}
