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
    public partial class BidBox : UserControl
    {
        int manager, bid;
        UserControl upc;
        TreeView[] tv;
        NewPlayer np;
        MobiCriLeague mcl;
        int mng1, mng2, mng3, mng4, mng5, mng6, mng7;
        public BidBox()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            Stop.Enabled = false;
            manager = 0;
            bid = 0;
            managerTableAdapter.Fill(mobiCricketLeagueDataSet1.Manager);
            manager1.Text = String.Format("{0:0,0}",int.Parse(mobiCricketLeagueDataSet1.Manager[0]["Money"].ToString()));
            manager2.Text = String.Format("{0:0,0}",int.Parse(mobiCricketLeagueDataSet1.Manager[1]["Money"].ToString()));
            manager3.Text = String.Format("{0:0,0}",int.Parse(mobiCricketLeagueDataSet1.Manager[2]["Money"].ToString()));
            manager4.Text = String.Format("{0:0,0}",int.Parse(mobiCricketLeagueDataSet1.Manager[3]["Money"].ToString()));
            manager5.Text = String.Format("{0:0,0}",int.Parse(mobiCricketLeagueDataSet1.Manager[4]["Money"].ToString()));
            manager6.Text = String.Format("{0:0,0}",int.Parse(mobiCricketLeagueDataSet1.Manager[5]["Money"].ToString()));
            manager7.Text = String.Format("{0:0,0}",int.Parse(mobiCricketLeagueDataSet1.Manager[6]["Money"].ToString()));
            mng1 = int.Parse(mobiCricketLeagueDataSet1.Manager[0]["Money"].ToString());
            mng2 = int.Parse(mobiCricketLeagueDataSet1.Manager[1]["Money"].ToString());
            mng3 = int.Parse(mobiCricketLeagueDataSet1.Manager[2]["Money"].ToString());
            mng4 = int.Parse(mobiCricketLeagueDataSet1.Manager[3]["Money"].ToString());
            mng5 = int.Parse(mobiCricketLeagueDataSet1.Manager[4]["Money"].ToString());
            mng6 = int.Parse(mobiCricketLeagueDataSet1.Manager[5]["Money"].ToString());
            mng7 = int.Parse(mobiCricketLeagueDataSet1.Manager[6]["Money"].ToString());
            button1.Text = mobiCricketLeagueDataSet1.Manager[0]["Name"].ToString();
            button2.Text = mobiCricketLeagueDataSet1.Manager[1]["Name"].ToString();
            button3.Text = mobiCricketLeagueDataSet1.Manager[2]["Name"].ToString();
            button4.Text = mobiCricketLeagueDataSet1.Manager[3]["Name"].ToString();
            button5.Text = mobiCricketLeagueDataSet1.Manager[4]["Name"].ToString();
            button6.Text = mobiCricketLeagueDataSet1.Manager[5]["Name"].ToString();
            button7.Text = mobiCricketLeagueDataSet1.Manager[6]["Name"].ToString();
        }
        public BidBox(UserControl uc, TreeView[] tvw, MobiCriLeague temp) : this() { upc = uc; tv = tvw; np = (NewPlayer)upc; mcl = temp; }
        private void balanceMoney()
        {
            if (manager == 1)
            {
                
                manager1.Text = String.Format("{0:0,0}",int.Parse((mng1 + bid).ToString()));
                mng1 += bid;
            }
            else if (manager == 2)
            {
                
                manager2.Text = String.Format("{0:0,0}",int.Parse((mng2 + bid).ToString()));
                mng2 += bid;
            }
            else if (manager == 3)
            {
                
                manager3.Text = String.Format("{0:0,0}",int.Parse((mng3 + bid).ToString()));
                mng3 += bid;
            }
            else if (manager == 4)
            {
                
                manager4.Text = String.Format("{0:0,0}",int.Parse((mng4 + bid).ToString()));
                mng4 += bid;
            }
            else if (manager == 5)
            {
                
                manager5.Text = String.Format("{0:0,0}",int.Parse((mng5 + bid).ToString()));
                mng5 += bid;
            }
            else if (manager == 6)
            {
                
                manager6.Text = String.Format("{0:0,0}",int.Parse((mng6 + bid).ToString()));
                mng6 += bid;
            }
            else if (manager == 7)
            {
                
                manager7.Text = String.Format("{0:0,0}",int.Parse((mng7 + bid).ToString()));
                mng7 += bid;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClockRefresh.Enabled = false;
            Money mm = new Money();
            mm.ShowDialog();
            int x = mm.bidMoney();
            if (x <= bid)
            {
                MessageBox.Show("Bid Money less than already bid by previous manager, recheck ammount", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClockRefresh.Enabled = true;
                return;
            }
            else if (x > mng1)
            {
                MessageBox.Show("Don't have sufficient funds!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClockRefresh.Enabled = true;
                return;
            }
            manager1.Text=String.Format("{0:0,0}",int.Parse((mng1 - x).ToString()));
            mng1 -= x;
            label1.Text = button1.Text;
            label3.Text = x.ToString();
            balanceMoney();
            manager = 1;
            bid = x;
            Start_Click(sender, e);
            ClockRefresh.Enabled = true;
            Start.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClockRefresh.Enabled = false;
            Money mm = new Money();
            mm.ShowDialog();
            int x = mm.bidMoney();
            if (x <= bid)
            {
                MessageBox.Show("Bid Money less than already bid by previous manager, recheck ammount", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClockRefresh.Enabled = true;
                return;
            }
            else if (x > mng2)
            {
                MessageBox.Show("Don't have sufficient funds!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClockRefresh.Enabled = true;
                return;
            }
            manager2.Text = String.Format("{0:0,0}",int.Parse((mng2 - x).ToString()));
            mng2 -= x;
            label1.Text = button2.Text;
            label3.Text = x.ToString();
            balanceMoney();
            manager = 2;
            bid = x;
            Start_Click(sender, e);
            ClockRefresh.Enabled = true;
            Start.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClockRefresh.Enabled = false;
            Money mm = new Money();
            mm.ShowDialog();
            int x = mm.bidMoney();
            if (x <= bid)
            {
                MessageBox.Show("Bid Money less than already bid by previous manager, recheck ammount", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClockRefresh.Enabled = true;
                return;
            }
            else if (x > mng3)
            {
                MessageBox.Show("Don't have sufficient funds!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClockRefresh.Enabled = true;
                return;
            }
            manager3.Text = String.Format("{0:0,0}",int.Parse((mng3 - x).ToString()));
            mng3 -= x;
            label1.Text = button3.Text;
            label3.Text = x.ToString();
            balanceMoney();
            manager = 3;
            bid = x;
            Start_Click(sender, e);
            ClockRefresh.Enabled = true;
            Start.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClockRefresh.Enabled = false;
            Money mm = new Money();
            mm.ShowDialog();
            int x = mm.bidMoney();
            if (x <= bid)
            {
                MessageBox.Show("Bid Money less than already bid by previous manager, recheck ammount", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClockRefresh.Enabled = true;
                return;
            }
            else if (x > mng4)
            {
                MessageBox.Show("Don't have sufficient funds!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClockRefresh.Enabled = true;
                return;
            }
            manager4.Text = String.Format("{0:0,0}",int.Parse((mng4 - x).ToString()));
            mng4 -= x;
            label1.Text = button4.Text;
            label3.Text = x.ToString();
            balanceMoney();
            manager = 4;
            bid = x;
            Start_Click(sender, e);
            ClockRefresh.Enabled = true;
            Start.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClockRefresh.Enabled = false;
            Money mm = new Money();
            mm.ShowDialog();
            int x = mm.bidMoney();
            if (x <= bid)
            {
                MessageBox.Show("Bid Money less than already bid by previous manager, recheck ammount", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClockRefresh.Enabled = true;
                return;
            }
            else if (x > mng5)
            {
                MessageBox.Show("Don't have sufficient funds!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClockRefresh.Enabled = true;
                return;
            }
            manager5.Text = String.Format("{0:0,0}",int.Parse((mng5 - x).ToString()));
            mng5 -= x;
            label1.Text = button5.Text;
            label3.Text = x.ToString();
            balanceMoney();
            manager = 5;
            bid = x;
            Start_Click(sender, e);
            ClockRefresh.Enabled = true;
            Start.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClockRefresh.Enabled = false;
            Money mm = new Money();
            mm.ShowDialog();
            int x = mm.bidMoney();
            if (x <= bid)
            {
                MessageBox.Show("Bid Money less than already bid by previous manager, recheck ammount", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClockRefresh.Enabled = true;
                return;
            }
            else if (x > mng6)
            {
                MessageBox.Show("Don't have sufficient funds!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClockRefresh.Enabled = true;
                return;
            }
            manager6.Text = String.Format("{0:0,0}",int.Parse((mng6 - x).ToString()));
            mng6 -= x;
            label1.Text = button6.Text;
            label3.Text = x.ToString();
            balanceMoney();
            manager = 6;
            bid = x;
            Start_Click(sender, e);
            ClockRefresh.Enabled = true;
            Start.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ClockRefresh.Enabled = false;
            Money mm = new Money();
            mm.ShowDialog();
            int x = mm.bidMoney();
            if (x <= bid)
            {
                MessageBox.Show("Bid Money less than already bid by previous manager, recheck ammount", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClockRefresh.Enabled = true;
                return;
            }
            else if (x > mng7)
            {
                MessageBox.Show("Don't have sufficient funds!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClockRefresh.Enabled = true;
                return;
            }
            manager7.Text = String.Format("{0:0,0}",int.Parse((mng7 - x).ToString()));
            mng7 -= x;
            label1.Text = button7.Text;
            label3.Text = x.ToString();
            balanceMoney();
            manager = 7;
            bid = x;
            Start_Click(sender, e);
            ClockRefresh.Enabled = true;
            Start.Enabled = false;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.Parent.Parent.Parent.Parent.Parent.GetType().ToString());
            labelTime.Text = "15";
            ClockRefresh.Enabled = true;
            Start.Enabled = false;
            Stop.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            np.block();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            ClockRefresh.Enabled = false;
            np.unblock();
            MessageBox.Show("Bidding Stopped in between", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            balanceMoney();
            label1.Text = "Manager";
            label3.Text = "Money";
            bid = 0;
            manager = 0;
            Start.Enabled = true;
            Stop.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
        }

        private void ClockRefresh_Tick(object sender, EventArgs e)
        {
            labelTime.Text=(int.Parse(labelTime.Text) - 1).ToString();
            if (labelTime.Text == "0")
            {
                String result = np.currentPlayerName();
                if (label1.Text != "Manager")
                {
                    mobiCricketLeagueDataSet1.Manager[manager - 1]["Money"] = (int.Parse(mobiCricketLeagueDataSet1.Manager[manager - 1]["Money"].ToString()) - bid).ToString();
                    ClockRefresh.Enabled = false;
                    MessageBox.Show(label1.Text + " has bought the player "+result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    np.unblock();
                    np.deletePlayer();
                    tv[manager - 1].Nodes[0].Nodes.Add(result);
                    

                }
                else
                {
                    ClockRefresh.Enabled = false;
                    np.unblock();
                    MessageBox.Show(result + " player not bought", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                label1.Text="Manager";
                label3.Text="Money";
                bid = 0;
                manager = 0;
                labelTime.Text = "15";
                Start.Enabled = true;
                Stop.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                if (np.playersLeft() == 0)
                {
                    Start.Enabled = false;
                }
                else
                {
                    np.updateImage();
                }
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BidBox_Paint(object sender, PaintEventArgs e)
        {
           
        }

    }
}
