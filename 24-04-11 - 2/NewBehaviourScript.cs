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
        s = Console.ReadLine().Split(' '); //�ڸ��� �Լ� �����̽��� �ڸ�

        int a = Int32.Parse(s[0]); //4 Parse(s[0]) - 1��. ��ǻ�ʹ� 0���� �����̴ϱ� 0 ������ 
        int b = Int32.Parse(s[1]); //5 Parse(s[1]) -2���ΰ���

        Console.WriteLine("a = {0}", a); // {0} = a 0�� ĭ
        Console.WriteLine("b = {0}", b);// {0} = b 0�� ĭ
    }
}
