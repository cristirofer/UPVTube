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

namespace UPVTubeGUI {
    public partial class ContentDetails : UPVTubeFormBase {
        Content content;
        public ContentDetails() {
            InitializeComponent();
        }

        public ContentDetails(IUPVTubeService service) :base(service) {
            InitializeComponent();
        }

        public ContentDetails(IUPVTubeService service, Content content) : base(service) {
            InitializeComponent();
            this.content = content;
        }

        private void ContentDetails_Load(object sender, EventArgs e) {
            InitialiseLabels();
            Details d = service.DisplayContentDetails(content);
            titleLabel.Text = d.Title;
            authorLabel.Text = d.Author;
            uriLabel.Text = d.Uri;
            descriptionTextBox.Text = d.Description;
            uploadDateLabel.Text = d.UploadDate.ToString();
            stateLabel.Text = d.IsPublic ? "Public" : "Private";
        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label10_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void InitialiseLabels() {
            titleLabel.Text = "";
            authorLabel.Text = "";
            uriLabel.Text = "";
            descriptionTextBox.Text = "";
            uploadDateLabel.Text = "";
            stateLabel.Text = "";
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
