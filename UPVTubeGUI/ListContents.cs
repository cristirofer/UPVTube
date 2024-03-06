using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVTube.Entities;
using UPVTube.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UPVTubeGUI {
    public partial class ListContents : UPVTubeFormBase {

        public DateTime startDate = new DateTime(1753, 1, 1, 0, 0, 0);
        public DateTime endDate = new DateTime(3450, 1, 1, 0, 0, 0);
        public string nick = "";
        public string wordsTitle = "";
        public string subject = "";
        public int selected = -1;
        public List<Content> contentList;
        public ListContents()
        {
            InitializeComponent();
        }
        public ListContents(IUPVTubeService service) :base(service) {
            InitializeComponent();
        }

        public ListContents(IUPVTubeService service, string wordstitle, string nick, string subject, DateTime startDate, DateTime endDate) :base(service) {
            InitializeComponent();
            this.wordsTitle = wordstitle;
            this.nick = nick;
            this.subject = subject;
            this.startDate = startDate;
            this.endDate = endDate;
            advancedSearchStart();
        }

        public ListContents(IUPVTubeService service, string w) :base(service) {
            InitializeComponent();
            wordsTitle = w;
            searchBox.Text = w;
            wordsTitle = w;
            ForceSearch();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (contentGrid.SelectedCells.Count > 0) {
                displayDetailsButton.Enabled = true;
                selected = contentGrid.SelectedCells[0].RowIndex;
            } else {
                selected = -1;
                displayDetailsButton.Enabled = false;
            }
        }
        private void startSearch(object sender, EventArgs e)
        {
            contentGrid.Rows.Clear();
            DateTime nullStartDate = new DateTime(1753, 1, 1, 0, 0, 0);
            DateTime nullEndDate = DateTime.Now;
            contentList = service.SearchContent(nullStartDate, nullEndDate, "", wordsTitle, "");
            foreach (Content c in contentList)
            {
                String subjects = "";
                foreach(Subject s in c.Subjects)
                {
                    subjects += s.Name.ToString() + " ";
                }

                contentGrid.Rows.Add(c.Title,c.Owner.Nick,c.UploadDate,subjects,c.ContentURI);
            }
            contentGrid.ClearSelection();
            searchBox.Text = "";
        }

        private void searchTextChanged(object sender, EventArgs e)
        {
            wordsTitle = searchBox.Text;
        }

        private void ListContents_Load(object sender, EventArgs e)
        {
            displayDetailsButton.Enabled = false;
        }

        private void advancedSearchClicked(object sender, EventArgs e)
        {
            UPVTubeFormBase advancedSearch = new advancedSearchForm(service, this);
            advancedSearch.ShowDialog();
        }

        public void advancedSearchStart()
        {
            contentGrid.Rows.Clear();
            contentList = service.SearchContent(startDate, endDate, nick, wordsTitle, subject);
            foreach (Content c in contentList)
            {
                String subjects = "";
                foreach (Subject s in c.Subjects)
                {
                    subjects += s.Name.ToString() + " ";
                }
                contentGrid.Rows.Add(c.Title, c.Owner.Nick, c.UploadDate, subjects, c.ContentURI);
            }
            contentGrid.ClearSelection();
            searchBox.Text = "";
        }

        private void logOutButton_Click(object sender, EventArgs e) {
            this.Close();
            service.LogOut();
            Program.Login.Show();
        }

        private void ForceSearch() {
            contentGrid.Rows.Clear();
            DateTime nullStartDate = new DateTime(1753, 1, 1, 0, 0, 0);
            DateTime nullEndDate = DateTime.Now;
            contentList = service.SearchContent(nullStartDate, nullEndDate, "", wordsTitle, "");
            foreach (Content c in contentList) {
                String subjects = "";
                foreach (Subject s in c.Subjects) {
                    subjects += s.Name.ToString() + " ";
                }

                contentGrid.Rows.Add(c.Title, c.Owner.Nick, c.UploadDate, subjects, c.ContentURI);
            }
        }

        private void displayDetailsButton_Click(object sender, EventArgs e) {
            Content[] a = contentList.ToArray();
            Content c = a[selected];
            UPVTubeFormBase details = new ContentDetails(service, c);
            details.ShowDialog();
        }

        private void contentGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (contentGrid.SelectedCells.Count > 0) {
                displayDetailsButton.Enabled = true;
                selected = contentGrid.SelectedCells[0].RowIndex;
            } else {
                selected = -1;
                displayDetailsButton.Enabled = false;
            }
        }

        private void logOutButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
            service.LogOut();
            Program.Login.Show();
        }

        private void goBackButton_Click(object sender, EventArgs e) {
            UPVTubeFormBase s = new Search(service);
            s.Show();
            this.Close();
        }
    }
}
