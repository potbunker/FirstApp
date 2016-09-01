using WeifenLuo.WinFormsUI.Docking;

namespace FirstApp
{
    partial class MainView
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
            this.mainSplit = new System.Windows.Forms.SplitContainer();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.level1Split = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonGroup = new System.Windows.Forms.GroupBox();
            this.linkLabel = new FirstApp.CustomLinkLabel();
            this.NO = new System.Windows.Forms.Button();
            this.YES = new System.Windows.Forms.Button();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.customContextMenu = new FirstApp.CustomControls.CustomContextMenuStrip();
            this.firstItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thirdItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separator = new System.Windows.Forms.ToolStripSeparator();
            this.fourthItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fifthItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).BeginInit();
            this.mainSplit.Panel1.SuspendLayout();
            this.mainSplit.Panel2.SuspendLayout();
            this.mainSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level1Split)).BeginInit();
            this.level1Split.Panel1.SuspendLayout();
            this.level1Split.Panel2.SuspendLayout();
            this.level1Split.SuspendLayout();
            this.buttonGroup.SuspendLayout();
            this.customContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplit
            // 
            this.mainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplit.Location = new System.Drawing.Point(0, 0);
            this.mainSplit.Name = "mainSplit";
            this.mainSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplit.Panel1
            // 
            this.mainSplit.Panel1.Controls.Add(this.dataGrid);
            // 
            // mainSplit.Panel2
            // 
            this.mainSplit.Panel2.Controls.Add(this.level1Split);
            this.mainSplit.Size = new System.Drawing.Size(692, 251);
            this.mainSplit.SplitterDistance = 189;
            this.mainSplit.TabIndex = 0;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(692, 189);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_CellMouseDown);
            // 
            // level1Split
            // 
            this.level1Split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.level1Split.Location = new System.Drawing.Point(0, 0);
            this.level1Split.Name = "level1Split";
            // 
            // level1Split.Panel1
            // 
            this.level1Split.Panel1.Controls.Add(this.textBox1);
            // 
            // level1Split.Panel2
            // 
            this.level1Split.Panel2.Controls.Add(this.buttonGroup);
            this.level1Split.Size = new System.Drawing.Size(692, 58);
            this.level1Split.SplitterDistance = 305;
            this.level1Split.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 58);
            this.textBox1.TabIndex = 0;
            // 
            // buttonGroup
            // 
            this.buttonGroup.Controls.Add(this.linkLabel);
            this.buttonGroup.Controls.Add(this.NO);
            this.buttonGroup.Controls.Add(this.YES);
            this.buttonGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGroup.Location = new System.Drawing.Point(0, 0);
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Size = new System.Drawing.Size(383, 58);
            this.buttonGroup.TabIndex = 0;
            this.buttonGroup.TabStop = false;
            this.buttonGroup.Text = "Choices";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(286, 37);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(55, 13);
            this.linkLabel.TabIndex = 2;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Add value";
            // 
            // NO
            // 
            this.NO.Location = new System.Drawing.Point(144, 28);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(75, 23);
            this.NO.TabIndex = 1;
            this.NO.Text = "NO";
            this.NO.UseVisualStyleBackColor = true;
            // 
            // YES
            // 
            this.YES.Location = new System.Drawing.Point(33, 29);
            this.YES.Name = "YES";
            this.YES.Size = new System.Drawing.Size(75, 23);
            this.YES.TabIndex = 0;
            this.YES.Text = "YES";
            this.YES.UseVisualStyleBackColor = true;
            // 
            // menuItem1
            // 
            this.menuItem1.Index = -1;
            this.menuItem1.Text = "";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = -1;
            this.menuItem2.Text = "";
            // 
            // customContextMenu
            // 
            this.customContextMenu.Grid = null;
            this.customContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstItem,
            this.secondItem,
            this.thirdItem,
            this.separator,
            this.fourthItem,
            this.fifthItem});
            this.customContextMenu.Name = "customContextMenu";
            this.customContextMenu.Size = new System.Drawing.Size(141, 120);
            // 
            // firstItem
            // 
            this.firstItem.Name = "firstItem";
            this.firstItem.Size = new System.Drawing.Size(140, 22);
            this.firstItem.Text = "First Item";
            // 
            // secondItem
            // 
            this.secondItem.Name = "secondItem";
            this.secondItem.Size = new System.Drawing.Size(140, 22);
            this.secondItem.Text = "Second Item";
            // 
            // thirdItem
            // 
            this.thirdItem.Name = "thirdItem";
            this.thirdItem.Size = new System.Drawing.Size(140, 22);
            this.thirdItem.Text = "Third Item";
            // 
            // separator
            // 
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(137, 6);
            // 
            // fourthItem
            // 
            this.fourthItem.Name = "fourthItem";
            this.fourthItem.Size = new System.Drawing.Size(140, 22);
            this.fourthItem.Text = "Fourth Item";
            // 
            // fifthItem
            // 
            this.fifthItem.Name = "fifthItem";
            this.fifthItem.Size = new System.Drawing.Size(140, 22);
            this.fifthItem.Text = "Firth Item";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = -1;
            this.menuItem3.Text = "First Item";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = -1;
            this.menuItem4.Text = "Second Item";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = -1;
            this.menuItem5.Text = "Third Item";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 251);
            this.Controls.Add(this.mainSplit);
            this.Name = "MainView";
            this.Text = "First Solution";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainView_Load);
            this.mainSplit.Panel1.ResumeLayout(false);
            this.mainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).EndInit();
            this.mainSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.level1Split.Panel1.ResumeLayout(false);
            this.level1Split.Panel1.PerformLayout();
            this.level1Split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.level1Split)).EndInit();
            this.level1Split.ResumeLayout(false);
            this.buttonGroup.ResumeLayout(false);
            this.buttonGroup.PerformLayout();
            this.customContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplit;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.SplitContainer level1Split;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox buttonGroup;
        private System.Windows.Forms.Button NO;
        private System.Windows.Forms.Button YES;
        private CustomLinkLabel linkLabel;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private CustomControls.CustomContextMenuStrip customContextMenu;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.ToolStripMenuItem firstItem;
        private System.Windows.Forms.ToolStripMenuItem secondItem;
        private System.Windows.Forms.ToolStripMenuItem thirdItem;
        private System.Windows.Forms.ToolStripSeparator separator;
        private System.Windows.Forms.ToolStripMenuItem fourthItem;
        private System.Windows.Forms.ToolStripMenuItem fifthItem;
    }
}

