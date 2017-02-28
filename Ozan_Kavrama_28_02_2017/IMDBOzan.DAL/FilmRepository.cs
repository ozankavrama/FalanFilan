using IMDBOzan.Entity;
using IMDBOzan.Entity.Model;
using IMDBOzan.Entity.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IMDBOzan.DAL
{
    public class FilmRepository
    {
        public static List<Entity.Model.ViewModel.VMFilm> GetAllFilms()
        {
            using (IMDBContext db=new IMDBContext())
            {
                return db.Film.OrderByDescending(f=>f.Point).Select(f=>new Entity.Model.ViewModel.VMFilm()
                {
                    DirectorName=f.Director.DirectorName,
                    FilmID=f.FilmID,
                    FilmName=f.FilmName,
                    Point=f.Point,
                    TypeName=f.Type.TypeName
                }).ToList();
            }
        }

        public static void GiveVote(int id, double point)
        {
            using (IMDBContext db=new IMDBContext())
            {
                var result = db.Film.Find(id);
                result.PointCount += 1;
                result.Point = ((result.Point * (result.PointCount - 1)) + point) / (result.PointCount);
                db.SaveChanges();
            }
        }

        public static void DeleteFilm(int id)
        {
            using (IMDBContext db=new IMDBContext())
            {
                db.Film.Remove(db.Film.Find(id));
                db.SaveChanges();
            }
        }

        public static Film GetFilm(int id)
        {
            using (IMDBContext db=new IMDBContext())
            {
                return db.Film.Find(id);
            }
        }

        public static List<VMFilm> GetFilmsByDirector(int id)
        {
            using (IMDBContext db=new IMDBContext())
            {
                return db.Film.Where(f => f.DirectorID == id).OrderByDescending(f=>f.FilmID).Select(f => new VMFilm()
                {
                    DirectorName = f.Director.DirectorName,
                    FilmID = f.FilmID,
                    FilmName = f.FilmName,
                    Point = f.Point,
                    TypeName = f.Type.TypeName
                }).ToList();
            }
        }

        public static List<VMFilm> GetFilteredFilms(int directorID, int typeID)
        {
            using (IMDBContext db=new IMDBContext())
            {
                return db.Film.Where(f => f.DirectorID == directorID && f.TypeID == typeID).Select(f => new VMFilm()
                {
                    DirectorName = f.Director.DirectorName,
                    FilmID = f.FilmID,
                    FilmName = f.FilmName,
                    Point = f.Point,
                    TypeName = f.Type.TypeName
                }).ToList();
            }
        }

        public static void UpdateFilm(Film _film)
        {
            using (IMDBContext db=new IMDBContext())
            {
                var result = db.Film.Find(_film.FilmID);
                result.Description = _film.Description;
                result.DirectorID = _film.DirectorID;
                result.FilmName = _film.FilmName;
                result.TypeID = _film.TypeID;
                db.SaveChanges();
            }
        }

        public static List<VMFilm> GetFilmsByType(int id)
        {
            using (IMDBContext db=new IMDBContext())
            {
                return db.Film.Where(f => f.TypeID == id).Select(f=>new VMFilm()
                {
                    DirectorName=f.Director.DirectorName,
                    FilmName=f.FilmName,
                    FilmID=f.FilmID,
                    Point=f.Point,
                    TypeName=f.Type.TypeName
                }).ToList();
            }
        }

        public static void AddFilm(Film _film)
        {
            using (IMDBContext db=new IMDBContext())
            {
                db.Film.Add(_film);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    //Exception - Tarih seçilmedi!
                }
            }
        }
    }
}
