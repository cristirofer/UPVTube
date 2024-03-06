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
    public partial class newSubject : UPVTubeFormBase {

        private string fullName = "";
        private string code = "";
        private string name = "";
        private UploadContent uploadC;
        private bool codeV = false;
        private bool nameV = false;
        public newSubject() 
        {
            InitializeComponent();
        }

        public newSubject(IUPVTubeService service, UploadContent uploadContent,string fn) : base(service) {
            InitializeComponent();
            fullName = fn;
            uploadC = uploadContent;
            fullNameBox.Text = fn;
            fullNameBox.Enabled = false;
            acceptButton.Enabled = false;

        }
      

        private void UPVTubeFormBase_Load(object sender, EventArgs e) {

        }


        private void closeAdvancedSearch(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void subjectBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void accept(object sender, EventArgs e)
        {
            int c = int.Parse(code);
            Subject s = new Subject(c,fullName,name);
            service.AddSubject(s);
            uploadC.addSubject2(s);
            this.Close();
        }

        private void codeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press if it's not a digit or control key
            }
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {   
            string f = nameBox.Text;
            if(f != "")
            {
                nameV = true;
                name = f;
                if (codeV)
                {
                    acceptButton.Enabled = true;
                }
            } else
            {
                nameV = false;
                acceptButton.Enabled = false;
            }
            
        }

        private void codeBox_TextChanged(object sender, EventArgs e)
        {
            string g = codeBox.Text;
            if (g != "")
            {
                codeV = true;
                code = g;
                if (nameV)
                {
                    acceptButton.Enabled = true;
                }
            }
            else
            {
                codeV = false;
                acceptButton.Enabled = false;
            }
        }
    }
}
