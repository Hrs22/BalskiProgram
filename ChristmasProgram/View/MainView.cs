using ChristmasProgram.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChristmasProgram
{
    public partial class MainView : Form
    {
        private static double balance = 0;
        private static int totalDeposit = 0;
        private static double totalDepositAmount = 0;
        private static int totalChecks = 0;
        private static double totalChecksAmount = 0;
        public MainView()
        {
            InitializeComponent();
        }

        private void txtBoxHoverText_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(txtBoxHoverText, "League of Legends, Minecraft, Terraria, FIFa2023, Undertale, Dead Cells");
        }

        private void btnChanceAcc_Click(object sender, EventArgs e)
        {
            LoginView lv = new LoginView();
            this.Hide();
            lv.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
