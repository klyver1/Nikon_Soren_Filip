﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepoNikon
{
    public class Produkt
    {
        public int ID { get; set; }
        public string Navn { get; set; }
        public string Tekst { get; set; }
        public string Billede { get; set; }
        public int KatID { get; set; }
        public decimal Pris { get; set; }
    }
}
