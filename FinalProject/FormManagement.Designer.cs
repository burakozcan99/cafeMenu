namespace FinalProject
{
    partial class FormManagement
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
            this.menuList = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.boxAddProduct = new System.Windows.Forms.GroupBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.addTypeBox = new System.Windows.Forms.GroupBox();
            this.radioDessert = new System.Windows.Forms.RadioButton();
            this.radioDrink = new System.Windows.Forms.RadioButton();
            this.radioChips = new System.Windows.Forms.RadioButton();
            this.radioHamburger = new System.Windows.Forms.RadioButton();
            this.addPriceBox = new System.Windows.Forms.TextBox();
            this.addNameBox = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.boxAddProduct.SuspendLayout();
            this.addTypeBox.SuspendLayout();
            this.SuspendLayout();
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
            this.menuList.Location = new System.Drawing.Point(218, 12);
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(205, 404);
            this.menuList.TabIndex = 5;
            this.menuList.UseCompatibleStateImageBehavior = false;
            this.menuList.View = System.Windows.Forms.View.Details;
            this.menuList.ItemActivate += new System.EventHandler(this.menuList_ItemActivate);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 75;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            this.columnPrice.Width = 75;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 50;
            // 
            // boxAddProduct
            // 
            this.boxAddProduct.Controls.Add(this.buttonUpdate);
            this.boxAddProduct.Controls.Add(this.buttonAdd);
            this.boxAddProduct.Controls.Add(this.addTypeBox);
            this.boxAddProduct.Controls.Add(this.addPriceBox);
            this.boxAddProduct.Controls.Add(this.addNameBox);
            this.boxAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boxAddProduct.Location = new System.Drawing.Point(12, 12);
            this.boxAddProduct.Name = "boxAddProduct";
            this.boxAddProduct.Size = new System.Drawing.Size(200, 200);
            this.boxAddProduct.TabIndex = 6;
            this.boxAddProduct.TabStop = false;
            this.boxAddProduct.Text = "Add New Product";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(12, 163);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(113, 163);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // addTypeBox
            // 
            this.addTypeBox.Controls.Add(this.radioDessert);
            this.addTypeBox.Controls.Add(this.radioDrink);
            this.addTypeBox.Controls.Add(this.radioChips);
            this.addTypeBox.Controls.Add(this.radioHamburger);
            this.addTypeBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addTypeBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addTypeBox.Location = new System.Drawing.Point(6, 71);
            this.addTypeBox.Name = "addTypeBox";
            this.addTypeBox.Size = new System.Drawing.Size(188, 86);
            this.addTypeBox.TabIndex = 9;
            this.addTypeBox.TabStop = false;
            this.addTypeBox.Text = "Type";
            // 
            // radioDessert
            // 
            this.radioDessert.AutoSize = true;
            this.radioDessert.Location = new System.Drawing.Point(106, 53);
            this.radioDessert.Name = "radioDessert";
            this.radioDessert.Size = new System.Drawing.Size(76, 23);
            this.radioDessert.TabIndex = 1;
            this.radioDessert.TabStop = true;
            this.radioDessert.Text = "Dessert";
            this.radioDessert.UseVisualStyleBackColor = true;
            this.radioDessert.CheckedChanged += new System.EventHandler(this.radioDessert_CheckedChanged);
            // 
            // radioDrink
            // 
            this.radioDrink.AutoSize = true;
            this.radioDrink.Location = new System.Drawing.Point(6, 53);
            this.radioDrink.Name = "radioDrink";
            this.radioDrink.Size = new System.Drawing.Size(63, 23);
            this.radioDrink.TabIndex = 0;
            this.radioDrink.TabStop = true;
            this.radioDrink.Text = "Drink";
            this.radioDrink.UseVisualStyleBackColor = true;
            this.radioDrink.CheckedChanged += new System.EventHandler(this.radioDrink_CheckedChanged);
            // 
            // radioChips
            // 
            this.radioChips.AutoSize = true;
            this.radioChips.Location = new System.Drawing.Point(107, 24);
            this.radioChips.Name = "radioChips";
            this.radioChips.Size = new System.Drawing.Size(63, 23);
            this.radioChips.TabIndex = 1;
            this.radioChips.TabStop = true;
            this.radioChips.Text = "Chips";
            this.radioChips.UseVisualStyleBackColor = true;
            this.radioChips.CheckedChanged += new System.EventHandler(this.radioChips_CheckedChanged);
            // 
            // radioHamburger
            // 
            this.radioHamburger.AutoSize = true;
            this.radioHamburger.Location = new System.Drawing.Point(6, 24);
            this.radioHamburger.Name = "radioHamburger";
            this.radioHamburger.Size = new System.Drawing.Size(105, 23);
            this.radioHamburger.TabIndex = 0;
            this.radioHamburger.TabStop = true;
            this.radioHamburger.Text = "Hamburger";
            this.radioHamburger.UseVisualStyleBackColor = true;
            this.radioHamburger.CheckedChanged += new System.EventHandler(this.radioHamburger_CheckedChanged);
            // 
            // addPriceBox
            // 
            this.addPriceBox.Location = new System.Drawing.Point(82, 45);
            this.addPriceBox.Name = "addPriceBox";
            this.addPriceBox.Size = new System.Drawing.Size(100, 22);
            this.addPriceBox.TabIndex = 1;
            // 
            // addNameBox
            // 
            this.addNameBox.Location = new System.Drawing.Point(82, 19);
            this.addNameBox.Name = "addNameBox";
            this.addNameBox.Size = new System.Drawing.Size(100, 22);
            this.addNameBox.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDelete.Location = new System.Drawing.Point(119, 218);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 670);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.boxAddProduct);
            this.Controls.Add(this.menuList);
            this.Name = "FormManagement";
            this.Text = "FormManagement";
            this.Load += new System.EventHandler(this.FormManagement_Load);
            this.boxAddProduct.ResumeLayout(false);
            this.boxAddProduct.PerformLayout();
            this.addTypeBox.ResumeLayout(false);
            this.addTypeBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView menuList;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.GroupBox boxAddProduct;
        private System.Windows.Forms.TextBox addPriceBox;
        private System.Windows.Forms.TextBox addNameBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox addTypeBox;
        private System.Windows.Forms.RadioButton radioDessert;
        private System.Windows.Forms.RadioButton radioDrink;
        private System.Windows.Forms.RadioButton radioChips;
        private System.Windows.Forms.RadioButton radioHamburger;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
    }
}