using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Solution
{
    public int solution(int num, int n)
    {       // num�� n���� ������ ���������� Ȯ���ϴ� �Լ�
        int answer = 0;
        if (num % n == 0)
        {       // num�� n���� ������ �������� answer�� 1�� ����
            answer = 1;
        }
        else
        {
            answer = 0;     // �׷��� ������ answer�� 0���� ����
        }
        return answer;
    }
}