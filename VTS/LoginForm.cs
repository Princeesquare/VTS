using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VTS
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private XmlDocument xmlDoc = new XmlDocument();
        private const string xmlFilePath = "login.xml";

        private void InitializeXmlDocument()
        {
            // Check if the XML file already exists
            if (File.Exists(xmlFilePath))
            {
                // Load the existing XML file
                xmlDoc.Load(xmlFilePath);
            }
            else
            {
                // Create a new XML document with a root element
                XmlElement root = xmlDoc.CreateElement("users");
                xmlDoc.AppendChild(root);

                // Save the XML document
                xmlDoc.Save(xmlFilePath);
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = utbox.Text;
            string password = ptbox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }

            if (ValidateCredentials(username, password))
            {
               
                // Credentials are correct, open the new form
                Buses f2 = new Buses();
                f2.Show();

                // Close the login form
                this.Hide();
            }
            else
            {
                // Display error message
                MessageBox.Show("Incorrect username or password.");
            }
        }

        private bool ValidateCredentials(string username, string password)
        {
            // Find the user with matching credentials
            XmlNodeList userNodes = xmlDoc.SelectNodes("/users/user");
            foreach (XmlNode userNode in userNodes)
            {
                string storedUsername = userNode.Attributes["username"].Value;
                string storedPassword = userNode.Attributes["password"].Value;

                if (storedUsername == username && storedPassword == password)
                {
                    return true; // Credentials match
                }
            }

            return false; // No matching credentials found
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            string username = utbox.Text;
            string password = ptbox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }

            // Check if the XML document has a root element
            if (xmlDoc.DocumentElement == null)
            {
                // If the root element doesn't exist, create one
                XmlElement root = xmlDoc.CreateElement("users");
                xmlDoc.AppendChild(root);
            }

            XmlNode userNode = xmlDoc.SelectSingleNode($"/users/user[@username='{username}']");
            if (userNode != null)
            {
                MessageBox.Show("User already exists.");
                return;
            }

            XmlElement user = xmlDoc.CreateElement("user");
            user.SetAttribute("username", username);
            user.SetAttribute("password", password);
            xmlDoc.DocumentElement.AppendChild(user);

            xmlDoc.Save(xmlFilePath);

            MessageBox.Show("User created successfully.");


        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
              InitializeXmlDocument();
        }
    }
}