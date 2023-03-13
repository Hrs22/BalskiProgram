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
    public partial class ShopView : Form
    {
        public ShopView()
        {
            InitializeComponent();
        }

        private void picBoxLOL_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxLOL, "Samoubii se, no po-dobre ne q kupuvai");
        }

        private void picBoxTerraria_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxTerraria, "Dig, fight, explore, build! Nothing is impossible in this action-packed adventure game." +
                "The world is your canvas and the ground itself is your paint.");
        }

        private void picBoxMinecraft_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxMinecraft, "With new games, new updates, and new ways to play, join one of the biggest communities in gaming and start crafting today!");
        }

        private void picBoxFiFa_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxFiFa, "EA SPORTS™ FIFA 23 brings The World's Game to the pitch, with next-gen ... the UEFA Women's Champions League knockout stage coming to FIFA 23 in early 2023.");
        }

        private void picBoxUndertale_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxUndertale, "UNDERTALE! The RPG game where you don't have to destroy anyone.");
        }

        private void picBoxDC_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxDC, "Dead Cells is a rogue-lite, Castlevania-inspired action-platformer, allowing you to explore a sprawling, ever-changing castle… assuming you’re able to fight your way past its keepers.");
        }
    }
}
