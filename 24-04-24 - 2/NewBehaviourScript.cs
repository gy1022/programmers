using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Solution
{
    public int solution(int a, int b, bool flag)
    {
        // flag ���� ���� �ٸ� ������ �����Ͽ� ����� ��ȯ
        if (flag)
        {
            return a + b; // flag�� true�� ��� a�� b�� ����
        }
        else
        {
            return a - b; // flag�� false�� ��� a�� b�� ��
        }
    }
}