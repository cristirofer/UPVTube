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
using System.Windows;
using UPVTube.Entities;
using UPVTube.Persistence;

namespace UPVTubeGUI {
    public partial class advancedSearchForm : UPVTubeFormBase {

        private DateTime startDate = new DateTime(1753, 1, 1, 0, 0, 0);
        private DateTime endDate  = new DateTime(3450, 1, 1, 0, 0, 0);
        private string nick = "";
        private string wordsTitle = "";
        private string subject = "" ;
        private ListContents contents;
        bool extra = false;
        bool review = false;
        Search s;
        ContentsToReview a;
        public advancedSearchForm() 
        {
            InitializeComponent();
        }

        public advancedSearchForm(IUPVTubeService service, ListContents contents) : base(service) {
            InitializeComponent();
            this.contents = contents;
            extra = true;
            
        }
        public void loadSubjects()
        {   
            subjectBox.Items.Clear();
            List<Subject> subjects = service.GetSubjects();
            foreach (Subject s in subjects)
            {
                subjectBox.Items.Add(s.FullName);
            }
        }
        public advancedSearchForm(IUPVTubeService service) : base(service) {
            InitializeComponent();
        }

        public advancedSearchForm(IUPVTubeService service, Search s) : base(service) {
            InitializeComponent();
            this.s = s;
        }

        public advancedSearchForm(IUPVTubeService service, ContentsToReview s, Search a) : base(service) {
            InitializeComponent();
            this.a = s;
            review = true;
            this.s = a;
        }

        public advancedSearchForm(IUPVTubeService service, string title, Search s) : base(service) {
            InitializeComponent();
            titleBox.Text = title;
            this.s = s;
        }

        private void UPVTubeFormBase_Load(object sender, EventArgs e) {
            loadSubjects();
            datePickerStart.Value = startDate;
        }

        private void startAdvancedSearch(object sender, EventArgs e)
        { 
            if (extra) {
                contents.startDate = this.startDate;
                contents.endDate = this.endDate;
                contents.nick = this.nick;
                contents.wordsTitle = this.wordsTitle;
                contents.subject = this.subject;
                contents.advancedSearchStart();
            } else if (!review) {
                contents = new ListContents(service, wordsTitle, nick, subject, startDate, endDate);
                contents.Show();
                s.Close();
            } else {
                contents = new ListContents(service, wordsTitle, nick, subject, startDate, endDate);
                contents.Show();
                a.Close();
                s.Close();
            }
            this.Close();
        }

        private void closeAdvancedSearch(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void subjectBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void subjectBox_SelectedIndexChanged(object sender, EventArgs e) {
            subject = subjectBox.SelectedItem.ToString();
        }

        private void authorBox_TextChanged(object sender, EventArgs e) {
            nick = authorBox.Text;
        }

        private void titleBox_TextChanged(object sender, EventArgs e) {
            wordsTitle = titleBox.Text;
        }

        private void datePickerStart_ValueChanged(object sender, EventArgs e) {
            startDate = datePickerStart.Value;
        }

        private void datePickerEnd_ValueChanged(object sender, EventArgs e) {
            endDate = datePickerEnd.Value;
        }
    }
}
