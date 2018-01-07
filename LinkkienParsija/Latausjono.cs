using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodleWebexLataaja
{
    public class Latausjono<T>
    {
        LinkedList<string> list = new LinkedList<string>();

        public void Enqueue(string ladattava)
        {
            list.AddLast(ladattava);
        }

        public string Dequeue()
        {
            var result = list.First.Value;
            list.RemoveFirst();
            return result;
        }

        public string Peek()
        {
            return list.First.Value;
        }

        public bool Contains(string ladattava)
        {
            if (list.Contains(ladattava))
                return true;
            else
                return false;
        }

        public bool Remove(string ladattava)
        {
            return list.Remove(ladattava);
        }

        public void Clear()
        {
            list.Clear();
        }

        public List<string> ToList()
        {
            return list.ToList();
        }


        public int Count { get { return list.Count; } }
    }
}
