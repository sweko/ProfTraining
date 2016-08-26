using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesDemo
{
    class BinaryTree<T>
    {
        public T Root { get; set; }
        public BinaryTree<T> Left { get; set; }
        public BinaryTree<T> Right { get; set; }

        public override string ToString()
        {
            //todo - make pretty for multi-level;
            StringBuilder sb = new StringBuilder();
            var left = Left == null? "" : string.Join("\n",Left.ToString().Split('\n').Select(s => "   " + s));
            var right = Right == null ? "" : string.Join("\n", Right.ToString().Split('\n').Select(s => "   " + s));
            sb.AppendLine(left);
            sb.Append(Root.ToString());
            sb.Append(right);
            return sb.ToString();
        }
    }
}
