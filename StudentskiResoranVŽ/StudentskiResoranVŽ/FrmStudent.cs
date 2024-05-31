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
            pnlAfterOrder.Visible = false;
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

        private void btnReturnReview_Click_1(object sender, EventArgs e)
        {
            pnlReview.Visible = false;
            pnlHome.Visible = true;
        }

        private void chbMeni1_CheckedChanged(object sender, EventArgs e)
        {
            if(chbMeni1.Checked == true)
            {
                chbMeni2.Checked = false;
                chbMeni3.Checked = false;
            }
        }

        private void chbMeni2_CheckedChanged(object sender, EventArgs e)
        {
            if( chbMeni2.Checked == true)
            {
                chbMeni3.Checked = false;
                chbMeni1.Checked = false;
            }
        }

        private void chbMeni3_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMeni3.Checked == true)
            {
                chbMeni1.Checked = false;
                chbMeni2.Checked = false;
            }
        }

        private void bntMakeOrder_Click(object sender, EventArgs e)
        {
            if(chbMeni1.Checked == true || chbMeni2.Checked == true || chbMeni3.Checked == true) 
            {
                pnlAfterOrder.Visible = true;
            }else
            {
                MessageBox.Show("Niste odabrali meni!", "Nemoguće kreiranje narudžbe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            chbMeni1.Checked = false;
            chbMeni2.Checked = false;
            chbMeni3.Checked = false;
        }
    }
}
