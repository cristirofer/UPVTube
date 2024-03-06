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
using static UPVTube.Services.UPVTubeService;

namespace UPVTubeGUI
{
    public partial class ContentsToReview : UPVTubeFormBase
    {
        Content content;
        public int selected = -1;
        public List<Content> contentList;
        Search s;
        public ContentsToReview()
        {
            InitializeComponent();
        }

        public ContentsToReview(IUPVTubeService service, Search s) : base(service)
        {
            InitializeComponent();
            displayDetailsButton.Enabled = false;
            reviewButton.Enabled = false;
            this.s = s;
            loadContent();
        }

        private void ContentsToReview_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }
        public void loadContent()
        { 
            contentGrid.Rows.Clear();
            List<Content> list = service.SearchUnAthorisedContent();
            contentList = list;
            foreach (Content c in list)
            {
                String subjects = "";
                foreach (Subject s in c.Subjects)
                {
                    subjects += s.Name.ToString() + " ";
                }
                contentGrid.Rows.Add(c.Title, c.Owner.Nick, c.UploadDate, subjects, c.ContentURI);
            }
        }
        private void contentGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (contentGrid.SelectedCells.Count > 0)
            //{
            if(contentGrid.SelectedCells.Count > 0) {
                displayDetailsButton.Enabled = true;
                reviewButton.Enabled = true;
                selected = contentGrid.CurrentCell.RowIndex;
            } else {
                selected = -1;
                displayDetailsButton.Enabled = false;
                reviewButton.Enabled = false;
            }
            //}
            //else
            //{
            //selected = -1;
            // displayDetailsButton.Enabled = false;
            //}
        }

        private Content obtainContent(int selected)
        {
            return contentList[selected];
        }

        private void contentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (contentGrid.SelectedCells.Count > 0)
            //{
            if (contentGrid.SelectedCells.Count > 0) {
                reviewButton.Enabled = true;
                displayDetailsButton.Enabled = true;
                selected = contentGrid.CurrentCell.RowIndex;
            } else {
                selected = -1;
                displayDetailsButton.Enabled = false;
                reviewButton.Enabled = false;
            }
            //Content[] a = contentList.ToArray();
            //content = a[selected];
            //}
            //else
            //{
            //selected = -1;
            //displayDetailsButton.Enabled = false;
            //}
        }


        private void reviewButton_Clicked(object sender, EventArgs e)
        {
            content = contentList[selected];
            UPVTubeFormBase addReview = new AddReview(service, content, this);
            addReview.ShowDialog();
        }

        private void displayDetailsButton_Click(object sender, EventArgs e)
        {
            UPVTubeFormBase details = new ContentDetails(service, content);
            details.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void contentGrid_Click(object sender, EventArgs e) {

        }
    }
}
