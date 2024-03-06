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

namespace UPVTubeGUI {
    public partial class SearchTeacher : UPVTubeFormBase {
        public SearchTeacher()
        {
            InitializeComponent();
        }
        public SearchTeacher(IUPVTubeService service) :base(service) {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SearchTeacher_Load(object sender, EventArgs e)
        {

        }

        private void logOutButton_Click(object sender, EventArgs e) {
            this.Close();
            service.LogOut();
            Program.Login.Show();
        }

        private void addReviewToContentButton_Click(object sender, EventArgs e) {

        }
    }
}
