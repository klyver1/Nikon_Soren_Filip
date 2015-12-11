using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using RepoMZ.Models.ViewModeles;

namespace RepoNikon
{
    public class ProduktFac:AutoFac<Produkt>
    {
      KategoriFac katFac = new KategoriFac();

        public ProduktList GeProduktList(int katID)
        {
            ProduktList pl = new ProduktList();
            pl.Kategori = katFac.Get(katID);
            pl.Produkter = GetBy("KatID", katID);
            return pl;
        }
    }

  
}
