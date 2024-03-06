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
    public partial class AddReview : UPVTubeFormBase {
        private string justification = "";
        private Content content;
        private ContentsToReview cont;
        private Reviews r;
        public AddReview()
        {
            InitializeComponent();
        }

        public AddReview(IUPVTubeService service, Content c, ContentsToReview a) : base(service) {
            InitializeComponent();
            content = c;
            cont = a;
        }

        public AddReview(IUPVTubeService service, Content c, Reviews a) : base(service) {
            InitializeComponent();
            content = c;
            r = a;
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

        private void rejectButton_Click(object sender, EventArgs e) {
            service.AddRewiewToPendingContent(content, justification);
            service.RejectContent(content);
            MessageBox.Show
                ("Email sent to " + content.Owner.Nick + "with the justification.", "Justification sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            r.loadContent();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
            r.loadContent();
        }

        private void confirmButton_Click(object sender, EventArgs e) {
            service.AuthoriseContent(content);
            this.Close();
            r.loadContent();
        }

        private void justificationTextBox_TextChanged(object sender, EventArgs e) {
            justification = justificationTextBox.Text;
            rejectButton.Enabled = justification != "";
        }

        private void AddReview_Load(object sender, EventArgs e) {
            rejectButton.Enabled = false;
        }
    }
}
