using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiResoranVŽ
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            Close();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            pnlCreateOrder.Visible = true;
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            pnlOrderHistory.Visible = true;
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            pnlReview.Visible = true;
        }

        private void btnReturnCreateOrder_Click(object sender, EventArgs e)
        {
            pnlCreateOrder.Visible = false;
            pnlHome.Visible = true;
        }

        private void btnReturnOrderHistory_Click(object sender, EventArgs e)
        {
            pnlOrderHistory.Visible = false;
            pnlHome.Visible = true;
        }
    }
}
