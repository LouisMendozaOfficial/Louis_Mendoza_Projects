using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;


namespace Messaging_GUI
{
    public partial class SenderPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Send_Button_Click(object sender, EventArgs e)
        {
            //Checking if the user entered the necessary IDs
            if(!string.IsNullOrWhiteSpace(SenderID_Textbox.Text) && !string.IsNullOrWhiteSpace(ReceiverID_Textbox.Text))
            {
                //Getting the time stamp
                DateTimeOffset currentTime = (DateTimeOffset)DateTime.Now;

                //Opening the web client channel
                WebClient channel = new WebClient();
                
                //Calling the service
                channel.DownloadData("http://localhost:55396/Service1.svc/sendMsg?senderID=" 
                    + SenderID_Textbox.Text + "&receiverID=" + ReceiverID_Textbox.Text + "&time=" + currentTime.ToString("MM/dd/yyyy h:mm tt") + "&message=" + Message_Textbox.Text);

                Message_Textbox.Text = "";
                SenderID_Textbox.Text = "";
                ReceiverID_Textbox.Text = "";
            }
        }

        protected void ReceiverPage_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReceiverPage.aspx", true);
        }
    }
}