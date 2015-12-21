namespace SQL_KB
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("root");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lswSQLItems = new System.Windows.Forms.ListView();
            this.Prop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDescr = new System.Windows.Forms.Label();
            this.KBTreeView = new System.Windows.Forms.TreeView();
            this.cmsTW = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tstAddNewSrvr = new System.Windows.Forms.ToolStripTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.cmsTW.SuspendLayout();
            this.SuspendLayout();
            // 
            // lswSQLItems
            // 
            this.lswSQLItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lswSQLItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Prop,
            this.Value});
            this.lswSQLItems.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lswSQLItems.FullRowSelect = true;
            this.lswSQLItems.GridLines = true;
            this.lswSQLItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lswSQLItems.Location = new System.Drawing.Point(353, 12);
            this.lswSQLItems.MaximumSize = new System.Drawing.Size(261, 298);
            this.lswSQLItems.MinimumSize = new System.Drawing.Size(261, 298);
            this.lswSQLItems.Name = "lswSQLItems";
            this.lswSQLItems.Size = new System.Drawing.Size(261, 298);
            this.lswSQLItems.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lswSQLItems.TabIndex = 0;
            this.lswSQLItems.UseCompatibleStateImageBehavior = false;
            this.lswSQLItems.View = System.Windows.Forms.View.Details;
            this.lswSQLItems.Click += new System.EventHandler(this.lswSQLItems_Click);
            // 
            // Prop
            // 
            this.Prop.Text = "Prop";
            this.Prop.Width = 120;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 120;
            // 
            // lblDescr
            // 
            this.lblDescr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescr.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDescr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescr.Font = new System.Drawing.Font("Bodoni MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescr.ForeColor = System.Drawing.Color.Black;
            this.lblDescr.Location = new System.Drawing.Point(620, 12);
            this.lblDescr.MaximumSize = new System.Drawing.Size(198, 298);
            this.lblDescr.MinimumSize = new System.Drawing.Size(198, 298);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(198, 298);
            this.lblDescr.TabIndex = 1;
            this.lblDescr.Text = "...";
            // 
            // KBTreeView
            // 
            this.KBTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KBTreeView.ContextMenuStrip = this.cmsTW;
            this.KBTreeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KBTreeView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KBTreeView.FullRowSelect = true;
            this.KBTreeView.ImageIndex = 0;
            this.KBTreeView.ImageList = this.imageList1;
            this.KBTreeView.Location = new System.Drawing.Point(12, 12);
            this.KBTreeView.Name = "KBTreeView";
            treeNode1.Name = "Root";
            treeNode1.Text = "root";
            this.KBTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.KBTreeView.SelectedImageIndex = 0;
            this.KBTreeView.Size = new System.Drawing.Size(335, 298);
            this.KBTreeView.TabIndex = 3;
            this.KBTreeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KBTreeView_MouseUp);
            // 
            // cmsTW
            // 
            this.cmsTW.AutoSize = false;
            this.cmsTW.BackColor = System.Drawing.Color.Silver;
            this.cmsTW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmsTW.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsTW.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstAddNewSrvr});
            this.cmsTW.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.cmsTW.Name = "cmsTW";
            this.cmsTW.ShowItemToolTips = false;
            this.cmsTW.Size = new System.Drawing.Size(200, 25);
            this.cmsTW.Paint += new System.Windows.Forms.PaintEventHandler(this.cmsTW_Paint);
            // 
            // tstAddNewSrvr
            // 
            this.tstAddNewSrvr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tstAddNewSrvr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tstAddNewSrvr.AutoSize = false;
            this.tstAddNewSrvr.BackColor = System.Drawing.Color.White;
            this.tstAddNewSrvr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstAddNewSrvr.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstAddNewSrvr.HideSelection = false;
            this.tstAddNewSrvr.Margin = new System.Windows.Forms.Padding(0);
            this.tstAddNewSrvr.Name = "tstAddNewSrvr";
            this.tstAddNewSrvr.ShortcutsEnabled = false;
            this.tstAddNewSrvr.Size = new System.Drawing.Size(165, 21);
            this.tstAddNewSrvr.Text = "...";
            this.tstAddNewSrvr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tstAddNewSrvr_KeyDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "SQL16x16.ICO");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.KBTreeView);
            this.Controls.Add(this.lblDescr);
            this.Controls.Add(this.lswSQLItems);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "SQL KB";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.cmsTW.ResumeLayout(false);
            this.cmsTW.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lswSQLItems;
        private System.Windows.Forms.ColumnHeader Prop;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.TreeView KBTreeView;
        private System.Windows.Forms.ContextMenuStrip cmsTW;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripTextBox tstAddNewSrvr;
        private System.Windows.Forms.Button button1;
    }
}

