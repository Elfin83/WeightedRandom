using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Class1
    {
        Dictionary <string, int> set = new Dictionary<string, int>();

        private void DictionaryInitialize(Dictionary<string, int> dic)
        {
            dic.Add("A", 1);
            dic.Add("B", 2);
            dic.Add("C", 8);
            dic.Add("D", 4);
        }

        void Main()
        {

        }
    }
}
