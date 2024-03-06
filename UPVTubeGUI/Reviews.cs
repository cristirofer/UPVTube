using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVTube.Entities;
using UPVTube.Services;

namespace UPVTubeGUI {
    public partial class Reviews : UPVTubeFormBase {
        private List<Content> contentList = new List<Content>();
        private int selected = -1;
        private Content content;
        Search s;
        public Reviews() {
            InitializeComponent();
        }

        public Reviews(IUPVTubeService service) :base(service) {
            InitializeComponent();
        }

        public Reviews(IUPVTubeService service, Search s) : base(service) {
            InitializeComponent();
            displayDetailsButton.Enabled = false;
            reviewButton.Enabled = false;
            this.s = s;
        }

        private void Reviews_Load(object sender, EventArgs e) {
            contentGrid.Rows.Clear();
            List<Content> list = service.SearchUnAthorisedContent();
            contentList = list;
            foreach (Content c in list) {
                String subjects = "";
                foreach (Subject s in c.Subjects) {
                    subjects += s.Name.ToString() + " ";
                }
                contentGrid.Rows.Add(c.Title, c.Owner.Nick, c.UploadDate, subjects, c.ContentURI);
            }
            displayDetailsButton.Enabled = false;
        }

        private void reviewButton_Click(object sender, EventArgs e) {
            content = contentList[selected];
            UPVTubeFormBase addReview = new AddReview(service, content, this);
            addReview.ShowDialog();
        }

        private void goBackButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void displayDetailsButton_Click(object sender, EventArgs e) {
            content = contentList[selected];
            UPVTubeFormBase details = new ContentDetails(service, content);
            details.ShowDialog();
        }

        private void contentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (contentGrid.SelectedCells.Count > 0) {
                reviewButton.Enabled = true;
                displayDetailsButton.Enabled = true;
                selected = contentGrid.CurrentCell.RowIndex;
            } else {
                selected = -1;
                displayDetailsButton.Enabled = false;
                reviewButton.Enabled = false;
            }
        }

        private void contentGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (contentGrid.SelectedCells.Count > 0) {
                reviewButton.Enabled = true;
                displayDetailsButton.Enabled = true;
                selected = contentGrid.CurrentCell.RowIndex;
            } else {
                selected = -1;
                displayDetailsButton.Enabled = false;
                reviewButton.Enabled = false;
            }
        }

        public void loadContent() {
            contentGrid.Rows.Clear();
            List<Content> list = service.SearchUnAthorisedContent();
            contentList = list;
            foreach (Content c in list) {
                String subjects = "";
                foreach (Subject s in c.Subjects) {
                    subjects += s.Name.ToString() + " ";
                }
                contentGrid.Rows.Add(c.Title, c.Owner.Nick, c.UploadDate, subjects, c.ContentURI);
            }
            displayDetailsButton.Enabled = false;
            reviewButton.Enabled = false;
        }
    }
}
