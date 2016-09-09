using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MobiCricketPremiumLeague
{
    public partial class NewPlayer : UserControl
    {
        public NewPlayer()
        {
            InitializeComponent();
            playerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            
                //Byte[] MyData;
                //MyData = (byte[])ob;
                //MemoryStream stream = new MemoryStream(MyData);
                ////With the code below, you are in fact converting the byte array of image
                ////to the real image.
                //playerPictureBox.Image = Image.FromStream(stream);
        }
        public NewPlayer(UserControl uc):this()
        {

        }
        public void deletePlayer()
        {
            
            mobiCricketLeagueDataSet.Cricket.Rows[int.Parse(bindingNavigatorPositionItem.Text) - 1].Delete();
            Validate();
            bindingSourceCricket.EndEdit();
            tableAdapterManager.UpdateAll(mobiCricketLeagueDataSet);
            

        }
        public String currentPlayerName()
        {
            String s = mobiCricketLeagueDataSet.Cricket[int.Parse(bindingNavigatorPositionItem.Text) - 1]["First Name"].ToString() + " " + mobiCricketLeagueDataSet.Cricket[int.Parse(bindingNavigatorPositionItem.Text) - 1]["Last Name"].ToString();
            return s;
        }

        private void bindingNavigatorCricket_RefreshItems(object sender, EventArgs e)
        {

        }

        public void block()
        {
            newPlayerPanel.Enabled = false;
        }
        public void unblock()
        {
            newPlayerPanel.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DialogResult dr = openFileDialog1.ShowDialog();
            //if (DialogResult.OK == dr)
            //{
            //    playerPictureBox.ImageLocation = openFileDialog1.FileName;
            //}
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorCricket_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
        public int playersLeft()
        {
            return int.Parse(bindingNavigatorPositionItem.Text);
        }
        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            String s = mobiCricketLeagueDataSet.Cricket[int.Parse(bindingNavigatorPositionItem.Text) - 1]["Image"].ToString();
            playerPictureBox.ImageLocation = s;
        }
        public void updateImage()
        {
            String s = mobiCricketLeagueDataSet.Cricket[int.Parse(bindingNavigatorPositionItem.Text) - 1]["Image"].ToString();
            playerPictureBox.ImageLocation = s;
        }

        private void newPlayerPanel_Paint(object sender, PaintEventArgs e)
        {
            cricketTableAdapter.Fill(mobiCricketLeagueDataSet.Cricket);
            if (mobiCricketLeagueDataSet.Cricket.Rows.Count > 0)
            {
                String s = mobiCricketLeagueDataSet.Cricket[0]["Image"].ToString();
                playerPictureBox.ImageLocation = s;
            }
        }
    }
}
