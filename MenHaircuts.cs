using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrizerskiSalon
{
    public partial class MenHaircuts : UserControl
    {
        public MenHaircuts()
        {
            InitializeComponent();
            //button1.MouseEnter += Button1_MouseEnter;
            //button1.MouseLeave += Button1_MouseLeave;

            hair1Pic.MouseEnter += Hair1Pic_MouseEnter;
            hair1Pic.MouseLeave += Hair1Pic_MouseLeave;

            hair2Pic.MouseEnter += Hair2Pic_MouseEnter;
            hair2Pic.MouseLeave += Hair2Pic_MouseLeave;

            hair3Pic.MouseEnter += Hair3Pic_MouseEnter;
            hair3Pic.MouseLeave += Hair3Pic_MouseLeave;

            hair4Pic.MouseEnter += Hair4Pic_MouseEnter;
            hair4Pic.MouseLeave += Hair4Pic_MouseLeave;

            hair5Pic.MouseEnter += Hair5Pic_MouseEnter;
            hair5Pic.MouseLeave += Hair5Pic_MouseLeave;

            hair6Pic.MouseEnter += Hair6Pic_MouseEnter;
            hair6Pic.MouseLeave += Hair6Pic_MouseLeave;

            
        }

        private void Hair6Pic_MouseLeave(object sender, EventArgs e)
        {
            hair6Pic.BringToFront();
        }

        private void Hair6Pic_MouseEnter(object sender, EventArgs e)
        {
            hair6Pic.SendToBack();
        }

        private void Hair5Pic_MouseLeave(object sender, EventArgs e)
        {
            hair5Pic.BringToFront();
        }

        private void Hair5Pic_MouseEnter(object sender, EventArgs e)
        {
            hair5Pic.SendToBack();
        }

        private void Hair4Pic_MouseLeave(object sender, EventArgs e)
        {
            hair4Pic.BringToFront();
        }

        private void Hair4Pic_MouseEnter(object sender, EventArgs e)
        {
            hair4Pic.SendToBack();
        }

        private void Hair3Pic_MouseLeave(object sender, EventArgs e)
        {
            hair3Pic.BringToFront();
        }

        private void Hair3Pic_MouseEnter(object sender, EventArgs e)
        {
            hair3Pic.SendToBack();
        }

        private void Hair2Pic_MouseLeave(object sender, EventArgs e)
        {
            hair2Pic.BringToFront();
        }

        private void Hair2Pic_MouseEnter(object sender, EventArgs e)
        {
            hair2Pic.SendToBack();
        }

        private void Hair1Pic_MouseLeave(object sender, EventArgs e)
        {
            hair1Pic.BringToFront();
        }

        private void Hair1Pic_MouseEnter(object sender, EventArgs e)
        {
            hair1Pic.SendToBack();
        }
    }
}
