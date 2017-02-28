using IMDBOzan.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMDBOzan.WEB
{
    public partial class FilmList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = FilmRepository.GetAllFilms();
            Repeater1.DataBind();
            if (!IsPostBack)
            {
                ddlType.DataSource = TypeRepository.GetAllTypes();
                ddlType.DataTextField = "TypeName";
                ddlType.DataValueField = "TypeID";
                ddlType.DataBind();
                ddlDirector.DataSource = DirectorRepository.GetAllDirectors();
                ddlDirector.DataTextField = "DirectorName";
                ddlDirector.DataValueField = "DirectorID";
                ddlDirector.DataBind();
                ddlType.Items.Add("Hepsi");
                ddlType.SelectedIndex = ddlType.Items.Count - 1;
                ddlDirector.Items.Add("Hepsi");
                ddlDirector.SelectedIndex = ddlDirector.Items.Count - 1;
            }
            if (Request.QueryString["filmID"] != null)
                FilmRepository.DeleteFilm(int.Parse(Request.QueryString["filmID"]));
            if (Request.QueryString["directorID"] != null)
            {
                ddlDirector.SelectedValue = Request.QueryString["directorID"];
                ddlDirector_SelectedIndexChanged(sender, e);
                ddlDirector.Enabled = false;
                return;
            }

        }

        protected void ddlDirector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlDirector.SelectedIndex == ddlDirector.Items.Count - 1 && ddlType.SelectedIndex == ddlType.Items.Count - 1)
            {
                Repeater1.DataSource = FilmRepository.GetAllFilms();
                Repeater1.DataBind();
            }
            else if(ddlType.SelectedIndex == ddlType.Items.Count - 1)
            {
                Repeater1.DataSource = FilmRepository.GetFilmsByDirector(int.Parse(ddlDirector.SelectedValue));
                Repeater1.DataBind();
            }
            else if (ddlDirector.SelectedIndex == ddlDirector.Items.Count - 1)
            {
                Repeater1.DataSource = FilmRepository.GetFilmsByType(int.Parse(ddlType.SelectedValue));
                Repeater1.DataBind();
            }
            else
            {
                Repeater1.DataSource = FilmRepository.GetFilteredFilms(int.Parse(ddlDirector.SelectedValue), int.Parse(ddlType.SelectedValue));
                Repeater1.DataBind();
            }
        }

        protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlType.SelectedIndex==ddlType.Items.Count-1 && ddlDirector.SelectedIndex == ddlDirector.Items.Count - 1)
            {
                Repeater1.DataSource = FilmRepository.GetAllFilms();
                Repeater1.DataBind();
            }
            else if(ddlDirector.SelectedIndex==ddlDirector.Items.Count-1)
            {
                Repeater1.DataSource = FilmRepository.GetFilmsByType(int.Parse(ddlType.SelectedValue));
                Repeater1.DataBind();
            }
            else if (ddlType.SelectedIndex == ddlType.Items.Count - 1)
            {
                Repeater1.DataSource = FilmRepository.GetFilmsByDirector(int.Parse(ddlDirector.SelectedValue));
                Repeater1.DataBind();
            }
            else
            {
                Repeater1.DataSource = FilmRepository.GetFilteredFilms(int.Parse(ddlDirector.SelectedValue), int.Parse(ddlType.SelectedValue));
                Repeater1.DataBind();
            }
        }
    }
}