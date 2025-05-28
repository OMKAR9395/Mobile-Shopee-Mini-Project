
namespace SS_Mobile_Shopee.Customer
{
    partial class UC_Add_Customer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.tb_Features = new System.Windows.Forms.TextBox();
            this.cmb_Catagory = new System.Windows.Forms.ComboBox();
            this.cmb_Subcatagory = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Image = new System.Windows.Forms.Label();
            this.lbl_Features = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Colour = new System.Windows.Forms.Label();
            this.lbl_SubCatagory = new System.Windows.Forms.Label();
            this.lbl_Catagory = new System.Windows.Forms.Label();
            this.cmb_Colour = new System.Windows.Forms.ComboBox();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.tb_Customer_name = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.tb_MobNo = new System.Windows.Forms.TextBox();
            this.lbl_MobNo = new System.Windows.Forms.Label();
            this.lbl__Price = new System.Windows.Forms.Label();
            this.lbl_Show_Price = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.tb_Id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Image
            // 
            this.pb_Image.Location = new System.Drawing.Point(674, 129);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(270, 162);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 58;
            this.pb_Image.TabStop = false;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(229, 229);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(280, 32);
            this.dtp_Date.TabIndex = 57;
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(678, 86);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(281, 32);
            this.tb_Quantity.TabIndex = 56;
            // 
            // tb_Features
            // 
            this.tb_Features.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Features.Location = new System.Drawing.Point(678, 22);
            this.tb_Features.Name = "tb_Features";
            this.tb_Features.Size = new System.Drawing.Size(281, 32);
            this.tb_Features.TabIndex = 55;
            // 
            // cmb_Catagory
            // 
            this.cmb_Catagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Catagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Catagory.FormattingEnabled = true;
            this.cmb_Catagory.Location = new System.Drawing.Point(229, 64);
            this.cmb_Catagory.Name = "cmb_Catagory";
            this.cmb_Catagory.Size = new System.Drawing.Size(281, 34);
            this.cmb_Catagory.TabIndex = 53;
            this.cmb_Catagory.SelectedIndexChanged += new System.EventHandler(this.cmb_Catagory_SelectedIndexChanged);
            // 
            // cmb_Subcatagory
            // 
            this.cmb_Subcatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Subcatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Subcatagory.FormattingEnabled = true;
            this.cmb_Subcatagory.Location = new System.Drawing.Point(229, 119);
            this.cmb_Subcatagory.Name = "cmb_Subcatagory";
            this.cmb_Subcatagory.Size = new System.Drawing.Size(281, 34);
            this.cmb_Subcatagory.TabIndex = 52;
            this.cmb_Subcatagory.SelectedIndexChanged += new System.EventHandler(this.cmb_Subcatagory_SelectedIndexChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Refresh.Location = new System.Drawing.Point(608, 413);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(220, 47);
            this.btn_Refresh.TabIndex = 49;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Submit.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Submit.Location = new System.Drawing.Point(154, 413);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(220, 47);
            this.btn_Submit.TabIndex = 51;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Quantity.Location = new System.Drawing.Point(537, 89);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(124, 25);
            this.lbl_Quantity.TabIndex = 42;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // lbl_Image
            // 
            this.lbl_Image.AutoSize = true;
            this.lbl_Image.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Image.Location = new System.Drawing.Point(537, 186);
            this.lbl_Image.Name = "lbl_Image";
            this.lbl_Image.Size = new System.Drawing.Size(82, 25);
            this.lbl_Image.TabIndex = 43;
            this.lbl_Image.Text = "Image";
            // 
            // lbl_Features
            // 
            this.lbl_Features.AutoSize = true;
            this.lbl_Features.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Features.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Features.Location = new System.Drawing.Point(537, 23);
            this.lbl_Features.Name = "lbl_Features";
            this.lbl_Features.Size = new System.Drawing.Size(124, 25);
            this.lbl_Features.TabIndex = 44;
            this.lbl_Features.Text = "Features";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Date.Location = new System.Drawing.Point(23, 229);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(68, 25);
            this.lbl_Date.TabIndex = 45;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Colour
            // 
            this.lbl_Colour.AutoSize = true;
            this.lbl_Colour.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Colour.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Colour.Location = new System.Drawing.Point(23, 174);
            this.lbl_Colour.Name = "lbl_Colour";
            this.lbl_Colour.Size = new System.Drawing.Size(96, 25);
            this.lbl_Colour.TabIndex = 46;
            this.lbl_Colour.Text = "Colour";
            // 
            // lbl_SubCatagory
            // 
            this.lbl_SubCatagory.AutoSize = true;
            this.lbl_SubCatagory.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubCatagory.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_SubCatagory.Location = new System.Drawing.Point(23, 122);
            this.lbl_SubCatagory.Name = "lbl_SubCatagory";
            this.lbl_SubCatagory.Size = new System.Drawing.Size(166, 25);
            this.lbl_SubCatagory.TabIndex = 47;
            this.lbl_SubCatagory.Text = "SubCatagory";
            // 
            // lbl_Catagory
            // 
            this.lbl_Catagory.AutoSize = true;
            this.lbl_Catagory.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Catagory.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Catagory.Location = new System.Drawing.Point(23, 69);
            this.lbl_Catagory.Name = "lbl_Catagory";
            this.lbl_Catagory.Size = new System.Drawing.Size(124, 25);
            this.lbl_Catagory.TabIndex = 48;
            this.lbl_Catagory.Text = "Catagory";
            // 
            // cmb_Colour
            // 
            this.cmb_Colour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Colour.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Colour.FormattingEnabled = true;
            this.cmb_Colour.Location = new System.Drawing.Point(228, 174);
            this.cmb_Colour.Name = "cmb_Colour";
            this.cmb_Colour.Size = new System.Drawing.Size(281, 34);
            this.cmb_Colour.TabIndex = 52;
            this.cmb_Colour.SelectedIndexChanged += new System.EventHandler(this.cmb_Colour_SelectedIndexChanged);
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Name.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Customer_Name.Location = new System.Drawing.Point(23, 279);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(194, 25);
            this.lbl_Customer_Name.TabIndex = 59;
            this.lbl_Customer_Name.Text = "Customer Name";
            // 
            // tb_Customer_name
            // 
            this.tb_Customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_name.Location = new System.Drawing.Point(228, 279);
            this.tb_Customer_name.Name = "tb_Customer_name";
            this.tb_Customer_name.Size = new System.Drawing.Size(281, 32);
            this.tb_Customer_name.TabIndex = 60;
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(678, 312);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(281, 32);
            this.tb_Address.TabIndex = 62;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Address.Location = new System.Drawing.Point(537, 317);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(110, 25);
            this.lbl_Address.TabIndex = 61;
            this.lbl_Address.Text = "Address";
            // 
            // tb_MobNo
            // 
            this.tb_MobNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MobNo.Location = new System.Drawing.Point(228, 330);
            this.tb_MobNo.Name = "tb_MobNo";
            this.tb_MobNo.Size = new System.Drawing.Size(281, 32);
            this.tb_MobNo.TabIndex = 64;
            // 
            // lbl_MobNo
            // 
            this.lbl_MobNo.AutoSize = true;
            this.lbl_MobNo.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MobNo.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_MobNo.Location = new System.Drawing.Point(23, 337);
            this.lbl_MobNo.Name = "lbl_MobNo";
            this.lbl_MobNo.Size = new System.Drawing.Size(152, 25);
            this.lbl_MobNo.TabIndex = 63;
            this.lbl_MobNo.Text = "Mobile No.";
            // 
            // lbl__Price
            // 
            this.lbl__Price.AutoSize = true;
            this.lbl__Price.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__Price.ForeColor = System.Drawing.Color.Crimson;
            this.lbl__Price.Location = new System.Drawing.Point(537, 363);
            this.lbl__Price.Name = "lbl__Price";
            this.lbl__Price.Size = new System.Drawing.Size(82, 25);
            this.lbl__Price.TabIndex = 61;
            this.lbl__Price.Text = "Price";
            // 
            // lbl_Show_Price
            // 
            this.lbl_Show_Price.AutoSize = true;
            this.lbl_Show_Price.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Show_Price.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Show_Price.Location = new System.Drawing.Point(673, 363);
            this.lbl_Show_Price.Name = "lbl_Show_Price";
            this.lbl_Show_Price.Size = new System.Drawing.Size(152, 25);
            this.lbl_Show_Price.TabIndex = 61;
            this.lbl_Show_Price.Text = "Show Price";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Id.Location = new System.Drawing.Point(23, 29);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(40, 25);
            this.lbl_Id.TabIndex = 65;
            this.lbl_Id.Text = "ID";
            // 
            // tb_Id
            // 
            this.tb_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Id.Location = new System.Drawing.Point(229, 22);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(281, 32);
            this.tb_Id.TabIndex = 66;
            // 
            // UC_Add_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.tb_MobNo);
            this.Controls.Add(this.lbl_MobNo);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.lbl_Show_Price);
            this.Controls.Add(this.lbl__Price);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.tb_Customer_name);
            this.Controls.Add(this.lbl_Customer_Name);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.tb_Quantity);
            this.Controls.Add(this.tb_Features);
            this.Controls.Add(this.cmb_Catagory);
            this.Controls.Add(this.cmb_Colour);
            this.Controls.Add(this.cmb_Subcatagory);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.lbl_Image);
            this.Controls.Add(this.lbl_Features);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Colour);
            this.Controls.Add(this.lbl_SubCatagory);
            this.Controls.Add(this.lbl_Catagory);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "UC_Add_Customer";
            this.Size = new System.Drawing.Size(982, 463);
            this.Load += new System.EventHandler(this.UC_Add_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.TextBox tb_Features;
        private System.Windows.Forms.ComboBox cmb_Catagory;
        private System.Windows.Forms.ComboBox cmb_Subcatagory;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Image;
        private System.Windows.Forms.Label lbl_Features;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Colour;
        private System.Windows.Forms.Label lbl_SubCatagory;
        private System.Windows.Forms.Label lbl_Catagory;
        private System.Windows.Forms.ComboBox cmb_Colour;
        private System.Windows.Forms.Label lbl_Customer_Name;
        private System.Windows.Forms.TextBox tb_Customer_name;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox tb_MobNo;
        private System.Windows.Forms.Label lbl_MobNo;
        private System.Windows.Forms.Label lbl__Price;
        private System.Windows.Forms.Label lbl_Show_Price;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox tb_Id;
    }
}
