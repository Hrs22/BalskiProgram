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

namespace ChristmasProgram.View
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }
        private void txtBoxEmail_MouseClick(object sender, MouseEventArgs e)
        {
            txtBoxEmail.Clear();
        }
        private void txtBoxPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtBoxPassword.Clear();
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=HRUSTIAN;Initial Catalog=BalskiDB;Integrated Security=True;Pooling=False");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM AccTable WHERE Email = @Email AND Password = @Password", con);
                cmd.Parameters.AddWithValue("Email", txtBoxEmail.Text.Trim());
                cmd.Parameters.AddWithValue("Password", txtBoxPassword.Text.Trim());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Succsesfully logged!");
                    MainView mv = new MainView();
                    this.Hide();
                    mv.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong!"); 
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            RegisterView rv = new RegisterView();
            this.Hide();
            rv.ShowDialog();
            this.Close();
        }
        private void btnCantLog_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sori motori nikoi ne mi plashta da pomagam");
        }

        private void txtBoxEmail_MouseHover(object sender, EventArgs e)
        {
            txtBoxEmail.Clear();
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.Info;
            t_Tip.SetToolTip(txtBoxEmail, "Email should start with Capital letter!");
        }
        private void txtBoxPassword_MouseHover(object sender, EventArgs e)
        {
            txtBoxPassword.Clear();
        }
    }
}
