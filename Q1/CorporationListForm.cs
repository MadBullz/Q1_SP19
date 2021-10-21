using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
    public partial class CorporationListForm : Form
    {
        CorporationDAO cdb = new CorporationDAO();
        public CorporationListForm()
        {
            InitializeComponent();
        }

        void Reload()
        {
            dgvCorp.DataSource = cdb.getCorporations();
            dgvCorp.AutoGenerateColumns = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void dgvCorp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int corpNo = Int32.Parse(dgvCorp.CurrentRow.Cells[2].Value.ToString());
                string corpName = dgvCorp.CurrentRow.Cells[3].Value.ToString();
                string street = dgvCorp.CurrentRow.Cells[4].Value.ToString();
                DateTime expr_dt = DateTime.Parse(dgvCorp.CurrentRow.Cells[6].Value.ToString());
                frmEdit fEdit = new frmEdit(corpNo, corpName, street, expr_dt);
                fEdit.ShowDialog();
                Reload();
            }
        }
    }
}
