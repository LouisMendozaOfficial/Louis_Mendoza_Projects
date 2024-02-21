using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Net;
using System.IO;
using System.Web;
using System.Text.RegularExpressions;
using System.Xml;
using System.Data;
using System.Xml.Schema;
using System.Xml.Linq;
using EncryptionDecryptionDLL;

namespace CSE445_Project5_Assignment8
{
    public partial class StaffLoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //If the user is a staff member thats already logged in, theres no reason for them to relogin so they can go to the staff page
            if (Session["user"] == "Staff")
                Response.Redirect("StaffPage.aspx", true);
        }

        protected void Login_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserName_Textbox.Text) == false && string.IsNullOrWhiteSpace(Password_Textbox.Text) == false)
            {
                //Encrypting the username and password
                string username = EncryptionDecryptionService.Encrypt(UserName_Textbox.Text, 5);
                string password = EncryptionDecryptionService.Encrypt(Password_Textbox.Text, 5);

                //Loading the Members.xml doc
                XmlDocument doc = new XmlDocument();
                doc.Load(AppDomain.CurrentDomain.BaseDirectory + "Staff.xml");
                var nodes = doc.GetElementsByTagName("StaffMember");
                var resultNodes = new List<XmlNode>();
                bool validUser = false;

                //Searching the Members.xml for a user element that has the correct username and password
                foreach (XmlNode node in nodes)
                {
                    if (node.Attributes != null && node.Attributes["Username"] != null && node.Attributes["Username"].Value == username
                                                && node.Attributes["Password"] != null && node.Attributes["Password"].Value == password)
                    {
                        validUser = true;
                        break;
                    }
                }

                //Decision depending on if its a valid user or not
                if (validUser)
                {
                    BadLogin_Label.Text = "";
                    Session["user"] = "Staff";
                    Response.Redirect("StaffPage.aspx", true);
                }

                else
                {
                    BadLogin_Label.Text = "Incorrect username or password!";
                }
            }

            else
            {
                BadLogin_Label.Text = "Incorrect username or password!";
            }
        }

        protected void Back_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", true);
        }
    }
}