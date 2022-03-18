namespace FinalProject
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuLogoutButton = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.cartList = new System.Windows.Forms.ListView();
            this.columnNameCart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPriceCart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuTimerLabel = new System.Windows.Forms.Label();
            this.menuTimer = new System.Windows.Forms.Timer(this.components);
            this.menuList = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cartLabel = new System.Windows.Forms.Label();
            this.menuLabel = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.panelUser = new System.Windows.Forms.Panel();
            this.buttonManageProfile = new System.Windows.Forms.Button();
            this.buttonOrderHistory = new System.Windows.Forms.Button();
            this.labelUserCity = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // menuLogoutButton
            // 
            this.menuLogoutButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuLogoutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuLogoutButton.Location = new System.Drawing.Point(42, 461);
            this.menuLogoutButton.Name = "menuLogoutButton";
            this.menuLogoutButton.Size = new System.Drawing.Size(111, 41);
            this.menuLogoutButton.TabIndex = 0;
            this.menuLogoutButton.Text = "Log Out";
            this.menuLogoutButton.UseVisualStyleBackColor = false;
            this.menuLogoutButton.Click += new System.EventHandler(this.menuLogoutButton_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOrder.Location = new System.Drawing.Point(768, 255);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(111, 41);
            this.buttonOrder.TabIndex = 2;
            this.buttonOrder.Text = "Order";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // cartList
            // 
            this.cartList.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cartList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameCart,
            this.columnPriceCart,
            this.columnCount});
            this.cartList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cartList.HideSelection = false;
            this.cartList.Location = new System.Drawing.Point(558, 93);
            this.cartList.Name = "cartList";
            this.cartList.Size = new System.Drawing.Size(204, 404);
            this.cartList.TabIndex = 1;
            this.cartList.UseCompatibleStateImageBehavior = false;
            this.cartList.View = System.Windows.Forms.View.Details;
            this.cartList.ItemActivate += new System.EventHandler(this.cartList_ItemActivate);
            // 
            // columnNameCart
            // 
            this.columnNameCart.Text = "Name";
            this.columnNameCart.Width = 100;
            // 
            // columnPriceCart
            // 
            this.columnPriceCart.Text = "Price";
            this.columnPriceCart.Width = 50;
            // 
            // columnCount
            // 
            this.columnCount.Text = "Count";
            this.columnCount.Width = 50;
            // 
            // menuTimerLabel
            // 
            this.menuTimerLabel.AutoSize = true;
            this.menuTimerLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuTimerLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuTimerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuTimerLabel.Location = new System.Drawing.Point(555, 33);
            this.menuTimerLabel.Name = "menuTimerLabel";
            this.menuTimerLabel.Size = new System.Drawing.Size(0, 16);
            this.menuTimerLabel.TabIndex = 3;
            // 
            // menuTimer
            // 
            this.menuTimer.Enabled = true;
            this.menuTimer.Interval = 1000;
            this.menuTimer.Tick += new System.EventHandler(this.menuTimer_Tick);
            // 
            // menuList
            // 
            this.menuList.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.menuList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnPrice,
            this.columnID});
            this.menuList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.menuList.HideSelection = false;
            this.menuList.Location = new System.Drawing.Point(230, 93);
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(205, 404);
            this.menuList.TabIndex = 4;
            this.menuList.UseCompatibleStateImageBehavior = false;
            this.menuList.View = System.Windows.Forms.View.Details;
            this.menuList.ItemActivate += new System.EventHandler(this.menuList_ItemActivate);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 100;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            this.columnPrice.Width = 100;
            // 
            // columnID
            // 
            this.columnID.Text = "";
            this.columnID.Width = 0;
            // 
            // cartLabel
            // 
            this.cartLabel.AutoSize = true;
            this.cartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cartLabel.Location = new System.Drawing.Point(555, 74);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.Size = new System.Drawing.Size(200, 16);
            this.cartLabel.TabIndex = 6;
            this.cartLabel.Text = "User Name\'s Shopping Cart";
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuLabel.Location = new System.Drawing.Point(227, 74);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(126, 16);
            this.menuLabel.TabIndex = 5;
            this.menuLabel.Text = "Cafe Name Menu";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(441, 161);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(111, 41);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add to Shopping Cart";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClear.Location = new System.Drawing.Point(768, 208);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(111, 41);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear List";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRemove.Location = new System.Drawing.Point(768, 161);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(111, 41);
            this.buttonRemove.TabIndex = 9;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelUser.Controls.Add(this.buttonManageProfile);
            this.panelUser.Controls.Add(this.buttonOrderHistory);
            this.panelUser.Controls.Add(this.labelUserCity);
            this.panelUser.Controls.Add(this.labelUserName);
            this.panelUser.Controls.Add(this.pictureUser);
            this.panelUser.Controls.Add(this.menuLogoutButton);
            this.panelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelUser.Location = new System.Drawing.Point(-5, -5);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(192, 519);
            this.panelUser.TabIndex = 10;
            // 
            // buttonManageProfile
            // 
            this.buttonManageProfile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonManageProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonManageProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonManageProfile.Location = new System.Drawing.Point(42, 213);
            this.buttonManageProfile.Name = "buttonManageProfile";
            this.buttonManageProfile.Size = new System.Drawing.Size(111, 41);
            this.buttonManageProfile.TabIndex = 12;
            this.buttonManageProfile.Text = "Manage Profile";
            this.buttonManageProfile.UseVisualStyleBackColor = false;
            // 
            // buttonOrderHistory
            // 
            this.buttonOrderHistory.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOrderHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOrderHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOrderHistory.Location = new System.Drawing.Point(42, 260);
            this.buttonOrderHistory.Name = "buttonOrderHistory";
            this.buttonOrderHistory.Size = new System.Drawing.Size(111, 41);
            this.buttonOrderHistory.TabIndex = 11;
            this.buttonOrderHistory.Text = "Order History";
            this.buttonOrderHistory.UseVisualStyleBackColor = false;
            // 
            // labelUserCity
            // 
            this.labelUserCity.AutoSize = true;
            this.labelUserCity.Location = new System.Drawing.Point(39, 166);
            this.labelUserCity.Name = "labelUserCity";
            this.labelUserCity.Size = new System.Drawing.Size(71, 16);
            this.labelUserCity.TabIndex = 2;
            this.labelUserCity.Text = "User City";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(39, 140);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(86, 16);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "User Name";
            // 
            // pictureUser
            // 
            this.pictureUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureUser.Image")));
            this.pictureUser.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureUser.InitialImage")));
            this.pictureUser.Location = new System.Drawing.Point(42, 17);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(111, 108);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 0;
            this.pictureUser.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(887, 509);
            this.ControlBox = false;
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.cartLabel);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.menuList);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.menuTimerLabel);
            this.Controls.Add(this.cartList);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuLogoutButton;
        private System.Windows.Forms.ListView cartList;
        private System.Windows.Forms.ColumnHeader columnNameCart;
        private System.Windows.Forms.ColumnHeader columnPriceCart;
        private System.Windows.Forms.ColumnHeader columnCount;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Label menuTimerLabel;
        private System.Windows.Forms.Timer menuTimer;
        private System.Windows.Forms.ListView menuList;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Button buttonManageProfile;
        private System.Windows.Forms.Button buttonOrderHistory;
        private System.Windows.Forms.Label labelUserCity;
        private System.Windows.Forms.Label labelUserName;
    }
}