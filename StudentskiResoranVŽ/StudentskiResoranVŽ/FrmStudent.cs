using System;
using DBLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentskiResoranVŽ.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentskiResoranVŽ
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
            DisplayAllMeniDetails();
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
            if (chbMeni1.Checked == true)
            {
                chbMeni2.Checked = false;
                chbMeni3.Checked = false;
            }
        }

        private void chbMeni2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMeni2.Checked == true)
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

        private async void bntMakeOrder_Click(object sender, EventArgs e)
        {
            if (chbMeni1.Checked == true || chbMeni2.Checked == true || chbMeni3.Checked == true)
            {
                pnlAfterOrder.Visible = true;
            } else
            {
                MessageBox.Show("Niste odabrali meni!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            chbMeni1.Checked = false;
            chbMeni2.Checked = false;
            chbMeni3.Checked = false;

            await Task.Delay(5000);
            pnlAfterOrderCreated.Size = new System.Drawing.Size(342, 81);
            pnlAfterOrderInProgress.Size = new System.Drawing.Size(342, 142);
            pnlAfterOrderInProgress.Location = (Point)new Size(width: 43, height: 140);

            await Task.Delay(5000);
            pnlAfterOrderInProgress.Size = new System.Drawing.Size(342, 81);
            pnlAfterOrderReady.Size = new System.Drawing.Size(342, 142);
            pnlAfterOrderReady.Location = (Point)new Size(width: 43, height: 235);

            await Task.Delay(5000);
            pnlAfterOrderReady.Size = new System.Drawing.Size(342, 81);
            pnlAfterOrderServed.Size = new System.Drawing.Size(342, 142);
            pnlAfterOrderServed.Location = (Point)new Size(width: 43, height: 330);

            await Task.Delay(5000);
            pnlAfterOrderServed.Size = new System.Drawing.Size(342, 81);
        }

        private void btnAfterOrder_Click(object sender, EventArgs e)
        {
            pnlAfterOrder.Visible = false;
            pnlCreateOrder.Visible = true;
        }

        private void DisplayMeniDetails(Meni meni, Label lblSoup, Label lblMainDish, Label lblSideDish, Label lblDesert)
        {
            lblSoup.Text = meni.Soup;
            lblMainDish.Text = meni.Main_Course;
            lblSideDish.Text = meni.Side_Dish;
            lblDesert.Text = meni.Desert;
        }

        private void DisplayAllMeniDetails()
        {
            DisplayMeniDetails(Meni.meni1, lblMeni1Soup, lblMeni1MainDish, lblMeni1SideDish, lblMeni1Desert);
            DisplayMeniDetails(Meni.meni2, lblMeni2Soup, lblMeni2MainDish, lblMeni2SideDish, lblMeni2Desert);
            DisplayMeniDetails(Meni.meni3, lblMeni3Soup, lblMeni3MainDish, lblMeni3SideDish, lblMeni3Desert);
        }
    }
}
