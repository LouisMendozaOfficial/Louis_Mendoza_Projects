using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSE445_Project5_Assignment8
{
    public partial class StaffPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != "Staff")
                Response.Redirect("Default.aspx", true);
        }

        protected void Back_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", true);
        }

        protected void Logout_Button_Click(object sender, EventArgs e)
        {
            Session["user"] = "Member";
            Response.Redirect("Default.aspx", true);
        }
    }
}