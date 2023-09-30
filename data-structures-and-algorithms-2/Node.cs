using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms_2
{
    public class Node
    {
        public String value;
        public Node NextNode;

        public Node(String value)
        {
            this.value = value;
            this.NextNode = null;
        }
    }
}