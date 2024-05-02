using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int M = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        string[] inputs = Console.ReadLine().Split(' ');

        int sum = 0;

        for (int i = 0; i < N; i++)
        {
            int E = int.Parse(inputs[i]);
            sum += E % M;
        }
        Console.WriteLine(sum);

    }
}