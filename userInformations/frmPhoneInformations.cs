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
    public partial class frmPhoneInformations : Form
    {
        public objPhone phone = new objPhone();

        public frmPhoneInformations()
        {
            InitializeComponent();
        }

        private void btnPhoneSave_Click(object sender, EventArgs e)
        {
            frmUserInformations FrmUserInformations = new frmUserInformations();
            phone.phoneNumber = txtPhoneNumber.Text;
            phone.phoneType = Convert.ToInt32((cmbPhoneType.SelectedItem as comboboxItem).Value);

            if (cbActive.Checked == true)
                phone.phoneActive = true;
            else
                phone.phoneActive = false;
            this.Close();
            FrmUserInformations.phoneRefresh();
        }

        private void frmPhoneInformations_Load(object sender, EventArgs e)
        {
            comboboxItem item = new OL.comboboxItem();
            item.Text = "İs";
            item.Value = 1;
            //comboBox1.Items.Add(item);
            cmbPhoneType.Items.Add(item);
            item = new comboboxItem();
            item.Text = "Sahsi";
            item.Value = 2;
            //comboBox1.Items.Add(item);
            cmbPhoneType.Items.Add(item);
            txtPhoneNumber.Text = phone.phoneNumber;
            if (phone.phoneActive == true)
                cbActive.Checked = true;
            else
                cbActive.Checked = false;
            if (phone.phoneType == 1)
                cmbPhoneType.SelectedIndex = 0;
            else
                cmbPhoneType.SelectedIndex = 1;



            cmbPhoneType.ValueMember = phone.phoneType.ToString();
            cmbPhoneType.SelectedValue = cmbPhoneType.ValueMember;
        }
    }
}
