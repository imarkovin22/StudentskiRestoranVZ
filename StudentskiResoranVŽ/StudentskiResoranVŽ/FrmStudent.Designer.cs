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
            this.bntMakeOrder = new System.Windows.Forms.Button();
            this.lblMeni3Desert = new System.Windows.Forms.Label();
            this.lblMeni3SideDish = new System.Windows.Forms.Label();
            this.lblMeni3MainDish = new System.Windows.Forms.Label();
            this.lblMeni3Soup = new System.Windows.Forms.Label();
            this.lblMeni2Desert = new System.Windows.Forms.Label();
            this.lblMeni2SideDish = new System.Windows.Forms.Label();
            this.lblMeni2MainDish = new System.Windows.Forms.Label();
            this.lblMeni2Soup = new System.Windows.Forms.Label();
            this.lblMeni1Desert = new System.Windows.Forms.Label();
            this.lblMeni1SideDish = new System.Windows.Forms.Label();
            this.lblMeni1MainDish = new System.Windows.Forms.Label();
            this.lblMeni1Soup = new System.Windows.Forms.Label();
            this.chbMeni3 = new System.Windows.Forms.CheckBox();
            this.chbMeni2 = new System.Windows.Forms.CheckBox();
            this.chbMeni1 = new System.Windows.Forms.CheckBox();
            this.lblMeni = new System.Windows.Forms.Label();
            this.btnReturnCreateOrder = new System.Windows.Forms.Button();
            this.pnlOrderHistory = new System.Windows.Forms.Panel();
            this.btnReturnOrderHistory = new System.Windows.Forms.Button();
            this.pnlReview = new System.Windows.Forms.Panel();
            this.btnReturnReview = new System.Windows.Forms.Button();
            this.pnlMeni1 = new System.Windows.Forms.Panel();
            this.pnlMeni2 = new System.Windows.Forms.Panel();
            this.pnlMeni3 = new System.Windows.Forms.Panel();
            this.pnlHome.SuspendLayout();
            this.pnlCreateOrder.SuspendLayout();
            this.pnlOrderHistory.SuspendLayout();
            this.pnlReview.SuspendLayout();
            this.pnlMeni1.SuspendLayout();
            this.pnlMeni2.SuspendLayout();
            this.pnlMeni3.SuspendLayout();
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
            this.pnlCreateOrder.Controls.Add(this.pnlMeni3);
            this.pnlCreateOrder.Controls.Add(this.pnlMeni2);
            this.pnlCreateOrder.Controls.Add(this.pnlMeni1);
            this.pnlCreateOrder.Controls.Add(this.bntMakeOrder);
            this.pnlCreateOrder.Controls.Add(this.lblMeni);
            this.pnlCreateOrder.Controls.Add(this.btnReturnCreateOrder);
            this.pnlCreateOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCreateOrder.Location = new System.Drawing.Point(0, 0);
            this.pnlCreateOrder.Name = "pnlCreateOrder";
            this.pnlCreateOrder.Size = new System.Drawing.Size(717, 565);
            this.pnlCreateOrder.TabIndex = 5;
            this.pnlCreateOrder.Visible = false;
            // 
            // bntMakeOrder
            // 
            this.bntMakeOrder.Location = new System.Drawing.Point(292, 529);
            this.bntMakeOrder.Name = "bntMakeOrder";
            this.bntMakeOrder.Size = new System.Drawing.Size(128, 24);
            this.bntMakeOrder.TabIndex = 22;
            this.bntMakeOrder.Text = "Kreiraj narudžbu";
            this.bntMakeOrder.UseVisualStyleBackColor = true;
            // 
            // lblMeni3Desert
            // 
            this.lblMeni3Desert.AutoSize = true;
            this.lblMeni3Desert.Location = new System.Drawing.Point(69, 116);
            this.lblMeni3Desert.Name = "lblMeni3Desert";
            this.lblMeni3Desert.Size = new System.Drawing.Size(38, 13);
            this.lblMeni3Desert.TabIndex = 21;
            this.lblMeni3Desert.Text = "Desert";
            // 
            // lblMeni3SideDish
            // 
            this.lblMeni3SideDish.AutoSize = true;
            this.lblMeni3SideDish.Location = new System.Drawing.Point(69, 97);
            this.lblMeni3SideDish.Name = "lblMeni3SideDish";
            this.lblMeni3SideDish.Size = new System.Drawing.Size(33, 13);
            this.lblMeni3SideDish.TabIndex = 20;
            this.lblMeni3SideDish.Text = "Prilog";
            // 
            // lblMeni3MainDish
            // 
            this.lblMeni3MainDish.AutoSize = true;
            this.lblMeni3MainDish.Location = new System.Drawing.Point(69, 75);
            this.lblMeni3MainDish.Name = "lblMeni3MainDish";
            this.lblMeni3MainDish.Size = new System.Drawing.Size(60, 13);
            this.lblMeni3MainDish.TabIndex = 19;
            this.lblMeni3MainDish.Text = "Glavno jelo";
            // 
            // lblMeni3Soup
            // 
            this.lblMeni3Soup.AutoSize = true;
            this.lblMeni3Soup.Location = new System.Drawing.Point(69, 53);
            this.lblMeni3Soup.Name = "lblMeni3Soup";
            this.lblMeni3Soup.Size = new System.Drawing.Size(30, 13);
            this.lblMeni3Soup.TabIndex = 18;
            this.lblMeni3Soup.Text = "Juha";
            // 
            // lblMeni2Desert
            // 
            this.lblMeni2Desert.AutoSize = true;
            this.lblMeni2Desert.Location = new System.Drawing.Point(70, 109);
            this.lblMeni2Desert.Name = "lblMeni2Desert";
            this.lblMeni2Desert.Size = new System.Drawing.Size(38, 13);
            this.lblMeni2Desert.TabIndex = 17;
            this.lblMeni2Desert.Text = "Desert";
            // 
            // lblMeni2SideDish
            // 
            this.lblMeni2SideDish.AutoSize = true;
            this.lblMeni2SideDish.Location = new System.Drawing.Point(70, 90);
            this.lblMeni2SideDish.Name = "lblMeni2SideDish";
            this.lblMeni2SideDish.Size = new System.Drawing.Size(33, 13);
            this.lblMeni2SideDish.TabIndex = 16;
            this.lblMeni2SideDish.Text = "Prilog";
            // 
            // lblMeni2MainDish
            // 
            this.lblMeni2MainDish.AutoSize = true;
            this.lblMeni2MainDish.Location = new System.Drawing.Point(70, 68);
            this.lblMeni2MainDish.Name = "lblMeni2MainDish";
            this.lblMeni2MainDish.Size = new System.Drawing.Size(60, 13);
            this.lblMeni2MainDish.TabIndex = 15;
            this.lblMeni2MainDish.Text = "Glavno jelo";
            // 
            // lblMeni2Soup
            // 
            this.lblMeni2Soup.AutoSize = true;
            this.lblMeni2Soup.Location = new System.Drawing.Point(70, 46);
            this.lblMeni2Soup.Name = "lblMeni2Soup";
            this.lblMeni2Soup.Size = new System.Drawing.Size(30, 13);
            this.lblMeni2Soup.TabIndex = 14;
            this.lblMeni2Soup.Text = "Juha";
            // 
            // lblMeni1Desert
            // 
            this.lblMeni1Desert.AutoSize = true;
            this.lblMeni1Desert.Location = new System.Drawing.Point(70, 112);
            this.lblMeni1Desert.Name = "lblMeni1Desert";
            this.lblMeni1Desert.Size = new System.Drawing.Size(38, 13);
            this.lblMeni1Desert.TabIndex = 13;
            this.lblMeni1Desert.Text = "Desert";
            // 
            // lblMeni1SideDish
            // 
            this.lblMeni1SideDish.AutoSize = true;
            this.lblMeni1SideDish.Location = new System.Drawing.Point(70, 93);
            this.lblMeni1SideDish.Name = "lblMeni1SideDish";
            this.lblMeni1SideDish.Size = new System.Drawing.Size(33, 13);
            this.lblMeni1SideDish.TabIndex = 12;
            this.lblMeni1SideDish.Text = "Prilog";
            // 
            // lblMeni1MainDish
            // 
            this.lblMeni1MainDish.AutoSize = true;
            this.lblMeni1MainDish.Location = new System.Drawing.Point(70, 71);
            this.lblMeni1MainDish.Name = "lblMeni1MainDish";
            this.lblMeni1MainDish.Size = new System.Drawing.Size(60, 13);
            this.lblMeni1MainDish.TabIndex = 11;
            this.lblMeni1MainDish.Text = "Glavno jelo";
            // 
            // lblMeni1Soup
            // 
            this.lblMeni1Soup.AutoSize = true;
            this.lblMeni1Soup.Location = new System.Drawing.Point(70, 49);
            this.lblMeni1Soup.Name = "lblMeni1Soup";
            this.lblMeni1Soup.Size = new System.Drawing.Size(30, 13);
            this.lblMeni1Soup.TabIndex = 10;
            this.lblMeni1Soup.Text = "Juha";
            // 
            // chbMeni3
            // 
            this.chbMeni3.AutoSize = true;
            this.chbMeni3.Location = new System.Drawing.Point(42, 17);
            this.chbMeni3.Name = "chbMeni3";
            this.chbMeni3.Size = new System.Drawing.Size(58, 17);
            this.chbMeni3.TabIndex = 9;
            this.chbMeni3.Text = "Meni 3";
            this.chbMeni3.UseVisualStyleBackColor = true;
            this.chbMeni3.CheckedChanged += new System.EventHandler(this.chbMeni3_CheckedChanged);
            // 
            // chbMeni2
            // 
            this.chbMeni2.AutoSize = true;
            this.chbMeni2.Location = new System.Drawing.Point(43, 11);
            this.chbMeni2.Name = "chbMeni2";
            this.chbMeni2.Size = new System.Drawing.Size(58, 17);
            this.chbMeni2.TabIndex = 8;
            this.chbMeni2.Text = "Meni 2";
            this.chbMeni2.UseVisualStyleBackColor = true;
            this.chbMeni2.CheckedChanged += new System.EventHandler(this.chbMeni2_CheckedChanged);
            // 
            // chbMeni1
            // 
            this.chbMeni1.AutoSize = true;
            this.chbMeni1.Location = new System.Drawing.Point(43, 20);
            this.chbMeni1.Name = "chbMeni1";
            this.chbMeni1.Size = new System.Drawing.Size(58, 17);
            this.chbMeni1.TabIndex = 7;
            this.chbMeni1.Text = "Meni 1";
            this.chbMeni1.UseVisualStyleBackColor = true;
            this.chbMeni1.CheckedChanged += new System.EventHandler(this.chbMeni1_CheckedChanged);
            // 
            // lblMeni
            // 
            this.lblMeni.AutoSize = true;
            this.lblMeni.Location = new System.Drawing.Point(355, 34);
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
            // pnlMeni1
            // 
            this.pnlMeni1.BackColor = System.Drawing.Color.Silver;
            this.pnlMeni1.Controls.Add(this.lblMeni1Desert);
            this.pnlMeni1.Controls.Add(this.lblMeni1SideDish);
            this.pnlMeni1.Controls.Add(this.lblMeni1MainDish);
            this.pnlMeni1.Controls.Add(this.lblMeni1Soup);
            this.pnlMeni1.Controls.Add(this.chbMeni1);
            this.pnlMeni1.Location = new System.Drawing.Point(165, 55);
            this.pnlMeni1.Name = "pnlMeni1";
            this.pnlMeni1.Size = new System.Drawing.Size(416, 146);
            this.pnlMeni1.TabIndex = 23;
            // 
            // pnlMeni2
            // 
            this.pnlMeni2.BackColor = System.Drawing.Color.Silver;
            this.pnlMeni2.Controls.Add(this.lblMeni2Desert);
            this.pnlMeni2.Controls.Add(this.lblMeni2SideDish);
            this.pnlMeni2.Controls.Add(this.lblMeni2MainDish);
            this.pnlMeni2.Controls.Add(this.lblMeni2Soup);
            this.pnlMeni2.Controls.Add(this.chbMeni2);
            this.pnlMeni2.Location = new System.Drawing.Point(165, 203);
            this.pnlMeni2.Name = "pnlMeni2";
            this.pnlMeni2.Size = new System.Drawing.Size(416, 146);
            this.pnlMeni2.TabIndex = 24;
            // 
            // pnlMeni3
            // 
            this.pnlMeni3.BackColor = System.Drawing.Color.Silver;
            this.pnlMeni3.Controls.Add(this.lblMeni3Desert);
            this.pnlMeni3.Controls.Add(this.lblMeni3SideDish);
            this.pnlMeni3.Controls.Add(this.lblMeni3MainDish);
            this.pnlMeni3.Controls.Add(this.lblMeni3Soup);
            this.pnlMeni3.Controls.Add(this.chbMeni3);
            this.pnlMeni3.Location = new System.Drawing.Point(165, 351);
            this.pnlMeni3.Name = "pnlMeni3";
            this.pnlMeni3.Size = new System.Drawing.Size(416, 146);
            this.pnlMeni3.TabIndex = 25;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 565);
            this.Controls.Add(this.pnlCreateOrder);
            this.Controls.Add(this.pnlHome);
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
            this.pnlMeni1.ResumeLayout(false);
            this.pnlMeni1.PerformLayout();
            this.pnlMeni2.ResumeLayout(false);
            this.pnlMeni2.PerformLayout();
            this.pnlMeni3.ResumeLayout(false);
            this.pnlMeni3.PerformLayout();
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
        private System.Windows.Forms.Label lblMeni1Soup;
        private System.Windows.Forms.CheckBox chbMeni3;
        private System.Windows.Forms.CheckBox chbMeni2;
        private System.Windows.Forms.CheckBox chbMeni1;
        private System.Windows.Forms.Label lblMeni1Desert;
        private System.Windows.Forms.Label lblMeni1SideDish;
        private System.Windows.Forms.Label lblMeni1MainDish;
        private System.Windows.Forms.Label lblMeni2Desert;
        private System.Windows.Forms.Label lblMeni2SideDish;
        private System.Windows.Forms.Label lblMeni2MainDish;
        private System.Windows.Forms.Label lblMeni2Soup;
        private System.Windows.Forms.Label lblMeni3Desert;
        private System.Windows.Forms.Label lblMeni3SideDish;
        private System.Windows.Forms.Label lblMeni3MainDish;
        private System.Windows.Forms.Label lblMeni3Soup;
        private System.Windows.Forms.Button bntMakeOrder;
        private System.Windows.Forms.Panel pnlMeni3;
        private System.Windows.Forms.Panel pnlMeni2;
        private System.Windows.Forms.Panel pnlMeni1;
    }
}