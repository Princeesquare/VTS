using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            if (!File.Exists(xmlFilePath))
            {
                CreateInitialXmlFile();
            }

            if (ValidateCredentials(username, password))
            {
                int screenWidth = Screen.PrimaryScreen.Bounds.Width;
                int screenHeight = Screen.PrimaryScreen.Bounds.Height;
                int centerX = screenWidth / 2;
                int centerY = screenHeight / 2;

                // if Credentials are correct, open the Buses Page
                Buses f2 = new Buses();
                f2.StartPosition = FormStartPosition.Manual;
                f2.Location = new System.Drawing.Point(centerX - f2.Width / 2, centerY - f2.Height / 2);
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
            // Load the XML document
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);

            // Find the user with matching credentials
            XmlNodeList userNodes = xmlDoc.SelectNodes($"/users/user[@username='{username}']");
            foreach (XmlNode userNode in userNodes)
            {
                string storedPassword = userNode.Attributes["password"].Value;

                if (storedPassword == password)
                {
                    return true; // Credentials match
                }
            }

            return false; // No matching credentials found
        }
        private void CreateInitialXmlFile()
        {
            // Create the XML document with a root element
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root = xmlDoc.CreateElement("users");
            xmlDoc.AppendChild(root);

            // Add a sample user
            XmlElement user = xmlDoc.CreateElement("user");
            user.SetAttribute("username", "admin");
            user.SetAttribute("password", "admin");
            root.AppendChild(user);

            // Save the XML document
            xmlDoc.Save(xmlFilePath);
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

        private void fb_Click(object sender, EventArgs e)
        {
            string link = "https://www.facebook.com/CIUOfficial/";
            Process.Start(link);
        
        }

        private void ig_Click(object sender, EventArgs e)
        {
            string link = "https://www.instagram.com/ciu.official/";
            Process.Start(link);
        }

        private void twitter_Click(object sender, EventArgs e)
        {
            string link = "https://twitter.com/CIUOfficial";
            Process.Start(link);
        }

        private void ciu_Click(object sender, EventArgs e)
        {
            string link = "https://www.ciu.edu.tr/en";
            Process.Start(link);
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;
            int centerX = (screenWidth - formWidth) / 2;
            int centerY = (screenHeight - formHeight) / 2;

            // Position the form at the center
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(centerX, centerY);
        }
    }
}