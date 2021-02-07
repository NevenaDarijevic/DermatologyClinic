using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
   public interface InterfejsGenerickiRepozitorijum
    {
        int Sacuvaj(OpstiDomenskiObjekat obj);
        List<OpstiDomenskiObjekat> VratiSve(OpstiDomenskiObjekat obj);
        void OtvoriKonekciju();
        void ZatvoriKonekciju();
       
        void ZapocniTransakciju();
        void Commit();
        void Rollback();
        List<OpstiDomenskiObjekat> VratiSaUslovom(OpstiDomenskiObjekat obj);
        int ObrisiObjekat(OpstiDomenskiObjekat obj);
        OpstiDomenskiObjekat PrikaziObjekat(OpstiDomenskiObjekat obj);
        int IzmeniObjekat(OpstiDomenskiObjekat obj);
        List<OpstiDomenskiObjekat> VratiSaViseUslova(OpstiDomenskiObjekat obj);
    }
}
