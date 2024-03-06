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
    public partial class UPVTubeFormBase : Form {
        protected IUPVTubeService service;

        public UPVTubeFormBase() {}

        public UPVTubeFormBase(IUPVTubeService service) :base() {
            InitializeComponent();
            this.service = service;
        }

        private void UPVTubeFormBase_Load(object sender, EventArgs e) {

        }
    }
}
