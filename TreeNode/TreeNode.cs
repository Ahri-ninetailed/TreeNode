using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;
namespace TreeNode
{
    public sealed class TreeNode
    {
        public char Value { get; set; }
        public TreeNode(char s)
        {
            Value = s;
        }
        public IEnumerable<TreeNode> Children { get; init; }
        //Поиск в ширину
        public static IEnumerable<TreeNode> BFS(TreeNode root)
        {
            //лист содержит всех потомков включая корневой узел
            List<TreeNode> answer = new List<TreeNode>();
            
            Queue<TreeNode> queue = new Queue<TreeNode>();
            //добавим главный узел в очередь
            queue.Enqueue(root);
            
            while(queue.Count > 0)
            {
                //получим самый старый элемент очереди
                TreeNode node = queue.Dequeue();
                //добавим его в ответ
                answer.Add(node);
                //если у него есть дети
                if (node.Children is not null)
                {
                    //сделаем перебор по ним и добавим их в очередь
                    foreach (var child in node.Children)
                    {
                        if (child is not null)
                            queue.Enqueue(child);
                    }
                }
            }
            return answer;
        }
        //Прямой обход
        public static IEnumerable<TreeNode> NLR(TreeNode node)
        {
            //лист содержит всех потомков включая корневой узел
            List<TreeNode> answer = new List<TreeNode>();

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(node);
            while (stack.Count > 0)
            {
                var tempnode = stack.Pop();
                answer.Add(tempnode);
                
                //если у него есть дети
                if (tempnode.Children is not null)
                {
                    //сделаем перебор по ним и добавим их в стек
                    foreach (var child in tempnode.Children)
                    {
                        if (child is not null)
                            stack.Push(child);
                    }
                }
            }
            return answer;
        }

    }
}
