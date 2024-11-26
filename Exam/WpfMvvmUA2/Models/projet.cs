using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMvvmUA2.Models; 

namespace WpfMvvmUA2.Models
{
    public class Projet
    {
        public Projet () { }
        public string Nom { get; set; }
        public int Avancement { get; set; }
        public string Titre { get; internal set; }
    }
}
