using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSE445_Project3_Assignment5_WebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Filter_Button_Click(object sender, EventArgs e)
        {
            RequiredServices.Service1Client WordFilterService = new RequiredServices.Service1Client();
            Filtered_Label.Text = WordFilterService.WordFilter(Unfiltered_Textbox.Text);
        }

        protected void Find_Button_Click(object sender, EventArgs e)
        {
            RequiredServices.Service1Client TopTenWordsFilter = new RequiredServices.Service1Client();
            TopTenWords_Label.Text = String.Join(", ", TopTenWordsFilter.TopTenWords(URL_Textbox.Text));
        }
    }
}