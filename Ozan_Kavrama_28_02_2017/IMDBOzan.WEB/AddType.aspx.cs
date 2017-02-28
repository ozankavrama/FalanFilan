using IMDBOzan.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMDBOzan.WEB
{
    public partial class AddType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            Entity.Model.Type _type = new Entity.Model.Type()
            {
                TypeName = txtTypeName.Text,
            };
            TypeRepository.AddType(_type);
            Response.Redirect("FilmList.aspx");
        }
    }
}