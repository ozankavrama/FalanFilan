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
    public partial class VoteFilm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Film result = FilmRepository.GetFilm(int.Parse(Request.QueryString["ID"]));
            txtFilmName.Text = result.FilmName;
            txtEskiPuan.Text = result.Point.ToString() == "-1" ? "-" : result.Point.ToString();
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            FilmRepository.GiveVote(int.Parse(Request.QueryString["ID"]), Convert.ToDouble(txtPuan.Text));
            Response.Redirect("FilmList.aspx");
        }
    }
}