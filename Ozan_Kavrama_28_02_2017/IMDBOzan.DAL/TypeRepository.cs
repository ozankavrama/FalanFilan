using IMDBOzan.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMDBOzan.Entity.Model;

namespace IMDBOzan.DAL
{
    public class TypeRepository
    {
        public static List<Entity.Model.Type> GetAllTypes()
        {
            using (IMDBContext db=new IMDBContext())
            {
                return db.Type.ToList();
            }
        }

        public static void AddType(Entity.Model.Type _type)
        {
            using (IMDBContext db=new IMDBContext())
            {
                db.Type.Add(_type);
                db.SaveChanges();
            }
        }
    }
}
