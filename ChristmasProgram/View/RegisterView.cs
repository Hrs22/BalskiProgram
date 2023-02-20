using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChristmasProgram.View
{
    public partial class RegisterView : Form
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        private void txtBoxHoverText_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("The following information helps us verify your identity and provide you with appropriate content.", txtBoxHoverText);
            toolTip1.OwnerDraw= true;
            toolTip1.ForeColor = Color.Black;
            toolTip1.BackColor= Color.Purple;
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
                MessageBox.Show("Succsesfully registered!");
                MainView mv = new MainView();
                this.Hide();
                mv.ShowDialog();
                this.Close();
            }
        }
    }
}
