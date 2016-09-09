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
    public partial class Manager : UserControl
    {
        TreeView[] tv;
        MobiCriLeague ff;
        public Manager()
        {
            InitializeComponent();
            managerTableAdapter.Fill(mobiCricketLeagueDataSet.Manager);
            treeView1.Nodes.Add(mobiCricketLeagueDataSet.Manager[0]["Name"].ToString());
            treeView2.Nodes.Add(mobiCricketLeagueDataSet.Manager[1]["Name"].ToString());
            treeView3.Nodes.Add(mobiCricketLeagueDataSet.Manager[2]["Name"].ToString());
            treeView4.Nodes.Add(mobiCricketLeagueDataSet.Manager[3]["Name"].ToString());
            treeView5.Nodes.Add(mobiCricketLeagueDataSet.Manager[4]["Name"].ToString());
            treeView6.Nodes.Add(mobiCricketLeagueDataSet.Manager[5]["Name"].ToString());
            treeView7.Nodes.Add(mobiCricketLeagueDataSet.Manager[6]["Name"].ToString());
            
                
            
        }
        public Manager(UserControl uc,MobiCriLeague f):this()
        {
            ff = f;
            tv = new TreeView[7];
            tv[0] = treeView1;
            tv[1] = treeView2;
            tv[2] = treeView3;
            tv[3] = treeView4;
            tv[4] = treeView5;
            tv[5] = treeView6;
            tv[6] = treeView7;



            NewPlayer np = new NewPlayer();
            panel1.Controls.Add(np);
            np.Show();
            np.Dock = DockStyle.Fill;
            BidBox bb = new BidBox(np, tv, ff);
            panel2.Controls.Add(bb);
            bb.Show();
            bb.Dock = DockStyle.Fill;
                
        }

        public TreeView[] getRoster()
        {
            return tv;
        }

        private void Manager_ControlRemoved(object sender, ControlEventArgs e)
        {
            
        }

        private void Manager_Paint(object sender, PaintEventArgs e)
        {
          

            
        }
    }
}
