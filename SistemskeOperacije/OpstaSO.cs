using Domain;
using Storage;
using Storage.SQLServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public abstract class OpstaSO //abstraktna klasa ne moze da se instancira
    {
        protected InterfejsGenerickiRepozitorijum repozitorijum;
        protected abstract void IzvrsiOperaciju(Object obj);
        
        public object Rezultat { get; protected set; }
        //implementacija repository paterna
        public OpstaSO()
        {
            repozitorijum = new GenerickiRepozitorijum();

        }
        public void ExecuteTemplate(Object obj)
        {
            try
            {
                repozitorijum.OtvoriKonekciju();
                repozitorijum.ZapocniTransakciju();
                IzvrsiOperaciju(obj);
                repozitorijum.Commit();

            }
            catch (Exception)
            {
                repozitorijum.Rollback();
                throw;
            }
            finally
            {
                repozitorijum.ZatvoriKonekciju();
            }
        }

        
    }
}
