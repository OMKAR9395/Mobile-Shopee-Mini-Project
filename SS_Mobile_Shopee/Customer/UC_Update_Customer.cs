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
    public partial class UC_Update_Customer : UserControl
    {
        public UC_Update_Customer()
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

        private void UC_Update_Customer_Load(object sender, EventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            void Clear_Field()
            {
                cmb_Catagory.SelectedIndex = -1;
                cmb_Subcatagory.SelectedIndex = -1;
                tb_Features.Clear();
                tb_Quantity.Clear();
                cmb_Colour.SelectedIndex = -1;
                pb_Image.Image = null;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = "Select * from Customer Where Id = @Id";

            cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_Id.Text;

            SqlDataAdapter da = new SqlDataAdapter("Select * From Product where Id = " + tb_Id.Text + "", Con);

            
            SqlDataReader Dr = cmd.ExecuteReader();

            if (Dr.Read())
            {
                cmb_Catagory.Text = Dr.GetString(Dr.GetOrdinal("Catagory"));
                cmb_Subcatagory.Text = Dr.GetString(Dr.GetOrdinal("Subcatagory"));
                cmb_Colour.Text = Dr.GetString(Dr.GetOrdinal("Colour"));
                tb_Features.Text = Dr.GetString(Dr.GetOrdinal("Features"));
                tb_Quantity.Text = (Dr["Quantity"].ToString());

                byte[] imageBytes = (byte[])Dr["Image"];
                MemoryStream ms = new MemoryStream(imageBytes);
                pb_Image.Image = new Bitmap(ms);

                




            }
            else
            {
                MessageBox.Show("Invalid Id Number", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Con_Close();
        }
    }
}
