using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS_Mobile_Shopee.Customer
{
    public partial class frm_Customer : Form
    {
        public frm_Customer()
        {
            InitializeComponent();
        }

        private void btn_Update_CustomerAC_Click(object sender, EventArgs e)
        {
            Customer.UC_Update_Customer Obj = new Customer.UC_Update_Customer();

            frm_Customer.pnl_Customer.Controls.Clear();
            frm_Customer.pnl_Customer.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Main obj = new frm_Main();
            obj.Show();
            this.Hide();
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

        private void btn_Add_Customer_Click(object sender, EventArgs e)
        {
            Customer.UC_Add_Customer Obj = new Customer.UC_Add_Customer();

            frm_Customer.pnl_Customer.Controls.Clear();
            frm_Customer.pnl_Customer.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_View_Customer_Click(object sender, EventArgs e)
        {
            Customer.UC_View_Customer Obj = new Customer.UC_View_Customer();

            frm_Customer.pnl_Customer.Controls.Clear();
            frm_Customer.pnl_Customer.Controls.Add(Obj);
            Obj.Show();
        }
    }
}
