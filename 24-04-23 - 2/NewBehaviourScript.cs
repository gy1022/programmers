using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solution
{
    public int solution(int number, int n, int m)
    {
        // number�� n�� ����̸鼭 m�� ������� Ȯ���Ͽ� ��� ��ȯ
        if (number % n == 0 && number % m == 0)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}
