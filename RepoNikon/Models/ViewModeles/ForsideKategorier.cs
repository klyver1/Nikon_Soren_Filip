using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepoNikon.Models.BaseModels;

namespace RepoNikon.Models.ViewModeles
{
    public class ForsideKategorier
    {
        public Katgori kat1 { get; set; }
        public Katgori kat2 { get; set; }
        public Katgori kat3 { get; set; }
        public Katgori kat4 { get; set; }
        public List<Slider> Slider { get; set; }
    }
}
