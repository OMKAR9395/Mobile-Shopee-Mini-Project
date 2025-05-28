using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS_Mobile_Shopee.Product
{
    public partial class frm_Product : Form
    {
        public frm_Product()
        {
            InitializeComponent();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm_Login obj = new frm_Login();
                obj.Show();
                this.Hide();
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Main obj = new frm_Main();
            obj.Show();
            this.Hide();
        }

        private void btn_Add_Product_Click(object sender, EventArgs e)
        {
            Product.UC_Add_Product Obj = new Product.UC_Add_Product();

            frm_Product.pnl_Product.Controls.Clear();
            frm_Product.pnl_Product.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_Update_Product_Click(object sender, EventArgs e)
        {
            Product.UC_Update_Product Obj = new Product.UC_Update_Product();

            frm_Product.pnl_Product.Controls.Clear();
            frm_Product.pnl_Product.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_View_Product_Click(object sender, EventArgs e)
        {
            Product.UC_View_Product Obj = new Product.UC_View_Product();

            frm_Product.pnl_Product.Controls.Clear();
            frm_Product.pnl_Product.Controls.Add(Obj);
            Obj.Show();
        }
    }
}
