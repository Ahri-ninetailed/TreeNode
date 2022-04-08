using System;

namespace TreeNode
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode n = new TreeNode('n');
            TreeNode m = new TreeNode('m');

            TreeNode l = new TreeNode('l');
            TreeNode k = new TreeNode('k') { Children = new TreeNode[] { n } };
            TreeNode j = new TreeNode('j') { Children = new TreeNode[] { m } };
            TreeNode i = new TreeNode('i');

            TreeNode h = new TreeNode('h') { Children = new TreeNode[] { l } };
            TreeNode g = new TreeNode('g');
            TreeNode f = new TreeNode('f') { Children = new TreeNode[] { k } };
            TreeNode e = new TreeNode('e');
            TreeNode d = new TreeNode('d') { Children = new TreeNode[] { i, j } };

            TreeNode b = new TreeNode('b') { Children = new TreeNode[] { d, e, f } };
            TreeNode c = new TreeNode('c') { Children = new TreeNode[] { g, h } };

            TreeNode a = new TreeNode('a') { Children = new TreeNode[] { b, c } };

            //обход в ширину
            var chidlren = TreeNode.BFS(a);
            foreach (var temp in chidlren)
                Console.WriteLine(temp.Value);

            Console.WriteLine();

            //прямой обход
            chidlren = TreeNode.NLR(a);
            foreach (var temp in chidlren)
                Console.WriteLine(temp.Value);

        }
    }
}
