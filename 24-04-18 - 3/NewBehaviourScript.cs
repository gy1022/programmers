using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Example
{
    public static void Main()
    {
        // ����ڷκ��� �ڿ��� n�� �Է¹���
        int n = int.Parse(Console.ReadLine());

        // n�� ¦������ Ȧ������ �Ǻ��Ͽ� ��� ���
        if (n % 2 == 0)
        {
            Console.WriteLine(n + " is even"); // n�� ¦���� �� ���
        }
        else
        {
            Console.WriteLine(n + " is odd"); // n�� Ȧ���� �� ���
        }
    }
}