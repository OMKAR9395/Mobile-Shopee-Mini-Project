using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS_Mobile_Shopee.Product
{
    public partial class UC_View_Product : UserControl
    {
        public UC_View_Product()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_View_Product_Load(object sender, EventArgs e)
        {
            Con_Open();

            string query = "SELECT * FROM Product";

            SqlDataAdapter da = new SqlDataAdapter(query, Con);

            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            Con_Close();
        }
    }
}
