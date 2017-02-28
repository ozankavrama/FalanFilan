using IMDBOzan.Entity;
using IMDBOzan.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBOzan.DAL
{
    public class DirectorRepository
    {
        public static List<Director> GetAllDirectors()
        {
            using (IMDBContext db=new IMDBContext())
            {
                return db.Director.ToList();
            }
        }

        public static void DeleteDirector(int id)
        {
            using (IMDBContext db=new IMDBContext())
            {
                db.Director.Remove(db.Director.Find(id));
                db.SaveChanges();
            }
        }

        public static Director GetDirector(int id)
        {
            using (IMDBContext db=new IMDBContext())
            {
                return db.Director.Find(id);
            }
        }

        public static void AddDirector(Director _director)
        {
            using (IMDBContext db = new IMDBContext())
            {
                db.Director.Add(_director);
                db.SaveChanges();
            }
        }

        public static void UpdateDirector(Director _director)
        {
            using (IMDBContext db=new IMDBContext())
            {
                var result = db.Director.Find(_director.DirectorID);
                result.DirectorName = _director.DirectorName;
                db.SaveChanges();
            }
        }
    }
}
