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


namespace SS_Mobile_Shopee.Customer
{
    public partial class UC_Add_Customer : UserControl
    {
        public UC_Add_Customer()
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
        int Auto_Incr()
        {
            int ID = 0;

            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Max(Id) From Product";

            ID = Convert.ToInt32(Cmd.ExecuteScalar());

            Con_Close();

            return (ID + 1);
        }

        void Clear_Field()
        {
            cmb_Catagory.SelectedIndex = -1;
            cmb_Subcatagory.SelectedIndex = -1;
            tb_Features.Clear();
            tb_Quantity.Clear();
            cmb_Colour.SelectedIndex = -1;
            tb_Customer_name.Clear();
            tb_Address.Clear();
            tb_MobNo.Clear();
            dtp_Date.Text = "01-01-2025";
            pb_Image.Image = null;
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Field();
        }

        private void UC_Add_Customer_Load(object sender, EventArgs e)
        {
            //tb_Id.Text = Convert.ToString(Auto_Incr());
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Distinct(Catagory) From Product";

            SqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                cmb_Catagory.Items.Add(Dr.GetString(Dr.GetOrdinal("Catagory")));
            }

            Con_Close();

        }

        private void cmb_Catagory_SelectedIndexChanged(object sender, EventArgs e)
        {

            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Distinct(Subcatagory) From Product where Catagory = '" + cmb_Catagory.Text + "' ";

            SqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                cmb_Subcatagory.Items.Add(Dr.GetString(Dr.GetOrdinal("Subcatagory")));
            }

            Con_Close();
        }

        private void cmb_Subcatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Distinct(Color) From Product where Catagory = '" + cmb_Catagory.Text + "' And Subcatagory = '" + cmb_Subcatagory.Text + "' ";

            SqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                cmb_Colour.Items.Add(Dr.GetString(Dr.GetOrdinal("Color")));
            }

            Con_Close();
        }

        private void cmb_Colour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand("SELECT Features, Quantity, Image, Sell_Price FROM Product WHERE Catagory = @Catagory AND Subcatagory = @Subcatagory AND Color = @Color", Con);

            Cmd.Parameters.AddWithValue("@Catagory", cmb_Catagory.Text);
            Cmd.Parameters.AddWithValue("@Subcatagory", cmb_Subcatagory.Text);
            Cmd.Parameters.AddWithValue("@Color", cmb_Colour.Text);

            SqlDataReader Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                //tb_Id.Text = Dr["Id"].ToString();
                tb_Features.Text = Dr["Features"].ToString();
                tb_Quantity.Text = Dr["Quantity"].ToString();

                
                byte[] imageBytes = (byte[])Dr["Image"];
                MemoryStream ms = new MemoryStream(imageBytes);
                pb_Image.Image = new Bitmap(ms);
               
                lbl_Show_Price.Text = Dr["Sell_Price"].ToString();
            }

            Cmd.Dispose();
            Con_Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_Quantity.Text != "" && tb_MobNo.Text != "" && tb_Features.Text != "" && tb_Address.Text != "" && tb_Customer_name.Text != "" && cmb_Colour.Text != "" && cmb_Subcatagory.Text != "" && cmb_Catagory.Text!=""&& pb_Image.Image != null)
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into Customer Values (@ID,@Cat,@Subcat,@Colour,@Features,@Quantity,@Image,@Date,@Name,@Mobile_No,@Address,@Sell_Price)";

                Cmd.Parameters.Add("ID", SqlDbType.Int).Value = tb_Id.Text;
                Cmd.Parameters.Add("Cat", SqlDbType.NVarChar).Value = cmb_Catagory.Text;
                Cmd.Parameters.Add("Subcat", SqlDbType.NVarChar).Value = cmb_Subcatagory.Text;
                Cmd.Parameters.Add("Colour", SqlDbType.NVarChar).Value = cmb_Colour.Text;
                Cmd.Parameters.Add("Features", SqlDbType.NVarChar).Value = tb_Features.Text;
                Cmd.Parameters.Add("Quantity", SqlDbType.Int).Value = tb_Quantity.Text;


                ImageConverter IC = new ImageConverter();

                byte[] imgArray = (byte[])IC.ConvertTo(pb_Image.Image, typeof(byte[]));

                Cmd.Parameters.Add("@Image", SqlDbType.Image).Value = imgArray;

                Cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Date.Text;
                Cmd.Parameters.Add("Name", SqlDbType.NVarChar).Value = tb_Customer_name.Text;
                Cmd.Parameters.Add("Mobile_No", SqlDbType.Decimal).Value = tb_MobNo.Text;
                Cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("Sell_Price", SqlDbType.Float).Value = lbl_Show_Price.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully...");
                Clear_Field();

            }
            else
            {
                MessageBox.Show("1st Fill All The Fields!!!");
            }
        }
    }
}
