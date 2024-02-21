using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSE445_Project5_Assignment8
{
    public partial class MemberPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("MemberLoginPage.aspx", true);
        }

        protected void Back_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", true);
        }

        protected void TopTenWords_Button_Click(object sender, EventArgs e)
        {
            LouisMendozaNonRESTful.Service1Client TopTenWordsFilter = new LouisMendozaNonRESTful.Service1Client();

            TopTenWords_Label.Text = TopTenWordsFilter.TopTenWords(URL_Textbox0.Text);
        }

        protected void AverageSentenceLength_Button_Click(object sender, EventArgs e)
        {
            LouisMendozaNonRESTful.Service1Client AverageSentenceLength = new LouisMendozaNonRESTful.Service1Client();
            AverageSentenceLength_Label.Text = "The average sentence length is " + AverageSentenceLength.AverageSentenceLength(URL_Textbox1.Text) + " words.";
        }

        protected void Logout_Button_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Response.Redirect("Default.aspx", true);
        }
    }
}