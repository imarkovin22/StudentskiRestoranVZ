namespace StudentskiResoranVŽ
{
    partial class FrmStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAppName = new System.Windows.Forms.Label();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.pnlCreateOrder = new System.Windows.Forms.Panel();
            this.lblMeni = new System.Windows.Forms.Label();
            this.btnReturnCreateOrder = new System.Windows.Forms.Button();
            this.pnlOrderHistory = new System.Windows.Forms.Panel();
            this.btnReturnOrderHistory = new System.Windows.Forms.Button();
            this.pnlReview = new System.Windows.Forms.Panel();
            this.btnReturnReview = new System.Windows.Forms.Button();
            this.pnlHome.SuspendLayout();
            this.pnlCreateOrder.SuspendLayout();
            this.pnlOrderHistory.SuspendLayout();
            this.pnlReview.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Location = new System.Drawing.Point(300, 21);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(120, 13);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "Studentski Restoran VŽ";
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(239, 75);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(244, 127);
            this.btnCreateOrder.TabIndex = 1;
            this.btnCreateOrder.Text = "Kreiranje narudžbe";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.Location = new System.Drawing.Point(239, 237);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Size = new System.Drawing.Size(244, 127);
            this.btnOrderHistory.TabIndex = 2;
            this.btnOrderHistory.Text = "Pregled prijašnjih narudžbi";
            this.btnOrderHistory.UseVisualStyleBackColor = true;
            this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(239, 403);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(244, 127);
            this.btnReview.TabIndex = 3;
            this.btnReview.Text = "Recenzije";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(630, 531);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Odjava";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.lblAppName);
            this.pnlHome.Controls.Add(this.btnCreateOrder);
            this.pnlHome.Controls.Add(this.btnOrderHistory);
            this.pnlHome.Controls.Add(this.btnReview);
            this.pnlHome.Controls.Add(this.btnLogout);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHome.Location = new System.Drawing.Point(0, 0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(717, 565);
            this.pnlHome.TabIndex = 5;
            // 
            // pnlCreateOrder
            // 
            this.pnlCreateOrder.Controls.Add(this.lblMeni);
            this.pnlCreateOrder.Controls.Add(this.btnReturnCreateOrder);
            this.pnlCreateOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCreateOrder.Location = new System.Drawing.Point(0, 0);
            this.pnlCreateOrder.Name = "pnlCreateOrder";
            this.pnlCreateOrder.Size = new System.Drawing.Size(717, 565);
            this.pnlCreateOrder.TabIndex = 5;
            this.pnlCreateOrder.Visible = false;
            // 
            // lblMeni
            // 
            this.lblMeni.AutoSize = true;
            this.lblMeni.Location = new System.Drawing.Point(336, 34);
            this.lblMeni.Name = "lblMeni";
            this.lblMeni.Size = new System.Drawing.Size(30, 13);
            this.lblMeni.TabIndex = 6;
            this.lblMeni.Text = "Meni";
            // 
            // btnReturnCreateOrder
            // 
            this.btnReturnCreateOrder.Location = new System.Drawing.Point(630, 530);
            this.btnReturnCreateOrder.Name = "btnReturnCreateOrder";
            this.btnReturnCreateOrder.Size = new System.Drawing.Size(75, 23);
            this.btnReturnCreateOrder.TabIndex = 5;
            this.btnReturnCreateOrder.Text = "Povratak";
            this.btnReturnCreateOrder.UseVisualStyleBackColor = true;
            this.btnReturnCreateOrder.Click += new System.EventHandler(this.btnReturnCreateOrder_Click);
            // 
            // pnlOrderHistory
            // 
            this.pnlOrderHistory.Controls.Add(this.btnReturnOrderHistory);
            this.pnlOrderHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderHistory.Location = new System.Drawing.Point(0, 0);
            this.pnlOrderHistory.Name = "pnlOrderHistory";
            this.pnlOrderHistory.Size = new System.Drawing.Size(717, 565);
            this.pnlOrderHistory.TabIndex = 5;
            // 
            // btnReturnOrderHistory
            // 
            this.btnReturnOrderHistory.Location = new System.Drawing.Point(630, 530);
            this.btnReturnOrderHistory.Name = "btnReturnOrderHistory";
            this.btnReturnOrderHistory.Size = new System.Drawing.Size(75, 23);
            this.btnReturnOrderHistory.TabIndex = 6;
            this.btnReturnOrderHistory.Text = "Povratak";
            this.btnReturnOrderHistory.UseVisualStyleBackColor = true;
            this.btnReturnOrderHistory.Click += new System.EventHandler(this.btnReturnOrderHistory_Click);
            // 
            // pnlReview
            // 
            this.pnlReview.Controls.Add(this.btnReturnReview);
            this.pnlReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReview.Location = new System.Drawing.Point(0, 0);
            this.pnlReview.Name = "pnlReview";
            this.pnlReview.Size = new System.Drawing.Size(717, 565);
            this.pnlReview.TabIndex = 5;
            // 
            // btnReturnReview
            // 
            this.btnReturnReview.Location = new System.Drawing.Point(630, 530);
            this.btnReturnReview.Name = "btnReturnReview";
            this.btnReturnReview.Size = new System.Drawing.Size(75, 23);
            this.btnReturnReview.TabIndex = 6;
            this.btnReturnReview.Text = "Povratak";
            this.btnReturnReview.UseVisualStyleBackColor = true;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 565);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlCreateOrder);
            this.Controls.Add(this.pnlOrderHistory);
            this.Controls.Add(this.pnlReview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStudent";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studentski Restoran VŽ";
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.pnlCreateOrder.ResumeLayout(false);
            this.pnlCreateOrder.PerformLayout();
            this.pnlOrderHistory.ResumeLayout(false);
            this.pnlReview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnOrderHistory;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlCreateOrder;
        private System.Windows.Forms.Button btnReturnCreateOrder;
        private System.Windows.Forms.Label lblMeni;
        private System.Windows.Forms.Panel pnlOrderHistory;
        private System.Windows.Forms.Button btnReturnOrderHistory;
        private System.Windows.Forms.Panel pnlReview;
        private System.Windows.Forms.Button btnReturnReview;
    }
}