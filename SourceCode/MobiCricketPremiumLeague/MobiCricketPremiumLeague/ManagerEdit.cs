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
    public partial class ManagerEdit : UserControl
    {
        public ManagerEdit()
        {
            InitializeComponent();
            managerTableAdapter.Fill(mobiCricketLeagueDataSet.Manager);
        }
        public ManagerEdit(UserControl uc): this()
        {
        }

        private void managerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.managerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mobiCricketLeagueDataSet);
            MessageBox.Show("Saved");

        }
    }
}
