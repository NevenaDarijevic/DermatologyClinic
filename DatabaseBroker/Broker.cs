using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace DatabaseBroker
{
    public class Broker
    {
        SqlConnection konekcija;
        SqlCommand komanda;
        SqlTransaction transakcija;

        public Broker()
        {
       
          konekcija = new SqlConnection(ConfigurationManager.ConnectionStrings["BAZA"].ConnectionString);
            komanda = konekcija.CreateCommand();
        }

        public void otvoriKonekciju()
        {
            konekcija.Open();

        }
        public void zatvoriKonekciju()
        {
            konekcija.Close();

        }
        public void zapocniTransakciju()
        {
            transakcija = konekcija.BeginTransaction();
        }
        public void Commit()
        {
            transakcija?.Commit();
        }
        public void Rollback()
        {
            transakcija?.Rollback();
        }
        //ZA CUVANJE  KORISNIKA, USLUGE I TERMINA
        public int Sacuvaj(OpstiDomenskiObjekat obj)
        {
            
            string upitProvera = $"select count(*) from {obj.ImeTabele} {obj.AlijasTabele} {obj.JoinTabela} {obj.JoinUslov} {obj.JoinTabela1} {obj.JoinUslov1} where {obj.SveKoloneTabeleUslov}";
            SqlCommand komandaProvera = new SqlCommand(upitProvera,konekcija,transakcija);
            int rez = (int)komandaProvera.ExecuteScalar();
            if (rez != 0)
            {
                throw new Exception("Vec postoji u bazi neki od unetih objekata. Pokusaj ponovo!");
            }
         
           string upit = $"insert into {obj.ImeTabele} values({obj.Vrednosti})";
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                throw new Exception("Greska u radu sa bazom!");
            }
        }
        //ZA VRACANJE SVIH KORISNIKA,SVIH ZAPOSLENIH I SVIH TIPOVA
        public List<OpstiDomenskiObjekat> VratiSve(OpstiDomenskiObjekat obj)                                                       
        {
            List<OpstiDomenskiObjekat> lista;

           string upit = $"select * from {obj.ImeTabele} {obj.AlijasTabele} {obj.JoinTabela} {obj.JoinUslov} {obj.JoinTabela1} {obj.JoinUslov1}";
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            SqlDataReader citac = komanda.ExecuteReader();

           
            lista = obj.VratiStaTreba(citac);
            citac.Close();
            return lista;

        }
        //ZA VRACANJE KORISNIKA NA OSNOVU IMENA, USLUGE NA OSNOVU NAZIVA, TERMINA NA OSNOVU IMENA KORISNIKA
        public List<OpstiDomenskiObjekat> VratiSaUslovom(OpstiDomenskiObjekat obj)
        {
            List<OpstiDomenskiObjekat> lista;

            string upit = $"select * from {obj.ImeTabele} {obj.AlijasTabele} {obj.JoinTabela} {obj.JoinUslov} {obj.JoinTabela1} {obj.JoinUslov1} where {obj.KolonaZaUslov}='{obj.KonkretanUslov}'";
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            SqlDataReader citac = komanda.ExecuteReader();


            lista = obj.VratiStaTreba(citac);
            citac.Close();
            return lista;

        }
        //za logovanje zaposlenog
        public List<OpstiDomenskiObjekat> VratiSaViseUslova(OpstiDomenskiObjekat obj)
        {
            List<OpstiDomenskiObjekat> lista;

            string upit = $"select * from {obj.ImeTabele} {obj.AlijasTabele} {obj.JoinTabela} {obj.JoinUslov} {obj.JoinTabela1} {obj.JoinUslov1} where {obj.ViseUslova}";
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            SqlDataReader citac = komanda.ExecuteReader();


            lista = obj.VratiStaTreba(citac);
            citac.Close();
            return lista;

        }
        //ZA BRISANJE KORISNIKA, ZA BRISANJE USLUGE
        public int ObrisiObjekat(OpstiDomenskiObjekat obj) 
        {
            string upit = "DELETE  FROM " + obj.ImeTabele + " WHERE " + obj.SveKoloneTabeleUslov;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

       //PRIKAZI KORISNIKA, PRIKAZI USLUGU, PRIKAZI TERMIN
        public OpstiDomenskiObjekat PrikaziObjekat(OpstiDomenskiObjekat obj)
        {
            List<OpstiDomenskiObjekat> lista;

           string upit = $"select * from {obj.ImeTabele} {obj.AlijasTabele} {obj.JoinTabela} {obj.JoinUslov} {obj.JoinTabela1} {obj.JoinUslov1} where {obj.SveKoloneTabeleUslov}";
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            SqlDataReader citac = komanda.ExecuteReader();


            lista = obj.VratiStaTreba(citac);
            citac.Close();
            return lista[0];
        }
        //ZA IZMENU KORISNIKA na osnovu id-a onog koji je izabrao
        public int IzmeniObjekat(OpstiDomenskiObjekat obj)
        {
            

            string upit = "UPDATE " + obj.ImeTabele + " SET " + obj.Azuriranje + " WHERE " + obj.ImeKoloneID+"="+obj.UslovInt;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }
       
    }
}


