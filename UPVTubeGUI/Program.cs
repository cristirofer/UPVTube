using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVTube.Services;
using UPVTube.Persistence;

namespace UPVTubeGUI {
    internal static class Program {
        public static UPVTubeFormBase Login;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() {
            IUPVTubeService service = new UPVTubeService(new EntityFrameworkDAL(new UPVTubeDbContext()));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Login = new Login(service));
        }
    }
}
