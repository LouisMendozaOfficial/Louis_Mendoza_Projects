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
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NewUserName_Textbox.Text) == false && string.IsNullOrWhiteSpace(NewUserPassword_Textbox.Text) == false)
            {
                //Encrypting the username and password
                string username = EncryptionDecryptionService.Encrypt(NewUserName_Textbox.Text, 5);
                string password = EncryptionDecryptionService.Encrypt(NewUserPassword_Textbox.Text, 5);

                //Loading the Staff.xml doc
                XmlDocument doc = new XmlDocument();
                doc.Load(AppDomain.CurrentDomain.BaseDirectory + "Staff.xml");
                var nodes = doc.GetElementsByTagName("StaffMember");
                var resultNodes = new List<XmlNode>();
                bool exists = false;

                //Searching the Staff.xml for an existing usernmane if there is one
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

                //Adding to the XML staff file
                else
                {
                    XmlElement root = doc.DocumentElement;

                    XmlElement userElement = doc.CreateElement("StaffMember");
                    XmlAttribute usernameAttribute = doc.CreateAttribute("Username");
                    XmlAttribute passwordAAttribute = doc.CreateAttribute("Password");

                    usernameAttribute.Value = username;
                    passwordAAttribute.Value = password;

                    root.AppendChild(userElement);
                    userElement.Attributes.Append(usernameAttribute);
                    userElement.Attributes.Append(passwordAAttribute);

                    doc.Save(Server.MapPath("~/Staff.xml"));

                    SuccessfulRegister_Label.Text = "Registry of new staff member is succesful!";
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
    }
}