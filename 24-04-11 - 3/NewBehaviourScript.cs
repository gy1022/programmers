using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Example
{
    public static void Main()
    {
        String[] input;

        Console.Clear();  //�ʱ�ȭ
        input = Console.ReadLine().Split(' ');  //���ڿ��� �迭�ؼ� �־��� ����� �����̽� ����

        String result = "";  //���ڿ� �ʱ�ȭ ""

        for (int i = 0; i < Int32.Parse(input[1]); i++) //i�� 0������ ���� input[1] = 5, i++ �̴ϱ� 5�� �ݺ�
        {
            result += input[0]; //�Էµ� ���ڿ� input[0]�� input[1]�� �ݺ��Ͽ� ��� ���ڿ��� �߰��մϴ�.
        }

