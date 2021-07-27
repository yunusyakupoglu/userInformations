using OL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userInformations
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        List<objUser> users = new List<objUser>();
        public void refresh()
        {
            dgvUserList.DataSource = null;
            if(users.Count>0)
            dgvUserList.DataSource = users;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            refresh();
        }

       

        private void dgvUserList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUserInformations FrmUserInformations = new frmUserInformations();
            FrmUserInformations.user = users[e.RowIndex];

            FrmUserInformations.ShowDialog();
            users[e.RowIndex] = FrmUserInformations.user;
            refresh();
        }

        private void btnUserOperations_Click(object sender, EventArgs e)
        {
            frmUserInformations FrmuserInformations = new frmUserInformations();
            FrmuserInformations.ShowDialog();
            users.Add(FrmuserInformations.user);
            refresh();
        }
    }
}
