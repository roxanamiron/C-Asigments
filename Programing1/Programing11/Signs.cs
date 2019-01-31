using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing11
{
   public class Signs
    {
        private List<Signs> sign;

        public Signs()
        {
            sign = new List<Signs>();
        }

        public bool IsEmpty()
        {
            return sign.Count() == 0;
        }
        public Signs top()
        {
            return sign.ElementAt(sign.Count() - 1);
        }
        public void Push(Signs s)
        {
            sign.Add(s);
        }
        public void Remove()
        {
            sign.RemoveAt(sign.Count() - 1);
        }
    }
}
