using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');      //���� ������ 4, 5�� ������ 

        int a = Int32.Parse(s[0]);      //0���� a�ֱ�
        int b = Int32.Parse(s[1]);      //1���� b�ֱ�

        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);      //0�� a 1�� b 2�� a+b
    }
}