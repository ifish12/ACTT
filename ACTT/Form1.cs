using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACTT
{
    public partial class Form1 : Form
    {
        int[] NoteCharts = new int[16];
        char[] NoteValues = new char[] { '_', '-', 'a', 'b', 'c', 'd', 'e', 'F', 'A', 'B', 'C', 'D', 'E', '?' };

        public Form1()
        {
            InitializeComponent();
        }

        private void Generate()
        {
            Random R = new Random();
            for (int count = 0; count < 16; count++)
            {
               
                int rand = R.Next(1, 15);
                NoteCharts[count] = rand;

            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            frmAbout About = new frmAbout();
            About.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Generate();
        }
    }
}
