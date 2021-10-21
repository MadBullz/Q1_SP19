using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Q1
{
    public partial class frmEdit : Form
    {
        public int corpNo { get; set; }
        public string corpName { get; set; }
        public string street { get; set; }
        public DateTime expiredDate { get; set; }

        CorporationDAO cdb = new CorporationDAO();

        public frmEdit(int corpNo, string corpName, string street, DateTime expr_dt)
        {
            InitializeComponent();
            this.corpNo = corpNo;
            this.corpName = corpName;
            this.street = street;
            this.expiredDate = expr_dt;
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            txtCorpName.Text = corpName;
            txtStreet.Text = street;
            dtpExpiredDate.Value = expiredDate;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Corporation corporation = new Corporation() {
                corpNo = corpNo,
                corpName = txtCorpName.Text,
                expiredDate = dtpExpiredDate.Value,
                street = txtStreet.Text
            };
            if (cdb.updateCorp(corporation) > 0)
            {
                MessageBox.Show("Updated");
            }
            else MessageBox.Show("Failed");
            this.Close();
        }
    }
}
