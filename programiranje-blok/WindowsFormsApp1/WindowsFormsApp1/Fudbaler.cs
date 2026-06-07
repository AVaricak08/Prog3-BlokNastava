using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Fudbaler
    {
        public string Ime { get; set; }
        public string Prezime {  get; set; }
        public string Pol {  get; set; }
        public int Godine {  get; set; }
        public string DeoTerena {  get; set; }
        public string Pozicija {  get; set; }

        public Fudbaler(string ime, string prezime, string pol, int godine, string deoterena, string pozicija) 
        { 
            Ime= ime;
            Prezime= prezime;
            Pol= pol;
            Godine= godine;
            DeoTerena= deoterena;
            Pozicija= pozicija;
        }
    }
}
