using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBOzan.Entity.Model.ViewModel
{
    public class VMFilm
    {
        public int FilmID { get; set; }
        public string FilmName { get; set; }
        public string DirectorName { get; set; }
        public string TypeName { get; set; }
        public double Point { get; set; }
    }
}
