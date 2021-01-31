using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplikacijaZaPrijavuOstecenjaSisMosZup.Models
{
    public class Prijavitelj
    {
        public int Id { get; set; }
        public string ImeVlasnikaTvrtke { get; set; }
        public string PrezimeVlasnikaTvrtke { get; set; }
        public string ImeTvrtke { get; set; }
        public short BrojGodinaPoslovanja { get; set; }
        public double OIBTvrtke { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public int KontaktBroj { get; set; }
        public int BrojRadnika { get; set; }
    }
}
