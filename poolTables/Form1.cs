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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void ctrlPoolTable1_onEndTable(object sender, ctrlPoolTable.TableArgs e)
        {
            MessageBox.Show($"The Table \"{e.tableName}\" that rented by player \"{e.tablePlayer}\" fees is \"{e.fees.ToString("0.00")}\"$ for \"{e.timeInSeconds}\" seconds");
        }

    }
}
