using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LibaryBorrowingSystem
{
    public partial class frmReturns : Form
    {
        public frmReturns()
        {
            InitializeComponent();
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmReturns_Load(object sender, EventArgs e)
        {
            if (this.DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;
            // TODO: This line of code loads data into the 'libaryDataSet.borrowrecords' table. You can move, or remove it, as needed.
            this.borrowrecordsTableAdapter.Fill(this.libaryDataSet.borrowrecords);
            // TODO: This line of code loads data into the 'libaryDataSet.members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.libaryDataSet.members);

        }
    }
}
