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
using System.Threading;
using Timer = System.Threading.Timer;
namespace UPVTubeGUI {
    public partial class UploadContent : UPVTubeFormBase {
        private string title = "";
        private string description = "";
        private List<Subject> subjects = new List<Subject>();
        private string uri = "";
        private bool isPublic = false;
        private List<Subject> ss;
        private string sss = "";
        private Subject su = new Subject();
        private string sub = "";
        public Subject puSubject;
        private bool maxSubjects = false;

        public UploadContent()
        {
            InitializeComponent();
        }
        public UploadContent(IUPVTubeService service) :base(service) {
            InitializeComponent();
            addSubject.Enabled = false;
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

        private void UploadContent_Load(object sender, EventArgs e)
        {   
            
            ss = service.GetSubjects();
            foreach (Subject s in ss) {
                subjectsComboBox.Items.Add(s.FullName);
            }
            

            confirmButton.Enabled = false;
            //subjectsListView.Items.Add(new ListViewItem("Selected subjects:"));
            deleteSubject.Enabled = false;
        }

        private void subjectTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e) {
            service.UploadNewContent(title, description, uri, isPublic, subjects);
            MessageBox.Show
                ("The content has been uploaded successfully.", "Content uploaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void titleTextbox_TextChanged(object sender, EventArgs e) {
            title = titleTextbox.Text;
            CheckButton();
        }

        private void publicButton_CheckedChanged(object sender, EventArgs e) {
            isPublic = publicButton.Checked;
        }

        private void CheckButton() {
            bool b = title == "" || description == "" || uri == "";
            confirmButton.Enabled = !b;
        }

        private void descTextbox_TextChanged(object sender, EventArgs e) {
            description = descTextbox.Text;
            CheckButton();
        }

        private void URITextbox_TextChanged(object sender, EventArgs e) {
            uri = URITextbox.Text;
            CheckButton();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void subjectsComboBox_Click(object sender, EventArgs e) {
            
        }

        private void deleteSubject_Click(object sender, EventArgs e) {
            try {
                foreach (Subject s in subjects)
                {
                    if (sss == s.FullName)
                    {
                        maxSubjects = false;
                        subjects.Remove(s);
                        for (int i = 0; i < subjectsListView.Items.Count; i++)
                        {
                            if (subjectsListView.Items[i].Text == sss)
                            {
                                subjectsListView.Items.RemoveAt(i);
                                subjectsComboBox.Items.Add(sss);
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

            }

            try {
                //if (subjectsListView.SelectedItems[0].Index > 0) {
                    deleteSubject.Enabled = true;
                    sss = subjectsListView.SelectedItems[0].Text;
                //} else {
                 //   deleteSubject.Enabled = false;
               // }
            } catch (Exception) {
                deleteSubject.Enabled = false;
            }

            
        }

        private void subjectsListView_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                //if (subjectsListView.SelectedItems[0].Index > 0) {
                    deleteSubject.Enabled = true;
                    sss = subjectsListView.SelectedItems[0].Text;
                //} else {
                //    deleteSubject.Enabled = false;
               // }
            } catch (Exception) {
                deleteSubject.Enabled = false;
            }
        }

        private void checkNewSubject(object sender, EventArgs e)
        {
            sub = subjectsComboBox.Text.ToString();
        }

        private void addSubjectToContentSubjects(object sender, EventArgs e)
        {
            ss = service.GetSubjects();
            bool subjectExisted = false;
            foreach(Subject s in ss)
            {
                if(s.FullName == sub || subjectsComboBox.SelectedItem != null)
                {
                    subjectExisted = true;
                    break;
                }
            }
            if (!subjectExisted)
            {
                UPVTubeFormBase advancedSearch = new newSubject(service, this, sub);
                advancedSearch.ShowDialog();
            }
            else
            {
                Subject q = su;
                addSubject2(q);
            }
        }

        public void addSubject2(Subject a)
        {
            subjects.Add(a);
            subjectsListView.Items.Add(new ListViewItem(a.FullName));
            if(subjects.Count == 3)
            {
                maxSubjects = true;
            }
            for (int i = 0; i < subjectsComboBox.Items.Count; i++)
            {
                if (subjectsComboBox.Items[i].Equals(subjectsComboBox.SelectedItem))
                {
                    subjectsComboBox.SelectedItem = null;
                    subjectsComboBox.Items.RemoveAt(i);
                }
            }
            subjectsComboBox.Text = "";

        }

        private void newSelectedSubject(object sender, EventArgs e)
        {
            ss = service.GetSubjects();
            subjectsComboBox.Text = "";
            if (subjectsComboBox.SelectedItem == null)
            {
                return;
            }
            string selected = subjectsComboBox.SelectedItem.ToString();
            if (selected == "")
                return;
            foreach (Subject s in ss)
            {
                if (selected == s.FullName)
                {
                    su = s; break;
                }
            }
            selected = "";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void checkSubjects(object sender, EventArgs e)
        {
            if (maxSubjects == true) { addSubject.Enabled = false; }
            else if (subjectsComboBox.SelectedIndex != -1 || subjectsComboBox.Text != "")
            {
                addSubject.Enabled = true;
            }
            else
            {
                addSubject.Enabled = false;
            }
        }
    }
}
