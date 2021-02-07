using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface OpstiDomenskiObjekat
    {
        string ImeTabele { get;  }
        string Vrednosti { get; }
        string ImeKoloneID { get; }
        string JoinUslov { get;  }
        string JoinTabela { get;  }
        string AlijasTabele { get; }
        string KolonaZaUslov { get; }
        string JoinUslov1 { get; }
        string JoinTabela1 { get; }
        string SveKoloneTabeleUslov { get; }
        string Azuriranje { get; }
        string KonkretanUslov { get; }
        string ViseUslova { get; }
        int UslovInt { get; }

        List<OpstiDomenskiObjekat> VratiStaTreba(SqlDataReader citac);
    }
}
