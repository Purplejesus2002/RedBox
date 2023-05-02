using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace RedBox
{
    public partial class RedBox : Form
    {
        public int tries = 0;
        public bool success = false;
        public bool userCorrect = false;
        public bool passCorrect = false;
        public RedBox()
        {
            InitializeComponent();
        }

        private void butLogIn_Click(object sender, EventArgs e)
        {
            const char DELIM = ',';
            const string authInfo = "AuthInfo.txt";
            string[] fields;
            StreamReader readUser = null;

            try
            {
                if (!File.Exists(authInfo))
                {
                    MessageBox.Show("Authentication file not found.");
                    return;
                }

                readUser = new StreamReader(authInfo);
                string line;
                while ((line = readUser.ReadLine()) != null)
                {
                    fields = line.Split(DELIM);
                    if (txtFullname.Text.ToLower() == fields[0].ToLower())
                    {
                        userCorrect = true;
                        if (txtCWID.Text.ToLower() == fields[1].ToLower())
                        {
                            passCorrect = true;
                            success = true;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Incorrect password.");
                            tries++;
                            return;
                        }
                    }
                }

                if (success)
                {
                    MessageBox.Show("Login successful!");
                }
                else
                {
                    tries++;
                    MessageBox.Show("Incorrect username.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally//explain to prof how to use this
            {
                if (readUser != null)
                {
                    readUser.Close();
                }
            }
        }
    }
}
    
