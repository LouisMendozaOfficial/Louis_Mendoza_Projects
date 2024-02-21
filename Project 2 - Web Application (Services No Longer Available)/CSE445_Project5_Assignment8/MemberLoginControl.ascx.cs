using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.IO;
using System.Web;
using System.Xml;
using System.Data;
using System.Xml.Schema;
using System.Xml.Linq;
//This is my custom DLL
using EncryptionDecryptionDLL;

namespace CSE445_Project5_Assignment8
{
    public partial class MemberLoginControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ReturningUserName_Textbox.Text) == false && string.IsNullOrWhiteSpace(ReturningUserPassword_Textbox.Text) == false)
            {
                //Encrypting the username and password
                string username = EncryptionDecryptionService.Encrypt(ReturningUserName_Textbox.Text, 5);
                string password = EncryptionDecryptionService.Encrypt(ReturningUserPassword_Textbox.Text, 5);


                //Loading the Members.xml doc
                XmlDocument doc = new XmlDocument();
                doc.Load(AppDomain.CurrentDomain.BaseDirectory + "Members.xml");
                var nodes = doc.GetElementsByTagName("User");
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
                    Session["user"] = "Member";
                    BadLogin_Label.Text = "";
                    Response.Redirect("MemberPage.aspx", true);
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

        protected void Register_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NewUserName_Textbox.Text) == false && string.IsNullOrWhiteSpace(NewUserPassword_Textbox.Text) == false)
            {
                //Encrypting the username and password
                string username = EncryptionDecryptionService.Encrypt(NewUserName_Textbox.Text, 5);
                string password = EncryptionDecryptionService.Encrypt(NewUserPassword_Textbox.Text, 5);

                //Loading the Members.xml doc
                XmlDocument doc = new XmlDocument();
                doc.Load(AppDomain.CurrentDomain.BaseDirectory + "Members.xml");
                var nodes = doc.GetElementsByTagName("User");
                var resultNodes = new List<XmlNode>();
                bool exists = false;

                //Searching the Members.xml for an existing usernmane if there is one
                foreach (XmlNode node in nodes)
                {
                    if (node.Attributes["Username"].Value == username)
                    {
                        exists = true;
                        break;
                    }
                }

                if (exists)
                {
                    BadRegister_Label.Text = "Username is already taken!";
                }

                //Adding to the XML members file
                else
                {
                    XmlElement root = doc.DocumentElement;

                    XmlElement userElement = doc.CreateElement("User");
                    XmlAttribute usernameAttribute = doc.CreateAttribute("Username");
                    XmlAttribute passwordAAttribute = doc.CreateAttribute("Password");

                    usernameAttribute.Value = username;
                    passwordAAttribute.Value = password;

                    root.AppendChild(userElement);
                    userElement.Attributes.Append(usernameAttribute);
                    userElement.Attributes.Append(passwordAAttribute);

                    doc.Save(Server.MapPath("~/Members.xml"));

                    SuccessfulRegister_Label.Text = "Registry is succesful! You can now login with your new credentials!";
                    NewUserName_Textbox.Text = "";
                    NewUserPassword_Textbox.Text = "";
                    BadRegister_Label.Text = "";
                }
            }

            else
            {
                BadRegister_Label.Text = "Please enter a valid username or password!";
            }
        }

        protected void Back_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", true);
        }
    }
}