using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Solution
{
    public string solution(string str1, string str2)
    {
        string result = ""; // ����� ������ ���ڿ� ����

        // �� ���ڿ��� ���̰� �����Ƿ� �� ���ڿ��� ���̸� �������� �ݺ��մϴ�.
        for (int i = 0; i < str1.Length; i++)
        {
            // �����ư��� ���ڿ��� �߰��մϴ�.
            result += str1[i];
            result += str2[i];
        }

        return result;
    }
}
