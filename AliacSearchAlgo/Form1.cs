﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using AISearchSample;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AliacSearchAlgo
{
    public partial class Form1 : Form
    {
        ArrayList nodes; // set of nodes for display of points
        int count;
        int state = 0; // 0=normal, 1=move , 2 remove, 3 connect nodes;
        bool open;
        bool movetoggle;
        bool connectoggle;
        bool nodeWithVal;
        int from;
        int to;
        int start;
        int goal;
        int totalCost;
        Node explored;
        Search search;
        HillSearch hillsearch;

        public Form1()
        {
            InitializeComponent();
            nodes = new ArrayList();
            state = 0;
            open = true;
            count = 0x41;
            movetoggle = false;
            connectoggle = false;
            nodeWithVal = false;
            from = -1;
            to = -1;
            start = -1;
            goal = -1;
            totalCost = 0;
            explored = null;
            search = null;
           
                        
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string searchopen(int ex,int ey)
        {
            String str="";
            open = true;
            for (int x = 0; x < nodes.Count; x++)
            {
                Node temp = (Node)nodes[x];
                if (ex >= temp.X && ex <= ((temp.X) + 10))
                {
                    if (ey >= temp.Y && ey <= ((temp.Y) + 10))
                    {
                        open = false;
                        str = temp.Name;
                    }
                }
               
               
            }
            return str;
        }


        public int searchMove(int ex, int ey) // gets the index number of the node found to be movable
        {
            int p = -1;
            for (int x = 0; x < nodes.Count; x++)
            {
                Node temp = (Node)nodes[x];
                if (ex >= temp.X && ex <= ((temp.X) + 10))
                {
                    if (ey >= temp.Y && ey <= ((temp.Y) + 10))
                    {
                        p = x;
                    }
                }
            }
            return p;
        }


        public int searchMovedNode(int ex, int ey) // looks for the one object in the nodes that can be moved
        {
            int p = -1;
            for (int x = 0; x < nodes.Count; x++)
            {
                Node temp = (Node)nodes[x];
                if (temp.Moved == true)
                    p = x;
            }
            return p;
        }
       

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
            label1.Text = searchopen(e.X,e.Y)+"(" + e.X + ", " + e.Y + ")";
           
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // this creates a node with the current coordinates
            if (state == 0) // normal mode
            {
                if (!nodeWithVal) 
                { 
                  if (open)
                    {
                        Node n = new Node();
                        n.Name=""+(char)count;
                        count++;
                        n.X = e.X;
                        n.Y = e.Y;
                        nodes.Add(n);
                        pictureBox1.Refresh();
                    }
                }
                else
                {
                    if (open)
                    {
                        Random r = new Random();
                        int rInt = r.Next(1, 5);
                        Node n = new Node();
                        n.Name = "" + (char)count;
                        count++;
                        n.Value = rInt;
                        n.X = e.X;
                        n.Y = e.Y;
                        label2.Text = "Node Value: " + n.Value;
                        nodes.Add(n);
                        pictureBox1.Refresh();
                    }
                }
            }
            if (state == 1) // move mode
            {
                int m = searchMove(e.X, e.Y);
                if (movetoggle == false)
                {
                    if (m != -1) // checks is a movable node is found
                    {
                        ((Node)nodes[m]).Moved = true;
                        movetoggle = true;
                        pictureBox1.Refresh();
                    }
                }
                else
                {
                   
                    if (m == -1) // checks for open locations
                    {
                        int y= searchMovedNode(e.X, e.Y);
                        //MessageBox.Show("" + ((Node)nodes[y]).Name + "=" + ((Node)nodes[y]).X + "  " + ((Node)nodes[y]).Y);
                        ((Node)nodes[y]).Moved = false;
                        ((Node)nodes[y]).X = e.X;
                        ((Node)nodes[y]).Y = e.Y;
                         movetoggle=false;
                         pictureBox1.Refresh();
                    }
                }
                
            }
            if (state == 2) // remove mode
            {
                int m = searchMove(e.X, e.Y);
                if (m != -1)
                {
                    nodes.RemoveAt(m);
                    pictureBox1.Refresh();
                }
            }
            if (state == 3) // connect nodes
            {
                int m = searchMove(e.X, e.Y);
                if (connectoggle == false)
                {
                    if (m != -1)
                    { from = m;
                    connectoggle = true;
                    pictureBox1.Refresh();
                    }
                }
                else {
                    if (m != -1 && m!=from)
                    {
                        to = m;
                        ((Node)(nodes[from])).addNeighbor(((Node)(nodes[to])));
                        ((Node)(nodes[to])).addNeighbor(((Node)(nodes[from])));
                        connectoggle = false;
                        from = -1;
                        to = -1;
                        pictureBox1.Refresh();
                    }
                }
            
            }
            if(state==4)  // set start node
            {
                int m = searchMove(e.X, e.Y);
                if (m != -1)
                {
                  //  search.setStart(((Node)nodes[m]));
                  //  explored = ((Node)nodes[m]);
                    start = m;
                    pictureBox1.Refresh();
                }          
            }
            if (state == 5) // set goal node
            {
                int m = searchMove(e.X, e.Y);
                if (m != -1)
                {
                   // search.setGoal(((Node)nodes[m]));
                    goal = m;
                    pictureBox1.Refresh();
                }
            }
            if(state == 6)
            {
                int m = searchMove(e.X, e.Y);
                if (m != -1 && textBox1.TextLength != 0)
                {
                    ((Node)(nodes[m])).Value = Convert.ToInt32(textBox1.Text);
                    pictureBox1.Refresh();
                }
                else
                {
                    MessageBox.Show("Value cannot be empty");
                    editNodeValuesToolStripMenuItem_Click(sender, e);
                }
            }
       }

        private void withoutValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nodeWithVal)
                clearAllNodesToolStripMenuItem_Click(sender, e);
            state = 0;
            nodeWithVal = false;
        }

        private void moveNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = 1; // move seeting for the nodes
        }

        private void removeNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = 2; //remove settings for the nodes
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if(nodes!=null)
            for (int x = 0; x < nodes.Count; x++)
            {
                Node temp = (Node)nodes[x];
               if(temp.Moved==false)
               { 
                g.DrawArc(Pens.Black, temp.X, temp.Y, 10, 10, 0, 360);
                    if(nodeWithVal)
                        g.DrawString(" " + Convert.ToString(temp.Value), new Font("Segoe UI", 8), Brushes.Black, temp.X + 10, temp.Y + 10);
               }
                else
                g.DrawArc(Pens.Yellow, temp.X, temp.Y, 10, 10, 0, 360);
               if(x==from)
                 g.DrawArc(Pens.White, temp.X, temp.Y, 10, 10, 0, 360);
              

               ArrayList connects = temp.getNeighbor();
               for (int y = 0; y < connects.Count; y++)
               {
                   Node neighbor = (Node)connects[y];
                   g.DrawLine(Pens.Black, temp.X + 5, temp.Y + 5, neighbor.X + 5, neighbor.Y + 5);
               }

               if (temp.Expanded)
                   g.FillEllipse(Brushes.Red, temp.X-5, temp.Y-5, 20, 20);
               if (x == start)
                   g.DrawString("S", new Font("Segoe UI", 20), Brushes.Yellow, temp.X+5, temp.Y+5);
                if (x == goal)
                    g.DrawString("G", new Font("Segoe UI", 20), Brushes.Green, temp.X+5, temp.Y+5);


            }
            Node path = explored;
            while (path != null && path.Origin != null)
            {
                totalCost += path.Value;
                g.DrawLine(new Pen(Brushes.Green, 5), path.X + 5, path.Y + 5, path.Origin.X + 5, path.Origin.Y + 5);
                path = path.Origin;
            }
            if(nodeWithVal == true) 
            {
                textBox1.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label4.Text = "Total Cost: " + Convert.ToString(totalCost);
            }
            else
            {
                textBox1.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
            }
        }

        private void saveNodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            
        }

       
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                var serializer = new BinaryFormatter();
                using (var stream = File.OpenWrite(saveFileDialog1.FileName))
                {
                    serializer.Serialize(stream, nodes);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unexpected Error in Saving");
            }

         
        }

        private void loadNodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var serializer = new BinaryFormatter();
            using (var stream = File.OpenRead(openFileDialog1.FileName))
            {
                nodes = (ArrayList)serializer.Deserialize(stream);
                count += nodes.Count;
                explored = null;
                search = null;
            }
            start = -1;
            goal = -1;
            pictureBox1.Refresh();
        }

        private void connectNodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = 3; // connect nodes
        }

        private void setStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = 4; // setting start node
        }

        private void setGoalNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = 5; // setting goal node
        }
   


        private void fullSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (start != -1 && goal != -1)
            {
                ArrayList tnodes = new ArrayList(nodes);
                search = new Search(tnodes, 1);
                search.setStart(((Node)tnodes[start]));
                explored = ((Node)tnodes[start]);
                search.setGoal(((Node)tnodes[goal]));
                explored = search.search();
                pictureBox1.Refresh();
            }
            else {
                MessageBox.Show("Start and Goal Nodes not set.");
            }
        }

        private void stepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (start != -1 && goal != -1)
            {
                if (search == null)
                {
                    ArrayList tnodes = new ArrayList(nodes);
                    search = new Search(tnodes, 1);
                    search.setStart(((Node)tnodes[start]));
                    explored = ((Node)tnodes[start]);
                    search.setGoal(((Node)tnodes[goal]));
                }
                explored = search.searchone();
                if (explored.Goal)
                    MessageBox.Show(explored.Name + " found");
                pictureBox1.Refresh();
            }
            else {
                MessageBox.Show("Start or Goal nodes not set.");
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = 0;
            open = true;
            movetoggle = false;
            connectoggle = false;
            from = -1;
            to = -1;
            start = -1;
            goal = -1;
            explored = null;
            search = null;
            totalCost = 0;
            for (int y = 0; y < nodes.Count; y++)
            {
                ((Node)nodes[y]).Moved = false;
                ((Node)nodes[y]).Expanded = false;
                ((Node)nodes[y]).Goal = false;
                ((Node)nodes[y]).Origin = null;
                ((Node)nodes[y]).Start = false;


            }
                pictureBox1.Refresh();
        }

        private void clearAllNodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explored = null;
            search = null;
            nodes = new ArrayList();
            state = 0;
            open = true;
            count = 0x41;
            movetoggle = false;
            connectoggle = false;
            from = -1;
            to = -1;
            start = -1;
            goal = -1;
            totalCost = 0;
            pictureBox1.Refresh();
        }

        private void stepToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (start != -1 && goal != -1)
            {
                if (search == null)
                {
                    ArrayList tnodes = new ArrayList(nodes);
                    search = new Search(tnodes, 2);
                    search.setStart(((Node)tnodes[start]));
                    explored = ((Node)tnodes[start]);
                    search.setGoal(((Node)tnodes[goal]));
                }
                explored = search.searchone();
                if (explored.Goal)
                    MessageBox.Show(explored.Name + " found");
                pictureBox1.Refresh();
            }
            else { MessageBox.Show("Start or Goal nodes not Set."); }
        }

        private void fullSearchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (start != -1 && goal != -1)
            {
                ArrayList tnodes = new ArrayList(nodes);
                search = new Search(tnodes, 2);
                search.setStart(((Node)tnodes[start]));
                explored = ((Node)tnodes[start]);
                search.setGoal(((Node)tnodes[goal]));
                explored = search.search();
                pictureBox1.Refresh();
            }
            else { MessageBox.Show("Start or Goal nodes not Set."); }
        }

        private void hillClimbingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fullSearchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (start != -1 && goal != -1)
            {
                
              
            }
            else { MessageBox.Show("Start or Goal nodes not Set."); }
        }

        private void withValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!nodeWithVal)
            {
                clearAllNodesToolStripMenuItem_Click(sender, e);
            }
            nodeWithVal = true;
        }

        private void uniformCostSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (start != -1 && goal != -1)
            {
                ArrayList tnodes = new ArrayList(nodes);
                search = new Search(tnodes, 3);
                search.setStart(((Node)tnodes[start]));
                explored = ((Node)tnodes[start]);
                search.setGoal(((Node)tnodes[goal]));
                explored = search.searchtwo();
                pictureBox1.Refresh();
                //LINK PARA PRIORITY QUEUE https://www.dotnetlovers.com/article/231/priority-queue
            }
            else { MessageBox.Show("Start or Goal nodes not Set."); }
        }

        private void editNodeValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = 6; //setting node value edit
        }

        private void aSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (start != -1 && goal != -1)
            {
                ArrayList tnodes = new ArrayList(nodes);
                search = new Search(tnodes, 3);
                search.setStart(((Node)tnodes[start]));
                explored = ((Node)tnodes[start]);
                search.setGoal(((Node)tnodes[goal]));
                explored = search.searchthree();
                pictureBox1.Refresh();
                //LINK PARA PRIORITY QUEUE https://www.dotnetlovers.com/article/231/priority-queue
            }
            else { MessageBox.Show("Start or Goal nodes not Set."); }
        }

        private void showNodeValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!nodeWithVal)
            {
                nodeWithVal = true;
                showNodeValuesToolStripMenuItem.Text = "Unshow Node Values";
            }
            else
            {
                nodeWithVal = false;
                showNodeValuesToolStripMenuItem.Text = "Show Node Values";
            }  
            pictureBox1.Refresh();
        }

        
    }
}
