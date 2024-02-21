using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XML_TryIt
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Validate_Button_Click(object sender, EventArgs e)
        {
            XML_Services.Service1Client ValidateService = new XML_Services.Service1Client();

            if(ValidateService.Validation(URL_Textbox.Text) == true)
            {
                Valid_Label.Text = "Valid";
            }

            else
            {
                Valid_Label.Text = "Invalid";
            }
        }

        protected void Path_Button_Click(object sender, EventArgs e)
        {
            XML_Services.Service1Client PathService = new XML_Services.Service1Client();

            Path_Label.Text = PathService.XMLPathSearch(URL_Textbox0.Text, Path_Textbox.Text);

        }
    }
}