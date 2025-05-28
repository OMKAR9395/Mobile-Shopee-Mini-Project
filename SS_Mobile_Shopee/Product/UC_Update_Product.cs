using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace SS_Mobile_Shopee.Product
{
    public partial class UC_Update_Product : UserControl
    {
        public UC_Update_Product()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=PATIL;Initial Catalog=SS_Mobile_Shopee.dbo;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        void Clear_Field()
        {
            tb_Catagory.Clear();
            tb_Subcatagory.Clear();
            tb_Features.Clear();
            tb_Quantity.Clear();
            tb_Colour.Clear();
            tb_Buy_Price.Clear();
            tb_Sell_Price.Clear();
            dtp_Date.Text = "01-01-2025";
            pb_Image.Image = null;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Field();
        }

        void Disable_Control()
        {
            tb_Catagory.Enabled = false;
            tb_Subcatagory.Enabled = false;
            tb_Features.Enabled = false;
            tb_Quantity.Enabled = false;
            tb_Colour.Enabled = false;
            tb_Buy_Price.Enabled = false;
            tb_Sell_Price.Enabled = false;
            dtp_Date.Enabled = false;
           
        }
        void Enable_Control()
        {
            tb_Catagory.Enabled = true;
            tb_Subcatagory.Enabled = true;
            tb_Features.Enabled = true;
            tb_Quantity.Enabled = true;
            tb_Colour.Enabled = true;
            tb_Buy_Price.Enabled = true;
            tb_Sell_Price.Enabled = true;
            dtp_Date.Enabled = true;
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_Catagory.Text != "" && tb_Subcatagory.Text != "" && tb_Features.Text != "" && tb_Quantity.Text != "" && tb_Colour.Text != "" && tb_Buy_Price.Text != "" && tb_Sell_Price.Text != "" && pb_Image.Image != null)
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Update Product Set Catagory = @Cat, Subcatagory = @Subcat, Color = @Colour, Features = @Features, Quantity = @Quantity, Image =@Image, Date = @Date, Buy_Price = @Buy, Sell_Price = @Sell Where Id = @Id";


                Cmd.Parameters.Add("ID", SqlDbType.Int).Value = tb__Id.Text;
                Cmd.Parameters.Add("Cat", SqlDbType.NVarChar).Value = tb_Catagory.Text;
                Cmd.Parameters.Add("Subcat", SqlDbType.NVarChar).Value = tb_Subcatagory.Text;
                Cmd.Parameters.Add("Colour", SqlDbType.NVarChar).Value = tb_Colour.Text;
                Cmd.Parameters.Add("Features", SqlDbType.NVarChar).Value = tb_Features.Text;
                Cmd.Parameters.Add("Quantity", SqlDbType.Int).Value = tb_Quantity.Text;


                ImageConverter IC = new ImageConverter();

                byte[] imgArray = (byte[])IC.ConvertTo(pb_Image.Image, typeof(byte[]));

                Cmd.Parameters.Add("@Image", SqlDbType.Image).Value = imgArray;

                Cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Date.Text;
                Cmd.Parameters.Add("Buy", SqlDbType.Float).Value = tb_Buy_Price.Text;
                Cmd.Parameters.Add("Sell", SqlDbType.Float).Value = tb_Sell_Price.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully...");
                Clear_Field();

            }
            else
            {
                MessageBox.Show("1st Fill All The Fields!!!");
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = "Select * from Product Where Id = @Id";

            cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb__Id.Text;

            SqlDataAdapter da = new SqlDataAdapter("Select * From Product where Id = " + tb__Id.Text + "", Con);

            DataSet ds = new DataSet();
            da.Fill(ds);
            SqlDataReader Dr = cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Catagory.Text = Dr.GetString(Dr.GetOrdinal("Catagory"));
                tb_Subcatagory.Text = Dr.GetString(Dr.GetOrdinal("Subcatagory"));
                tb_Colour.Text = Dr.GetString(Dr.GetOrdinal("Color"));
                tb_Features.Text = Dr.GetString(Dr.GetOrdinal("Features"));
                tb_Quantity.Text = (Dr["Quantity"].ToString());

                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Image"]);
                pb_Image.Image = new Bitmap(ms);

                dtp_Date.Text = (Dr["Date"].ToString());
                tb_Buy_Price.Text = (Dr["Buy_Price"].ToString());
                tb_Sell_Price.Text = (Dr["Sell_Price"].ToString());





            }
            else
            {
                MessageBox.Show("Invalid Roll Number", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Con_Close();
        }
    }
}
