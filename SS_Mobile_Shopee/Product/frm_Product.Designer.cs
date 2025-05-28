
namespace SS_Mobile_Shopee.Product
{
    partial class frm_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Product));
            this.pnl_Customer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            pnl_Product = new System.Windows.Forms.Panel();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_View_Product = new System.Windows.Forms.Button();
            this.btn_Update_Product = new System.Windows.Forms.Button();
            this.btn_Add_Product = new System.Windows.Forms.Button();
            this.pnl_Customer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Customer
            // 
            this.pnl_Customer.Controls.Add(this.panel1);
            this.pnl_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Customer.Location = new System.Drawing.Point(0, 90);
            this.pnl_Customer.Name = "pnl_Customer";
            this.pnl_Customer.Size = new System.Drawing.Size(982, 463);
            this.pnl_Customer.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(pnl_Product);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 463);
            this.panel1.TabIndex = 3;
            // 
            // pnl_Product
            // 
            pnl_Product.BackColor = System.Drawing.SystemColors.ControlDark;
            pnl_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_Product.ForeColor = System.Drawing.Color.Coral;
            pnl_Product.Location = new System.Drawing.Point(0, 0);
        pnl_Product.Name = "pnl_Product";
        pnl_Product.Size = new System.Drawing.Size(982, 463);
            pnl_Product.TabIndex = 0;
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.DimGray;
            this.pnl_Header.Controls.Add(this.btn_Back);
            this.pnl_Header.Controls.Add(this.btn_Logout);
            this.pnl_Header.Controls.Add(this.btn_View_Product);
            this.pnl_Header.Controls.Add(this.btn_Update_Product);
            this.pnl_Header.Controls.Add(this.btn_Add_Product);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(982, 90);
            this.pnl_Header.TabIndex = 2;
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Back.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Back.Location = new System.Drawing.Point(3, 8);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(88, 76);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Logout.BackgroundImage")));
            this.btn_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Logout.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Logout.Location = new System.Drawing.Point(891, 11);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(88, 76);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_View_Product
            // 
            this.btn_View_Product.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Product.ForeColor = System.Drawing.Color.Crimson;
            this.btn_View_Product.Location = new System.Drawing.Point(646, 21);
            this.btn_View_Product.Name = "btn_View_Product";
            this.btn_View_Product.Size = new System.Drawing.Size(216, 52);
            this.btn_View_Product.TabIndex = 3;
            this.btn_View_Product.Text = "View Product";
            this.btn_View_Product.UseVisualStyleBackColor = true;
            this.btn_View_Product.Click += new System.EventHandler(this.btn_View_Product_Click);
            // 
            // btn_Update_Product
            // 
            this.btn_Update_Product.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Product.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Update_Product.Location = new System.Drawing.Point(380, 21);
            this.btn_Update_Product.Name = "btn_Update_Product";
            this.btn_Update_Product.Size = new System.Drawing.Size(242, 52);
            this.btn_Update_Product.TabIndex = 2;
            this.btn_Update_Product.Text = "Update Product";
            this.btn_Update_Product.UseVisualStyleBackColor = true;
            this.btn_Update_Product.Click += new System.EventHandler(this.btn_Update_Product_Click);
            // 
            // btn_Add_Product
            // 
            this.btn_Add_Product.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Product.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Add_Product.Location = new System.Drawing.Point(118, 21);
            this.btn_Add_Product.Name = "btn_Add_Product";
            this.btn_Add_Product.Size = new System.Drawing.Size(227, 52);
            this.btn_Add_Product.TabIndex = 1;
            this.btn_Add_Product.Text = "Add Product";
            this.btn_Add_Product.UseVisualStyleBackColor = true;
            this.btn_Add_Product.Click += new System.EventHandler(this.btn_Add_Product_Click);
            // 
            // frm_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.pnl_Customer);
            this.Controls.Add(this.pnl_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.pnl_Customer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnl_Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Customer;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_View_Product;
        private System.Windows.Forms.Button btn_Update_Product;
        private System.Windows.Forms.Button btn_Add_Product;
        private System.Windows.Forms.Panel panel1;
        public static System.Windows.Forms.Panel pnl_Product;
    }
}