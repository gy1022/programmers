using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();        //�ʱ�ȭ
        s = Console.ReadLine();     //�� ���� �Է��� �޾Ƽ� ���ڿ� ���� s�� ����

        foreach (char c in s)       // ���ڿ� s�� �� ���ڸ� ��ȸ�ϸ鼭 �ֿܼ� �� ���ھ� ���
            Console.WriteLine(c);       //c���

    }
}
