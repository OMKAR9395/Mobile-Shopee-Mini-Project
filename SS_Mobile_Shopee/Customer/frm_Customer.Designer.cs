
namespace SS_Mobile_Shopee.Customer
{
    partial class frm_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Customer));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_View_Customer = new System.Windows.Forms.Button();
            this.btn_Update_CustomerAC = new System.Windows.Forms.Button();
            this.btn_Add_Customer = new System.Windows.Forms.Button();
            pnl_Customer = new System.Windows.Forms.Panel();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.DimGray;
            this.pnl_Header.Controls.Add(this.btn_Back);
            this.pnl_Header.Controls.Add(this.btn_Logout);
            this.pnl_Header.Controls.Add(this.btn_View_Customer);
            this.pnl_Header.Controls.Add(this.btn_Update_CustomerAC);
            this.pnl_Header.Controls.Add(this.btn_Add_Customer);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(982, 90);
            this.pnl_Header.TabIndex = 0;
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
            this.btn_Back.TabIndex = 2;
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
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_View_Customer
            // 
            this.btn_View_Customer.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Customer.ForeColor = System.Drawing.Color.Crimson;
            this.btn_View_Customer.Location = new System.Drawing.Point(646, 21);
            this.btn_View_Customer.Name = "btn_View_Customer";
            this.btn_View_Customer.Size = new System.Drawing.Size(216, 52);
            this.btn_View_Customer.TabIndex = 1;
            this.btn_View_Customer.Text = "View Customer";
            this.btn_View_Customer.UseVisualStyleBackColor = true;
            this.btn_View_Customer.Click += new System.EventHandler(this.btn_View_Customer_Click);
            // 
            // btn_Update_CustomerAC
            // 
            this.btn_Update_CustomerAC.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_CustomerAC.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Update_CustomerAC.Location = new System.Drawing.Point(380, 21);
            this.btn_Update_CustomerAC.Name = "btn_Update_CustomerAC";
            this.btn_Update_CustomerAC.Size = new System.Drawing.Size(242, 52);
            this.btn_Update_CustomerAC.TabIndex = 1;
            this.btn_Update_CustomerAC.Text = "Update Customer";
            this.btn_Update_CustomerAC.UseVisualStyleBackColor = true;
            this.btn_Update_CustomerAC.Click += new System.EventHandler(this.btn_Update_CustomerAC_Click);
            // 
            // btn_Add_Customer
            // 
            this.btn_Add_Customer.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Customer.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Add_Customer.Location = new System.Drawing.Point(118, 21);
            this.btn_Add_Customer.Name = "btn_Add_Customer";
            this.btn_Add_Customer.Size = new System.Drawing.Size(227, 52);
            this.btn_Add_Customer.TabIndex = 1;
            this.btn_Add_Customer.Text = "Add Customer";
            this.btn_Add_Customer.UseVisualStyleBackColor = true;
            this.btn_Add_Customer.Click += new System.EventHandler(this.btn_Add_Customer_Click);
            // 
            // pnl_Customer
            // 
            pnl_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_Customer.Location = new System.Drawing.Point(0, 90);
            pnl_Customer.Name = "pnl_Customer";
            pnl_Customer.Size = new System.Drawing.Size(982, 463);
            pnl_Customer.TabIndex = 1;
            // 
            // frm_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(pnl_Customer);
            this.Controls.Add(this.pnl_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.pnl_Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_Add_Customer;
        private System.Windows.Forms.Button btn_View_Customer;
        private System.Windows.Forms.Button btn_Update_CustomerAC;
        public static System.Windows.Forms.Panel pnl_Customer;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Back;
    }
}