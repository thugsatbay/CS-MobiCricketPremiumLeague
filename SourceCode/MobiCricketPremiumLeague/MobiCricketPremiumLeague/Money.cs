using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MobiCricketPremiumLeague
{
    public partial class Money : Form
    {
        public Money()
        {
            InitializeComponent();
        }
        public int bidMoney()
        {
            return (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Money_Load(object sender, EventArgs e)
        {
            this.Location = new Point(25, 275);
        }
    }
}
