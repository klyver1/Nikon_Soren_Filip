using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepoNikon;

namespace RepoNikon.Models.ViewModeles
{
   public class ProduktList
    {
        public Kategori Kategori { get; set; }
        public List<Produkt> Produkter { get; set; } 
    }
}
