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
using System.Threading;
using StudentskiResoranVŽ.Repositories;

namespace StudentskiResoranVŽ
{
    public partial class FrmStudent : Form
    {

        private MeniRepository _meniRepository;
        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private OrderHistoryRepository _orderHistoryRepository;

        public FrmStudent()
        {
            InitializeComponent();
            _meniRepository = new MeniRepository();
            LoadMenus();
            _orderHistoryRepository = new OrderHistoryRepository();
            DisplayOrders();
        }

        private void LoadMenus()
        {
            var menus = _meniRepository.GetAllMenus();

            if (menus.Count >= 1)
            {
                DisplayMeniDetails(menus[0], lblMeni1Soup, lblMeni1MainDish, lblMeni1SideDish, lblMeni1Desert);
            }

            if (menus.Count >= 2)
            {
                DisplayMeniDetails(menus[1], lblMeni2Soup, lblMeni2MainDish, lblMeni2SideDish, lblMeni2Desert);
            }

            if (menus.Count >= 3)
            {
                DisplayMeniDetails(menus[2], lblMeni3Soup, lblMeni3MainDish, lblMeni3SideDish, lblMeni3Desert);
            }
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
            pnlOrderHistory.Visible = false;
            pnlReview.Visible = false;
            pnlAfterOrder.Visible = false;
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            pnlReview.Visible = false;
            pnlOrderHistory.Visible = true;
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            pnlOrderHistory.Visible = false;
            pnlReview.Visible = true;
        }

        private void btnReturnCreateOrder_Click(object sender, EventArgs e)
        {
            StopTask();
            pnlCreateOrder.Visible = false;
            pnlHome.Visible = true;

            pnlAfterOrderCreated.Size = new System.Drawing.Size(342, 142);
            pnlAfterOrderCreated.Location = new Point(43, 43);
            pnlAfterOrderInProgress.Size = new System.Drawing.Size(342, 81);
            pnlAfterOrderInProgress.Location = new Point(43, 201);
            pnlAfterOrderReady.Size = new System.Drawing.Size(342, 81);
            pnlAfterOrderReady.Location = new Point(43, 301);
            pnlAfterOrderServed.Size = new System.Drawing.Size(342, 81);
            pnlAfterOrderServed.Location = new Point(43, 401);
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
            if (chbMeni1.Checked)
            {
                chbMeni2.Checked = false;
                chbMeni3.Checked = false;
            }
        }

        private void chbMeni2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMeni2.Checked)
            {
                chbMeni3.Checked = false;
                chbMeni1.Checked = false;
            }
        }

        private void chbMeni3_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMeni3.Checked)
            {
                chbMeni1.Checked = false;
                chbMeni2.Checked = false;
            }
        }

        private async void bntMakeOrder_Click(object sender, EventArgs e)
        {
            if (chbMeni1.Checked || chbMeni2.Checked || chbMeni3.Checked)
            {

                int selectedMeniId = -1;
                if (chbMeni1.Checked) selectedMeniId = 1;
                else if (chbMeni2.Checked) selectedMeniId = 2;
                else if (chbMeni3.Checked) selectedMeniId = 3;

                var order = new OrderHistory
                {
                    SelectedMeni = _meniRepository.GetMeniById(selectedMeniId),
                };

                _orderHistoryRepository.SaveOrder(order);

                DisplayOrders();

                pnlAfterOrder.Visible = true;
            } 
            else
            {
                MessageBox.Show("Niste odabrali meni!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            chbMeni1.Checked = false;
            chbMeni2.Checked = false;
            chbMeni3.Checked = false;

            pnlAfterOrderReview.Visible = false;

            try
            {
                await Task.Delay(5000, _cancellationTokenSource.Token);
                pnlAfterOrderCreated.Size = new System.Drawing.Size(342, 75);
                pnlAfterOrderInProgress.Size = new System.Drawing.Size(342, 140);
                pnlAfterOrderInProgress.Location = (Point)new Size(width: 43, height: 130);

                await Task.Delay(5000, _cancellationTokenSource.Token);
                pnlAfterOrderInProgress.Size = new System.Drawing.Size(342, 75);
                pnlAfterOrderReady.Size = new System.Drawing.Size(342, 142);
                pnlAfterOrderReady.Location = (Point)new Size(width: 43, height: 215);

                await Task.Delay(5000, _cancellationTokenSource.Token);
                pnlAfterOrderReady.Size = new System.Drawing.Size(342, 75);
                pnlAfterOrderServed.Size = new System.Drawing.Size(342, 142);
                pnlAfterOrderServed.Location = (Point)new Size(width: 43, height: 300);

                await Task.Delay(5000, _cancellationTokenSource.Token);
                pnlAfterOrderServed.Size = new System.Drawing.Size(342, 75);
                pnlAfterOrderReview.Visible = true;
            } 
            catch{}
        }

        private void btnAfterOrder_Click(object sender, EventArgs e)
        {
            StopTask();
            pnlAfterOrderReview.Visible = false;
            pnlAfterOrder.Visible = false;
            pnlCreateOrder.Visible = true;

            pnlAfterOrderCreated.Size = new System.Drawing.Size(342, 142);
            pnlAfterOrderCreated.Location = new Point(43, 43);
            pnlAfterOrderInProgress.Size = new System.Drawing.Size(342, 81);
            pnlAfterOrderInProgress.Location = new Point(43, 201);
            pnlAfterOrderReady.Size = new System.Drawing.Size(342, 81);
            pnlAfterOrderReady.Location = new Point(43, 301);
            pnlAfterOrderServed.Size = new System.Drawing.Size(342, 81);
            pnlAfterOrderServed.Location = new Point(43, 401);
        }

        private void DisplayMeniDetails(Meni meni, Label lblSoup, Label lblMainDish, Label lblSideDish, Label lblDesert)
        {
            lblSoup.Text = meni.Soup;
            lblMainDish.Text = meni.Main_Course;
            lblSideDish.Text = meni.Side_Dish;
            lblDesert.Text = meni.Desert;
        }

        private void StopTask()
        {
            if (_cancellationTokenSource != null)
            {
                _cancellationTokenSource.Cancel();
                _cancellationTokenSource = new CancellationTokenSource();
            }
        }

        private void DisplayOrders()
        {
            lsbOrderHistory.Items.Clear();

            var orders = _orderHistoryRepository.GetAllOrders();

            foreach (var order in orders)
            {
                string orderDetails = $"Order ID: {order.OrderId}, Soup: {order.SelectedMeni.Soup}, Main Course: {order.SelectedMeni.Main_Course}, Side Dish: {order.SelectedMeni.Side_Dish}, Dessert: {order.SelectedMeni.Desert}";

                lsbOrderHistory.Items.Add(orderDetails);
            }
        }
    }
}
