using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace MobiCricketPremiumLeague
{
    public partial class MobiCriLeague : Form
    {
        // Xml tag for node, e.g. 'node' in case of <node></node>
        private const string XmlNodeTag = "player";

        // Xml attributes for node e.g. <node text="Asia" tag="" 
        // imageindex="1"></node>
        private const string XmlNodeTextAtt = "name";
        private const string XmlNodeTagAtt = "tag";
        private const string XmlNodeImageIndexAtt = "imageindex";
        UserControl activeUserControl;
        UserControl bidBoxControl;
        public MobiCriLeague()
        {
            InitializeComponent();
            bidBoxControl = null;
            NewPlayer np = new NewPlayer();
            activeUserControl = np;
            mainPanel.Controls.Add(np);
            np.Show();
            np.Dock = DockStyle.Fill;
        }

        private void enterPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activeUserControl != null)
            {
                mainPanel.Controls.Remove(activeUserControl);
            }
            AddPlayer np = new AddPlayer(activeUserControl);
            mainPanel.Controls.Add(np);
            activeUserControl = np;
            mainPanel.Controls.Add(np);
            np.Show();
            np.Dock = DockStyle.Fill;

        }

        private void MobiCriLeague_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

        private void viewPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activeUserControl != null)
            {
                mainPanel.Controls.Remove(activeUserControl);
            }
            NewPlayer np = new NewPlayer(activeUserControl);
            mainPanel.Controls.Add(np);
            activeUserControl = np;
            mainPanel.Controls.Add(np);
            np.Show();
            np.Dock = DockStyle.Fill;
        }

        private void beginBidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editManagersToolStripMenuItem.Enabled = false;
            if (activeUserControl != null)
            {
                mainPanel.Controls.Remove(activeUserControl);
            }
            if (bidBoxControl != null)
            {
                mainPanel.Controls.Add(bidBoxControl);
                activeUserControl = bidBoxControl;
            }
            else
            {
                Manager np = new Manager(activeUserControl, this);
                mainPanel.Controls.Add(np);
                activeUserControl = np;
                bidBoxControl = np;
                mainPanel.Controls.Add(np);
                np.Show();
                np.Dock = DockStyle.Fill;
            }

        }

        private void rosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activeUserControl.GetType().ToString() == "MobiCricketPremiumLeague.Manager")
            {
                //DoMerge(((Manager)activeUserControl).getRoster()[0], ((Manager)activeUserControl).getRoster()[1]);
                //DoMerge(((Manager)activeUserControl).getRoster()[0], ((Manager)activeUserControl).getRoster()[2]);
                //DoMerge(((Manager)activeUserControl).getRoster()[0], ((Manager)activeUserControl).getRoster()[3]);
                //DoMerge(((Manager)activeUserControl).getRoster()[0], ((Manager)activeUserControl).getRoster()[4]);
                //DoMerge(((Manager)activeUserControl).getRoster()[0], ((Manager)activeUserControl).getRoster()[5]);
                //DoMerge(((Manager)activeUserControl).getRoster()[0], ((Manager)activeUserControl).getRoster()[6]);
                TextWriter ss = new StreamWriter("C:\\Roster.xml", false, System.Text.Encoding.ASCII);
                XmlTextWriter textWriter = new XmlTextWriter(ss);
                // writing the xml declaration tag
                textWriter.WriteStartDocument();
                //textWriter.WriteRaw("\r\n");
                // writing the main tag that encloses all node tags
                textWriter.WriteStartElement("Roster");
                SerializeTreeView(((Manager)activeUserControl).getRoster()[0], textWriter);
                SerializeTreeView(((Manager)activeUserControl).getRoster()[1], textWriter);
                SerializeTreeView(((Manager)activeUserControl).getRoster()[2], textWriter);
                SerializeTreeView(((Manager)activeUserControl).getRoster()[3], textWriter);
                SerializeTreeView(((Manager)activeUserControl).getRoster()[4], textWriter);
                SerializeTreeView(((Manager)activeUserControl).getRoster()[5], textWriter);
                SerializeTreeView(((Manager)activeUserControl).getRoster()[6], textWriter);
                textWriter.WriteEndElement();
                textWriter.Close();
                MessageBox.Show("Roster Saved at location : C:\\Roster.xml");
                
            }
        }

        private void DoMerge(TreeView target, TreeView source) 
        {
            if (source == null || target == null) { return; }

            foreach (TreeNode n in source.Nodes) 
            {
                    target.Nodes.Add(n);
            }
        }
        public void SerializeTreeView(TreeView treeView, XmlTextWriter textWriter)
        {
            

            // save the nodes, recursive method
            SaveNodes(treeView.Nodes, textWriter);

            
        }
        private void SaveNodes(TreeNodeCollection nodesCollection,XmlTextWriter textWriter)
        {
            for (int i = 0; i < nodesCollection.Count; i++)
            {
                TreeNode node = nodesCollection[i];
                textWriter.WriteStartElement("manager");
                textWriter.WriteAttributeString(XmlNodeTextAtt, node.Text);

                for (int j = 0; j < node.Nodes.Count; ++j)
                {
                    TreeNode node1 = node.Nodes[j];
                    textWriter.WriteStartElement("player");
                    textWriter.WriteAttributeString(XmlNodeTextAtt,node1.Text);
                    textWriter.WriteEndElement();
                }
             textWriter.WriteEndElement();
            }

        }

        private void supportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr=MessageBox.Show("Application Created by Faizan Amin, help will be provided by all means", "Help", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (DialogResult.Cancel == dr)
            {
                MessageBox.Show("Did you really fell for that, application is created by Gurleen Singh - 9920738258", "True Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editManagersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activeUserControl != null)
            {
                mainPanel.Controls.Remove(activeUserControl);
            }
            ManagerEdit np = new ManagerEdit(activeUserControl);
            mainPanel.Controls.Add(np);
            activeUserControl = np;
            mainPanel.Controls.Add(np);
            np.Show();
            np.Dock = DockStyle.None;

        }
        
    }
}
