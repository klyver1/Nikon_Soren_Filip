using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepoMZ
{
    public class Mail
    {
        public string Navn { get; set; }
        public string Email { get; set; }
        public string SMTP { get; set; }
        public string Bruger { get; set; }
        public string Password { get; set; }
        public string Emne { get; set; }
        public string Modtager { get; set; }
    }
}
