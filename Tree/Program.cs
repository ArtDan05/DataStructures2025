﻿namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            tree.CreateBalancedTree(5);
            Console.ReadLine();
        }
    }
}
