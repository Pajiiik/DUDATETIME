using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime hodnota = new DateTime();
        DateTime ted = new DateTime();
        private void button1_Click(object sender, EventArgs e)
        {
            if (hodnota != null)
            {
                hodnota = DateTime.Now;         
                button2.Enabled = true;
                button1.Enabled = false;
            }
        }
        TimeSpan cas;
        private void button2_Click(object sender, EventArgs e)
        {
 
            ted = DateTime.Now;
            cas = (ted - hodnota);
            MessageBox.Show("Uběhlo: " + cas.Seconds.ToString() + " sekund");
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
