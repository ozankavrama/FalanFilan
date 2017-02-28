using IMDBOzan.DAL;
using IMDBOzan.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMDBOzan.WEB
{
    public partial class AddFilm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlDirector.DataSource = DirectorRepository.GetAllDirectors();
                ddlDirector.DataTextField = "DirectorName";
                ddlDirector.DataValueField = "DirectorID";
                ddlDirector.DataBind();
                ddlTypes.DataSource = TypeRepository.GetAllTypes();
                ddlTypes.DataTextField = "TypeName";
                ddlTypes.DataValueField = "TypeID";
                ddlTypes.DataBind();
                if (Request.QueryString["ID"]!=null)
                {
                    Film _film = FilmRepository.GetFilm(int.Parse(Request.QueryString["ID"]));
                    txtFilmDescription.Text = _film.Description;
                    ddlDirector.SelectedValue = _film.DirectorID.ToString();
                    ddlTypes.SelectedValue = _film.TypeID.ToString();
                    txtFilmName.Text = _film.FilmName;
                    calender1.VisibleDate = _film.PublishDate;
                    calender1.SelectedDate = _film.PublishDate.Date;
                    btnKaydet.Text = "Güncelle";
                }
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            Film _film = new Film()
            {
                Description = txtFilmDescription.Text,
                DirectorID = int.Parse(ddlDirector.SelectedValue),
                FilmName = txtFilmName.Text,
                TypeID = int.Parse(ddlTypes.SelectedValue),
            };
            _film.PublishDate = calender1.SelectedDate.Year.ToString() == "1" ? DateTime.Now : calender1.SelectedDate;
            if (Request.QueryString["ID"] != null)
            {
                _film.FilmID = int.Parse(Request.QueryString["ID"]);
                FilmRepository.UpdateFilm(_film);
            }
            else
            {
                _film.Point = -1;
                _film.PointCount = 0;
                FilmRepository.AddFilm(_film);
            }
            Response.Redirect("FilmList.aspx");
        }
    }
}