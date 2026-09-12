using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poolTables
{
    public partial class frmRentDetails : Form
    {
        public frmRentDetails()
        {
            InitializeComponent();
        }


        public Action<string, int, int,bool> returnFormData;
        private void btnOk_Click(object sender, EventArgs e)
        {
            returnFormData?.Invoke(txtPlayerName.Text, (int)nudHours.Value, (int)nudMinutes.Value, ckbOpenTime.Checked);
            this.Close();
        }
  

        private void txtPlayerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOk_Click(this, new EventArgs());
            }
        }

        private void nudHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOk_Click(this, new EventArgs());
            }
        }

        private void nudMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOk_Click(this, new EventArgs());
            }
        }

        private void ckbOpenTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOk_Click(this, new EventArgs());
            }
        }

        private void frmRentDetails_Load(object sender, EventArgs e)
        {
            ckbOpenTime.Checked = true;
            nudHours.Enabled = false;
            nudMinutes.Enabled = false;
        }

        private void ckbOpenTime_CheckedChanged(object sender, EventArgs e)
        {
            nudHours.Enabled = !ckbOpenTime.Checked;
            nudMinutes.Enabled = !ckbOpenTime.Checked;
            if (ckbOpenTime.Checked)
            {
                nudHours.Value = 0;
                nudMinutes.Value= 0;
            }
        }
    }
}
