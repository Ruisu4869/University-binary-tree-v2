using System;
using System.Collections.Generic;
using System.Text;

namespace University_binary_tree
{
    class UniversityBinaryTree
    {
        public NodePositionTree RootNode;
        public int cont = 0;

        public void AddPosition(NodePositionTree root, PositionTree create, String rootPositionName)
        {
            NodePositionTree node = new NodePositionTree();
            node.Position = create;
            if(RootNode == null)
            {
                RootNode = node;
                return;
            }
            if(root == null)
            {
                return;
            }
            if(root.Position.NameEmployed == rootPositionName)
            {
                if(root.Left == null)
                {
                    root.Left = node;
                    return;
                }
                root.Right = node;
                return;
            }
            AddPosition(root.Left, create, rootPositionName);
            AddPosition(root.Right, create, rootPositionName);
        }

        public void PrintTree(NodePositionTree from)
        {
            if(from == null)
            {
                return;
            }
            Console.WriteLine($"{from.Position.NameEmployed} : $ {from.Position.SalaryEmployed} : {from.Position.Percentage}%");
            PrintTree(from.Left);
            PrintTree(from.Right);
        }

        public float SumSalaries(NodePositionTree start)
        {
            if(start == null)
            {
                return 0;
            }
            return start.Position.SalaryEmployed + SumSalaries(start.Left) + SumSalaries(start.Right);
        }

        public float AverageSalary(int quantity, NodePositionTree aveSal)
        {
            if (aveSal == null)
            {
                return 0;
            }
            return (aveSal.Position.SalaryEmployed + SumSalaries(aveSal.Left) + SumSalaries(aveSal.Right))/quantity;
        }

        public int SumatoryNode(NodePositionTree temp)
        {
            if(temp != null)
            {
                SumatoryNode(temp.Left);
                SumatoryNode(temp.Right);
                cont++;
            }
            return cont;
        }

        public float Percentage(NodePositionTree valuePercentage)
        {
            if(valuePercentage == null)
            {
                return 0;
            }
            return ((valuePercentage.Position.Percentage / 100)*valuePercentage.Position.SalaryEmployed) + Percentage(valuePercentage.Left) + Percentage(valuePercentage.Right);
        }

        public float OtherSumatory(NodePositionTree count)
        {
            if (count == null)
            {
                return 0;
            }
            return count.Position.SalaryEmployed + OtherSumatory(count.Left) + OtherSumatory(count.Right);
        }

    }
}