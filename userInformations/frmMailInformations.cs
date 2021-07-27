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
    public partial class frmMailInformations : Form
    {
        public objMail mail = new objMail();
        public frmMailInformations()
        {
            InitializeComponent();
        }

        private void frmMailInformations_Load(object sender, EventArgs e)
        {
            
            comboboxItem item = new OL.comboboxItem();
            item.Text = "İs";
            item.Value = 1;
            //comboBox1.Items.Add(item);
            cmbMailType.Items.Add(item);
            item = new comboboxItem();
            item.Text = "Sahsi";
            item.Value = 2;
            //comboBox1.Items.Add(item);
            cmbMailType.Items.Add(item); 
            txtMailAddress.Text = mail.mailAddress;
            if (mail.mailActive == true)
                cbActive.Checked = true;
            else
                cbActive.Checked = false;
            if (mail.mailType == 1)
                cmbMailType.SelectedIndex = 0;
            else
                cmbMailType.SelectedIndex = 1;



            cmbMailType.ValueMember = mail.mailType.ToString();
            cmbMailType.SelectedValue = cmbMailType.ValueMember;



        }

        private void btnMailSave_Click(object sender, EventArgs e)
        {
            frmUserInformations FrmUserInformations = new frmUserInformations();
            mail.mailAddress = txtMailAddress.Text;
            mail.mailType =Convert.ToInt32((cmbMailType.SelectedItem as comboboxItem).Value);
            
            if (cbActive.Checked == true)
                mail.mailActive = true;
            else
                mail.mailActive = false;
            this.Close();
            FrmUserInformations.mailRefresh();
        }
    }
}
