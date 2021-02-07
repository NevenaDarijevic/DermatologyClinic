using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.SQLServer
{
    public class GenerickiRepozitorijum : InterfejsGenerickiRepozitorijum
    {
        private Broker broker = new Broker();

        public void Commit()
        {
            broker.Commit();
        }

        public int IzmeniObjekat(OpstiDomenskiObjekat obj)
        {
            return broker.IzmeniObjekat(obj);
        }

        public int ObrisiObjekat(OpstiDomenskiObjekat obj)
        {
           return broker.ObrisiObjekat(obj);
        }

        public void OtvoriKonekciju()
        {
            broker.otvoriKonekciju();
        }

        public OpstiDomenskiObjekat PrikaziObjekat(OpstiDomenskiObjekat obj)
        {
            return broker.PrikaziObjekat(obj);
        }

        public void Rollback()
        {
            broker.Rollback();
        }

        public int Sacuvaj(OpstiDomenskiObjekat obj)
        {
            return broker.Sacuvaj(obj);
        }

        public List<OpstiDomenskiObjekat> VratiSaUslovom(OpstiDomenskiObjekat obj)
        {
            return broker.VratiSaUslovom(obj);
        }

        public List<OpstiDomenskiObjekat> VratiSaViseUslova(OpstiDomenskiObjekat obj)
        {
            return broker.VratiSaViseUslova(obj);
        }

        public List<OpstiDomenskiObjekat> VratiSve(OpstiDomenskiObjekat obj)
        {
            return broker.VratiSve(obj);
        }

        public void ZapocniTransakciju()
        {
            broker.zapocniTransakciju();
        }

        public void ZatvoriKonekciju()
        {
            broker.zatvoriKonekciju();
        }
    }
}
