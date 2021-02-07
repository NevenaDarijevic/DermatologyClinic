using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.TerminSO
{
    public class SacuvajTerminSO : OpstaSO
    {
        protected override void IzvrsiOperaciju(object obj)
        {

            List<Termin> termini = (List<Termin>)obj;
            foreach (Termin t in termini)
            {
                repozitorijum.Sacuvaj((OpstiDomenskiObjekat)t);
            }
        }
    }
}
