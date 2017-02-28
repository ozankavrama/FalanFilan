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
    public partial class FilmDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlDirector.DataSource = DirectorRepository.GetAllDirectors();
            ddlDirector.DataTextField = "DirectorName";
            ddlDirector.DataValueField = "DirectorID";
            ddlDirector.DataBind();
            ddlTypes.DataSource = TypeRepository.GetAllTypes();
            ddlTypes.DataTextField = "TypeName";
            ddlTypes.DataValueField = "TypeID";
            ddlTypes.DataBind();
            Film _film=FilmRepository.GetFilm(int.Parse(Request.QueryString["ID"]));
            txtFilmDescription.Text = _film.Description;
            txtFilmName.Text = _film.FilmName;
            txtPublishDate.Text = _film.PublishDate.ToString();
            ddlDirector.SelectedValue = _film.DirectorID.ToString();
            ddlTypes.SelectedValue = _film.TypeID.ToString();
        }
    }
}