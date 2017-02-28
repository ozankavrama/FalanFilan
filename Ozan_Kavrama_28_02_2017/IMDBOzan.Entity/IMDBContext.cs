namespace IMDBOzan.Entity
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class IMDBContext : DbContext
    {
        public IMDBContext()
            : base("name=IMDBContext")
        {
        }

        public virtual DbSet<Director> Director { get; set; }
        public virtual DbSet<Model.Type> Type { get; set; }
        public virtual DbSet<Film> Film { get; set; }
    }
}