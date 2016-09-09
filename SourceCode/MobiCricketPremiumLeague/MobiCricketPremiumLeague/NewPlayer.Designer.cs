namespace MobiCricketPremiumLeague
{
    partial class NewPlayer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPlayer));
            this.newPlayerPanel = new System.Windows.Forms.Panel();
            this.playerInformationGroup = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bindingSourceCricket = new System.Windows.Forms.BindingSource(this.components);
            this.mobiCricketLeagueDataSet = new MobiCricketPremiumLeague.MobiCricketLeagueDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingNavigatorCricket = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cricketTableAdapter = new MobiCricketPremiumLeague.MobiCricketLeagueDataSetTableAdapters.CricketTableAdapter();
            this.tableAdapterManager = new MobiCricketPremiumLeague.MobiCricketLeagueDataSetTableAdapters.TableAdapterManager();
            this.newPlayerPanel.SuspendLayout();
            this.playerInformationGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCricket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobiCricketLeagueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCricket)).BeginInit();
            this.bindingNavigatorCricket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // newPlayerPanel
            // 
            this.newPlayerPanel.Controls.Add(this.playerInformationGroup);
            this.newPlayerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newPlayerPanel.Location = new System.Drawing.Point(0, 0);
            this.newPlayerPanel.Name = "newPlayerPanel";
            this.newPlayerPanel.Size = new System.Drawing.Size(735, 453);
            this.newPlayerPanel.TabIndex = 0;
            this.newPlayerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.newPlayerPanel_Paint);
            // 
            // playerInformationGroup
            // 
            this.playerInformationGroup.Controls.Add(this.label6);
            this.playerInformationGroup.Controls.Add(this.label5);
            this.playerInformationGroup.Controls.Add(this.label4);
            this.playerInformationGroup.Controls.Add(this.bindingNavigatorCricket);
            this.playerInformationGroup.Controls.Add(this.playerPictureBox);
            this.playerInformationGroup.Controls.Add(this.label3);
            this.playerInformationGroup.Controls.Add(this.label2);
            this.playerInformationGroup.Controls.Add(this.label1);
            this.playerInformationGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerInformationGroup.Location = new System.Drawing.Point(14, 16);
            this.playerInformationGroup.Name = "playerInformationGroup";
            this.playerInformationGroup.Size = new System.Drawing.Size(703, 423);
            this.playerInformationGroup.TabIndex = 0;
            this.playerInformationGroup.TabStop = false;
            this.playerInformationGroup.Text = "Player Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCricket, "PSNo", true));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "PsNo";
            // 
            // bindingSourceCricket
            // 
            this.bindingSourceCricket.DataMember = "Cricket";
            this.bindingSourceCricket.DataSource = this.mobiCricketLeagueDataSet;
            // 
            // mobiCricketLeagueDataSet
            // 
            this.mobiCricketLeagueDataSet.DataSetName = "MobiCricketLeagueDataSet";
            this.mobiCricketLeagueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCricket, "Last Name", true));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCricket, "First Name", true));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // bindingNavigatorCricket
            // 
            this.bindingNavigatorCricket.AddNewItem = null;
            this.bindingNavigatorCricket.BindingSource = this.bindingSourceCricket;
            this.bindingNavigatorCricket.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorCricket.DeleteItem = null;
            this.bindingNavigatorCricket.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorCricket.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigatorCricket.Location = new System.Drawing.Point(3, 395);
            this.bindingNavigatorCricket.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorCricket.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorCricket.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorCricket.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorCricket.Name = "bindingNavigatorCricket";
            this.bindingNavigatorCricket.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorCricket.Size = new System.Drawing.Size(697, 25);
            this.bindingNavigatorCricket.TabIndex = 7;
            this.bindingNavigatorCricket.Text = "bindingNavigatorCricket";
            this.bindingNavigatorCricket.RefreshItems += new System.EventHandler(this.bindingNavigatorCricket_RefreshItems);
            this.bindingNavigatorCricket.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.bindingNavigatorCricket_ItemClicked);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.TextChanged += new System.EventHandler(this.bindingNavigatorPositionItem_TextChanged);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bindingSourceCricket, "Image", true));
            this.playerPictureBox.Location = new System.Drawing.Point(336, 21);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(341, 354);
            this.playerPictureBox.TabIndex = 6;
            this.playerPictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "PS No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // cricketTableAdapter
            // 
            this.cricketTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CricketTableAdapter = this.cricketTableAdapter;
            this.tableAdapterManager.ManagerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MobiCricketPremiumLeague.MobiCricketLeagueDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // NewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newPlayerPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewPlayer";
            this.Size = new System.Drawing.Size(735, 453);
            this.newPlayerPanel.ResumeLayout(false);
            this.playerInformationGroup.ResumeLayout(false);
            this.playerInformationGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCricket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobiCricketLeagueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCricket)).EndInit();
            this.bindingNavigatorCricket.ResumeLayout(false);
            this.bindingNavigatorCricket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel newPlayerPanel;
        private System.Windows.Forms.GroupBox playerInformationGroup;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSourceCricket;
        private MobiCricketLeagueDataSet mobiCricketLeagueDataSet;
        private MobiCricketLeagueDataSetTableAdapters.CricketTableAdapter cricketTableAdapter;
        private MobiCricketLeagueDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bindingNavigatorCricket;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
