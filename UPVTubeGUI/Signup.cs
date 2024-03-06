using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVTube.Services;
using System.Text.RegularExpressions;

namespace UPVTubeGUI {
    public partial class Signup : UPVTubeFormBase {
        private string email = "";
        private string name = "";
        private string surname = "";
        private string password = "";
        private string confirm = "";
        private string nickname = "";
        public Signup()
        {
            InitializeComponent();
        }
        public Signup(IUPVTubeService service) :base(service) {
            InitializeComponent();
            confirmButton.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e) {

        }

        private bool checkButton() {
            bool b = email == "" || name == "" || password == "" || confirm == "" || surname == "" || nickname == "";
            if (b)
                return false;
            else
                return password == confirm;
        }

        private void nameBox_TextChanged(object sender, EventArgs e) {
            name = nameBox.Text;
            if (checkButton()) {
                confirmButton.Enabled = true;
            } else {
                confirmButton.Enabled = false;
            }
        }

        private void surnameBox_TextChanged(object sender, EventArgs e) {
            surname = surnameBox.Text;
            if (checkButton()) {
                confirmButton.Enabled = true;
            } else {
                confirmButton.Enabled = false;
            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e) {
            password = passwordBox.Text;
            if (checkButton()) {
                confirmButton.Enabled = true;
            } else {
                confirmButton.Enabled = false;
            }
        }

        private void confirmBox_TextChanged(object sender, EventArgs e) {
            confirm = confirmBox.Text;
            if (checkButton()) {
                confirmButton.Enabled = true;
            } else {
                confirmButton.Enabled = false;
            }
            if (password != confirm) {
                confirmBox.BackColor = Color.FromArgb(255, 192, 192);
            } else
                confirmBox.BackColor = Color.White;
        }

        private void confirmButton_Click(object sender, EventArgs e) {
            try {
                /*const String pattern1 = "[A-Za-z0-9]+@inf\\.upv\\.es";
                const String pattern2 = "[A-Za-z0-9]+@dsic\\.upv\\.es";
                const String pattern3 = "[A-Za-z0-9]+@disca\\.upv\\.es";
                Regex regex1 = new Regex(pattern1);
                Regex regex2 = new Regex(pattern2);
                Regex regex3 = new Regex(pattern3);
                */
                //if (regex1.IsMatch(email) || regex2.IsMatch(email) || regex3.IsMatch(email))
                //{
                    service.RegisterNewUser(email, name + " " + surname, nickname, password);
                    service.LogIn(nickname, password);
                    UPVTubeFormBase search;
                    search = new Search(service);
                    search.Show();
                    this.Close();
                //} else
                //{
                //   MessageBox.Show
                //    ("The email supplied is not valid, valid emails should end with: @inf.upv.es, @disca.upv.es or @dsic.upv.es", "Incorrect email format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                
            } catch (ServiceException se) {
                MessageBox.Show
                (se.Message, "Already existing user", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
            Program.Login.Show();
            
        }

        private void nicknameBox_TextChanged(object sender, EventArgs e) {
            nickname = nicknameBox.Text;
            if (checkButton()) {
                confirmButton.Enabled = true;
            } else {
                confirmButton.Enabled = false;
            }
        }

        private void email_TextChanged(object sender, EventArgs e) {
            email = emailBox.Text;
            if (checkButton()) {
                confirmButton.Enabled = true;
            } else {
                confirmButton.Enabled = false;
            }
        }
    }
}
