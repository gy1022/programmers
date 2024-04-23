using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

class Solution
{
    public int solution(int n)
    {
        // ����� ������ ���� �ʱ�ȭ
        int answer = 0;

        // 1���� n���� �ݺ��ϸ鼭
        for (int i = 1; i <= n; i++)
        {
            // n�� Ȧ���̰� ���� ���� i�� Ȧ���� ���
            if (n % 2 == 1 && i % 2 == 1)
            {
                answer += i; // ���� ���� i�� ����
            }
            // n�� ¦���̰� ���� ���� i�� ¦���� ���
            else if (n % 2 == 0 && i % 2 == 0)
            {
                answer += i * i; // ���� ���� i�� ������ ����
            }
        }

        // ���� ��� ��ȯ
        return answer;
    }
}
