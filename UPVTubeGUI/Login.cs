using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVTube.Services;
using UPVTube.Entities;

namespace UPVTubeGUI {
    public partial class Login : UPVTubeFormBase {

        string username = "";
        string password = "";
        UPVTubeFormBase search;

        public Login()
        {
            InitializeComponent();
        }
        public Login(IUPVTubeService service) :base(service) {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = textBox1.Text;
            button1.Enabled = CheckButton();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e) {
            password = textBox2.Text;
            button1.Enabled = CheckButton();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            UPVTubeFormBase signUp = new Signup(service);
            signUp.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                service.LogIn(username, password);
                search = new Search(service);
                search.Show();
                this.Hide();
            } catch (ServiceException) {
                MessageBox.Show
                ("The username and/or password are not correct.", "Incorrect credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private bool CheckButton() {
            bool b = username == "" || password == "";
            return !b;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void dBInitialisationToolStripMenuItem_Click(object sender, EventArgs e) {
            service.DBInitialization();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
