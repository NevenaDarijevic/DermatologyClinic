using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.ZaposleniSO
{
    public class PronadjiZaposlenogSO : OpstaSO
    {
        protected override void IzvrsiOperaciju(object obj)
        {
            List<OpstiDomenskiObjekat> lista = repozitorijum.VratiSaViseUslova((OpstiDomenskiObjekat)obj);
            if (lista.Count == 0)
            {
                Rezultat= null;
            }
            else
            {
                Rezultat = (Zaposleni)lista[0];
            }

        }
    }
}
