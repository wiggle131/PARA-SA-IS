using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using AliacSearchAlgo;

namespace AISearchSample
{
    class Search
    {
        Fringes fringe;
        ArrayList n;
        bool start=false;

        public Search(ArrayList nodes,int type) 
        {
           if(type==1)//DFS 
            fringe = new Fringe2();
            n = nodes;
         if (type==2)//BFS
            fringe = new Fringe();
         if (type == 3)//UCS and A*
                fringe = new Fringe3();


        }

        public void setStart(Node n)
        {
            n.Start = true;
        }

        public void setGoal(Node n) 
        {
            n.Goal = true;
        }

        public Node search() 
        {
            Node explored=null;
            //pangita Start node
            for (int i = 0; i < n.Count; i++) 
            {
                if (((Node)n[i]).Start == true) 
                {
                    fringe.add(((Node)n[i]), null);
                }
            }

            Node explorer = null;
            ArrayList temp;
            Object []t;
            while ((explorer = fringe.remove()) != null)
            {
              //  MessageBox.Show(explorer.Name+"removed");
                if (explorer.Goal == true)
                {
                    explorer.Expanded = true;
                    MessageBox.Show("found " + explorer.Name);
                    explored = explorer;
                    break;
                }

                //find connections and push to fringe
                temp = explorer.getNeighbor();
                t = temp.ToArray();
                for (int i = 0; i < t.Length; i++)
                {
                    if (((Node)t[i]).Expanded != true)
                    {
                        //MessageBox.Show(((Node)t[i]).Name + "added");
                        fringe.add((Node)t[i],explorer);
                    }
                }
                explorer.Expanded = true;
                explored = explorer;
                

            }
            return explored;

        }


        public Node searchone()
        {
            Node explored=null;
            //pangita Start node
            if (!start)
            {
                for (int i = 0; i < n.Count; i++)
                {
                    if (((Node)n[i]).Start == true)
                    {
                        fringe.add(((Node)n[i]), null);
                    }
                }
                start = true;
            }

            Node explorer = null;
            ArrayList temp;
            Object[] t;

            if ((explorer = fringe.remove()) != null)
            {
                if (explorer.Goal == true)
                {
                    explorer.Expanded = true;
                    //    MessageBox.Show("found " + explorer.Name);
                    explored = explorer;

                }

                //find connections and push to fringe
                temp = explorer.getNeighbor();
                t = temp.ToArray();
                for (int i = 0; i < t.Length; i++)
                {
                    if (((Node)t[i]).Expanded != true)
                        fringe.add((Node)t[i], explorer);
                }
                explorer.Expanded = true;
                explored = explorer;
            }
                return explored;
                

            
        }

        public Node searchtwo()
        {
            Node explored = null;
            //pangita Start node
            for (int i = 0; i < n.Count; i++)
            {
                if (((Node)n[i]).Start == true)
                {
                    fringe.add(((Node)n[i]), null);
                }
            }

            Node explorer = null;
            ArrayList temp;
            Object[] t;
            while ((explorer = fringe.remove()) != null)
            {
                //  MessageBox.Show(explorer.Name+"removed");
                if (explorer.Goal == true)
                {
                    explorer.Expanded = true;
                    MessageBox.Show("found " + explorer.Name);
                    explored = explorer;
                    break;
                }
                temp = explorer.getNeighbor();
                t = temp.ToArray();
                Node next = null;
                temp = explorer.getNeighbor();
                t = temp.ToArray();
                next = findMin(t);
                for (int i = 0; i < t.Length; i++)
                {
                    if (((Node)t[i]).Expanded != true && ((Node)t[i]).Value == next.Value)
                    {
                        //MessageBox.Show(((Node)t[i]).Name + "added");
                        fringe.add(next, explorer);
                    }
                }
                explorer.Expanded = true;
                explored = explorer;

            }
            return explored;
        }

        public Node searchthree()
        {
            Node explored = null;
            Heuristics h = new Heuristics();
            int startIndex = -1;
            int goalIndex = -1;
            //pangita Start node
            for (int i = 0; i < n.Count; i++)
            {
                if (((Node)n[i]).Start == true)
                {
                    fringe.add(((Node)n[i]), null);
                    startIndex = i;
                }
            }
            //pangita Goal node
            for (int i = 0; i < n.Count; i++)
            {
                if (((Node)n[i]).Goal == true)
                {
                   goalIndex = i;
                }
            }
            Node startTemp = ((Node)n[startIndex]);
            Node goalTemp = ((Node)n[goalIndex]);
            if (((Node)n[startIndex]) != null && ((Node)n[goalIndex]) != null)
                ((Node)n[startIndex]).F_Score = h.calculate(startTemp,goalTemp );
            ((Node)n[startIndex]).G_Score = 0;
            Node explorer = null;
            ArrayList temp;
            Object[] t;
            while ((explorer = fringe.remove()) != null)
            {
                //  MessageBox.Show(explorer.Name+"removed");
                if (explorer.Goal == true)
                {
                    explorer.Expanded = true;
                    MessageBox.Show("found " + explorer.Name);
                    explored = explorer;
                    break;
                }
                double temp_g_Score = explorer.G_Score + 1;
                temp = explorer.getNeighbor();
                t = temp.ToArray();
                //Node next = null;
                temp = explorer.getNeighbor();
                t = temp.ToArray();
                //next = findMin(t);
                for (int i = 0; i < t.Length; i++)
                {
                    if (((Node)t[i]).Expanded != true && ((Node)t[i]).G_Score > temp_g_Score)
                    {
                        //MessageBox.Show(((Node)t[i]).Name + "added");
                        ((Node)t[i]).G_Score = temp_g_Score;
                        ((Node)t[i]).F_Score = temp_g_Score + h.calculate(((Node)t[i]), (Node)n[goalIndex]);
                        fringe.add(((Node)t[i]), explorer);
                    }
                }
                explorer.Expanded = true;
                explored = explorer;

            }
            return explored;
        }
        public Node findMin(Object[] temp)
        {
            int min = int.MaxValue;
            Node min_node = null;
            foreach (Node type in temp)
            {
                if (type.Value <= min && type.Expanded != true)
                {
                    min = type.Value;
                    min_node = type;
                }
            }
            //Console.WriteLine("Min: " + min);
            return min_node;
        }
    }
}
