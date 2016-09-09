using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MobiCricketPremiumLeague
{
    public partial class AddPlayer : UserControl
    {
        public AddPlayer()
        {
            InitializeComponent();
            playerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            cricketTableAdapter.Fill(mobiCricketLeagueDataSet.Cricket);
        }
        public AddPlayer(UserControl uc):this()
        {
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //if((first_NameTextBox.Text == null)||(first_NameTextBox.Text == ""))
            //{
            //    return;
            //}
            //if((last_NameTextBox.Text == null)||(last_NameTextBox.Text == ""))
            //{
            //    return;
            //}
            //if ((pSNoTextBox.Text == null) || (pSNoTextBox.Text == ""))
            //{
            //    return;
            //}
            //if ((imageTextBox.Text == null) || (imageTextBox.Text == ""))
            //{
            //    return;
            //}
            Validate();
            bindingSource1.EndEdit();
            tableAdapterManager.UpdateAll(mobiCricketLeagueDataSet);
            MessageBox.Show("Saved");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (DialogResult.OK == dr)
            {
                imageTextBox.Text = openFileDialog1.FileName;
                playerPictureBox.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            String s = mobiCricketLeagueDataSet.Cricket[int.Parse(bindingNavigatorPositionItem.Text) - 1]["Image"].ToString();
            playerPictureBox.ImageLocation = s;
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            playerPictureBox.Image = null;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (int.Parse(bindingNavigatorPositionItem.Text) == 0)
            {
                playerPictureBox.Image = null;
            }
        }
    }
}
