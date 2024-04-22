using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Solution
{     //�� ���� ������ �޾Ƽ� �� ū ���� ��ȯ�ϴ� �Լ�
    public int solution(int a, int b)
    {         // int -> string -> ���ϱ� -> int.Parse() -> ��    

        string str1 = a.ToString();     //ù ��° ������ ���ڿ��� ��ȯ
        string str2 = b.ToString();     //�� ��° ������ ���ڿ��� ��ȯ

        int sum1 = int.Parse(str1 + str2);      //�� ���ڿ��� �̾�ٿ��� ���� ���ڸ� ������ ��ȯ
        int sum2 = int.Parse(str2 + str1);

        if (sum1 != sum2)       //�� ���ڸ� ���Ͽ� �� ū ���� ��ȯ
        {
            return Math.Max(sum1, sum2);
        }
        else
        {
            return sum1;
        }
    }
}