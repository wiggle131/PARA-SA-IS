using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliacSearchAlgo;

namespace AISearchSample
{
    class Fringe3: Fringes
    {
        // Stack<Node> s;
        List<Node> s;
        int heapSize = -1;
        public int Count { get { return s.Count; } }
        public Fringe3()
        {
            // s = new Stack<Node>();
            s = new List<Node>();
        }

        public void add(Node n, Node origin)
        {
            n.Origin = origin;
            //s.Push(n);
            s.Add(n);
            heapSize++;
            BuildHeapMin(heapSize);
        }

        public Node remove()
        {
            if (heapSize > -1)
            {
                var returnVal = s[0];
                s[0] = s[heapSize];
                s.RemoveAt(heapSize);
                heapSize--;
                //Maintaining lowest or highest at root based on min or max queue
                MinHeapify(0);
                return returnVal;
            }
            //     return s.Pop();
            return null;
        }

        private void Swap(int i, int j)
        {
            var temp = s[i];
            s[i] = s[j];
            s[j] = temp;
        }

        private void MinHeapify(int i)
        {
            int left = ChildL(i);
            int right = ChildR(i);

            int lowest = i;

            if (left <= heapSize && s[lowest].Value > s[left].Value)
                lowest = left;
            if (right <= heapSize && s[lowest].Value > s[right].Value)
                lowest = right;

            if (lowest != i)
            {
                Swap(lowest, i);
                MinHeapify(lowest);
            }
        }

        private int ChildL(int i)
        {
            return i * 2 + 1;
        }
        private int ChildR(int i)
        {
            return i * 2 + 2;
        }

        private void BuildHeapMin(int i)
        {
            while (i >= 0 && s[(i - 1) / 2].Value > s[i].Value)
            {
                Swap(i, (i - 1) / 2);
                i = (i - 1) / 2;
            }
        }
    }
}
