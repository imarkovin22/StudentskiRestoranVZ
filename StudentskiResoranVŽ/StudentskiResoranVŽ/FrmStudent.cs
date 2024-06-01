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
        private List<OrderHistory> _originalOrders;
        private ReviewRepository _reviewsRepository;
        private int _userId;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;

        public FrmStudent(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _meniRepository = new MeniRepository();
            LoadMenus();
            _orderHistoryRepository = new OrderHistoryRepository();
            DisplayOrders();

            lsbOrderHistory.HorizontalScrollbar = true;
            _originalOrders = _orderHistoryRepository.GetAllOrders();

            _reviewsRepository = new ReviewRepository();
            lsbReview.HorizontalScrollbar = true;

            pnlHome.Visible = true;
            pnlCreateOrder.Visible = false;
            pnlOrderHistory.Visible = false;
            pnlReview.Visible = false;

            InitializeTimer();

            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
        }

        private void InitializeTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;

            timer2 = new System.Windows.Forms.Timer();
            timer2.Interval = 1000;
            timer2.Tick += Timer2_Tick;

            timer3 = new System.Windows.Forms.Timer();
            timer3.Interval = 1000;
            timer3.Tick += Timer3_Tick;

            timer4 = new System.Windows.Forms.Timer();
            timer4.Interval = 1000;
            timer4.Tick += Timer4_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblAfterOrderCreatedTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            lblAfterOrderInProgressTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            lblAfterOrderReadyTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            lblAfterOrderServedTime.Text = DateTime.Now.ToString("HH:mm:ss");
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
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();

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
                timer1.Stop();
                pnlAfterOrderCreated.Size = new System.Drawing.Size(342, 75);
                pnlAfterOrderInProgress.Size = new System.Drawing.Size(342, 140);
                pnlAfterOrderInProgress.Location = (Point)new Size(width: 43, height: 130);

                await Task.Delay(5000, _cancellationTokenSource.Token);
                timer2.Stop();
                pnlAfterOrderInProgress.Size = new System.Drawing.Size(342, 75);
                pnlAfterOrderReady.Size = new System.Drawing.Size(342, 142);
                pnlAfterOrderReady.Location = (Point)new Size(width: 43, height: 215);

                await Task.Delay(5000, _cancellationTokenSource.Token);
                timer3.Stop();
                pnlAfterOrderReady.Size = new System.Drawing.Size(342, 75);
                pnlAfterOrderServed.Size = new System.Drawing.Size(342, 142);
                pnlAfterOrderServed.Location = (Point)new Size(width: 43, height: 300);

                await Task.Delay(5000, _cancellationTokenSource.Token);
                timer4.Stop();
                pnlAfterOrderServed.Size = new System.Drawing.Size(342, 75);
                pnlAfterOrderReview.Visible = true;
            } 
            catch{}
        }

        private void btnAfterOrder_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();

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
                string orderDetails = $"ID: {order.OrderId}, Juha: {order.SelectedMeni.Soup}, Glavno jelo: {order.SelectedMeni.Main_Course}, Prilog: {order.SelectedMeni.Side_Dish}, Desert: {order.SelectedMeni.Desert}";

                lsbOrderHistory.Items.Add(orderDetails);
            }
        }

        private void btnOrderHistorySub_Click(object sender, EventArgs e)
        {
            string searchTerm = txtOrderHistorySub.Text.ToLower();

            var filteredOrders = _originalOrders.Where(order =>
                order.SelectedMeni.Soup.ToLower().Contains(searchTerm) ||
                order.SelectedMeni.Main_Course.ToLower().Contains(searchTerm) ||
                order.SelectedMeni.Side_Dish.ToLower().Contains(searchTerm) ||
                order.SelectedMeni.Desert.ToLower().Contains(searchTerm)
            ).ToList();

            DisplayFilteredOrders(filteredOrders);
        }

        private void DisplayFilteredOrders(List<OrderHistory> orders)
        {
            lsbOrderHistory.Items.Clear();

            foreach (var order in orders)
            {
                string orderDetails = $"ID: {order.OrderId}, Juha: {order.SelectedMeni.Soup}, Glavno jelo: {order.SelectedMeni.Main_Course}, Prilog: {order.SelectedMeni.Side_Dish}, Desert: {order.SelectedMeni.Desert}";
                lsbOrderHistory.Items.Add(orderDetails);
            }
        }

        private int GenerateUniqueId()
        {
            Random random = new Random();
            return random.Next(1000, 9999);
        }

        private int GetCurrentUserId()
        {
            return _userId;
        }
        private OrderHistory GetCurrentOrder()
        {
            List<OrderHistory> allOrders = _orderHistoryRepository.GetAllOrders();

            if (allOrders.Count == 0)
            {
                return null;
            }

            OrderHistory currentOrder = allOrders.Last();

            return currentOrder;
        }

        private void btnAfterOrderReview_Click(object sender, EventArgs e)
        {
            string reviewText = txtAfterOrderReview.Text;

            if (string.IsNullOrWhiteSpace(reviewText))
            {
                MessageBox.Show("Unesite recenziju prije slanja!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OrderHistory currentOrder = GetCurrentOrder();

            if (currentOrder != null)
            {
                int orderId = currentOrder.OrderId;
                int userId = GetCurrentUserId();

                if (_reviewsRepository.GetReviewByOrderId(orderId) != null)
                {
                    MessageBox.Show("Samo jedna recenzija po narudžbi!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var review = new Review
                {
                    Id = GenerateUniqueId(),
                    UserId = userId,
                    OrderItemId = orderId,
                    ReviewText = reviewText
                };

                _reviewsRepository.SaveReview(review);

                MessageBox.Show("Recenzija uspješno spremljena!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DisplayReviews();
                txtAfterOrderReview.Text = "";
            }
        }

        private void DisplayReviews()
        {
            lsbReview.Items.Clear();

            List<Review> reviews = _reviewsRepository.GetAllReviews();

            foreach (var review in reviews)
            {
                string reviewDetails = $"ID: {review.Id}, User ID: {review.UserId}, Order ID: {review.OrderItemId}, Recenzija: {review.ReviewText}";
                lsbReview.Items.Add(reviewDetails);
            }
        }

        private void btnReviewDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtReviewDelete.Text))
            {
                int orderIdToDelete;
                if (int.TryParse(txtReviewDelete.Text, out orderIdToDelete))
                {
                    _reviewsRepository.DeleteReviewByOrderId(orderIdToDelete);
                    DisplayReviews();
                }
                else
                {
                    MessageBox.Show("Molimo unesite ispravan ID narudžbe.", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Unesite ID narudžbe koju želite izbrisati.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
