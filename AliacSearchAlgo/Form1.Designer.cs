namespace AliacSearchAlgo
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveNodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadNodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninformedSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depthFirstSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breadthFirstSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fullSearchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uniformCostSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infromedSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hillClimbingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullSearchToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withoutValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectNodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setGoalNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllNodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNodeValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.showNodeValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.nodesToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.resetSearchToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.programToolStripMenuItem.Text = "Program ";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // nodesToolStripMenuItem
            // 
            this.nodesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveNodesToolStripMenuItem,
            this.loadNodesToolStripMenuItem});
            this.nodesToolStripMenuItem.Name = "nodesToolStripMenuItem";
            this.nodesToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.nodesToolStripMenuItem.Text = "Nodes ";
            // 
            // saveNodesToolStripMenuItem
            // 
            this.saveNodesToolStripMenuItem.Name = "saveNodesToolStripMenuItem";
            this.saveNodesToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.saveNodesToolStripMenuItem.Text = "Save Nodes";
            this.saveNodesToolStripMenuItem.Click += new System.EventHandler(this.saveNodesToolStripMenuItem_Click);
            // 
            // loadNodesToolStripMenuItem
            // 
            this.loadNodesToolStripMenuItem.Name = "loadNodesToolStripMenuItem";
            this.loadNodesToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.loadNodesToolStripMenuItem.Text = "Load Nodes";
            this.loadNodesToolStripMenuItem.Click += new System.EventHandler(this.loadNodesToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uninformedSearchToolStripMenuItem,
            this.depthFirstSearchToolStripMenuItem,
            this.breadthFirstSearchToolStripMenuItem,
            this.uniformCostSearchToolStripMenuItem,
            this.infromedSearchToolStripMenuItem,
            this.hillClimbingToolStripMenuItem,
            this.aSearchToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // uninformedSearchToolStripMenuItem
            // 
            this.uninformedSearchToolStripMenuItem.Enabled = false;
            this.uninformedSearchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.uninformedSearchToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uninformedSearchToolStripMenuItem.Name = "uninformedSearchToolStripMenuItem";
            this.uninformedSearchToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.uninformedSearchToolStripMenuItem.Text = "Uninformed Search";
            // 
            // depthFirstSearchToolStripMenuItem
            // 
            this.depthFirstSearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stepToolStripMenuItem,
            this.fullSearchToolStripMenuItem});
            this.depthFirstSearchToolStripMenuItem.Name = "depthFirstSearchToolStripMenuItem";
            this.depthFirstSearchToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.depthFirstSearchToolStripMenuItem.Text = "Depth First Search";
            // 
            // stepToolStripMenuItem
            // 
            this.stepToolStripMenuItem.Name = "stepToolStripMenuItem";
            this.stepToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.stepToolStripMenuItem.Text = "Step";
            this.stepToolStripMenuItem.Click += new System.EventHandler(this.stepToolStripMenuItem_Click);
            // 
            // fullSearchToolStripMenuItem
            // 
            this.fullSearchToolStripMenuItem.Name = "fullSearchToolStripMenuItem";
            this.fullSearchToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.fullSearchToolStripMenuItem.Text = "Full Search";
            this.fullSearchToolStripMenuItem.Click += new System.EventHandler(this.fullSearchToolStripMenuItem_Click);
            // 
            // breadthFirstSearchToolStripMenuItem
            // 
            this.breadthFirstSearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stepToolStripMenuItem1,
            this.fullSearchToolStripMenuItem1});
            this.breadthFirstSearchToolStripMenuItem.Name = "breadthFirstSearchToolStripMenuItem";
            this.breadthFirstSearchToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.breadthFirstSearchToolStripMenuItem.Text = "Breadth First Search";
            // 
            // stepToolStripMenuItem1
            // 
            this.stepToolStripMenuItem1.Name = "stepToolStripMenuItem1";
            this.stepToolStripMenuItem1.Size = new System.Drawing.Size(163, 26);
            this.stepToolStripMenuItem1.Text = "Step";
            this.stepToolStripMenuItem1.Click += new System.EventHandler(this.stepToolStripMenuItem1_Click);
            // 
            // fullSearchToolStripMenuItem1
            // 
            this.fullSearchToolStripMenuItem1.Name = "fullSearchToolStripMenuItem1";
            this.fullSearchToolStripMenuItem1.Size = new System.Drawing.Size(163, 26);
            this.fullSearchToolStripMenuItem1.Text = "Full Search";
            this.fullSearchToolStripMenuItem1.Click += new System.EventHandler(this.fullSearchToolStripMenuItem1_Click);
            // 
            // uniformCostSearchToolStripMenuItem
            // 
            this.uniformCostSearchToolStripMenuItem.Name = "uniformCostSearchToolStripMenuItem";
            this.uniformCostSearchToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.uniformCostSearchToolStripMenuItem.Text = "Uniform Cost Search";
            this.uniformCostSearchToolStripMenuItem.Click += new System.EventHandler(this.uniformCostSearchToolStripMenuItem_Click);
            // 
            // infromedSearchToolStripMenuItem
            // 
            this.infromedSearchToolStripMenuItem.Enabled = false;
            this.infromedSearchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.infromedSearchToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.infromedSearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.infromedSearchToolStripMenuItem.Name = "infromedSearchToolStripMenuItem";
            this.infromedSearchToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.infromedSearchToolStripMenuItem.Text = "Infromed Search";
            // 
            // hillClimbingToolStripMenuItem
            // 
            this.hillClimbingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullSearchToolStripMenuItem2});
            this.hillClimbingToolStripMenuItem.Name = "hillClimbingToolStripMenuItem";
            this.hillClimbingToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.hillClimbingToolStripMenuItem.Text = "Hill Climbing";
            this.hillClimbingToolStripMenuItem.Click += new System.EventHandler(this.hillClimbingToolStripMenuItem_Click);
            // 
            // fullSearchToolStripMenuItem2
            // 
            this.fullSearchToolStripMenuItem2.Name = "fullSearchToolStripMenuItem2";
            this.fullSearchToolStripMenuItem2.Size = new System.Drawing.Size(163, 26);
            this.fullSearchToolStripMenuItem2.Text = "Full Search";
            this.fullSearchToolStripMenuItem2.Click += new System.EventHandler(this.fullSearchToolStripMenuItem2_Click);
            // 
            // aSearchToolStripMenuItem
            // 
            this.aSearchToolStripMenuItem.Name = "aSearchToolStripMenuItem";
            this.aSearchToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.aSearchToolStripMenuItem.Text = "A* Search";
            this.aSearchToolStripMenuItem.Click += new System.EventHandler(this.aSearchToolStripMenuItem_Click);
            // 
            // resetSearchToolStripMenuItem
            // 
            this.resetSearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.moveNodeToolStripMenuItem,
            this.removeNodeToolStripMenuItem,
            this.connectNodesToolStripMenuItem,
            this.setStartToolStripMenuItem,
            this.setGoalNodeToolStripMenuItem,
            this.clearAllNodesToolStripMenuItem,
            this.editNodeValuesToolStripMenuItem,
            this.showNodeValuesToolStripMenuItem});
            this.resetSearchToolStripMenuItem.Name = "resetSearchToolStripMenuItem";
            this.resetSearchToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.resetSearchToolStripMenuItem.Text = "Node Settings";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withValueToolStripMenuItem,
            this.withoutValueToolStripMenuItem});
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.normalToolStripMenuItem.Text = "Create Nodes";
            // 
            // withValueToolStripMenuItem
            // 
            this.withValueToolStripMenuItem.Name = "withValueToolStripMenuItem";
            this.withValueToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.withValueToolStripMenuItem.Text = "With Value";
            this.withValueToolStripMenuItem.Click += new System.EventHandler(this.withValueToolStripMenuItem_Click);
            // 
            // withoutValueToolStripMenuItem
            // 
            this.withoutValueToolStripMenuItem.Name = "withoutValueToolStripMenuItem";
            this.withoutValueToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.withoutValueToolStripMenuItem.Text = "Without Value";
            this.withoutValueToolStripMenuItem.Click += new System.EventHandler(this.withoutValueToolStripMenuItem_Click);
            // 
            // moveNodeToolStripMenuItem
            // 
            this.moveNodeToolStripMenuItem.Name = "moveNodeToolStripMenuItem";
            this.moveNodeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.moveNodeToolStripMenuItem.Text = "Move Node";
            this.moveNodeToolStripMenuItem.Click += new System.EventHandler(this.moveNodeToolStripMenuItem_Click);
            // 
            // removeNodeToolStripMenuItem
            // 
            this.removeNodeToolStripMenuItem.Name = "removeNodeToolStripMenuItem";
            this.removeNodeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.removeNodeToolStripMenuItem.Text = "Remove Node";
            this.removeNodeToolStripMenuItem.Click += new System.EventHandler(this.removeNodeToolStripMenuItem_Click);
            // 
            // connectNodesToolStripMenuItem
            // 
            this.connectNodesToolStripMenuItem.Name = "connectNodesToolStripMenuItem";
            this.connectNodesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.connectNodesToolStripMenuItem.Text = "Connect Nodes";
            this.connectNodesToolStripMenuItem.Click += new System.EventHandler(this.connectNodesToolStripMenuItem_Click);
            // 
            // setStartToolStripMenuItem
            // 
            this.setStartToolStripMenuItem.Name = "setStartToolStripMenuItem";
            this.setStartToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.setStartToolStripMenuItem.Text = "Set Start Node";
            this.setStartToolStripMenuItem.Click += new System.EventHandler(this.setStartToolStripMenuItem_Click);
            // 
            // setGoalNodeToolStripMenuItem
            // 
            this.setGoalNodeToolStripMenuItem.Name = "setGoalNodeToolStripMenuItem";
            this.setGoalNodeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.setGoalNodeToolStripMenuItem.Text = "Set Goal Node";
            this.setGoalNodeToolStripMenuItem.Click += new System.EventHandler(this.setGoalNodeToolStripMenuItem_Click);
            // 
            // clearAllNodesToolStripMenuItem
            // 
            this.clearAllNodesToolStripMenuItem.Name = "clearAllNodesToolStripMenuItem";
            this.clearAllNodesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clearAllNodesToolStripMenuItem.Text = "Clear all nodes";
            this.clearAllNodesToolStripMenuItem.Click += new System.EventHandler(this.clearAllNodesToolStripMenuItem_Click);
            // 
            // editNodeValuesToolStripMenuItem
            // 
            this.editNodeValuesToolStripMenuItem.Name = "editNodeValuesToolStripMenuItem";
            this.editNodeValuesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editNodeValuesToolStripMenuItem.Text = "Edit Node Values";
            this.editNodeValuesToolStripMenuItem.Click += new System.EventHandler(this.editNodeValuesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox1.Location = new System.Drawing.Point(16, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(884, 485);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(732, 522);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 2;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(562, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(502, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Value:";
            this.label3.Visible = false;
            // 
            // showNodeValuesToolStripMenuItem
            // 
            this.showNodeValuesToolStripMenuItem.Name = "showNodeValuesToolStripMenuItem";
            this.showNodeValuesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.showNodeValuesToolStripMenuItem.Text = "Show Node Values";
            this.showNodeValuesToolStripMenuItem.Click += new System.EventHandler(this.showNodeValuesToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 36);
            this.label4.TabIndex = 7;
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 567);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Search Algorithm by Chris Jordan Aliac";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveNodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadNodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depthFirstSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breadthFirstSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hillClimbingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNodeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem connectNodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setGoalNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllNodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fullSearchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fullSearchToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem withValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withoutValueToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem uniformCostSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uninformedSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infromedSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNodeValuesToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem aSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showNodeValuesToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}

