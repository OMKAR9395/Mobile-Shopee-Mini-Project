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

namespace SS_Mobile_Shopee.Product
{
    public partial class UC_Add_Product : UserControl
    {
        public UC_Add_Product()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=PATIL;Initial Catalog=SS_Mobile_Shopee.dbo;Integrated Security=True");
      
        void Con_Open()
        {
            if(Con.State != ConnectionState.Open)
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
            Cmb_Catagory.SelectedIndex = -1;
            cmb_Subcatagory.SelectedIndex = -1;
            tb_Features.Clear();
            tb_Quantity.Clear();
            tb_Colour.Clear();
            tb_Buy_Price.Clear();
            tb_Sell_Price.Clear();
            dtp_Date.Text = "01-01-2025";
            pb_Image.Image = null;
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
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();

            OFD.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                pb_Image.Image = new Bitmap(OFD.FileName);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Field();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (Cmb_Catagory.Text != "" && cmb_Subcatagory.Text != "" && tb_Features.Text != "" && tb_Quantity.Text != "" && tb_Colour.Text != "" && tb_Buy_Price.Text != "" && tb_Sell_Price.Text != "" && pb_Image.Image != null)
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into Product Values (@ID,@Cat,@Subcat,@Colour,@Features,@Quantity,@Image,@Date,@Buy,@Sell)";

                Cmd.Parameters.Add("ID", SqlDbType.Int).Value = tb__Id.Text;
                Cmd.Parameters.Add("Cat", SqlDbType.NVarChar).Value = Cmb_Catagory.Text;
                Cmd.Parameters.Add("Subcat", SqlDbType.NVarChar).Value = cmb_Subcatagory.Text;
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

        private void UC_Add_Product_Load(object sender, EventArgs e)
        {
            tb__Id.Text = Convert.ToString(Auto_Incr());
        }
    }
}
