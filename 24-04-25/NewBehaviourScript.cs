using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Solution
{
    // �־��� ���������� ���� ����ϴ� �Լ�
    public int solution(int a, int d, bool[] included)
    {
        int answer = 0;

        // ���������� ���ԵǴ� �� �׿� ���� �ݺ�
        for (int i = 0; i < included.Length; i++)
        {
            // included �迭�� ���� true�̸� �ش� ���� ���������� �տ� ����
            if (included[i])
                answer += (a + (d * i)); // ���������� i��° ���� ����Ͽ� �տ� �߰�
        }
        return answer; // ���������� �� ��ȯ
    }
}