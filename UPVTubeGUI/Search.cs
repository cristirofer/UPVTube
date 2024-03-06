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
    public partial class Search : UPVTubeFormBase {

        ListContents listContent;
        string searchText = "";
        bool extra = false;
        public Search()
        {
            InitializeComponent();
        }
        public Search(IUPVTubeService service) :base(service) {
            InitializeComponent();
            addReviewToContentButton.Visible = service.ImTeacher();
            if (!service.isMember())
            {
                uploadNewContentButton.Visible =false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e) {
            
        }

        private void SearchButton_Click(object sender, EventArgs e) {
            listContent = new ListContents(service, searchBox.Text);
            listContent.Show();
            this.Close();
        }

        private void searchBox_TextChanged_1(object sender, EventArgs e) {
            searchText = searchBox.Text;
        }

        private void logOutButton_Click(object sender, EventArgs e) {
            this.Close();
            service.LogOut();
            Program.Login.Show();
        }

        private void addReviewToContentButton_Click(object sender, EventArgs e) {
            Reviews contentsToReview = new Reviews(service, this);
            contentsToReview.ShowDialog();
        }

        private void label2_Click_1(object sender, EventArgs e) {

        }

        private void advancedSearchButton_Click(object sender, EventArgs e) {
            UPVTubeFormBase advancedSearch = searchText == "" ? new advancedSearchForm(service, this) : new advancedSearchForm(service, searchText, this);
            advancedSearch.ShowDialog();
        }

        

        private void uploadNewContentButton_Click(object sender, EventArgs e) {
            UPVTubeFormBase uploadNewContent = new UploadContent(service);
            uploadNewContent.ShowDialog();
        }
    }
}
