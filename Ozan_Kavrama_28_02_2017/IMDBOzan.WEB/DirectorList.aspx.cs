using IMDBOzan.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMDBOzan.WEB
{
    public partial class DirectorList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] != null)
                DirectorRepository.DeleteDirector(int.Parse(Request.QueryString["ID"]));
            Repeater1.DataSource = DirectorRepository.GetAllDirectors();
            Repeater1.DataBind();
        }
    }
}