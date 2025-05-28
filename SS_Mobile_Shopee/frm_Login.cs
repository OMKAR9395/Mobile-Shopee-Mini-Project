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


namespace SS_Mobile_Shopee
{
    public partial class frm_Login : Form
    {
        public frm_Login()
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

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Con_Open();

            int Cnt = 0;
            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select count(*) From Login_Details Where Username = @unm And Password = @Pwd";

            Cmd.Parameters.Add("@Unm", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("@Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("Login Success", "Welcome ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Shared_content.Uname = tb_username.Text;
                frm_Main obj = new frm_Main();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed", "Re-Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lbl_Error.Text = "Incorrect Username or Password!!!";
                lbl_Error.ForeColor = Color.OrangeRed;
            }
            tb_Username.Clear();
            tb_Password.Clear();
            tb_Password.Enabled = false;
            btn_Login.Enabled = false;
            Con_Close();
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            lbl_Error.Visible = true;
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Login.Enabled = true;
        }
    }
}
