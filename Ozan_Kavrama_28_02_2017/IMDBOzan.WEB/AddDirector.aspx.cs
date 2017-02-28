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
    public partial class AddDirector : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"]!=null&&!IsPostBack)
            {
                btnKaydet.Text = "Guncelle";
                var result=DirectorRepository.GetDirector(int.Parse(Request.QueryString["ID"]));
                txtDirectorName.Text = result.DirectorName;
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            Director _director = new Director()
            {
                DirectorName = txtDirectorName.Text
            };
            if (Request.QueryString["ID"]==null)
                DirectorRepository.AddDirector(_director);
            else
            {
                _director.DirectorID = int.Parse(Request.QueryString["ID"]);
                DirectorRepository.UpdateDirector(_director);
            }
            Response.Redirect("DirectorList.aspx");
        }
    }
}