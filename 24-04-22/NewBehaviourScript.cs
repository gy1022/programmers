using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Solution
{
    // ���ڿ� s�� n�� �ݺ��Ͽ� ��ȯ�ϴ� �Լ�
    public string solution(string s, int n)
    {
        string answer = "";
        // n�� �ݺ��ϴ� �ݺ���
        for (int i = 0; i < n; i++)
        {
            // ���ڿ� s�� answer�� �߰�
            answer += s;
        }
        // ��� ���ڿ� ��ȯ
        return answer;
    }
}
