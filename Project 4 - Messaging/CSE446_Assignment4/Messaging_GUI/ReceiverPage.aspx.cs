using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Messaging_GUI
{
    public partial class ReceiverPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Receive_Button_Click(object sender, EventArgs e)
        {
            string purgeResponse;

            //Checking for purge
            if(Purge_Checkbox.Checked)
            {
                purgeResponse = "yes";
            }

            else
            {
                purgeResponse = "no";
            }
            
            //Calling the service
            if(!string.IsNullOrWhiteSpace(ReceiverID_Textbox.Text))
            {
                using (var webClient = new System.Net.WebClient())
                {
                    string messagesArray = webClient.DownloadString("http://localhost:55396/Service1.svc/receiveMsg?receiverID=" + ReceiverID_Textbox.Text + "&purge=" + purgeResponse);
                    messagesArray = messagesArray.Replace("\"", string.Empty);
                    messagesArray = messagesArray.Replace("\\", string.Empty);
                    messagesArray = messagesArray.Replace("$", "\n");
                    Messages_Textbox.Text = messagesArray;
                }
            }

            else
            {
                Messages_Textbox.Text = "";
                Purge_Checkbox.Checked = false;
            }

            ReceiverID_Textbox.Text = "";
        }

        protected void SenderPage_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("SenderPage.aspx", true);
        }
    }
}