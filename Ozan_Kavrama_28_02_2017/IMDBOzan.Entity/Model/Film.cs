using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBOzan.Entity.Model
{
    public class Film
    {
        public int FilmID { get; set; }
        public string FilmName { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public double Point { get; set; }
        public int PointCount { get; set; }
        public int TypeID { get; set; }
        public int DirectorID { get; set; }
        public Type Type { get; set; }
        public Director Director { get; set; }
    }
}
