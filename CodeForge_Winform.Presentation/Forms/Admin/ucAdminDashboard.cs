using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeForge_Winform.CodeForge_Winform.Presentation.Forms.Admin
{
    public partial class ucAdminDashboard : UserControl
    {
        public ucAdminDashboard()
        {
            InitializeComponent();
        }

        private void btnUIUser_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            ucUserManagement ucUser = new ucUserManagement();
            ucUser.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(ucUser);

        }
    }
}
