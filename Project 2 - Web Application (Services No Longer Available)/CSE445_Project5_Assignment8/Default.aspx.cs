using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSE445_Project5_Assignment8
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void MemberPage_Button_Click(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("MemberLoginPage.aspx", true);
            if (Session["user"] != null)
                Response.Redirect("MemberPage.aspx", true);
        }

        protected void StaffPage_Button_Click(object sender, EventArgs e)
        {
            if (Session["user"] != "Staff")
                Response.Redirect("StaffLoginPage.aspx", true);

            if (Session["user"] == "Staff")
                Response.Redirect("StaffPage.aspx", true);

        }

        protected void Logout_Button_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
        }
    }
}