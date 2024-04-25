using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Solution
{
    // �� ���� ������ ���� ������ �����ϴ� �Լ�
    public int solution(int a, int b, int c)
    {
        int answer = 0;

        // �� ������ ��� ���� ���
        if (a == b && a == c)
            answer = (a + b + c) * (a * a + b * b + c * c) * ((int)Math.Pow(a, 3) + (int)Math.Pow(b, 3) + (int)Math.Pow(c, 3));
        // �� ������ ���� ���
        else if (a == b || b == c || a == c)
            answer = (a + b + c) * (a * a + b * b + c * c);
        // ��� ������ �ٸ� ���
        else
            answer = a + b + c;

        return answer; // ���� ��� ��ȯ
    }
}