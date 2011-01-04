using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.jajago.SA.Biz
{
    public class BuffLines
    {
        Queue<string> buff = new Queue<string>(); 

        public void AddLine(string line)
        {
            buff.Enqueue(line);
            if (buff.Count > 10) buff.Dequeue();
        }

        public override string ToString()
        {
            return string.Join("\n",buff.ToArray());
        }

    }
}
