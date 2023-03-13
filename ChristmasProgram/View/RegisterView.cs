using ChristmasProgram.Controller;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace ChristmasProgram.View
{
    public partial class RegisterView : Form
    {
        public RegisterView ()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=HRUSTIAN;Initial Catalog=BalskiDB;Integrated Security=True;Pooling=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        private void txtBoxHoverText_MouseHover(object sender, EventArgs e)
        {
            toolTipLearnThis.Show("The following information helps us verify your identity and provide you with appropriate content.", txtBoxHoverText);
            toolTipLearnThis.OwnerDraw= true;
            toolTipLearnThis.ForeColor = Color.Black;
            toolTipLearnThis.BackColor= Color.Purple;
        }
        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawText();
            e.DrawBorder();
        }
        private void txtBoxEnterEmail_MouseClick(object sender, MouseEventArgs e)
        {
            txtBoxEnterEmail.Clear();
        }
        private void txtBoxEnterPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtBoxEnterPassword.Clear();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxEnterEmail.Text) || string.IsNullOrWhiteSpace(txtBoxEnterPassword.Text))
            {
                MessageBox.Show("Something went wrong!");
            }
            else if (true)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UserADD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", txtBoxEnterEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtBoxEnterPassword.Text.Trim());
                cmd.ExecuteNonQuery();
                Clear();

                void Clear()
                {
                    txtBoxEnterEmail = null;
                    txtBoxEnterPassword = null;
                }  

                con.Close();
                MessageBox.Show("Succsesfully registered!");
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
        private void txtBoxEnterEmail_MouseHover(object sender, EventArgs e)
        {
            txtBoxEnterEmail.Clear();
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.Info;
            t_Tip.SetToolTip(txtBoxEnterEmail, "Email should start with Capital letter!");
        }
        private void txtBoxEnterPassword_MouseHover(object sender, EventArgs e)
        {
            txtBoxEnterPassword.Clear();
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.Info;
            t_Tip.SetToolTip(txtBoxEnterPassword, "Choose a strong password!");
        }
    }
}
