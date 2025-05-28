
namespace SS_Mobile_Shopee
{
    partial class frm_Main
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
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_Product = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_Product = new System.Windows.Forms.PictureBox();
            this.pb_Customer = new System.Windows.Forms.PictureBox();
            this.btn_Logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Customer
            // 
            this.btn_Customer.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Customer.Location = new System.Drawing.Point(430, 106);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(345, 94);
            this.btn_Customer.TabIndex = 0;
            this.btn_Customer.Text = "Customer";
            this.btn_Customer.UseVisualStyleBackColor = true;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_Product
            // 
            this.btn_Product.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Product.Location = new System.Drawing.Point(430, 338);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(345, 94);
            this.btn_Product.TabIndex = 0;
            this.btn_Product.Text = "Product";
            this.btn_Product.UseVisualStyleBackColor = true;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 648);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label1";
            // 
            // pb_Product
            // 
            this.pb_Product.Image = global::SS_Mobile_Shopee.Properties.Resources.Customer;
            this.pb_Product.Location = new System.Drawing.Point(249, 103);
            this.pb_Product.Name = "pb_Product";
            this.pb_Product.Size = new System.Drawing.Size(140, 111);
            this.pb_Product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Product.TabIndex = 2;
            this.pb_Product.TabStop = false;
            // 
            // pb_Customer
            // 
            this.pb_Customer.Image = global::SS_Mobile_Shopee.Properties.Resources.Mobile;
            this.pb_Customer.Location = new System.Drawing.Point(249, 331);
            this.pb_Customer.Name = "pb_Customer";
            this.pb_Customer.Size = new System.Drawing.Size(140, 111);
            this.pb_Customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Customer.TabIndex = 2;
            this.pb_Customer.TabStop = false;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackgroundImage = global::SS_Mobile_Shopee.Properties.Resources.logout;
            this.btn_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Logout.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Logout.Location = new System.Drawing.Point(882, 12);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(88, 76);
            this.btn_Logout.TabIndex = 0;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.pb_Product);
            this.Controls.Add(this.pb_Customer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Product);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Customer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.PictureBox pb_Customer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_Product;
        private System.Windows.Forms.Button btn_Logout;
    }
}