using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (true)
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
    }
}
