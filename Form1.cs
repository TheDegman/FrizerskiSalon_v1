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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            home1.BringToFront();

            homeBtn.BackColor = Color.FromArgb(255, 153, 0);


        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            menhaircutBtn.BackColor = Color.FromArgb(51, 52, 78);
            womenhaircutsBtn.BackColor = Color.FromArgb(51, 52, 78);

            panel3.BackColor = Color.FromArgb(255,153,0);
            panel2.BackColor = Color.FromArgb(185,107,0);
            home1.BringToFront();
            homeBtn.BackColor = Color.FromArgb(255, 153, 0);

           

            
            
        }

        private void menhaircutBtn_Click(object sender, EventArgs e)
        {
            homeBtn.BackColor = Color.FromArgb(51, 52, 78);
            womenhaircutsBtn.BackColor = Color.FromArgb(51, 52, 78);

            panel3.BackColor = Color.FromArgb(194, 46, 68);
            panel2.BackColor = Color.FromArgb(138,29,49);
            menHaircuts1.BringToFront();
            menhaircutBtn.BackColor = Color.FromArgb(194, 46, 68);
        }

        private void womenhaircutsBtn_Click(object sender, EventArgs e)
        {
            menhaircutBtn.BackColor = Color.FromArgb(51, 52, 78);
            homeBtn.BackColor = Color.FromArgb(51, 52, 78);


            panel3.BackColor = Color.FromArgb(0, 159, 178);
            panel2.BackColor = Color.FromArgb(0, 113, 126);
            womenHaircuts1.BringToFront();
            womenhaircutsBtn.BackColor = Color.FromArgb(0, 159, 178);
        }



        private void aboutBtn_Click(object sender, EventArgs e)
        {

        }

       
    }
}
