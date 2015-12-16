using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepoNikon.Factroy;
using RepoNikon.Models.BaseModels;
using RepoNikon.Models.ViewModeles;


namespace RepoNikon
{
    public class KategoriFac:AutoFac<Katgori>
    {
        public ForsideKategorier GetForsideKats(Forside f)
        {
            SliderFac sf = new SliderFac();
            ForsideKategorier fk = new ForsideKategorier();
            
            fk.kat1 = Get(f.Kategori1);
            fk.kat2 = Get(f.Kategori2);
            fk.kat3 = Get(f.Kategori3);
            fk.kat4 = Get(f.Kategori4);
            fk.Slider = sf.GetAll();
            return fk;
        }
    }
}
