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
    public partial class frmUserInformations : Form
    {
        public objUser user = new objUser();
        public List<objMail> mails = new List<objMail>();
        public List<objPhone> phones = new List<objPhone>();
        public frmUserInformations()
        {
            InitializeComponent();
        }
        public void mailRefresh()
        {
            dvMail.DataSource = null;
            if (mails.Count > 0)
                dvMail.DataSource = mails;
        }
        public void phoneRefresh()
        {
            dvPhone.DataSource = null;
            if (mails.Count > 0)
                dvPhone.DataSource = phones;
        }
        private void btnUserSave_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            user.name = txtName.Text;
            user.Surname = txtSurname.Text;
            if (rbMale.Checked)
                user.gender = 1;
            this.Close();
            frmMain.refresh();
        }

        private void frmUserInformations_Load(object sender, EventArgs e)
        {
            txtName.Text = user.name;
            txtSurname.Text = user.Surname;
            if (user.gender == 1)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;
        }

        private void btnMailInformations_Click(object sender, EventArgs e)
        {
            frmMailInformations FrmMailInformations = new frmMailInformations();
            FrmMailInformations.ShowDialog();
            mails.Add(FrmMailInformations.mail);
            mailRefresh();
        }

        private void dvMail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMailInformations FrmMailInformations = new frmMailInformations();
            FrmMailInformations.mail = mails[e.RowIndex];

            FrmMailInformations.ShowDialog();
            mails[e.RowIndex] = FrmMailInformations.mail;
            mailRefresh();
        }

        private void btnPhoneOperations_Click(object sender, EventArgs e)
        {
            frmPhoneInformations FrmPhoneInformations = new frmPhoneInformations();
            FrmPhoneInformations.ShowDialog();
            phones.Add(FrmPhoneInformations.phone);
            phoneRefresh();
        }

        private void dvPhone_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmPhoneInformations FrmPhoneInformations = new frmPhoneInformations();
            FrmPhoneInformations.phone = phones[e.RowIndex];

            FrmPhoneInformations.ShowDialog();
            phones[e.RowIndex] = FrmPhoneInformations.phone;
            phoneRefresh();
        }
    }
}
