using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepoNikon.Models.BaseModels;
using RepoNikon.Models.ViewModeles;


namespace RepoNikon
{
    public class KategoriFac:AutoFac<Katgori>
    {
        public ForsideKategorier GetForsideKats(Forside f)
        {
            ForsideKategorier fk = new ForsideKategorier();
            KategoriFac kf = new KategoriFac();
            fk.kat1 = kf.Get(f.Kategori1);
            fk.kat2 = kf.Get(f.Kategori2);
            fk.kat3 = kf.Get(f.Kategori3);
            fk.kat4 = kf.Get(f.Kategori4);
            return fk;
        }
    }
}
