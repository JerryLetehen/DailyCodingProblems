using System;
using System.Text.Json;

namespace DailyCodingProblems
{
    /*
     * Given the root to a binary tree, implement serialize(root), which serializes the tree into a string, and deserialize(s), which deserializes the string back into the tree.
     */

    public class Problem3 : IProblem
    {
        public void Solve()
        {
            var node = new Node("first", new Node("second", null, null), new Node("third", null, null));
            var serialized = Serizlize(node);
            var desiarilized = Deserialize(serialized);
            Console.WriteLine(desiarilized);
        }

        private string Serizlize(Node node)
        {
            return JsonSerializer.Serialize(node);
        }

        private Node Deserialize(string json)
        {
            return JsonSerializer.Deserialize<Node>(json);
        }

        public class Node
        {
            public string Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(string value, Node left, Node right)
            {
                this.Value = value;
                this.Left = left;
                this.Right = right;
            }

            public Node()
            {
            }

            public override string ToString()
            {
                return $"value : {Value}\nLeft : {Left}\nRight : {Right}";
            }
        }
    }
}