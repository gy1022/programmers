using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Example
{
    public static void Main()
    {
        String[] input;

        Console.Clear();        //�ʱ�ȭ
        input = Console.ReadLine().Split(' ');      //' '�ȿ� �ִ°� �����

        String s1 = input[0];       //s1�� 0��
        String s2 = input[1];       //s2�� 1��
        String output = s1 + s2.Replace(" ", "");      //������ ������ s2�� �����ϰ� s1�� �����Ͽ� output�� ����
                                                       //String.Replace(" ", "") --> ���ڿ����� Ư�� ���ڿ��� �ٸ� ���ڿ��� ��ü. ����� " "�� ""�� ��ü�� ������ ���ذ�

        Console.WriteLine(output);
    }
}